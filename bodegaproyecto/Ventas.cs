using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraSpellChecker.Parser;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class Ventas : Form
    {

        private SqlConnection conexion = ConexionBD.ObtenerConexion();

        private int idVentaSeleccionada = 0;
        private int idClienteSeleccionado = 0;

        private bool modoNuevo = false;
        private bool modoEditar = false;

        public Ventas()
        {
            InitializeComponent();
            CrearDetalleVenta();
            AsignarEventosManuales();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarUsuarios();

            CargarTipoCliente();

            MostrarVentas();

            LimpiarFormulario();

            HabilitarControles(false);

            dtpFecha.Value = DateTime.Now;
            dtpFecha.Enabled = false;
        }

        // EVENTOS MANUALES

        private void AsignarEventosManuales()
        {
            btnNuevo.Click += btnNuevo_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnEditar.Click += btnEditar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvVentas.CellClick += dgvVentas_CellClick;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            dgvDetallesVentas.CellClick += dgvDetallesVentas_CellClick;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            cmbTipoCliente.SelectedIndexChanged += cmbTipoCliente_SelectedIndexChanged;
            this.Load += Ventas_Load;
        }

        private void LimpiarFormulario()
        {
            txtIDVenta.Clear();
            txtIDVenta.Text = "(Automático)";

            dtpFecha.Value = DateTime.Now;

            txtBuscarCliente.Clear();
            txtNombreCliente.Clear();
            txtClienteDNI.Clear();
            cmbTipoCliente.SelectedIndex = -1;
            idClienteSeleccionado = 0;
            cmbMetodoPago.SelectedIndex = -1;

            txtBuscarProducto.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            txtImpuesto.Clear();
            txtStock.Clear();

            nudCantidad.Value = 1;

            lblSubtotal.Text = "L. 0.00";
            lblImpuestoValor.Text = "L. 0.00";
            lblTotalValor.Text = "L. 0.00";


            CrearDetalleVenta();
            dgvDetallesVentas.DataSource = detalleVenta;
        }

        private void CargarTipoCliente()
        {
            cmbTipoCliente.Items.Clear();

            cmbTipoCliente.Items.Add("Cliente Normal");
            cmbTipoCliente.Items.Add("Cliente Generico");

            cmbTipoCliente.SelectedIndex = -1;
        }

        private void HabilitarControles(bool estado)
        {
            cmbTipoCliente.Enabled = estado;
            cmbMetodoPago.Enabled = estado;

            btnGuardar.Enabled = estado;

            txtBuscarProducto.Enabled = estado;
            btnBuscarProducto.Enabled = estado;
            btnAgregarProducto.Enabled = estado;

            nudCantidad.Enabled = estado;

            cmbTipoCliente.Enabled = estado;

            if (cmbTipoCliente.Text == "Cliente Normal")
            {
                txtBuscarCliente.Enabled = estado;
                btnBuscarCliente.Enabled = estado;
            }
            else
            {
                txtBuscarCliente.Enabled = false;
                btnBuscarCliente.Enabled = false;
            }
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

        private void MostrarVentas()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"SELECT
                                                v.id_venta,
                                                v.Fecha_Venta,
                                                c.Nombre AS Cliente,
                                                u.Nombre AS Usuario,
                                                v.metodo_pago
                                        FROM Venta v
                                        INNER JOIN Cliente c
                                            ON v.id_cliente = c.id_cliente
                                        INNER JOIN Usuario u
                                            ON v.id_usuario = u.id_usuario
                                        ORDER BY v.id_venta DESC";

                    SqlDataAdapter da = new SqlDataAdapter(consulta, cn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvVentas.DataSource = dt;

                    ConfigurarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al mostrar ventas: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void BuscarClienteGenerico()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();


                    string sql = @"
                SELECT 
                    id_cliente,
                    Nombre,
                    DNI
                FROM Cliente
                WHERE Nombre = 'Cliente Generico'
                AND Estado = 1";


                    SqlCommand cmd = new SqlCommand(sql, cn);


                    SqlDataReader dr = cmd.ExecuteReader();


                    if (dr.Read())
                    {

                        idClienteSeleccionado =
                            Convert.ToInt32(dr["id_cliente"]);



                        txtNombreCliente.Text =
                            dr["Nombre"].ToString();



                        txtClienteDNI.Text =
                            dr["DNI"].ToString();

                    }
                    else
                    {
                        MessageBox.Show(
                            "No existe el cliente genérico en la base de datos.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }


                    dr.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar cliente genérico: "
                    + ex.Message);
            }
        }
        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTipoCliente.SelectedItem == null)
                return;


            string tipo = cmbTipoCliente.SelectedItem.ToString();


            if (tipo == "Cliente Normal")
            {
                // Habilitar búsqueda

                txtBuscarCliente.Enabled = true;
                btnBuscarCliente.Enabled = true;


                txtBuscarCliente.Clear();
                txtNombreCliente.Clear();
                txtClienteDNI.Clear();


                idClienteSeleccionado = 0;


                txtBuscarCliente.Focus();
            }



            else if (tipo == "Cliente Generico")
            {

                // Desactivar búsqueda

                txtBuscarCliente.Enabled = false;
                btnBuscarCliente.Enabled = false;


                txtBuscarCliente.Clear();


                BuscarClienteGenerico();

            }

        }

        private void ConfigurarGrid()
        {
            if (dgvVentas.Columns.Count == 0)
                return;

            dgvVentas.Columns["id_venta"].HeaderText = "ID";
            dgvVentas.Columns["Fecha_Venta"].HeaderText = "Fecha";
            dgvVentas.Columns["Cliente"].HeaderText = "Cliente";
            dgvVentas.Columns["Usuario"].HeaderText = "Usuario";
            dgvVentas.Columns["metodo_pago"].HeaderText = "Método de Pago";

            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.MultiSelect = false;
            dgvVentas.ReadOnly = true;
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
        }

        // VALIDACION

        private bool ValidarCampos()
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un cliente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBuscarCliente.Focus();

                return false;
            }

            if (cmbMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un método de pago.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbMetodoPago.Focus();
                return false;
            }

            if (cmbUsuario.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un usuario.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbUsuario.Focus();
                return false;
            }

            return true;
        }

        private void BuscarVentas(string buscar)
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"SELECT
                                    v.id_venta,
                                    v.Fecha_Venta,
                                    c.Nombre AS Cliente,
                                    u.Nombre AS Usuario,
                                    v.metodo_pago
                                FROM Venta v
                                INNER JOIN Cliente c
                                    ON v.id_cliente = c.id_cliente
                                INNER JOIN Usuario u
                                    ON v.id_usuario = u.id_usuario
                                WHERE c.Nombre LIKE @buscar
                                   OR u.Nombre LIKE @buscar
                                   OR v.metodo_pago LIKE @buscar
                                ORDER BY v.id_venta DESC";

                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dgvVentas.DataSource = dt;

                        ConfigurarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar ventas.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarVentas(txtBuscar.Text.Trim());
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {

            if (modoEditar)
            {
                MessageBox.Show("Debe guardar o cancelar la edicion actual antes de crear una nueva venta.", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            modoNuevo = true;

            idVentaSeleccionada = 0;

            LimpiarFormulario();

            HabilitarControles(true);

            dtpFecha.Enabled = false;
            dtpFecha.Value = DateTime.Now;




        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            if (modoNuevo && detalleVenta.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Debe agregar al menos un producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    SqlTransaction transaccion = cn.BeginTransaction();

                    string consulta;

                    if (modoNuevo)
                    {
                        consulta = @"INSERT INTO Venta
                            (Fecha_Venta, metodo_pago, id_cliente, id_usuario)
                            VALUES
                            (@fecha,@metodo,@cliente,@usuario)";
                    }
                    else
                    {
                        consulta = @"UPDATE Venta
                           SET Fecha_Venta=@fecha,
                               metodo_pago=@metodo,
                               id_cliente=@cliente
                           WHERE id_venta=@id";
                    }

                    int idVenta = 0;

                    using (SqlCommand cmd = new SqlCommand(consulta, cn, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                        cmd.Parameters.AddWithValue("@metodo", cmbMetodoPago.Text);
                        cmd.Parameters.AddWithValue("@cliente", idClienteSeleccionado);
                        cmd.Parameters.AddWithValue("@usuario", cmbUsuario.SelectedValue);

                        if (!modoNuevo)
                            cmd.Parameters.AddWithValue("@id", idVentaSeleccionada);

                        if (modoNuevo)
                        {
                            cmd.CommandText += "; SELECT SCOPE_IDENTITY();";
                            idVenta = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            idVenta = idVentaSeleccionada;
                        }
                    }

                    // GUARDAR DETALLES
                    foreach (DataRow fila in detalleVenta.Rows)
                    {
                        int cantidadNueva = Convert.ToInt32(fila["Cantidad"]);
                        int cantidadAnterior = 0;

                        // Obtener cantidad anterior si se está editando
                        if (modoEditar)
                        {
                            string sqlCantidad = @"
                        SELECT Cantidad
                        FROM Detalle_Venta
                        WHERE id_venta=@venta
                        AND id_producto=@producto";

                            using (SqlCommand cmdCantidad = new SqlCommand(sqlCantidad, cn, transaccion))
                            {
                                cmdCantidad.Parameters.AddWithValue("@venta", idVenta);
                                cmdCantidad.Parameters.AddWithValue("@producto", Convert.ToInt32(fila["ID"]));

                                object resultado = cmdCantidad.ExecuteScalar();

                                if (resultado != null)
                                    cantidadAnterior = Convert.ToInt32(resultado);
                            }
                        }

                        // Verificar si el producto ya existe
                        int existeProducto = 0;

                        string sqlExiste = @"
                    SELECT COUNT(*)
                    FROM Detalle_Venta
                    WHERE id_venta=@venta
                    AND id_producto=@producto";

                        using (SqlCommand existeCmd = new SqlCommand(sqlExiste, cn, transaccion))
                        {
                            existeCmd.Parameters.AddWithValue("@venta", idVenta);
                            existeCmd.Parameters.AddWithValue("@producto", Convert.ToInt32(fila["ID"]));

                            existeProducto = Convert.ToInt32(existeCmd.ExecuteScalar());
                        }

                        // INSERTAR O ACTUALIZAR DETALLE
                        string sqlDetalle;

                        if (existeProducto > 0)
                        {
                            sqlDetalle = @"
                        UPDATE Detalle_Venta
                        SET Cantidad=@cantidad,
                            precio_unitario=@precio
                        WHERE id_venta=@venta
                        AND id_producto=@producto";
                        }
                        else
                        {
                            sqlDetalle = @"
                        INSERT INTO Detalle_Venta
                        (
                            Cantidad,
                            precio_unitario,
                            id_venta,
                            id_producto
                        )
                        VALUES
                        (
                            @cantidad,
                            @precio,
                            @venta,
                            @producto
                        )";
                        }

                        // ESTA PARTE FALTABA EN TU CÓDIGO
                        using (SqlCommand cmdDetalle = new SqlCommand(sqlDetalle, cn, transaccion))
                        {
                            cmdDetalle.Parameters.AddWithValue("@cantidad", cantidadNueva);
                            cmdDetalle.Parameters.AddWithValue("@precio", Convert.ToDecimal(fila["Precio"]));
                            cmdDetalle.Parameters.AddWithValue("@venta", idVenta);
                            cmdDetalle.Parameters.AddWithValue("@producto", Convert.ToInt32(fila["ID"]));

                            cmdDetalle.ExecuteNonQuery();
                        }

                        // ACTUALIZAR STOCK
                        int diferencia;

                        if (modoNuevo)
                            diferencia = cantidadNueva;
                        else
                            diferencia = cantidadNueva - cantidadAnterior;

                        if (diferencia != 0)
                        {
                            string sqlStock = @"
                        UPDATE Producto
                        SET Stock = Stock - @cantidad
                        WHERE id_producto=@producto";

                            using (SqlCommand cmdStock = new SqlCommand(sqlStock, cn, transaccion))
                            {
                                cmdStock.Parameters.AddWithValue("@cantidad", diferencia);
                                cmdStock.Parameters.AddWithValue("@producto", Convert.ToInt32(fila["ID"]));

                                cmdStock.ExecuteNonQuery();
                            }
                        }
                    }

                    transaccion.Commit();

                    MessageBox.Show(
                        "Venta guardada correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    MostrarVentas();

                    // Limpiar formulario después de guardar
                    LimpiarFormulario();

                    HabilitarControles(false);

                    modoNuevo = false;
                    modoEditar = false;
                    idVentaSeleccionada = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la venta: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void CargarDetalleVenta(int idVenta)
        {
            detalleVenta.Rows.Clear();

            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {

                if (cn.State != ConnectionState.Open)
                    cn.Open();

                string sql = @"
        SELECT
            p.id_producto,
            p.Nombre_Producto,
            dv.precio_unitario,
            p.impuesto,
            dv.Cantidad
        FROM Detalle_Venta dv
        INNER JOIN Producto p
            ON dv.id_producto = p.id_producto
        WHERE dv.id_venta = @id";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", idVenta);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    decimal precio = Convert.ToDecimal(dr["precio_unitario"]);
                    decimal isv = Convert.ToDecimal(dr["impuesto"]);
                    int cantidad = Convert.ToInt32(dr["Cantidad"]);
                    decimal subtotal = precio * cantidad;

                    detalleVenta.Rows.Add(
                        dr["id_producto"],
                        dr["Nombre_Producto"],
                        precio,
                        isv,
                        cantidad,
                        subtotal
                    );
                }

                dr.Close();
            }

            subtotalVenta = 0;
            impuestoVenta = 0;
            totalVenta = 0;

            foreach (DataRow fila in detalleVenta.Rows)
            {
                decimal subtotal = Convert.ToDecimal(fila["Subtotal"]);
                decimal isv = Convert.ToDecimal(fila["ISV"]) * Convert.ToInt32(fila["Cantidad"]);

                subtotalVenta += subtotal;
                impuestoVenta += isv;
            }

            totalVenta = subtotalVenta + impuestoVenta;

            lblSubtotal.Text = "L. " + subtotalVenta.ToString("N2");
            lblImpuestoValor.Text = "L. " + impuestoVenta.ToString("N2");
            lblTotalValor.Text = "L. " + totalVenta.ToString("N2");
        }

        private void BuscarStockProducto(int idProducto)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                string sql = @"SELECT Stock
                       FROM Producto
                       WHERE id_producto=@id";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", idProducto);

                object stock = cmd.ExecuteScalar();

                if (stock != null)
                    txtStock.Text = stock.ToString();
            }
        }

        // SELECCIONAR VENTA

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvVentas.Rows[e.RowIndex];

            idVentaSeleccionada = Convert.ToInt32(fila.Cells["id_venta"].Value);

            txtIDVenta.Text = fila.Cells["id_venta"].Value.ToString();

            if (fila.Cells["Fecha_Venta"].Value != DBNull.Value)
                dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha_Venta"].Value);

            cmbMetodoPago.Text = fila.Cells["metodo_pago"].Value.ToString();
            CargarClienteVenta(idVentaSeleccionada);

            CargarDetalleVenta(idVentaSeleccionada);
        }

        private void dgvDetallesVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvDetallesVentas.Rows[e.RowIndex];

            idProductoSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);

            txtBuscarProducto.Text = fila.Cells["Producto"].Value.ToString();
            txtProducto.Text = fila.Cells["Producto"].Value.ToString();

            txtPrecio.Text = Convert.ToDecimal(fila.Cells["Precio"].Value).ToString("N2");
            txtImpuesto.Text = Convert.ToDecimal(fila.Cells["ISV"].Value).ToString("N2");

            nudCantidad.Value = Convert.ToDecimal(fila.Cells["Cantidad"].Value);

            BuscarStockProducto(idProductoSeleccionado);

            TXTProductoRembolso.Text = fila.Cells["Producto"].Value.ToString();
            int cantidadActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
            nudCantidadRembolso.Minimum = 1;
            nudCantidadRembolso.Maximum = cantidadActual;
            nudCantidadRembolso.Value = 1;
        }

        private DataTable detalleVenta = new DataTable();

        private int idProductoSeleccionado = 0;

        private decimal subtotalVenta = 0;
        private decimal impuestoVenta = 0;
        private decimal totalVenta = 0;

        private void CrearDetalleVenta()
        {
            detalleVenta = new DataTable();

            detalleVenta.Columns.Add("ID", typeof(int));
            detalleVenta.Columns.Add("Producto");
            detalleVenta.Columns.Add("Precio", typeof(decimal));
            detalleVenta.Columns.Add("ISV", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("Subtotal", typeof(decimal));
            subtotalVenta = 0;
            impuestoVenta = 0;
            totalVenta = 0;

            dgvDetallesVentas.DataSource = detalleVenta;

            dgvDetallesVentas.Columns["ID"].Visible = false;

            dgvDetallesVentas.Columns["Producto"].HeaderText = "Producto";
            dgvDetallesVentas.Columns["Precio"].HeaderText = "Precio";
            dgvDetallesVentas.Columns["ISV"].HeaderText = "ISV";
            dgvDetallesVentas.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvDetallesVentas.Columns["Subtotal"].HeaderText = "Subtotal";

            dgvDetallesVentas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto.");

                txtBuscarProducto.Focus();
                return;
            }

            BuscarProducto(txtBuscarProducto.Text.Trim());
        }


        private void BuscarProducto(string nombre)
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"
                        SELECT TOP 1
                            id_producto,
                            Nombre_Producto,
                            Precio_Venta,
                            impuesto,
                            Stock
                        FROM Producto
                        WHERE Estado = 1
                        AND Nombre_Producto LIKE @nombre";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        idProductoSeleccionado =
                            Convert.ToInt32(dr["id_producto"]);

                        txtProducto.Text =
                            dr["Nombre_Producto"].ToString();

                        txtPrecio.Text =
                            Convert.ToDecimal(dr["Precio_Venta"])
                            .ToString("N2");

                        txtImpuesto.Text =
                            Convert.ToDecimal(dr["impuesto"])
                            .ToString("N2");

                        txtStock.Text =
                            dr["Stock"].ToString();

                        nudCantidad.Focus();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Producto no encontrado.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        idProductoSeleccionado = 0;

                        txtProducto.Clear();
                        txtPrecio.Clear();
                        txtImpuesto.Clear();
                        txtStock.Clear();
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar producto: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void LimpiarProducto()
        {
            idProductoSeleccionado = 0;

            txtBuscarProducto.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            txtImpuesto.Clear();
            txtStock.Clear();

            nudCantidad.Value = 1;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            if (modoEditar)
            {
                MessageBox.Show("no puede agrregar un producto en modo edicion, use el panel de reembolso",
                   "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("debe buscar un producto primero.", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            decimal precio = Convert.ToDecimal(txtPrecio.Text);

            decimal isv = Convert.ToDecimal(txtImpuesto.Text);

            int cantidad = Convert.ToInt32(nudCantidad.Value);

            decimal subtotal = precio * cantidad;

            decimal impuesto = isv * cantidad;

            decimal total = subtotal + impuesto;

            bool existe = false;


            foreach (DataRow fila in detalleVenta.Rows)
            {
                if (Convert.ToInt32(fila["ID"]) == idProductoSeleccionado)
                {
                    existe = true;


                    if (modoEditar)
                    {
                        fila["Cantidad"] = cantidad;
                        fila["Subtotal"] = subtotal;
                    }
                    else
                    {
                        int nuevaCantidad = Convert.ToInt32(fila["Cantidad"]) + cantidad;

                        fila["Cantidad"] = nuevaCantidad;
                        fila["Subtotal"] = precio * nuevaCantidad;
                    }


                    break;
                }
            }


            // Si el producto no existe, lo agrega aunque sea modo editar
            if (!existe)
            {
                detalleVenta.Rows.Add(
                    idProductoSeleccionado,
                    txtProducto.Text,
                    precio,
                    isv,
                    cantidad,
                    subtotal
                );
            }


            CalcularTotales();

            dgvDetallesVentas.DataSource = detalleVenta;

            LimpiarProducto();
        }
        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (txtStock.Text == "")
                return;

            int stock = Convert.ToInt32(txtStock.Text);

            if (nudCantidad.Value > stock)
            {
                MessageBox.Show(
                    "No hay suficiente stock disponible.",
                    "Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                nudCantidad.Value = stock;
            }
        }

        private void CargarClienteVenta(int idVenta)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                string sql = @"
            SELECT
                c.id_cliente,
                c.Nombre,
                c.DNI
            FROM Venta v
            INNER JOIN Cliente c
                ON v.id_cliente = c.id_cliente
            WHERE v.id_venta = @id";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", idVenta);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    idClienteSeleccionado = Convert.ToInt32(dr["id_cliente"]);

                    txtNombreCliente.Text = dr["Nombre"].ToString();
                    txtClienteDNI.Text = dr["DNI"].ToString();

                    if (dr["Nombre"].ToString() == "Cliente Generico")
                        cmbTipoCliente.Text = "Cliente Generico";
                    else
                        cmbTipoCliente.Text = "Cliente Normal";
                }

                dr.Close();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idVentaSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una venta para editar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (dgvVentas.CurrentRow == null)
                return;

            DataGridViewRow fila = dgvVentas.CurrentRow;

            txtIDVenta.Text = fila.Cells["id_venta"].Value.ToString();

            if (fila.Cells["Fecha_Venta"].Value != DBNull.Value)
                dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha_Venta"].Value);

            cmbMetodoPago.Text = fila.Cells["metodo_pago"].Value.ToString();

            CargarClienteVenta(idVentaSeleccionada);
            CargarDetalleVenta(idVentaSeleccionada);

            modoNuevo = false;
            modoEditar = true;

            HabilitarControles(true);

            dtpFecha.Enabled = false;
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarVentas();

            LimpiarFormulario();

            HabilitarControles(false);

            modoNuevo = false;
            modoEditar = false;
            idVentaSeleccionada = 0;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modoNuevo = false;
            modoEditar = false;

            idVentaSeleccionada = 0;

            LimpiarFormulario();

            HabilitarControles(false);

            dtpFecha.Value = DateTime.Today;
        }

        private void CalcularTotales()
        {
            subtotalVenta = 0;
            impuestoVenta = 0;

            foreach (DataRow fila in detalleVenta.Rows)
            {
                decimal precio = Convert.ToDecimal(fila["Precio"]);
                decimal isv = Convert.ToDecimal(fila["ISV"]);
                int cantidad = Convert.ToInt32(fila["Cantidad"]);

                subtotalVenta += precio * cantidad;
                impuestoVenta += isv * cantidad;
            }

            totalVenta = subtotalVenta + impuestoVenta;

            lblSubtotal.Text = "L. " + subtotalVenta.ToString("N2");
            lblImpuestoValor.Text = "L. " + impuestoVenta.ToString("N2");
            lblTotalValor.Text = "L. " + totalVenta.ToString("N2");
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
            {
                MessageBox.Show(
                    "Ingrese el DNI del cliente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBuscarCliente.Focus();
                return;
            }


            BuscarClienteDNI(txtBuscarCliente.Text.Trim());
        }

        private void BuscarClienteDNI(string dni)
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();


                    string sql = @"
                SELECT 
                    id_cliente,
                    Nombre,
                    DNI
                FROM Cliente
                WHERE DNI = @dni
                AND Estado = 1";


                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue("@dni", dni);


                    SqlDataReader dr = cmd.ExecuteReader();


                    if (dr.Read())
                    {
                        idClienteSeleccionado =
                            Convert.ToInt32(dr["id_cliente"]);


                        txtNombreCliente.Text =
                            dr["Nombre"].ToString();


                        txtClienteDNI.Text =
                            dr["DNI"].ToString();


                        MessageBox.Show(
                            "Cliente encontrado.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        idClienteSeleccionado = 0;

                        txtNombreCliente.Clear();
                        txtClienteDNI.Clear();


                        MessageBox.Show(
                            "Cliente no encontrado.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }


                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar cliente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (modoNuevo)
            {
                MessageBox.Show("debe guardar o cancelar la venta antes de editar otra.", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (menu.RolUsuario != "Administrador")
            {
                MessageBox.Show("solo un administrador puede editar ventas.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            modoEditar = true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
            modoEditar = false;
            modoNuevo = false;
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!modoEditar)
            {
                MessageBox.Show("debe presionar 'editar' para poder realizar un reembolso",
                    "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TXTProductoRembolso.Text))
            {
                MessageBox.Show("Seleccione un producto del dealle primero", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidadRembolso = Convert.ToInt32(nudCantidadRembolso.Value);

            DialogResult confirm = MessageBox.Show($" Desea Reembolsar? {cantidadRembolso} unidad(es) de {TXTProductoRembolso.Text}? ",
               "confirmar Reembolso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
                return;

            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    SqlTransaction transaccion = cn.BeginTransaction();

                    string sqlCantidadActual = @"
                    SELECT Cantidad
                    FROM Detalle_Venta
                    WHERE id_venta = @venta
                    AND id_producto = @producto";

                    int cantidadActual = 0;

                    using (SqlCommand cmd = new SqlCommand(sqlCantidadActual, cn, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@venta", idVentaSeleccionada);
                        cmd.Parameters.AddWithValue("@producto", idProductoSeleccionado);
                        cantidadActual = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    int cantidadNueva = cantidadActual - cantidadRembolso;

                    if (cantidadNueva <= 0)
                    {
                        string sqlEliminar = @"
                         DELETE FROM Detalle_Venta 
                         WHERE id_venta = @venta 
                         AND id_producto = @producto";

                        using (SqlCommand cmd = new SqlCommand(sqlEliminar, cn, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@venta", idVentaSeleccionada);
                            cmd.Parameters.AddWithValue("@producto", idProductoSeleccionado);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string sqlActualizar = @"
                          UPDATE Detalle_Venta 
                          SET Cantidad = @cantidad 
                          WHERE id_venta = @venta 
                          AND id_producto = @producto";

                        using (SqlCommand cmd = new SqlCommand(sqlActualizar, cn, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@cantidad", cantidadNueva);
                            cmd.Parameters.AddWithValue("@venta", idVentaSeleccionada);
                            cmd.Parameters.AddWithValue("@producto", idProductoSeleccionado);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    string sqlStock = @"
                     UPDATE Producto 
                     SET Stock = Stock + @cantidad 
                     WHERE id_producto = @producto";

                    using (SqlCommand cmd = new SqlCommand(sqlStock, cn, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", cantidadRembolso);
                        cmd.Parameters.AddWithValue("@producto", idProductoSeleccionado);
                        cmd.ExecuteNonQuery();
                    }

                    transaccion.Commit();

                    MessageBox.Show("Rembolso aplicado correctamente.",
                        "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDetalleVenta(idVentaSeleccionada);
                    TXTProductoRembolso.Clear();
                    nudCantidadRembolso.Value = 1;
                    nudCantidadRembolso.Maximum = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al aplicar reembolso: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlTotales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            if (!modoNuevo)
            {
                MessageBox.Show("solo puede buscar un cliente al crear una nueva venta.",
                    "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }



}
