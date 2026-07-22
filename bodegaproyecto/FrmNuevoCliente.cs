using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class FrmNuevoCliente : Form
    {

        private SqlConnection conexion = ConexionBD.ObtenerConexion();


        public FrmNuevoCliente()
        {
            InitializeComponent();

            AsignarEventosManuales();
        }


        private void AsignarEventosManuales()
        {
            this.Load += FrmNuevoCliente_Load;

            btnGuardar.Click += btnGuardar_Click;

            btnCancelar.Click += btnCancelar_Click;

            btnVolver.Click += btnVolver_Click;
        }



        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {
            dtpFechaRegistro.Value = DateTime.Now;
            dtpFechaRegistro.Enabled = false;

            txtIDCliente.Text = "(Automático)";

            MostrarClientes();
        }



        private bool ValidarCampos()
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre completo del cliente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show(
                    "Ingrese el DNI del cliente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDNI.Focus();
                return false;
            }


            if (!txtDNI.Text.Trim().All(char.IsDigit))
            {
                MessageBox.Show(
                    "El DNI solamente debe contener números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDNI.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show(
                    "Ingrese el número de teléfono.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefono.Focus();
                return false;
            }


            if (!txtTelefono.Text.Trim().All(char.IsDigit))
            {
                MessageBox.Show(
                    "El teléfono solamente debe contener números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefono.Focus();
                return false;
            }


            if (!string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                try
                {
                    MailAddress correo =
                        new MailAddress(txtCorreo.Text.Trim());
                }
                catch
                {
                    MessageBox.Show(
                        "Ingrese un correo electrónico válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCorreo.Focus();

                    return false;
                }
            }


            return true;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!ValidarCampos())
                return;


            try
            {

                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {

                    if (cn.State != ConnectionState.Open)
                        cn.Open();


                    string sql = @"
                    INSERT INTO Cliente
                    (
                        Nombre,
                        DNI,
                        RTN,
                        Telefono,
                        Correo,
                        Direccion,
                        Fecha_Registro,
                        Estado
                    )
                    VALUES
                    (
                        @nombre,
                        @dni,
                        @rtn,
                        @telefono,
                        @correo,
                        @direccion,
                        @fecha,
                        1
                    )";


                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            txtNombre.Text.Trim());


                        cmd.Parameters.AddWithValue(
                            "@dni",
                            txtDNI.Text.Trim());


                        cmd.Parameters.AddWithValue(
                            "@rtn",
                            string.IsNullOrWhiteSpace(txtRTN.Text)
                            ? "N/A"
                            : txtRTN.Text.Trim());


                        cmd.Parameters.AddWithValue(
                            "@telefono",
                            txtTelefono.Text.Trim());


                        cmd.Parameters.AddWithValue(
                            "@correo",
                            string.IsNullOrWhiteSpace(txtCorreo.Text)
                            ? "N/A"
                            : txtCorreo.Text.Trim());


                        cmd.Parameters.AddWithValue(
                            "@direccion",
                            string.IsNullOrWhiteSpace(txtDireccion.Text)
                            ? "N/A"
                            : txtDireccion.Text.Trim());


                        cmd.Parameters.AddWithValue(
                            "@fecha",
                            dtpFechaRegistro.Value);


                        cmd.ExecuteNonQuery();

                    }


                    MessageBox.Show(
                        "Cliente registrado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    MostrarClientes();

                    LimpiarCampos();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    "Error al guardar cliente:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

        }


        private void MostrarClientes()
        {

            try
            {

                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {

                    if (cn.State != ConnectionState.Open)
                        cn.Open();


                    string sql = @"
                    SELECT
                        id_cliente,
                        Nombre,
                        DNI,
                        RTN,
                        Telefono,
                        Correo,
                        Direccion,
                        Fecha_Registro
                    FROM Cliente
                    WHERE Estado = 1
                    ORDER BY id_cliente DESC";


                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, cn);


                    DataTable dt = new DataTable();


                    da.Fill(dt);


                    dgvClientes.DataSource = dt;


                    dgvClientes.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;


                    dgvClientes.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;


                    dgvClientes.ReadOnly = true;


                    dgvClientes.AllowUserToAddRows = false;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    "Error al cargar clientes:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

        }


        private void LimpiarCampos()
        {

            txtIDCliente.Text = "(Automático)";

            txtNombre.Clear();

            txtDNI.Clear();

            txtRTN.Clear();

            txtTelefono.Clear();

            txtCorreo.Clear();

            txtDireccion.Clear();


            dtpFechaRegistro.Value = DateTime.Now;


            txtNombre.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}