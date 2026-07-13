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
        private bool esEdicion = false;

        public FrmCategoria()
        {
            InitializeComponent();
            AsignarEventosManuales();
            ListarCategorias();

            btnGuardar.Enabled = false;
        }

        private void AsignarEventosManuales()
        {
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            btnNuevo.Click += BtnNuevo_Click;

            txtNombre.TextChanged += TxtNombre_TextChanged;
            dgvCategorias.CellClick += dgvCategorias_CellClick;

            txtNombre.KeyPress += SoloLetras_KeyPress;
            txtDescripcion.KeyPress += SoloLetrasDescripcion_KeyPress;
            txtBuscar.KeyPress += SoloLetrasDescripcion_KeyPress;

            txtNombre.Enter += (s, e) =>
            {
                if (txtNombre.Text == "Ej: Medicamentos...")
                {
                    txtNombre.Clear();
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
                    txtDescripcion.Clear();
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
                    txtBuscar.Clear();
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            esEdicion = false;
            permitirCambioEstado = false;

            txtNombre.Focus();
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void SoloLetrasDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
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

                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        query += @" WHERE Nombre_Categoria LIKE @filtro
                                    OR Descripcion LIKE @filtro";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro))
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dgvCategorias.DataSource = dt;

                        dgvCategorias.Columns["ID"].Visible = false;

                        lblRegistros.Text = $"{dt.Rows.Count} registros";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidarCategoria()
        {
            string nombre = txtNombre.Text.Trim();
            nombre = System.Text.RegularExpressions.Regex.Replace(nombre, @"\s+", " ");
            nombre = System.Globalization.CultureInfo.CurrentCulture
                        .TextInfo
                        .ToTitleCase(nombre.ToLower());
            string descripcion = txtDescripcion.Text.Trim();

            if (nombre == "" || nombre == "Ej: Medicamentos...")
            {
                MessageBox.Show("Ingrese el nombre de la categoría.");

                txtNombre.Focus();

                return false;
            }

            if (nombre.Length < 3)
            {
                MessageBox.Show("El nombre debe contener al menos 3 letras.");

                txtNombre.Focus();

                return false;
            }

            if (descripcion == "" ||
                descripcion == "Descripción detallada de la categoría...")
            {
                MessageBox.Show("Ingrese una descripción.");

                txtDescripcion.Focus();

                return false;
            }

            if (descripcion.Length < 5)
            {
                MessageBox.Show("La descripción es demasiado corta.");

                txtDescripcion.Focus();

                return false;
            }

            return true;
        }

        private bool ExisteCategoria(string nombre)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"SELECT COUNT(*)
                               FROM Categoria
                               WHERE Nombre_Categoria=@nombre";

                if (esEdicion)
                    sql += " AND id_categoria<>@id";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@nombre", nombre);

                if (esEdicion)
                    cmd.Parameters.AddWithValue("@id", txtId.Text);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCategoria())
                return;

            string nombre = txtNombre.Text.Trim();

            nombre = System.Text.RegularExpressions.Regex.Replace(nombre, @"\s+", " ");

            nombre = System.Globalization.CultureInfo.CurrentCulture
                        .TextInfo
                        .ToTitleCase(nombre.ToLower());


            if (ExisteCategoria(txtNombre.Text.Trim()))
            {
                MessageBox.Show(
                    "Ya existe una categoría con ese nombre.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    SqlCommand cmd;

                    if (!esEdicion)
                    {
                        string sql = @"INSERT INTO Categoria
                                      (Nombre_Categoria, Descripcion)
                                      VALUES
                                      (@Nombre,@Descripcion)";

                        cmd = new SqlCommand(sql, con);
                    }
                    else
                    {
                        string sql = @"UPDATE Categoria
                                      SET Nombre_Categoria=@Nombre,
                                          Descripcion=@Descripcion
                                      WHERE id_categoria=@Id";

                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    }

                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        esEdicion
                        ? "Categoría actualizada correctamente."
                        : "Categoría registrada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarFormulario();

                    ListarCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la categoría.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "Ej: Medicamentos..." &&
                !string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblContadorCaracteres.Text = $"{txtNombre.Text.Length}/80";

                btnGuardar.Enabled = true;
            }
            else
            {
                lblContadorCaracteres.Text = "0/80";

                btnGuardar.Enabled = false;
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text == "🔍 Buscar..."
                ? ""
                : txtBuscar.Text.Trim();

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

            lblContadorCaracteres.Text = "0/80";

            lblAlerta.Visible = false;

            btnGuardar.Enabled = false;

            esEdicion = false;

            permitirCambioEstado = false;
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
                MessageBox.Show(
                    "Primero debe presionar el botón Editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione una categoría.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string estadoActual =
                dgvCategorias.SelectedRows[0].Cells["Estado"].Value.ToString();

            string accion =
                estadoActual == "Activo"
                ? "inhabilitar"
                : "habilitar";

            DialogResult r = MessageBox.Show(
                $"¿Desea {accion} esta categoría?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.No)
                return;

            int nuevoEstado =
                estadoActual == "Activo"
                ? 0
                : 1;

            int id =
                Convert.ToInt32(
                    dgvCategorias.SelectedRows[0].Cells["ID"].Value);

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"UPDATE Categoria
                               SET Estado=@Estado
                               WHERE id_categoria=@Id";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(
                estadoActual == "Activo"
                ? "Categoría inhabilitada correctamente."
                : "Categoría habilitada correctamente.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ListarCategorias();

            LimpiarFormulario();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            dgvCategorias.Rows[e.RowIndex].Selected = true;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione una categoría para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            permitirCambioEstado = true;
            esEdicion = true;

            DataGridViewRow fila = dgvCategorias.SelectedRows[0];

            txtId.Text = fila.Cells["ID"].Value.ToString();

            txtNombre.Text = fila.Cells["Nombre Categoria"].Value.ToString();

            txtDescripcion.Text = fila.Cells["Descripción"].Value.ToString();

            txtNombre.ForeColor = Color.Black;
            txtDescripcion.ForeColor = Color.Black;

            btnGuardar.Enabled = true;

            txtNombre.Focus();
            txtNombre.SelectionStart = txtNombre.Text.Length;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LimpiarFormulario();

            btnGuardar.Enabled = false;
        }
    }
}