using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class FrmDetallesCompra : Form
    {
        private SqlConnection conexion = ConexionBD.ObtenerConexion();

        private int idCompraSeleccionada = 0;

        public FrmDetallesCompra()
        {
            InitializeComponent();
            AsignarEventos();
        }

        private void AsignarEventos()
        {
            Load += FrmDetallesCompra_Load;

            btnBuscar.Click += btnBuscar_Click;

            btnBuscarFecha.Click += btnBuscarFecha_Click;

            dgvCompras.CellClick += dgvCompras_CellClick;
        }

        private void FrmDetallesCompra_Load(object sender, EventArgs e)
        {
            dtpDesde.MaxDate = DateTime.Today;
            dtpHasta.MaxDate = DateTime.Today;

            MostrarCompras();

            dgvDetalleCompra.DataSource = null;
        }

        private void MostrarCompras()
        {
            try
            {
                conexion = ConexionBD.ObtenerConexion();

                string consulta = @"
                SELECT
                    C.id_compra AS 'ID Compra',
                    C.fecha_compra AS Fecha,
                    P.Nombre AS Proveedor,
                    U.Nombre AS Usuario,
                    SUM(DC.Cantidad * DC.precio_unitario) AS Total

                FROM Compra C

                INNER JOIN Proveedor P
                    ON C.id_proveedor = P.id_proveedor

                INNER JOIN Usuario U
                    ON C.id_usuario = U.id_usuario

                INNER JOIN Detalle_Compra DC
                    ON C.id_compra = DC.id_compra

                GROUP BY
                    C.id_compra,
                    C.fecha_compra,
                    P.Nombre,
                    U.Nombre

                ORDER BY C.id_compra DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvCompras.DataSource = tabla;

                Bitacora.Registrar(
                    "Compras",
                    "Consultar",
                    "Consultó el listado general de compras");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compras: " + ex.Message);

                Bitacora.Registrar(
                    "Compras",
                    "Error",
                    "Error al cargar compras: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarID.Text.Trim() == "")
            {
                MostrarCompras();
                return;
            }

            BuscarCompra();
        }

        private void BuscarCompra()
        {
            try
            {
                conexion = ConexionBD.ObtenerConexion();

                string consulta = @"
                SELECT
                    C.id_compra AS 'ID Compra',
                    C.fecha_compra AS Fecha,
                    P.Nombre AS Proveedor,
                    U.Nombre AS Usuario,
                    SUM(DC.Cantidad * DC.precio_unitario) AS Total

                FROM Compra C

                INNER JOIN Proveedor P
                    ON C.id_proveedor = P.id_proveedor

                INNER JOIN Usuario U
                    ON C.id_usuario = U.id_usuario

                INNER JOIN Detalle_Compra DC
                    ON C.id_compra = DC.id_compra

                WHERE C.id_compra = @id

                GROUP BY
                    C.id_compra,
                    C.fecha_compra,
                    P.Nombre,
                    U.Nombre";

                SqlCommand cmd = new SqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@id", txtBuscarID.Text.Trim());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvCompras.DataSource = tabla;

                Bitacora.Registrar(
                    "Compras",
                    "Buscar",
                    "Buscó la compra con ID " + txtBuscarID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar compra: " + ex.Message);

                Bitacora.Registrar(
                    "Compras",
                    "Error",
                    "Error al buscar compra: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            BuscarPorFecha();
        }

        private void BuscarPorFecha()
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show(
                    "La fecha inicial no puede ser mayor que la fecha final.",
                    "Rango de fechas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                conexion = ConexionBD.ObtenerConexion();

                string consulta = @"
                SELECT
                    C.id_compra AS 'ID Compra',
                    C.fecha_compra AS Fecha,
                    P.Nombre AS Proveedor,
                    U.Nombre AS Usuario,
                    SUM(DC.Cantidad * DC.precio_unitario) AS Total

                FROM Compra C

                INNER JOIN Proveedor P
                    ON C.id_proveedor = P.id_proveedor

                INNER JOIN Usuario U
                    ON C.id_usuario = U.id_usuario

                INNER JOIN Detalle_Compra DC
                    ON C.id_compra = DC.id_compra

                WHERE C.fecha_compra BETWEEN @inicio AND @fin

                GROUP BY
                    C.id_compra,
                    C.fecha_compra,
                    P.Nombre,
                    U.Nombre

                ORDER BY C.id_compra DESC";

                SqlCommand cmd = new SqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@inicio", dtpDesde.Value.Date);

                cmd.Parameters.AddWithValue("@fin", dtpHasta.Value.Date.AddDays(1));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvCompras.DataSource = tabla;

                Bitacora.Registrar(
                    "Compras",
                    "Buscar por fecha",
                    $"Buscó compras entre {dtpDesde.Value:dd/MM/yyyy} y {dtpHasta.Value:dd/MM/yyyy}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar por fecha: " + ex.Message);

                Bitacora.Registrar(
                    "Compras",
                    "Error",
                    "Error al buscar por fecha: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void CargarDetalleCompra(int idCompra)
        {
            try
            {
                conexion = ConexionBD.ObtenerConexion();

                string consulta = @"
                    SELECT
                        P.Nombre_Producto AS Producto,
                        DC.Cantidad,
                        DC.precio_unitario AS Precio,
                        (DC.Cantidad * DC.precio_unitario) AS Subtotal

                    FROM Detalle_Compra DC

                    INNER JOIN Producto P
                        ON DC.id_producto = P.id_producto

                    WHERE DC.id_compra = @idCompra";

                SqlCommand cmd = new SqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@idCompra", idCompra);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvDetalleCompra.DataSource = tabla;

                Bitacora.Registrar(
                    "Compras",
                    "Ver detalle",
                    "Consultó el detalle de la compra ID " + idCompra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle: " + ex.Message);

                Bitacora.Registrar(
                    "Compras",
                    "Error",
                    "Error al cargar detalle de compra " + idCompra + ": " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idCompraSeleccionada = Convert.ToInt32(
                    dgvCompras.Rows[e.RowIndex].Cells["ID Compra"].Value);

                CargarDetalleCompra(idCompraSeleccionada);
            }
        }
    }
}