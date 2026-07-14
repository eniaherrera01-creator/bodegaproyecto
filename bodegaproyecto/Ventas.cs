using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class Ventas : Form
    {
        private int idVentaSeleccionada = 0;
        private bool modoNuevo = false;
        private bool modoEditar = false;

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarUsuarios();
            CargarVentas();

            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtIDVenta.Text = "(Automático)";

            dtpFecha.Value = DateTime.Now;

            cmbCliente.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            cmbMetodoPago.SelectedIndex = -1;
        }
        

        private void HabilitarControles(bool estado)
        {
            cmbCliente.Enabled = estado;
            cmbUsuario.Enabled = estado;
            cmbMetodoPago.Enabled = estado;
            dtpFecha.Enabled = estado;

            btnGuardar.Enabled = estado;
        }

        //=========================================
        // CARGAR CLIENTES
        //=========================================
        private void CargarClientes()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string sql = @"SELECT id_cliente, Nombre
                           FROM Cliente
                           WHERE Estado = 1
                           ORDER BY Nombre";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cmbCliente.DataSource = dt;
                    cmbCliente.DisplayMember = "Nombre";
                    cmbCliente.ValueMember = "id_cliente";
                    cmbCliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes.\n" + ex.Message);
            }
        }

        //=========================================
        // CARGAR USUARIOS
        //=========================================
        private void CargarUsuarios()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string sql = @"SELECT id_usuario, Nombre
                           FROM Usuario
                           WHERE Estado = 1
                           ORDER BY Nombre";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cmbUsuario.DataSource = dt;
                    cmbUsuario.DisplayMember = "Nombre";
                    cmbUsuario.ValueMember = "id_usuario";
                    cmbUsuario.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios.\n" + ex.Message);
            }
        }
        private void CargarVentas()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string sql = @"
            SELECT
                v.id_venta,
                v.Fecha_Venta,
                c.Nombre AS Cliente,
                u.Nombre AS Usuario,
                v.metodo_pago
            FROM Venta v
            INNER JOIN Cliente c
                ON v.id_cliente = c.id_cliente
            INNER JOIN Usuario u
                ON v.id_usuario = u.id_usuario";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvVentas.DataSource = dt;

                    dgvVentas.Columns["id_venta"].HeaderText = "ID";
                    dgvVentas.Columns["Fecha_Venta"].HeaderText = "Fecha";
                    dgvVentas.Columns["metodo_pago"].HeaderText = "Método de Pago";

                    lblTotal.Text = "Total ventas: " + dt.Rows.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            HabilitarControles(false);
        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null)
                return;
            txtIDVenta.Text = dgvVentas.CurrentRow.Cells["ID"].Value.ToString();
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }



        private void dgvVentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.CurrentRow == null)
                return;

            idVentaSeleccionada = Convert.ToInt32(dgvVentas.CurrentRow.Cells["ID"].Value);

            txtIDVenta.Text = idVentaSeleccionada.ToString();

            if (DateTime.TryParse(dgvVentas.CurrentRow.Cells["Fecha"].Value.ToString(), out DateTime fecha))
            {
                dtpFecha.Value = fecha;
            }

            cmbMetodoPago.Text =
                dgvVentas.CurrentRow.Cells["Método de Pago"].Value.ToString();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            modoNuevo = true;
            modoEditar = false;

            LimpiarFormulario();

            HabilitarControles(true);

            dtpFecha.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            if (cmbUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            if (cmbMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un método de pago.");
                return;
            }

            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string sql;

                    if (modoNuevo)
                    {
                        sql = @"INSERT INTO Venta
                        (Fecha_Venta, metodo_pago, id_usuario, id_cliente)
                        VALUES
                        (@Fecha,@Metodo,@Usuario,@Cliente)";
                    }
                    else
                    {
                        sql = @"UPDATE Venta
                        SET Fecha_Venta=@Fecha,
                            metodo_pago=@Metodo,
                            id_usuario=@Usuario,
                            id_cliente=@Cliente
                        WHERE id_venta=@Id";
                    }

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Fecha", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("@Metodo", cmbMetodoPago.Text);
                    cmd.Parameters.AddWithValue("@Usuario", cmbUsuario.SelectedValue);
                    cmd.Parameters.AddWithValue("@Cliente", cmbCliente.SelectedValue);

                    if (!modoNuevo)
                        cmd.Parameters.AddWithValue("@Id", idVentaSeleccionada);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Venta guardada correctamente.");

                    CargarVentas();
                    LimpiarFormulario();
                    HabilitarControles(false);

                    modoNuevo = false;
                    modoEditar = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (idVentaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una venta.");
                return;
            }

            modoNuevo = false;
            modoEditar = true;

            HabilitarControles(true);
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}