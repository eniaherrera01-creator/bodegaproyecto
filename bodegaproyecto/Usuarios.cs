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
        private bool permitirSeleccionGrid = false; 
        private bool enModoEdicion = false; // Variable para controlar el modo de edición
        private bool enModoNuevo = false; // Variable para controlar el modo de nuevo

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
                    dgvUsuarios.Columns["id_usuario"].Visible = false;
                    //sirve para ocultar la columna de contraseña y id. Quitar estas lineas en caso de querer ver esos campos en dgv

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
            
            if (enModoEdicion)
            {
                MessageBox.Show("debe guardar o cancelar la edicion actual antes de crear un nuevo usuario.", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            enModoNuevo = true; 

            permitirSeleccionGrid = false;
            dgvUsuarios.ClearSelection();
            dgvUsuarios.CurrentCell = null;
            btnEstado.Enabled = false;

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

            // Validar que el nombre solo contenga letras y espacios
            foreach (char c in txtNombre.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("El nombre solo puede contener letras.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }
            }

            // VALIDAR CONTRASEÑA
            if (selectedUserId == -1 || txtContrasena.Text != contrasenaOriginal)
            {
                if (!ValidarContrasena(txtContrasena.Text))
                {
                    MessageBox.Show("La contraseña debe tener mínimo 8 caracteres, una mayúscula, un número y un símbolo.");
                    return;
                }
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

                    enModoEdicion = false; // sale del modo edicion
                    enModoNuevo = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private string contrasenaOriginal = ""; // Validacion
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Habilita el botón de inhabilitar/habilitar al seleccionar un usuario
            permitirSeleccionGrid = true;
            btnEstado.Enabled = true;

            if (enModoNuevo)
            {
                MessageBox.Show("debe guardar o cancelar el nuevo usuario antes de editar otro ", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            enModoEdicion = true; // entra en modo edicion

            DataGridViewRow row = dgvUsuarios.SelectedRows[0];
            selectedUserId = Convert.ToInt32(row.Cells["id_usuario"].Value);
            txtIDUsuario.Text = selectedUserId.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value.ToString();
            txtUsuario.Text = row.Cells["usuario"].Value.ToString();
            txtContrasena.Text = row.Cells["Contraseña"].Value.ToString();
            contrasenaOriginal = txtContrasena.Text;
            cmbRol.SelectedItem = row.Cells["rol"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // mensaje para confirmar si desea inhabilitar o habilitar el usuario seleccionado
            if (!permitirSeleccionGrid || dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Primero debe presionar 'Editar' y seleccione un usuario.");
                return;
            }

            string estadoActual = dgvUsuarios.SelectedRows[0].Cells["Estado"].Value.ToString();

            // texto dinamico segun el estado actual del usuario
            string accion = estadoActual == "Activo" ? "inhabilitar" : "habilitar";

            DialogResult resultado = MessageBox.Show($"¿Desea {accion} este usuario?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["id_usuario"].Value);
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

            string accionPasada = estadoActual == "Activo" ? "inhabilitado" : "habilitado";
            MessageBox.Show($"Usuario {accionPasada} correctamente.");

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

        // Validacion contraseña
        private bool ValidarContrasena(string contrasena)
        {
            if (contrasena.Length < 8)
                return false;

            if (!contrasena.Any(char.IsUpper))
                return false;

            if (!contrasena.Any(char.IsDigit))
                return false;

            if (contrasena.All(char.IsLetterOrDigit))
                return false;

            return true;
        }

        private void btnActualizar_Click(object sender, EventArgs e) { CargarUsuarios(); LimpiarFormulario(); }
        private void btnCancelar_Click(object sender, EventArgs e) 
        { 
           
            LimpiarFormulario();
            enModoEdicion = false; // sale del modo edicion
            enModoNuevo = false;
        }
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

        private string GenerarNombreUsuario(string nombreCompleto)
        {
            if (string.IsNullOrWhiteSpace(nombreCompleto))
                return string.Empty;

            string[] palabras = nombreCompleto.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (palabras.Length < 2)
                return string.Empty;

            string primerNombre = palabras[0];
            string ApellidoPaterno;

            if (palabras.Length == 2)
            {
                ApellidoPaterno = palabras[palabras.Length - 1];
            }
            else
            {
                ApellidoPaterno = palabras[palabras.Length - 2];
            }
            string usuario = primerNombre.Substring(0, 1) + ApellidoPaterno;

            return quitarTildes(usuario).ToLower();
        }

        private string quitarTildes(string texto)
        {
            string textoNormalizado = texto.Normalize(System.Text.NormalizationForm.FormD);
            var sb = new System.Text.StringBuilder();

            foreach (char c in textoNormalizado)
            {
                var categoria = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);
                if (categoria != System.Globalization.UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(System.Text.NormalizationForm.FormC);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = GenerarNombreUsuario(txtNombre.Text);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            btnEstado.Enabled = false;

        }

       
    }
}