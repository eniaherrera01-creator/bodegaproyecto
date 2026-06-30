using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class ProveedoresForm : Form
    {
        public ProveedoresForm()
        {
            InitializeComponent();
            AsignarEventosManuales();
            ListarProveedores();
        }

        private void AsignarEventosManuales()
        {
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            txtNombre.KeyPress += SoloLetras_KeyPress;
            txtTelefono.KeyPress += SoloTelefono_KeyPress;
            txtDireccion.KeyPress += Direccion_KeyPress;
            txtNombre.TextChanged += TxtNombre_TextChanged;
            txtBuscar.TextChanged += TxtBuscar_TextChanged;

            // Si usas DataGridView, deja esta línea activa:
            dgvProveedores.CellClick += dgvProveedores_CellClick;

            // Si usas DevExpress, comenta la línea de arriba y usa esta:
            // gridViewProveedores.RowClick += GridViewProveedores_RowClick;

            ConfigurarPlaceholder(txtNombre, "Ej: Distribuidora Norte...");
            ConfigurarPlaceholder(txtTelefono, "Ej: 9999-1111");
            ConfigurarPlaceholder(txtCorreo, "Ej: proveedor@gmail.com");
            ConfigurarPlaceholder(txtDireccion, "Ej: Tegucigalpa...");
            ConfigurarPlaceholder(txtBuscar, "🔍 Buscar...");
        }

        private void ConfigurarPlaceholder(TextBox caja, string textoPlaceholder)
        {
            caja.Enter += (s, e) =>
            {
                if (caja.Text == textoPlaceholder)
                {
                    caja.Text = "";
                    caja.ForeColor = Color.Black;
                }
            };

            caja.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(caja.Text))
                {
                    caja.Text = textoPlaceholder;
                    caja.ForeColor = Color.Gray;
                }
            };
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, espacios, borrar, punto y guion
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != '-' &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void SoloTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números, guion, espacio y borrar
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-' &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, números, espacios y símbolos comunes de dirección
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',' &&
                e.KeyChar != '-' &&
                e.KeyChar != '#' &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ListarProveedores(string filtro = "")
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    string query = @"SELECT 
                                        id_proveedor AS [ID],
                                        Nombre AS [Nombre],
                                        Telefono AS [Teléfono],
                                        Correo AS [Correo],
                                        Direccion AS [Dirección]
                                    FROM Proveedor";

                    if (!string.IsNullOrWhiteSpace(filtro) && filtro != "🔍 Buscar...")
                    {
                        query += @" WHERE Nombre LIKE @filtro
                                    OR Telefono LIKE @filtro
                                    OR Correo LIKE @filtro
                                    OR Direccion LIKE @filtro";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro) && filtro != "🔍 Buscar...")
                        {
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvProveedores.Columns.Clear();
                        dgvProveedores.AutoGenerateColumns = true;
                        dgvProveedores.DataSource = dt;

                        lblRegistros.Text = $"{dt.Rows.Count} registros";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }


        private bool ValidarProveedor()
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || nombre == "Ej: Distribuidora Norte...")
            {
                MessageBox.Show("El nombre del proveedor es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            foreach (char c in nombre)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && c != '.' && c != '-')
                {
                    MessageBox.Show("El nombre del proveedor solo debe contener letras.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(telefono) || telefono == "Ej: 9999-1111")
            {
                MessageBox.Show("El teléfono del proveedor es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            foreach (char c in telefono)
            {
                if (!char.IsDigit(c) && c != '-' && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("El teléfono solo debe contener números y guion.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono.Focus();
                    return false;
                }
            }

            if (telefono.Length < 8)
            {
                MessageBox.Show("El teléfono debe tener al menos 8 números.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(correo) || correo == "Ej: proveedor@gmail.com")
            {
                MessageBox.Show("El correo del proveedor es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("Ingrese un correo válido. Ejemplo: proveedor@gmail.com", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(direccion) || direccion == "Ej: Tegucigalpa...")
            {
                MessageBox.Show("La dirección del proveedor es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
                return false;
            }

            return true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarProveedor())
                return;

            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    SqlCommand cmd;

                    if (txtId.Text == "ID: Automático")
                    {
                        string query = @"INSERT INTO Proveedor
                                (Nombre, Telefono, Correo, Direccion)
                                VALUES
                                (@nombre, @telefono, @correo, @direccion)";

                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                        string query = @"UPDATE Proveedor SET
                                    Nombre = @nombre,
                                    Telefono = @telefono,
                                    Correo = @correo,
                                    Direccion = @direccion
                                WHERE id_proveedor = @id";

                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                    }

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@direccion", direccion);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Proveedor guardado correctamente.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    ListarProveedores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar proveedor: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "ID: Automático")
            {
                lblAlerta.Text = "Selecciona una fila primero";
                lblAlerta.Visible = true;
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este proveedor?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = ConexionBD.ObtenerConexion())
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        string query = "DELETE FROM Proveedor WHERE id_proveedor = @id";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Proveedor eliminado correctamente.");

                    LimpiarFormulario();
                    ListarProveedores();
                }
                catch (SqlException ex) when (ex.Number == 547)
                {
                    MessageBox.Show("No se puede eliminar este proveedor porque está siendo usado en otros registros.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar proveedor: " + ex.Message);
                }
            }
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                txtId.Text = fila.Cells["ID"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["Teléfono"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                txtDireccion.Text = fila.Cells["Dirección"].Value.ToString();

                txtNombre.ForeColor = Color.Black;
                txtTelefono.ForeColor = Color.Black;
                txtCorreo.ForeColor = Color.Black;
                txtDireccion.ForeColor = Color.Black;

                lblAlerta.Visible = false;
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            ListarProveedores(filtro);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && txtNombre.Text != "Ej: Distribuidora Norte...")
            {
                btnGuardar.Enabled = true;
                btnGuardar.BackColor = Color.FromArgb(40, 167, 69);
                btnGuardar.ForeColor = Color.White;
            }
            else
            {
                btnGuardar.Enabled = false;
                btnGuardar.BackColor = Color.White;
                btnGuardar.ForeColor = Color.Black;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtId.Text = "ID: Automático";

            txtNombre.Text = "Ej: Distribuidora Norte...";
            txtTelefono.Text = "Ej: 9999-1111";
            txtCorreo.Text = "Ej: proveedor@gmail.com";
            txtDireccion.Text = "Ej: Tegucigalpa...";

            txtNombre.ForeColor = Color.Gray;
            txtTelefono.ForeColor = Color.Gray;
            txtCorreo.ForeColor = Color.Gray;
            txtDireccion.ForeColor = Color.Gray;

            txtBuscar.Text = "🔍 Buscar...";
            txtBuscar.ForeColor = Color.Gray;

            lblAlerta.Visible = false;

            btnGuardar.Enabled = false;
            btnGuardar.BackColor = Color.White;
            btnGuardar.ForeColor = Color.Black;
        }

        private void ProveedoresForm_Load(object sender, EventArgs e)
        {

        }
    }
}