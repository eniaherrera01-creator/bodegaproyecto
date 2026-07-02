using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class FrmCategoria : Form


    {
        private bool permitirCambioEstado = false;

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

            txtNombre.TextChanged += TxtNombre_TextChanged;
            dgvCategorias.CellClick += dgvCategorias_CellClick;

            // VALIDACIONES AL ESCRIBIR
            txtNombre.KeyPress += SoloLetras_KeyPress;
            txtDescripcion.KeyPress += SoloLetrasDescripcion_KeyPress;
            txtBuscar.KeyPress += SoloLetrasDescripcion_KeyPress;

            txtNombre.Enter += (s, e) =>
            {
                if (txtNombre.Text == "Ej: Medicamentos...")
                {
                    txtNombre.Text = "";
                    txtNombre.ForeColor = Color.Black;
                }
            };

            txtNombre.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    txtNombre.Text = "Ej: Medicamentos...";
                    txtNombre.ForeColor = Color.Gray;
                }
            };

            txtDescripcion.Enter += (s, e) =>
            {
                if (txtDescripcion.Text == "Descripción detallada de la categoría...")
                {
                    txtDescripcion.Text = "";
                    txtDescripcion.ForeColor = Color.Black;
                }
            };

            txtDescripcion.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    txtDescripcion.Text = "Descripción detallada de la categoría...";
                    txtDescripcion.ForeColor = Color.Gray;
                }
            };

            txtBuscar.Enter += (s, e) =>
            {
                if (txtBuscar.Text == "🔍 Buscar...")
                {
                    txtBuscar.Text = "";
                    txtBuscar.ForeColor = Color.Black;
                }
            };

            txtBuscar.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    txtBuscar.Text = "🔍 Buscar...";
                    txtBuscar.ForeColor = Color.Gray;
                }
            };

            txtBuscar.TextChanged += TxtBuscar_TextChanged;
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, espacios y borrar
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void SoloLetrasDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, espacios, borrar, punto, coma y guion
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',' &&
                e.KeyChar != '-' &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void ListarCategorias(string filtro = "")
        {
            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    string query = @"SELECT
                            id_categoria AS [ID],
                            Nombre_Categoria AS [Nombre Categoria],
                            Descripcion AS [Descripción],
                            CASE
                                WHEN Estado = 1 THEN 'Activo'
                                ELSE 'Inactivo'
                            END AS [Estado]
                         FROM Categoria";

                    if (!string.IsNullOrEmpty(filtro))
                    {
                        query += @" WHERE Nombre_Categoria LIKE @filtro
                        OR Descripcion LIKE @filtro";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvCategorias.DataSource = dt;

                        // Si no quieres mostrar el ID
                        dgvCategorias.Columns["ID"].Visible = false;

                        lblRegistros.Text = $"{dt.Rows.Count} registros";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCategoria()
        {
            string nombre = txtNombre.Text.Trim();
            string desc = txtDescripcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || nombre == "Ej: Medicamentos...")
            {
                MessageBox.Show("El nombre de la categoría es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            foreach (char c in nombre)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("El nombre de la categoría solo debe contener letras.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(desc) || desc == "Descripción detallada de la categoría...")
            {
                MessageBox.Show("La descripción de la categoría es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }

            foreach (char c in desc)
            {
                if (!char.IsLetter(c) &&
                    !char.IsWhiteSpace(c) &&
                    c != '.' &&
                    c != ',' &&
                    c != '-')
                {
                    MessageBox.Show("La descripción solo debe contener letras y signos básicos.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripcion.Focus();
                    return false;
                }
            }

            return true;
        }





        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCategoria())
                return;

            string nombre = txtNombre.Text.Trim();
            string desc = txtDescripcion.Text.Trim();

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
                    MessageBox.Show("¡Registro guardado con éxito!", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    ListarCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
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

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (!permitirCambioEstado)
            {
                MessageBox.Show("Primero debe presionar el botón Editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            string estadoActual = dgvCategorias.SelectedRows[0].Cells["Estado"].Value.ToString();

            // Texto dinámico según el estado actual de la categoría
            string accion = estadoActual == "Activo" ? "inhabilitar" : "habilitar";

            DialogResult resultado = MessageBox.Show(
                $"¿Desea {accion} esta categoría?",
                "Confirmar acción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            int idCategoria = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["ID"].Value);
            int nuevoEstado = estadoActual == "Activo" ? 0 : 1;

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"UPDATE Categoria
                       SET Estado = @Estado
                       WHERE id_categoria = @id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", idCategoria);

                cmd.ExecuteNonQuery();
            }

            string accionPasada = estadoActual == "Activo" ? "inhabilitada" : "habilitada";
            MessageBox.Show($"Categoría {accionPasada} correctamente.");

            ListarCategorias();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            permitirCambioEstado = true;

            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dgvCategorias.SelectedRows[0];

            txtId.Text = fila.Cells["ID"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre Categoria"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripción"].Value.ToString();

            txtNombre.ForeColor = Color.Black;
            txtDescripcion.ForeColor = Color.Black;

            btnGuardar.Enabled = true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }
    }
}