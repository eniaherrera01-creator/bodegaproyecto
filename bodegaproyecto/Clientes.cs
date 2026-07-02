using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class Clientes : Form
    {
        private int selectedClienteId = -1;

        private bool permitirSeleccionGrid = false;
        private bool enModoEdicion = false;
        private bool enModoNuevo = false;

        public Clientes()
        {
            InitializeComponent();

            CargarClientes();

            btnEstado.Enabled = false;
            dtpFechaRegistro.Value = DateTime.Now;
        }

        private void CargarClientes(string filtro = "")
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = @"
                    SELECT
                        id_cliente,
                        Codigo_Cliente,
                        Nombre,
                        RTN,
                        DNI,
                        Telefono,
                        Correo,
                        Direccion,
                        Fecha_Registro,
                        CASE
                            WHEN Estado = 1 THEN 'Activo'
                            ELSE 'Inactivo'
                        END AS Estado
                    FROM Cliente";

                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        query += @" WHERE
                                Codigo_Cliente LIKE @filtro OR
                                Nombre LIKE @filtro OR
                                RTN LIKE @filtro OR
                                DNI LIKE @filtro OR
                                Telefono LIKE @filtro";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    }

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvClientes.DataSource = dt;

                    dgvClientes.Columns["id_cliente"].Visible = false;

                    dgvClientes.Columns["Codigo_Cliente"].HeaderText = "Código";
                    dgvClientes.Columns["Nombre"].HeaderText = "Nombre";
                    dgvClientes.Columns["RTN"].HeaderText = "RTN";
                    dgvClientes.Columns["DNI"].HeaderText = "DNI";
                    dgvClientes.Columns["Telefono"].HeaderText = "Teléfono";
                    dgvClientes.Columns["Correo"].HeaderText = "Correo";
                    dgvClientes.Columns["Direccion"].HeaderText = "Dirección";
                    dgvClientes.Columns["Fecha_Registro"].HeaderText = "Fecha";
                    dgvClientes.Columns["Estado"].HeaderText = "Estado";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar clientes.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtIDCliente.Text = "(Automático)";
            txtCodigoCliente.Clear();
            txtNombre.Clear();
            txtRTN.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();


            dtpFechaRegistro.Value = DateTime.Now;

            selectedClienteId = -1;
        }


        //=====================================================
        // VALIDAR SI EXISTE EL CÓDIGO
        //=====================================================

        private bool ExisteCodigo(string codigo, int idCliente)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string sql = @"SELECT COUNT(*)
                               FROM Cliente
                               WHERE Codigo_Cliente=@Codigo
                               AND id_cliente<>@ID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@ID", idCliente == -1 ? 0 : idCliente);

                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        //=====================================================
        // VALIDAR RTN
        //=====================================================

        private bool ExisteRTN(string rtn, int idCliente)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string sql = @"SELECT COUNT(*)
                               FROM Cliente
                               WHERE RTN=@RTN
                               AND id_cliente<>@ID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@RTN", rtn);
                cmd.Parameters.AddWithValue("@ID", idCliente == -1 ? 0 : idCliente);

                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        //=====================================================
        // VALIDAR DNI
        //=====================================================

        private bool ExisteDNI(string dni, int idCliente)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string sql = @"SELECT COUNT(*)
                               FROM Cliente
                               WHERE DNI=@DNI
                               AND id_cliente<>@ID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@DNI", dni);
                cmd.Parameters.AddWithValue("@ID", idCliente == -1 ? 0 : idCliente);

                return (int)cmd.ExecuteScalar() > 0;
            }
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //==============================
            // VALIDAR CAMPOS VACIOS
            //==============================

            if (string.IsNullOrWhiteSpace(txtCodigoCliente.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtRTN.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show(
                    "Debe completar todos los campos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            //==============================
            // NOMBRE
            //==============================

            foreach (char c in txtNombre.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show(
                        "El nombre solo puede contener letras.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }
            }

            //==============================
            // RTN
            //==============================

            if (txtRTN.Text.Length != 14 || !txtRTN.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El RTN debe contener exactamente 14 números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtRTN.Focus();
                return;
            }

            //==============================
            // DNI
            //==============================

            if (txtDNI.Text.Length != 13 || !txtDNI.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El DNI debe contener exactamente 13 números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDNI.Focus();
                return;
            }

            //==============================
            // TELEFONO
            //==============================

            if (txtTelefono.Text.Length != 8 || !txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El teléfono debe contener 8 dígitos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefono.Focus();
                return;
            }


            //==============================
            // CORREO
            //==============================

            if (!Regex.IsMatch(
                txtCorreo.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show(
                    "Ingrese un correo válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCorreo.Focus();
                return;
            }





            //==============================
            // DUPLICADOS
            //==============================

            if (ExisteCodigo(txtCodigoCliente.Text.Trim(), selectedClienteId))
            {
                MessageBox.Show(
                    "El código del cliente ya existe.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (ExisteRTN(txtRTN.Text.Trim(), selectedClienteId))
            {
                MessageBox.Show(
                    "El RTN ya está registrado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (ExisteDNI(txtDNI.Text.Trim(), selectedClienteId))
            {
                MessageBox.Show(
                    "El DNI ya está registrado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            //==============================
            // GUARDAR
            //==============================

            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {

                    string query;

                    if (selectedClienteId == -1)
                    {
                        query = @"
                        INSERT INTO Cliente
                        (
                            Codigo_Cliente,
                            Nombre,
                            RTN,
                            DNI,
                            Telefono,
                            Correo,
                            Direccion,
                            Fecha_Registro)
                        VALUES
                        (
                            @Codigo,
                            @Nombre,
                            @RTN,
                            @DNI,
                            @Telefono,
                            @Correo,
                            @Direccion,
                            @Fecha)";
                    }
                    else
                    {
                        query = @"
                        UPDATE Cliente
                        SET

                            Codigo_Cliente=@Codigo,
                            Nombre=@Nombre,
                            RTN=@RTN,
                            DNI=@DNI,
                            Telefono=@Telefono,
                            Correo=@Correo,
                            Direccion=@Direccion,
                            Fecha_Registro=@Fecha
                        WHERE id_cliente=@ID";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Codigo", txtCodigoCliente.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@RTN", txtRTN.Text.Trim());
                    cmd.Parameters.AddWithValue("@DNI", txtDNI.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@Fecha", dtpFechaRegistro.Value);

                    if (selectedClienteId != -1)
                        cmd.Parameters.AddWithValue("@ID", selectedClienteId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        selectedClienteId == -1
                        ? "✅ Cliente agregado correctamente."
                        : "✅ Cliente actualizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarFormulario();

                    CargarClientes();

                    enModoEdicion = false;
                    enModoNuevo = false;
                }
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

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            if (enModoEdicion)
            {
                MessageBox.Show(
                    "Debe guardar o cancelar la edición actual antes de crear un nuevo cliente.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            enModoNuevo = true;

            permitirSeleccionGrid = false;

            dgvClientes.ClearSelection();
            dgvClientes.CurrentCell = null;

            btnEstado.Enabled = false;

            LimpiarFormulario();

            txtCodigoCliente.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            permitirSeleccionGrid = true;
            btnEstado.Enabled = true;

            if (enModoNuevo)
            {
                MessageBox.Show(
                    "Debe guardar o cancelar el nuevo cliente antes de editar otro.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un cliente.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            enModoEdicion = true;

            DataGridViewRow row = dgvClientes.SelectedRows[0];

            selectedClienteId =
                Convert.ToInt32(row.Cells["id_cliente"].Value);

            txtIDCliente.Text = selectedClienteId.ToString();

            txtCodigoCliente.Text = row.Cells["Codigo_Cliente"].Value.ToString();

            txtNombre.Text = row.Cells["Nombre"].Value.ToString();

            txtRTN.Text = row.Cells["RTN"].Value.ToString();

            txtDNI.Text = row.Cells["DNI"].Value.ToString();

            txtTelefono.Text = row.Cells["Telefono"].Value.ToString();

            txtCorreo.Text = row.Cells["Correo"].Value.ToString();

            txtDireccion.Text = row.Cells["Direccion"].Value.ToString();

            dtpFechaRegistro.Value =
                Convert.ToDateTime(row.Cells["Fecha_Registro"].Value);

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (!permitirSeleccionGrid || dgvClientes.CurrentRow == null)
            {
                MessageBox.Show(
                    "Primero presione Editar y seleccione un cliente.");

                return;
            }

            string estadoActual =
                dgvClientes.SelectedRows[0]
                .Cells["Estado"].Value.ToString();

            string accion =
                estadoActual == "Activo"
                ? "inhabilitar"
                : "habilitar";

            DialogResult r = MessageBox.Show(

                $"¿Desea {accion} este cliente?",

                "Confirmar",

                MessageBoxButtons.YesNo,

                MessageBoxIcon.Question);

            if (r == DialogResult.No)
                return;

            int nuevoEstado =
                estadoActual == "Activo" ? 0 : 1;

            using (SqlConnection conn =
                ConexionBD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(

                @"UPDATE Cliente
                  SET Estado=@Estado
                  WHERE id_cliente=@ID",

                conn);

                cmd.Parameters.AddWithValue("@Estado", nuevoEstado);

                cmd.Parameters.AddWithValue("@ID",
                    selectedClienteId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(

                estadoActual == "Activo"
                ? "Cliente inhabilitado."
                : "Cliente habilitado.",

                "Información",

                MessageBoxButtons.OK,

                MessageBoxIcon.Information);

            CargarClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            CargarClientes();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarClientes(txtBuscar.Text);

        }

        private void dgvClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string estado =
                dgvClientes.Rows[e.RowIndex].Cells["Estado"].Value.ToString();

            if (estado == "Activo")
                btnEstado.Text = "Inhabilitar";
            else
                btnEstado.Text = "Habilitar";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            enModoNuevo = false;
            enModoEdicion = false;

            dgvClientes.ClearSelection();

            btnEstado.Enabled = false;
        }


        //=====================================================
        // SOLO LETRAS
        //=====================================================

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //=====================================================
        // SOLO NÚMEROS
        //=====================================================

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }



        //=====================================================
        // VALIDAR CORREO AL SALIR
        //=====================================================
        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
          
        }

        //=====================================================
        // LONGITUD MÁXIMA
        //=====================================================

        private void Clientes_Load_1(object sender, EventArgs e)
        {
            btnEstado.Enabled = false;

            txtRTN.MaxLength = 14;
            txtDNI.MaxLength = 13;
            txtTelefono.MaxLength = 8;

            txtCodigoCliente.MaxLength = 20;
            txtNombre.MaxLength = 100;
            txtCorreo.MaxLength = 100;
            txtDireccion.MaxLength = 250;

            dgvClientes.ClearSelection();
        }
    }


}
