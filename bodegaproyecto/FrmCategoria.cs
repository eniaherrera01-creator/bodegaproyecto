using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            AsignarEventosManuales();
            ListarCategorias();
        }

        private void AsignarEventosManuales()
        {
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            txtNombre.TextChanged += TxtNombre_TextChanged;
            dgvCategorias.CellClick += dgvCategorias_CellClick;

            txtNombre.Enter += (s, e) => { if (txtNombre.Text == "Ej: Medicamentos...") { txtNombre.Text = ""; txtNombre.ForeColor = Color.Black; } };
            txtNombre.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtNombre.Text)) { txtNombre.Text = "Ej: Medicamentos..."; txtNombre.ForeColor = Color.Gray; } };
            txtDescripcion.Enter += (s, e) => { if (txtDescripcion.Text == "Descripción detallada de la categoría...") { txtDescripcion.Text = ""; txtDescripcion.ForeColor = Color.Black; } };
            txtDescripcion.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) { txtDescripcion.Text = "Descripción detallada de la categoría..."; txtDescripcion.ForeColor = Color.Gray; } };
            txtBuscar.Enter += (s, e) => { if (txtBuscar.Text == "🔍 Buscar...") { txtBuscar.Text = ""; txtBuscar.ForeColor = Color.Black; } };
            txtBuscar.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtBuscar.Text)) { txtBuscar.Text = "🔍 Buscar..."; txtBuscar.ForeColor = Color.Gray; } };
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
        }

        private void ListarCategorias(string filtro = "")
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    // Consulta adaptada exactamente a las 3 columnas de tu diagrama
                    string query = "SELECT id_categoria AS [ID], Nombre_Categoria AS [Nombre Categoria], Descripcion AS [Descripción] FROM Categoria";
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        query += " WHERE Nombre_Categoria LIKE @filtro OR Descripcion LIKE @filtro";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCategorias.DataSource = dt;

                        lblRegistros.Text = $"{dt.Rows.Count} registros";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string desc = txtDescripcion.Text == "Descripción detallada de la categoría..." ? "" : txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || nombre == "Ej: Medicamentos...")
            {
                MessageBox.Show("El nombre de la categoría es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    SqlCommand cmd;

                    if (txtId.Text == "ID: Automático")
                    {
                        string query = "INSERT INTO Categoria (Nombre_Categoria, Descripcion) VALUES (@nombre, @desc)";
                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                        string query = "UPDATE Categoria SET Nombre_Categoria = @nombre, Descripcion = @desc WHERE id_categoria = @id";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                    }

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@desc", desc);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("¡Registro guardado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    ListarCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta categoría?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = ConexionBD.ObtenerConexion())
                    {
                        string query = "DELETE FROM Categoria WHERE id_categoria = @id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    ListarCategorias();
                }
                catch (SqlException ex) when (ex.Number == 547) // Código de error de clave foránea en SQL Server
                {
                    MessageBox.Show("No se puede eliminar esta categoría porque está siendo utilizada por uno o más productos.", "Restricción de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];
                txtId.Text = fila.Cells["ID"].Value.ToString();
                txtId.Visible = false;
                txtNombre.Text = fila.Cells["Nombre Categoria"].Value.ToString();
                txtNombre.ForeColor = Color.Black;
                txtDescripcion.Text = fila.Cells["Descripción"].Value.ToString();
                txtDescripcion.ForeColor = Color.Black;
                lblAlerta.Visible = false;
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "Ej: Medicamentos..." && !string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblContadorCaracteres.Text = $"{txtNombre.Text.Length}/80";
                btnGuardar.Enabled = true;
                btnGuardar.BackColor = Color.FromArgb(40, 167, 69);
                btnGuardar.ForeColor = Color.White;
            }
            else
            {
                lblContadorCaracteres.Text = "0/80";
                btnGuardar.Enabled = false;
                btnGuardar.BackColor = Color.White;
                btnGuardar.ForeColor = Color.Black;
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text == "🔍 Buscar..." ? "" : txtBuscar.Text.Trim();
            ListarCategorias(filtro);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtId.Text = "ID: Automático";
            txtNombre.Text = "Ej: Medicamentos...";
            txtNombre.ForeColor = Color.Gray;
            txtDescripcion.Text = "Descripción detallada de la categoría...";
            txtDescripcion.ForeColor = Color.Gray;
            lblAlerta.Visible = false;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}