using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography; // HASH
using System.Text; // HASH

namespace bodegaproyecto
{
    public partial class Usuarios : Form
    {
        private int selectedUserId = -1;

        public Usuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios(string filtro = "")
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = @"SELECT
                    id_usuario,
                    Nombre,
                    usuario,
                    Contraseña,
                    rol,
                    CASE
                        WHEN Estado = 1 THEN 'Activo'
                        ELSE 'Inactivo'
                    END AS Estado
                 FROM Usuario";

                    if (!string.IsNullOrEmpty(filtro))
                        query += " WHERE Nombre LIKE @filtro OR usuario LIKE @filtro OR rol LIKE @filtro";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    if (!string.IsNullOrEmpty(filtro))
                        da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsuarios.DataSource = dt;

                    dgvUsuarios.Columns["Contraseña"].Visible = false; 
                    //sirve para ocultar la columna de contraseña. Quitar esta linea en caso de querer ver ese campo

                    dgvUsuarios.Columns["id_usuario"].HeaderText = "ID";
                    dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre Completo";
                    dgvUsuarios.Columns["usuario"].HeaderText = "Usuario";
                    dgvUsuarios.Columns["Contraseña"].HeaderText = "Contraseña";
                    dgvUsuarios.Columns["rol"].HeaderText = "Rol";
                    dgvUsuarios.Columns["Estado"].HeaderText = "Estado";

                    lblTotal.Text = "Total usuarios: " + dt.Rows.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtIDUsuario.Text = "(Automático)";
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            cmbRol.SelectedIndex = -1;
            selectedUserId = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query;
                    if (selectedUserId == -1)
                        query = "INSERT INTO Usuario (Nombre, usuario, Contraseña, rol) VALUES (@nombre, @usuario, @contrasena, @rol)";
                    else
                        query = "UPDATE Usuario SET Nombre=@nombre, usuario=@usuario, Contraseña=@contrasena, rol=@rol WHERE id_usuario=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@contrasena", CalcularSHA256(txtContrasena.Text.Trim())); // HASH
                    cmd.Parameters.AddWithValue("@rol", cmbRol.SelectedItem.ToString());
                    if (selectedUserId != -1)
                        cmd.Parameters.AddWithValue("@id", selectedUserId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(selectedUserId == -1 ? "✅ Usuario agregado." : "✅ Usuario actualizado.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow row = dgvUsuarios.SelectedRows[0];
            selectedUserId = Convert.ToInt32(row.Cells["id_usuario"].Value);
            txtIDUsuario.Text = selectedUserId.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value.ToString();
            txtUsuario.Text = row.Cells["usuario"].Value.ToString();
            txtContrasena.Text = row.Cells["Contraseña"].Value.ToString();
            cmbRol.SelectedItem = row.Cells["rol"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            int idUsuario = Convert.ToInt32(
                dgvUsuarios.SelectedRows[0].Cells["id_usuario"].Value);

            string estadoActual = dgvUsuarios.SelectedRows[0]
                .Cells["Estado"].Value.ToString();

            int nuevoEstado = estadoActual == "Activo" ? 0 : 1;

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"UPDATE Usuario
                       SET Estado = @Estado
                       WHERE id_usuario = @id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", idUsuario);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Estado actualizado correctamente.");
            CargarUsuarios();
        }

        // PARTE DEL HASH
        private string CalcularSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e) { CargarUsuarios(); LimpiarFormulario(); }
        private void btnCancelar_Click(object sender, EventArgs e) { LimpiarFormulario(); }
        private void txtBuscar_TextChanged(object sender, EventArgs e) { CargarUsuarios(txtBuscar.Text); }
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e) { }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string estado = dgvUsuarios.Rows[e.RowIndex]
                    .Cells["Estado"].Value.ToString().Trim();

                MessageBox.Show("Estado: " + estado);

                if (estado == "Activo")
                {
                    btnEstado.Text = "Inhabilitar";
                }
                else
                {
                    btnEstado.Text = "Habilitar";
                }
            }
        }
    }
}