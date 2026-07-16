using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace bodegaproyecto
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            AsignarEventosManuales();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            MostrarProductos();
            LimpiarFormulario();

            dtpfv.Value = DateTime.Today;

            dtpfv.Value = DateTime.Today;
            dtpfv.Enabled = true;
        }

        private void AsignarEventosManuales()
        {
            // Primero quitamos eventos por si el Designer ya los agregó
            btnguardar.Click -= btnguardar_Click;
            btneditar.Click -= btneditar_Click;
            btnestado.Click -= btnestado_Click;
            btnnuevo.Click -= btnnuevo_Click;

            // Por si algún botón quedó conectado al evento equivocado

            txtbuscar.TextChanged -= txtbuscar_TextChanged;

            txtnombre.KeyPress -= TextoProducto_KeyPress;
            txtdescripcion.KeyPress -= TextoDescripcion_KeyPress;
            txtpreciocompra.KeyPress -= Decimal_KeyPress;
            txtprecioventa.KeyPress -= Decimal_KeyPress;
            txtimpuesto.KeyPress -= Decimal_KeyPress;
            txtstock.KeyPress -= Entero_KeyPress;
            txtbuscar.KeyPress -= TextoProducto_KeyPress;

            // Ahora sí agregamos los eventos correctos una sola vez
            btnguardar.Click += btnguardar_Click;
            btneditar.Click += btneditar_Click;
            btnestado.Click += btnestado_Click;
            btnnuevo.Click += btnnuevo_Click;

            txtbuscar.TextChanged += txtbuscar_TextChanged;

            txtnombre.KeyPress += TextoProducto_KeyPress;
            txtdescripcion.KeyPress += TextoDescripcion_KeyPress;
            txtpreciocompra.KeyPress += Decimal_KeyPress;
            txtprecioventa.KeyPress += Decimal_KeyPress;
            txtimpuesto.KeyPress += Decimal_KeyPress;
            txtstock.KeyPress += Entero_KeyPress;
            txtbuscar.KeyPress += TextoProducto_KeyPress;
        }

        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = "SELECT id_categoria, Nombre_Categoria FROM Categoria ORDER BY Nombre_Categoria";

                    SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbcategoria.DataSource = dt;
                    cbcategoria.DisplayMember = "Nombre_Categoria";
                    cbcategoria.ValueMember = "id_categoria";
                    cbcategoria.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarProductos()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"SELECT
                        p.id_producto,
                        p.Nombre_Producto,
                        p.Descripcion,
                        p.Precio_Compra,
                        p.Precio_Venta,
                        p.Stock,
                        p.fecha_vencimiento,
                        p.impuesto,
                        p.id_categoria,
                        c.Nombre_Categoria,
                        CASE
                            WHEN p.Estado = 1 THEN 'Activo'
                            ELSE 'Inactivo'
                        END AS Estado
                    FROM Producto p
                    INNER JOIN Categoria c
                    ON p.id_categoria = c.id_categoria
                    ORDER BY p.id_producto DESC";

                    SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvproductos.DataSource = dt;
                    ConfigurarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar productos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            if (dgvproductos.Columns.Count == 0)
                return;

            dgvproductos.Columns["id_producto"].HeaderText = "ID";
            dgvproductos.Columns["Nombre_Producto"].HeaderText = "Nombre del Producto";
            dgvproductos.Columns["Descripcion"].HeaderText = "Descripción";
            dgvproductos.Columns["Precio_Compra"].HeaderText = "Precio Compra";
            dgvproductos.Columns["Precio_Venta"].HeaderText = "Precio Venta";
            dgvproductos.Columns["Stock"].HeaderText = "Stock";
            dgvproductos.Columns["fecha_vencimiento"].HeaderText = "Fecha de Vencimiento";
            dgvproductos.Columns["impuesto"].HeaderText = "Impuesto";
            dgvproductos.Columns["Nombre_Categoria"].HeaderText = "Categoría";
            dgvproductos.Columns["Estado"].HeaderText = "Estado";

            dgvproductos.Columns["id_categoria"].Visible = false;

            dgvproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvproductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvproductos.ReadOnly = true;
        }

        private bool ValidarCampos()
        {
            string nombre = txtnombre.Text.Trim();
            string descripcion = txtdescripcion.Text.Trim();
            string precioCompraTexto = txtpreciocompra.Text.Trim();
            string precioVentaTexto = txtprecioventa.Text.Trim();
            string stockTexto = txtstock.Text.Trim();
            string impuestoTexto = txtimpuesto.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese el nombre del producto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return false;
            }

            if (nombre.Length < 3)
            {
                MessageBox.Show("El nombre del producto debe tener al menos 3 caracteres.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Ingrese la descripción del producto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdescripcion.Focus();
                return false;
            }

            if (!ObtenerDecimal(precioCompraTexto, out decimal precioCompra) || precioCompra <= 0)
            {
                MessageBox.Show("Ingrese un precio de compra válido mayor que 0.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpreciocompra.Focus();
                return false;
            }

            if (!ObtenerDecimal(precioVentaTexto, out decimal precioVenta) || precioVenta <= 0)
            {
                MessageBox.Show("Ingrese un precio de venta válido mayor que 0.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtprecioventa.Focus();
                return false;
            }

            if (precioVenta < precioCompra)
            {
                MessageBox.Show("El precio de venta no puede ser menor que el precio de compra.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtprecioventa.Focus();
                return false;
            }

            if (!int.TryParse(stockTexto, out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un stock válido. Solo números enteros.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtstock.Focus();
                return false;
            }

            if (!ObtenerDecimal(impuestoTexto, out decimal impuesto) || impuesto < 0)
            {
                MessageBox.Show("Ingrese un impuesto válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtimpuesto.Focus();
                return false;
            }

            if (impuesto > 100)
            {
                MessageBox.Show("El impuesto no puede ser mayor a 100.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtimpuesto.Focus();
                return false;
            }

            if (cbcategoria.SelectedIndex == -1 || cbcategoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbcategoria.Focus();
                return false;
            }

            if (dtpfv.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de vencimiento no puede ser menor a la fecha actual.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpfv.Focus();
                return false;
            }

            return true;
        }

        private bool ObtenerDecimal(string texto, out decimal numero)
        {
            texto = texto.Replace(",", ".");

            return decimal.TryParse(
                texto,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out numero
            );
        }

        private void GuardarProducto()
        {
            ObtenerDecimal(txtpreciocompra.Text.Trim(), out decimal precioCompra);
            ObtenerDecimal(txtprecioventa.Text.Trim(), out decimal precioVenta);
            ObtenerDecimal(txtimpuesto.Text.Trim(), out decimal impuesto);

            int stock = int.Parse(txtstock.Text.Trim());

            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"INSERT INTO Producto
                                (Nombre_Producto,Descripcion,
                                 Precio_Compra,Precio_Venta,
                                 Stock,fecha_vencimiento,
                                 impuesto,id_categoria,Estado)
                                VALUES
                                (@nombre,@descripcion,
                                 @compra,@venta,
                                 @stock,@fecha,
                                 @impuesto,@categoria,@estado)";

                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@compra", precioCompra);
                        cmd.Parameters.AddWithValue("@venta", precioVenta);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@fecha", dtpfv.Value.Date);
                        cmd.Parameters.AddWithValue("@impuesto", impuesto);
                        cmd.Parameters.AddWithValue("@categoria", cbcategoria.SelectedValue);
                        cmd.Parameters.AddWithValue("@estado", 1);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto guardado correctamente.");

                    MostrarProductos();
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                GuardarProducto();
            }
            else
            {
                ActualizarProducto();
            }


        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgvproductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para editar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dgvproductos.CurrentRow;

            txtId.Text = fila.Cells["id_producto"].Value.ToString();
            txtnombre.Text = fila.Cells["Nombre_Producto"].Value.ToString();
            txtdescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            txtpreciocompra.Text = fila.Cells["Precio_Compra"].Value.ToString();
            txtprecioventa.Text = fila.Cells["Precio_Venta"].Value.ToString();
            txtstock.Text = fila.Cells["Stock"].Value.ToString();
            txtimpuesto.Text = fila.Cells["impuesto"].Value.ToString();

            if (fila.Cells["fecha_vencimiento"].Value == DBNull.Value)
                dtpfv.Value = DateTime.Today;
            else
                dtpfv.Value = Convert.ToDateTime(fila.Cells["fecha_vencimiento"].Value);

            cbcategoria.SelectedValue = fila.Cells["id_categoria"].Value;
        }

        private void ActualizarProducto()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos())
                return;

            ObtenerDecimal(txtpreciocompra.Text.Trim(), out decimal precioCompra);
            ObtenerDecimal(txtprecioventa.Text.Trim(), out decimal precioVenta);
            ObtenerDecimal(txtimpuesto.Text.Trim(), out decimal impuesto);

            int stock = int.Parse(txtstock.Text.Trim());

            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"UPDATE Producto
                                        SET Nombre_Producto = @nombre,
                                            Descripcion = @descripcion,
                                            Precio_Compra = @compra,
                                            Precio_Venta = @venta,
                                            Stock = @stock,
                                            fecha_vencimiento = @fecha,
                                            impuesto = @impuesto,
                                            id_categoria = @categoria
                                        WHERE id_producto = @id";

                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                        cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@compra", precioCompra);
                        cmd.Parameters.AddWithValue("@venta", precioVenta);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@fecha", dtpfv.Value.Date);
                        cmd.Parameters.AddWithValue("@impuesto", impuesto);
                        cmd.Parameters.AddWithValue("@categoria", cbcategoria.SelectedValue);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto actualizado correctamente.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarProductos();
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnestado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Seleccione un producto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"UPDATE Producto
                                        SET Estado = CASE
                                            WHEN Estado = 1 THEN 0
                                            ELSE 1
                                        END
                                        WHERE id_producto = @id";

                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Estado actualizado correctamente.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarProductos();
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar estado: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos(txtbuscar.Text.Trim());
        }

        private void BuscarProductos(string buscar)
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"SELECT
                                            p.id_producto,
                                            p.Nombre_Producto,
                                            p.Descripcion,
                                            p.Precio_Compra,
                                            p.Precio_Venta,
                                            p.Stock,
                                            p.fecha_vencimiento,
                                            p.impuesto,
                                            p.id_categoria,
                                            c.Nombre_Categoria,
                                            CASE
                                            WHEN p.Estado = 1 THEN 'Activo'
                                            ELSE 'Inactivo'
                                            END AS Estado
                                        FROM Producto p
                                        INNER JOIN Categoria c
                                        ON p.id_categoria = c.id_categoria
                                        WHERE p.Nombre_Producto LIKE @buscar
                                           OR p.Descripcion LIKE @buscar
                                           OR c.Nombre_Categoria LIKE @buscar
                                        ORDER BY p.id_producto DESC";

                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvproductos.DataSource = dt;
                        ConfigurarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar producto: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtId.Clear();
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtpreciocompra.Clear();
            txtprecioventa.Clear();
            txtstock.Clear();
            txtimpuesto.Clear();
            txtbuscar.Clear();

            if (cbcategoria.Items.Count > 0)
                cbcategoria.SelectedIndex = -1;

            dtpfv.Value = DateTime.Today;

            txtnombre.Focus();
        }

        private void TextoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Para nombre de producto y búsqueda:
            // permite letras, números, espacios y símbolos básicos.
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',' &&
                e.KeyChar != '-' &&
                e.KeyChar != '/' &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TextoDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Para descripción:
            // permite letras, números, espacios y signos comunes.
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',' &&
                e.KeyChar != '-' &&
                e.KeyChar != '/' &&
                e.KeyChar != '#' &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Entero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo números enteros
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox caja = sender as TextBox;

            // Permitir números, borrar, punto y coma decimal
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',' &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            // Evitar más de un punto o coma decimal
            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                (caja.Text.Contains(".") || caja.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTituloForm_Click(object sender, EventArgs e)
        {

        }
    }
}