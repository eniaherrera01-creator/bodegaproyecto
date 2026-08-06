using Microsoft.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace bodegaproyecto
{
    public partial class Compras : Form
    {
        // ================== ESTADO INTERNO ==================
        private List<DetalleLinea> detalleActual = new List<DetalleLinea>();

        private int idProveedorSeleccionado = 0;
        private int idProductoSeleccionado = 0;
        private decimal impuestoProductoSeleccionado = 0m; // % de ISV del producto elegido

        private int idCompraActual = 0;   // 0 = compra nueva todavía no guardada
        private bool cargandoDatos = false; // evita disparar eventos mientras se llenan campos por código

        private class DetalleLinea
        {
            public int IdProducto;
            public string Producto;
            public int Cantidad;
            public decimal PrecioUnitario;
            public decimal IsvUnitario;
            public bool EsNuevo; // true = todavía no está guardado en Detalle_Compra

            public decimal Subtotal => PrecioUnitario * Cantidad;
            public decimal IsvTotal => IsvUnitario * Cantidad;
            public decimal Total => Subtotal + IsvTotal;
        }

        public Compras()
        {
            InitializeComponent();

            // Eventos que NO están conectados en el Designer
            btnNuevoCompra.Click += btnNuevoCompra_Click;
            btnEditarCompra.Click += btnEditarCompra_Click;
            btnRefrescar.Click += btnRefrescar_Click;
            txtBuscarCompra.TextChanged += txtBuscarCompra_TextChanged;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            dgvDetalleCompra.CellDoubleClick += dgvDetalleCompra_CellDoubleClick;
            dgvCompras.SelectionChanged += dgvCompras_SelectionChanged;
            dgvDetalleCompra.SelectionChanged += dgvDetalleCompra_SelectionChanged;

            this.Load += Compras_Load;


        }

        private void dgvDetalleCompra_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvDetalleCompra.SelectedRows.Count == 0) return;

            int index = dgvDetalleCompra.SelectedRows[0].Index;
            if (index < 0 || index >= detalleActual.Count) return;

            var linea = detalleActual[index];

            // Cargar variables de estado interno
            idProductoSeleccionado = linea.IdProducto;

            // Cargar cajas de texto con la información de la línea seleccionada
            txtProducto.Text = linea.Producto;
            txtCosto.Text = linea.PrecioUnitario.ToString("0.00", CultureInfo.InvariantCulture);

            // Si la línea fue calculada, sacamos el % equivalente para mostrarlo en txtIsvProducto
            decimal porcentajeEquivalente = linea.PrecioUnitario > 0
                ? Math.Round((linea.IsvUnitario / linea.PrecioUnitario) * 100m, 2)
                : 0m;

            txtIsvProducto.Text = porcentajeEquivalente.ToString("0.00", CultureInfo.InvariantCulture);
            nudCantidad.Value = linea.Cantidad;

            // Consultar el Stock actual del producto a la BD para mostrarlo en txtStockActual
            CargarStockProductoActual(linea.IdProducto);
        }

        private void CargarStockProductoActual(int idProducto)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string sql = "SELECT Stock FROM Producto WHERE id_producto = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idProducto);
                        object result = cmd.ExecuteScalar();
                        txtStockActual.Text = result != null ? result.ToString() : "0";
                    }
                }
            }
            catch
            {
                txtStockActual.Text = "0";
            }
        }

        // ================== CARGA INICIAL ==================
        private void Compras_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasGrids();
            CargarUsuarios();
            CargarCompras();
            LimpiarFormularioCompra();
            HabilitarFormularioCompra(false);
        }

        private void ConfigurarColumnasGrids()
        {
            // dgvCompras: id, fecha, proveedor, total
            dgvCompras.Columns[0].HeaderText = "ID";
            dgvCompras.Columns[0].Name = "colIdCompra";
            dgvCompras.Columns[1].HeaderText = "Fecha";
            dgvCompras.Columns[2].HeaderText = "Proveedor";
            dgvCompras.Columns[3].HeaderText = "Total";

            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.MultiSelect = false;
            dgvCompras.ReadOnly = true;
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;


            // dgvDetalleCompra: producto, cantidad, precio unit, isv, subtotal
            dgvDetalleCompra.Columns[0].HeaderText = "Producto";
            dgvDetalleCompra.Columns[1].HeaderText = "Cantidad";
            dgvDetalleCompra.Columns[2].HeaderText = "Precio Unit.";
            dgvDetalleCompra.Columns[3].HeaderText = "ISV";
            dgvDetalleCompra.Columns[4].HeaderText = "Subtotal";

            dgvDetalleCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleCompra.MultiSelect = false;
            dgvDetalleCompra.ReadOnly = true;
            dgvDetalleCompra.AllowUserToAddRows = false;
            dgvDetalleCompra.AllowUserToDeleteRows = false;

        }

        private void CargarUsuarios()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"
                SELECT id_usuario, usuario
                FROM Usuario
                WHERE usuario = @usuario";

                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@usuario", menu.UsuarioActual);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbUsuario.DataSource = dt;
                    cmbUsuario.DisplayMember = "usuario";
                    cmbUsuario.ValueMember = "id_usuario";

                    if (dt.Rows.Count > 0)
                        cmbUsuario.SelectedIndex = 0;

                    cmbUsuario.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuario: " + ex.Message);
            }
        }

        // ================== LISTA DE COMPRAS (izquierda de la grilla superior) ==================
        private void CargarCompras(string filtro = "")
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string sql = @"
                        SELECT c.id_compra, c.fecha_compra, p.Nombre AS Proveedor,
                               ISNULL(SUM(dc.Cantidad * dc.precio_unitario), 0) AS Total
                        FROM Compra c
                        INNER JOIN Proveedor p ON p.id_proveedor = c.id_proveedor
                        LEFT JOIN Detalle_Compra dc ON dc.id_compra = c.id_compra
                        WHERE (@filtro = '' OR CAST(c.id_compra AS VARCHAR(20)) LIKE @like
                               OR p.Nombre LIKE @like)
                        GROUP BY c.id_compra, c.fecha_compra, p.Nombre
                        ORDER BY c.id_compra DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@filtro", filtro ?? "");
                        cmd.Parameters.AddWithValue("@like", "%" + (filtro ?? "") + "%");

                        dgvCompras.Rows.Clear();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvCompras.Rows.Add(
                                    reader["id_compra"],
                                    Convert.ToDateTime(reader["fecha_compra"]).ToString("dd/MM/yyyy"),
                                    reader["Proveedor"].ToString(),
                                    "L. " + Convert.ToDecimal(reader["Total"]).ToString("0.00")
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compras: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarCompra_TextChanged(object sender, EventArgs e)
        {
            CargarCompras(txtBuscarCompra.Text.Trim());
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioCompra();
            HabilitarFormularioCompra(false);
        }

        // ================== SELECCIÓN DE UNA COMPRA EXISTENTE ==================
        private void dgvCompras_SelectionChanged(object sender, EventArgs e)
        {
            if (cargandoDatos) return;
            if (dgvCompras.SelectedRows.Count == 0) return; 

            int idCompra = Convert.ToInt32(dgvCompras.SelectedRows[0].Cells["colIdCompra"].Value);
            CargarCabeceraCompra(idCompra);
            CargarDetalleCompra(idCompra);
            HabilitarFormularioCompra(false);
        }

        private void CargarCabeceraCompra(int idCompra)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string sql = @"
                        SELECT c.id_compra, c.fecha_compra, pr.id_proveedor, pr.Nombre, pr.Telefono
                        FROM Compra c
                        INNER JOIN Proveedor pr ON pr.id_proveedor = c.id_proveedor
                        WHERE c.id_compra = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idCompra);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cargandoDatos = true;
                                idCompraActual = Convert.ToInt32(reader["id_compra"]);
                                txtIdCompra.Text = idCompraActual.ToString();
                                dtpFecha.Value = Convert.ToDateTime(reader["fecha_compra"]);
                                idProveedorSeleccionado = Convert.ToInt32(reader["id_proveedor"]);
                                txtProveedor.Text = reader["Nombre"].ToString();
                                txtTelefono.Text = reader["Telefono"].ToString();
                                cargandoDatos = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la compra: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDetalleCompra(int idCompra)
        {
            try
            {
                detalleActual.Clear();

                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string sql = @"
                        SELECT pr.id_producto, pr.Nombre_Producto, dc.Cantidad,
                               dc.precio_unitario, pr.impuesto
                        FROM Detalle_Compra dc
                        INNER JOIN Producto pr ON pr.id_producto = dc.id_producto
                        WHERE dc.id_compra = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idCompra);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal precioUnit = Convert.ToDecimal(reader["precio_unitario"]);
                                decimal impuestoPct = reader["impuesto"] == DBNull.Value
                                    ? 0m : Convert.ToDecimal(reader["impuesto"]);

                                detalleActual.Add(new DetalleLinea
                                {
                                    IdProducto = Convert.ToInt32(reader["id_producto"]),
                                    Producto = reader["Nombre_Producto"].ToString(),
                                    Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                    PrecioUnitario = precioUnit,
                                    IsvUnitario = Math.Round(precioUnit * (impuestoPct / 100m), 2),
                                    EsNuevo = false
                                });
                            }
                        }
                    }
                }

                RefrescarGridDetalle();
                RecalcularTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================== BÚSQUEDA DE PROVEEDOR ==================
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarProveedor.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Escriba un nombre o ID de proveedor para buscar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string sql = @"
                        SELECT TOP 1 id_proveedor, Nombre, Telefono
                        FROM Proveedor
                        WHERE Nombre LIKE @like OR CAST(id_proveedor AS VARCHAR(20)) = @exacto
                        ORDER BY Nombre";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@like", "%" + busqueda + "%");
                        cmd.Parameters.AddWithValue("@exacto", busqueda);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idProveedorSeleccionado = Convert.ToInt32(reader["id_proveedor"]);
                                txtProveedor.Text = reader["Nombre"].ToString();
                                txtTelefono.Text = reader["Telefono"].ToString();
                            }
                            else
                            {
                                idProveedorSeleccionado = 0;
                                txtProveedor.Clear();
                                txtTelefono.Clear();
                                MessageBox.Show("No se encontró ningún proveedor con ese criterio.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar proveedor: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================== BÚSQUEDA DE PRODUCTO ==================
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarProducto.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Escriba un nombre o ID de producto para buscar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string sql = @"
                        SELECT TOP 1 id_producto, Nombre_Producto, Precio_Compra, Stock, impuesto
                        FROM Producto
                        WHERE Nombre_Producto LIKE @like OR CAST(id_producto AS VARCHAR(20)) = @exacto
                        ORDER BY Nombre_Producto";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@like", "%" + busqueda + "%");
                        cmd.Parameters.AddWithValue("@exacto", busqueda);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idProductoSeleccionado = Convert.ToInt32(reader["id_producto"]);
                                txtProducto.Text = reader["Nombre_Producto"].ToString();
                                txtStockActual.Text = reader["Stock"].ToString();
                                impuestoProductoSeleccionado = 0m;
                                txtIsvProducto.Text = impuestoProductoSeleccionado.ToString("0.##", CultureInfo.InvariantCulture); // <-- NUEVA LÍNEA
                                txtIsvProducto.Text = "0";
                                txtCosto.Text = Convert.ToDecimal(reader["Precio_Compra"]).ToString("0.00", CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                idProductoSeleccionado = 0;
                                txtProducto.Clear();
                                txtStockActual.Clear();
                                txtCosto.Clear();
                                txtIsvProducto.Text = "0";
                                MessageBox.Show("No se encontró ningún producto con ese criterio.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar producto: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private bool agregandoProducto = false;

        // ================== AGREGAR PRODUCTO AL DETALLE ==================
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            if (agregandoProducto) return; // Evita reentrada
            agregandoProducto = true;
            try
            {
                if (idProductoSeleccionado == 0)
                {
                    MessageBox.Show("Primero busque y seleccione un producto.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal costo;
                if (!decimal.TryParse(txtCosto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out costo) || costo <= 0)
                {
                    MessageBox.Show("Ingrese un costo válido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                // NUEVO: Validar y obtener el porcentaje de ISV ingresado en el txtIsvProducto
                decimal porcentajeIsv = 0m;
                if (!decimal.TryParse(txtIsvProducto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out porcentajeIsv) || porcentajeIsv < 0)
                {
                    MessageBox.Show("Ingrese un porcentaje de ISV válido (ejemplo: 15).", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int cantidad = (int)nudCantidad.Value;
                // NUEVO: Calcular el valor del ISV unitario en Lempiras basándose en el porcentaje escrito
                decimal isvUnit = Math.Round(costo * (porcentajeIsv / 100m), 2);

                // si el producto ya estaba en el detalle, se suma la cantidad
                var existente = detalleActual.FirstOrDefault(x => x.IdProducto == idProductoSeleccionado);
                if (existente != null)
                {
                    existente.Cantidad = cantidad;
                    existente.PrecioUnitario = costo;
                    existente.IsvUnitario = isvUnit;
                }
                else
                {
                    detalleActual.Add(new DetalleLinea
                    {
                        IdProducto = idProductoSeleccionado,
                        Producto = txtProducto.Text,
                        Cantidad = cantidad,
                        PrecioUnitario = costo,
                        IsvUnitario = isvUnit,
                        EsNuevo = true
                    });
                }

                RefrescarGridDetalle();
                RecalcularTotales();

                // MENSAJE DE ÉXITO AGREGADO:
                MessageBox.Show("Producto agregado correctamente al detalle.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarPanelProducto();
                // ... todo tu código actual (incluidas validaciones y agregado) ...
            }
            finally
            {
                agregandoProducto = false;
            }


        }

        private void dgvDetalleCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= detalleActual.Count) return;

            // Solo permitir doble clic si el formulario está en modo edición (Guardar activado)
            if (!btnGuardar.Enabled) return;
            var linea = detalleActual[e.RowIndex];


            if (MessageBox.Show($"¿Quitar \"{linea.Producto}\" del detalle?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                detalleActual.RemoveAt(e.RowIndex);
                RefrescarGridDetalle();
                RecalcularTotales();
                Bitacora.Registrar("Compras", "quitar Producto", "se quito un producto del detalle");
            }
        }

        private void RefrescarGridDetalle()
        {
            dgvDetalleCompra.Rows.Clear();
            foreach (var linea in detalleActual)
            {
                dgvDetalleCompra.Rows.Add(
                    linea.Producto,
                    linea.Cantidad,
                    "L. " + linea.PrecioUnitario.ToString("0.00"),
                    "L. " + linea.IsvUnitario.ToString("0.00"),
                    "L. " + linea.Subtotal.ToString("0.00")
                );
            }
        }

        private void RecalcularTotales()
        {
            decimal subtotal = detalleActual.Sum(x => x.Subtotal);
            decimal isv = detalleActual.Sum(x => x.IsvTotal);
            decimal total = subtotal + isv;

            lblSubtotalValor.Text = "L. " + subtotal.ToString("0.00");
            lblIsvValor.Text = "L. " + isv.ToString("0.00");
            lblTotalValor.Text = "L. " + total.ToString("0.00");
        }

        // ================== NUEVO / EDITAR ==================
        private void btnNuevoCompra_Click(object sender, EventArgs e)
        {
            LimpiarFormularioCompra();
            idCompraActual = 0;
            dtpFecha.Value = DateTime.Now;
            HabilitarFormularioCompra(true);
        }

        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una compra de la lista para editarla.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // idCompraActual y el detalle ya fueron cargados por dgvCompras_SelectionChanged
            HabilitarFormularioCompra(true);

            MessageBox.Show("Modo edición activado. Puede modificar la información o agregar más productos.", "Información",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ================== GUARDAR ==================
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbUsuario.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un usuario.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (detalleActual.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto al detalle.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                SqlTransaction tx = conn.BeginTransaction();
                try
                {
                    // 1) Cabecera de la compra: Insertar o Actualizar
                    if (idCompraActual == 0)
                    {
                        string sqlInsertCompra = @"
                    INSERT INTO Compra (fecha_compra, id_proveedor, id_usuario)
                    OUTPUT INSERTED.id_compra
                    VALUES (@fecha, @idProveedor, @idUsuario)";

                        using (SqlCommand cmd = new SqlCommand(sqlInsertCompra, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                            cmd.Parameters.AddWithValue("@idProveedor", idProveedorSeleccionado);
                            cmd.Parameters.AddWithValue("@idUsuario", cmbUsuario.SelectedValue);
                            idCompraActual = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        // Si la compra ya existe, actualizar cabecera
                        string sqlUpdateCompra = @"
                    UPDATE Compra 
                    SET fecha_compra = @fecha, id_proveedor = @idProveedor, id_usuario = @idUsuario
                    WHERE id_compra = @idCompra";

                        using (SqlCommand cmd = new SqlCommand(sqlUpdateCompra, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                            cmd.Parameters.AddWithValue("@idProveedor", idProveedorSeleccionado);
                            cmd.Parameters.AddWithValue("@idUsuario", cmbUsuario.SelectedValue);
                            cmd.Parameters.AddWithValue("@idCompra", idCompraActual);
                            cmd.ExecuteNonQuery();
                        }

                        // Si se esta editando, revertimos el Stock y borramos el detalle viejo para reinsertar el nuevo
                        string sqlRevertirStock = @"
                    UPDATE Producto 
                    SET Stock = Stock - dc.Cantidad
                    FROM Producto p
                    INNER JOIN Detalle_Compra dc ON p.id_producto = dc.id_producto
                    WHERE dc.id_compra = @idCompra";

                        using (SqlCommand cmd = new SqlCommand(sqlRevertirStock, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@idCompra", idCompraActual);
                            cmd.ExecuteNonQuery();
                        }

                        string sqlDeleteDetalle = "DELETE FROM Detalle_Compra WHERE id_compra = @idCompra";
                        using (SqlCommand cmd = new SqlCommand(sqlDeleteDetalle, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@idCompra", idCompraActual);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 2) Insertar las líneas vigentes de detalleActual y actualizar Stock
                    string sqlDetalle = @"
                INSERT INTO Detalle_Compra (Cantidad, precio_unitario, id_compra, id_producto)
                VALUES (@cantidad, @precio, @idCompra, @idProducto)";

                    string sqlStock = @"
                UPDATE Producto SET Stock = Stock + @cantidad
                WHERE id_producto = @idProducto";

                    foreach (var linea in detalleActual)
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlDetalle, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@cantidad", linea.Cantidad);
                            cmd.Parameters.AddWithValue("@precio", linea.PrecioUnitario);
                            cmd.Parameters.AddWithValue("@idCompra", idCompraActual);
                            cmd.Parameters.AddWithValue("@idProducto", linea.IdProducto);
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd = new SqlCommand(sqlStock, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@cantidad", linea.Cantidad);
                            cmd.Parameters.AddWithValue("@idProducto", linea.IdProducto);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    tx.Commit();
                    Bitacora.Registrar("Compras", "Guardar Compra", "Se guardó/actualizó la compra ID: " + idCompraActual);
                    MessageBox.Show("Compra guardada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // PASO 1: Desactivar escuchadores de eventos
                    cargandoDatos = true;

                    // PASO 2: Recargar las compras sin seleccionar ninguna fila
                    CargarCompras(txtBuscarCompra.Text.Trim());
                    dgvCompras.ClearSelection();

                    // PASO 3: Limpiar el formulario y deshabilitar controles
                    LimpiarFormularioCompra();
                    HabilitarFormularioCompra(false);

                    // PASO 4: Reactivar eventos
                    cargandoDatos = false;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("Error al guardar la compra: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioCompra();
            HabilitarFormularioCompra(false);
        }

        // ================== AUXILIARES ==================
        private void LimpiarPanelProducto()
        {
            txtBuscarProducto.Clear();
            txtProducto.Clear();
            txtCosto.Clear();
            txtIsvProducto.Text = "0"; // Muestra 0 como porcentaje inicial
            txtStockActual.Clear();
            nudCantidad.Value = 1;
            idProductoSeleccionado = 0;
            impuestoProductoSeleccionado = 0;
        }

        private void LimpiarFormularioCompra()
        {

            // 1. Resetear variables de estado interno
            idCompraActual = 0;
            idProveedorSeleccionado = 0;
            idProductoSeleccionado = 0;
            impuestoProductoSeleccionado = 0;

            txtIdCompra.Text = "(Automático)";
            dtpFecha.Value = DateTime.Now;
            txtBuscarProveedor.Clear();
            txtProveedor.Clear();
            txtTelefono.Clear();

            // 3. Limpiar panel lateral (Agregar Producto)
            LimpiarPanelProducto();
            

            // 4. Vaciar lista en memoria y limpiar la grilla del detalle
            detalleActual.Clear();
            dgvDetalleCompra.Rows.Clear();

            // 5. Blanquear etiquetas de los totales
            lblSubtotalValor.Text = "L. 0.00";
            lblIsvValor.Text = "L. 0.00";
            lblTotalValor.Text = "L. 0.00";

            // 5. Recalcular y forzar la reescritura de los totales a cero
            RecalcularTotales();
        }

        private void HabilitarFormularioCompra(bool activar)
        {
            dtpFecha.Enabled = activar;
            txtBuscarProveedor.Enabled = activar;
            btnBuscarProveedor.Enabled = activar;
            cmbUsuario.Enabled = activar;
            grpAgregarProducto.Enabled = activar; // Habilita o deshabilita el panel de productos
            grpAgregarProducto.Enabled = activar;
            btnGuardar.Enabled = activar;
            btnCancelar.Enabled = activar;

            // Controlar campos específicos según estado
            txtCosto.ReadOnly = !activar;
            txtIsvProducto.ReadOnly = !activar;
            nudCantidad.Enabled = activar;
        }
    }
}