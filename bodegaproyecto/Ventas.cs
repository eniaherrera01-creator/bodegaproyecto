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
            CargarClientes();
            CargarUsuarios();

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
            this.Load += Ventas_Load;
        }

        private void LimpiarFormulario()
        {
            txtIDVenta.Clear();
            txtIDVenta.Text = "(Automático)";

            dtpFecha.Value = DateTime.Now;

            cmbCliente.SelectedIndex = -1;
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

            cmbCliente.Focus();

            CrearDetalleVenta();
            dgvDetallesVentas.DataSource = detalleVenta;
        }


        private void HabilitarControles(bool estado)
        {
            cmbCliente.Enabled = estado;
            cmbMetodoPago.Enabled = estado;

            btnGuardar.Enabled = estado;

            txtBuscarProducto.Enabled = estado;
            btnBuscarProducto.Enabled = estado;
            btnAgregarProducto.Enabled = estado;

            nudCantidad.Enabled = estado;
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"SELECT
                                            id_cliente,
                                            Nombre
                                        FROM Cliente
                                        WHERE Estado = 1
                                        ORDER BY Nombre";

                    SqlDataAdapter da = new SqlDataAdapter(consulta, cn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cmbCliente.DataSource = dt;
                    cmbCliente.DisplayMember = "Nombre";
                    cmbCliente.ValueMember = "id_cliente";
                    cmbCliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar clientes: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
            if (cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un cliente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCliente.Focus();
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
            modoNuevo = true;
            modoEditar = false;

            idVentaSeleccionada = 0;

            LimpiarFormulario();

            HabilitarControles(true);

            dtpFecha.Enabled = false;
            dtpFecha.Value = DateTime.Now;

            cmbCliente.Focus();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            if (detalleVenta.Rows.Count == 0)
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

                    using (SqlCommand cmd = new SqlCommand(consulta, cn, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                        cmd.Parameters.AddWithValue("@metodo", cmbMetodoPago.Text);
                        cmd.Parameters.AddWithValue("@cliente", cmbCliente.SelectedValue);
                        cmd.Parameters.AddWithValue("@usuario", cmbUsuario.SelectedValue);

                        if (!modoNuevo)
                            cmd.Parameters.AddWithValue("@id", idVentaSeleccionada);

                        int idVenta = 0;

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

                        foreach (DataRow fila in detalleVenta.Rows)
                        {
                            string sqlDetalle = @"INSERT INTO Detalle_Venta
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

                            using (SqlCommand detalle =
                                   new SqlCommand(sqlDetalle, cn, transaccion))
                            {
                                detalle.Parameters.AddWithValue("@cantidad", fila["Cantidad"]);
                                detalle.Parameters.AddWithValue("@precio", fila["Precio"]);
                                detalle.Parameters.AddWithValue("@venta", idVenta);
                                detalle.Parameters.AddWithValue("@producto", fila["ID"]);

                                detalle.ExecuteNonQuery();

                                string sqlStock = @"UPDATE Producto
                                                  SET Stock = Stock - @cantidad
                                                  WHERE id_producto = @producto";


                                using (SqlCommand stock =
                                       new SqlCommand(sqlStock, cn, transaccion))
                                {
                                    stock.Parameters.AddWithValue("@cantidad", fila["Cantidad"]);
                                    stock.Parameters.AddWithValue("@producto", fila["ID"]);

                                    stock.ExecuteNonQuery();
                                }
                            }
                        }

                        transaccion.Commit();
                    }

                    MessageBox.Show(
                        "Venta guardada correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    MostrarVentas();

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

            cmbCliente.Text = fila.Cells["Cliente"].Value.ToString();
            cmbMetodoPago.Text = fila.Cells["metodo_pago"].Value.ToString();
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
            decimal precio = Convert.ToDecimal(txtPrecio.Text);

            decimal isv = Convert.ToDecimal(txtImpuesto.Text);

            int cantidad = Convert.ToInt32(nudCantidad.Value);

            decimal subtotal = precio * cantidad;

            decimal impuesto = isv * cantidad;

            decimal total = subtotal + impuesto;

            detalleVenta.Rows.Add(
                idProductoSeleccionado,
                txtProducto.Text,
                precio,
                isv,
                cantidad,
                subtotal);

            subtotalVenta += subtotal;
            impuestoVenta += impuesto;
            totalVenta += total;

            lblSubtotal.Text = "L. " + subtotalVenta.ToString("N2");
            lblImpuestoValor.Text = "L. " + impuestoVenta.ToString("N2");
            lblTotalValor.Text = "L. " + totalVenta.ToString("N2");

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

            cmbCliente.Text = fila.Cells["Cliente"].Value.ToString();
            cmbMetodoPago.Text = fila.Cells["metodo_pago"].Value.ToString();

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

    }

}
