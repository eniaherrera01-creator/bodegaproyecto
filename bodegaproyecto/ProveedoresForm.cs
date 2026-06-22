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
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            txtNombre.TextChanged += TxtNombre_TextChanged;
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || nombre == "Ej: Distribuidora Norte...")
            {
                MessageBox.Show("El nombre del proveedor es obligatorio.");
                return;
            }

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

                    MessageBox.Show("Proveedor guardado correctamente.");

                    LimpiarFormulario();
                    ListarProveedores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar proveedor: " + ex.Message);
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