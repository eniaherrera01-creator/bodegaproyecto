using DevExpress.CodeParser;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class ProveedoresForm : Form
    {
        private bool permitirSeleccionGrid = false;

        public ProveedoresForm()
        {
            InitializeComponent();

            AsignarEventosManuales();

            ListarProveedores();

            btnGuardar.Enabled = false;
            btnEstado.Enabled = false;
        }

        private void AsignarEventosManuales()
        {
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            btnNuevo.Click += btnNuevo_Click;

            txtNombre.KeyPress += SoloLetras_KeyPress;
            txtTelefono.KeyPress += SoloTelefono_KeyPress;
            txtDireccion.KeyPress += Direccion_KeyPress;

            txtNombre.TextChanged += TxtNombre_TextChanged;
            txtBuscar.TextChanged += TxtBuscar_TextChanged;

            dgvProveedores.CellClick += dgvProveedores_CellClick;

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
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != '-' &&
                e.KeyChar != '&' &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void SoloTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                        con.Open();

                    string query = @"
                    SELECT
                        id_proveedor AS ID,
                        Nombre,
                        Telefono AS [Teléfono],
                        Correo,
                        Direccion AS [Dirección],
                        CASE
                            WHEN Estado = 1 THEN 'Activo'
                            ELSE 'Inactivo'
                        END AS Estado
                    FROM Proveedor";

                    if (!string.IsNullOrWhiteSpace(filtro) &&
                        filtro != "🔍 Buscar...")
                    {
                        query += @" WHERE
                                    Nombre LIKE @filtro
                                    OR Telefono LIKE @filtro
                                    OR Correo LIKE @filtro
                                    OR Direccion LIKE @filtro";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro) &&
                            filtro != "🔍 Buscar...")
                        {
                            cmd.Parameters.AddWithValue("@filtro",
                                "%" + filtro + "%");
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dgvProveedores.AutoGenerateColumns = true;
                        dgvProveedores.DataSource = dt;

                        // Ocultar el ID
                        dgvProveedores.Columns["ID"].Visible = false;

                        lblRegistros.Text = $"{dt.Rows.Count} registros";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar proveedores.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Valida que no exista otro proveedor con el mismo nombre.
        /// </summary>
        private bool ExisteProveedor(string nombre, int idProveedor = 0)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"SELECT COUNT(*)
                               FROM Proveedor
                               WHERE Nombre=@nombre
                               AND id_proveedor<>@id";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@id", idProveedor);

                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                return cantidad > 0;
            }
        }
        private bool ValidarProveedor()
        {
            string nombre = Regex.Replace(txtNombre.Text.Trim(), @"\s+", " ");
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = Regex.Replace(txtDireccion.Text.Trim(), @"\s+", " ");

            if (string.IsNullOrWhiteSpace(nombre) ||
                nombre == "Ej: Distribuidora Norte...")
            {
                MessageBox.Show(
                    "El nombre del proveedor es obligatorio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                return false;
            }

            foreach (char c in nombre)
            {
                if (!char.IsLetter(c) &&
                    !char.IsWhiteSpace(c) &&
                    c != '.' &&
                    c != '-' &&
                    c != '&')
                {
                    MessageBox.Show(
                        "El nombre contiene caracteres no válidos.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return false;
                }
            }

            string soloNumeros = telefono.Replace("-", "");

            if (string.IsNullOrWhiteSpace(telefono) ||
                telefono == "Ej: 9999-1111")
            {
                MessageBox.Show(
                    "Debe ingresar un teléfono.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefono.Focus();
                return false;
            }

            if (soloNumeros.Length != 8)
            {
                MessageBox.Show(
                    "El teléfono debe contener exactamente 8 dígitos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(correo) ||
                correo == "Ej: proveedor@gmail.com")
            {
                MessageBox.Show(
                    "Debe ingresar un correo electrónico.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCorreo.Focus();
                return false;
            }

            if (!Regex.IsMatch(correo,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show(
                    "Ingrese un correo electrónico válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCorreo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(direccion) ||
                direccion == "Ej: Tegucigalpa...")
            {
                MessageBox.Show(
                    "Debe ingresar la dirección.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDireccion.Focus();
                return false;
            }

            return true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarProveedor())
                return;

            string nombre = Regex.Replace(txtNombre.Text.Trim(), @"\s+", " ");
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = Regex.Replace(txtDireccion.Text.Trim(), @"\s+", " ");

            int idProveedor = 0;

            if (txtId.Text != "ID: Automático")
                idProveedor = Convert.ToInt32(txtId.Text);

            if (ExisteProveedor(nombre, idProveedor))
            {
                MessageBox.Show(
                    "Ya existe un proveedor con ese nombre.",
                    "Proveedor duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                txtId.Text == "ID: Automático"
                ? "¿Desea guardar este proveedor?"
                : "¿Desea actualizar este proveedor?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                return;

            try
            {
                using (SqlConnection con = ConexionBD.ObtenerConexion())
                {
                    SqlCommand cmd;

                    if (txtId.Text == "ID: Automático")
                    {
                        cmd = new SqlCommand(@"
                        INSERT INTO Proveedor
                        (
                            Nombre,
                            Telefono,
                            Correo,
                            Direccion
                        )
                        VALUES
                        (
                            @nombre,
                            @telefono,
                            @correo,
                            @direccion
                        )", con);
                    }
                    else
                    {
                        cmd = new SqlCommand(@"
                        UPDATE Proveedor
                        SET
                            Nombre=@nombre,
                            Telefono=@telefono,
                            Correo=@correo,
                            Direccion=@direccion
                        WHERE id_proveedor=@id", con);

                        cmd.Parameters.AddWithValue(
                            "@id",
                            idProveedor);
                    }

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@direccion", direccion);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Proveedor guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                ListarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            permitirSeleccionGrid = false;

            btnEstado.Enabled = false;

            LimpiarFormulario();

            txtNombre.Focus();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (filtro == "🔍 Buscar...")
                filtro = "";

            ListarProveedores(filtro);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtNombre.SelectionStart;

            txtNombre.Text = Regex.Replace(txtNombre.Text, @"\s{2,}", " ");

            txtNombre.SelectionStart = posicion;

            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                txtNombre.Text != "Ej: Distribuidora Norte...")
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

        private void dgvProveedores_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (!permitirSeleccionGrid)
                return;

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

            btnGuardar.Enabled = true;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (!permitirSeleccionGrid)
            {
                MessageBox.Show(
                    "Primero debe presionar el botón Editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgvProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un proveedor.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string estadoActual = dgvProveedores.SelectedRows[0]
                .Cells["Estado"].Value.ToString();

            string accion = estadoActual == "Activo"
                ? "inhabilitar"
                : "habilitar";

            DialogResult respuesta = MessageBox.Show(
                $"¿Desea {accion} este proveedor?",
                "Confirmar acción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                return;

            int idProveedor = Convert.ToInt32(
                dgvProveedores.SelectedRows[0].Cells["ID"].Value);

            int nuevoEstado = estadoActual == "Activo" ? 0 : 1;

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                string sql = @"UPDATE Proveedor
                               SET Estado=@Estado
                               WHERE id_proveedor=@id";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", idProveedor);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(
                $"Proveedor {(estadoActual == "Activo" ? "inhabilitado" : "habilitado")} correctamente.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            permitirSeleccionGrid = false;
            btnEstado.Enabled = false;

            LimpiarFormulario();
            ListarProveedores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un proveedor para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            permitirSeleccionGrid = true;
            btnEstado.Enabled = true;

            DataGridViewRow fila = dgvProveedores.SelectedRows[0];

            txtId.Text = fila.Cells["ID"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtTelefono.Text = fila.Cells["Teléfono"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            txtDireccion.Text = fila.Cells["Dirección"].Value.ToString();

            txtNombre.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            txtCorreo.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;

            btnGuardar.Enabled = true;

            txtNombre.Focus();
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

            txtBuscar.ForeColor = Color.Gray;

            lblAlerta.Visible = false;

            btnGuardar.Enabled = false;
            btnGuardar.BackColor = Color.White;
            btnGuardar.ForeColor = Color.Black;

            permitirSeleccionGrid = false;
            btnEstado.Enabled = false;
        }

        private void ProveedoresForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }

    }
}