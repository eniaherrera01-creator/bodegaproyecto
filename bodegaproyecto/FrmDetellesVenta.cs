    using Microsoft.Data.SqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;

    namespace bodegaproyecto
    {
    public partial class FrmDetellesVenta : Form
    {
        private SqlConnection conexion = ConexionBD.ObtenerConexion();

        private int idVentaSeleccionada = 0;


        public FrmDetellesVenta()
        {
            InitializeComponent();

            AsignarEventos();
        }


        private void AsignarEventos()
        {
            Load += FrmDetellesVenta_Load;

            btnBuscar.Click += btnBuscar_Click;

            btnBuscarFecha.Click += btnBuscarFecha_Click;

            dgvVentas.CellClick += dgvVentas_CellClick;
        }



        private void FrmDetellesVenta_Load(object sender, EventArgs e)
        {
            MostrarVentas();
            dgvDetalleVenta.DataSource = null;
        }



        private void MostrarVentas()
        {
            try
            {


                string consulta = @"
                    SELECT
                        V.id_venta AS 'ID Venta',
                        V.Fecha_Venta AS Fecha,
                        C.Nombre AS Cliente,
                        U.Nombre AS Usuario,
                        V.metodo_pago AS 'Método Pago',
                        SUM(DV.Cantidad * DV.precio_unitario) AS Total

                    FROM Venta V

                    INNER JOIN Cliente C
                    ON V.id_cliente = C.id_cliente

                    INNER JOIN Usuario U
                    ON V.id_usuario = U.id_usuario

                    INNER JOIN Detalle_Venta DV
                    ON V.id_venta = DV.id_venta

                    GROUP BY
                        V.id_venta,
                        V.Fecha_Venta,
                        C.Nombre,
                        U.Nombre,
                        V.metodo_pago

                    ORDER BY V.id_venta DESC";


                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);


                dgvVentas.DataSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
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
                MostrarVentas();
                return;
            }


            BuscarVenta();
        }



        private void BuscarVenta()
        {
            try
            {


                string consulta = @"
                    SELECT
                        V.id_venta AS 'ID Venta',
                        V.Fecha_Venta AS Fecha,
                        C.Nombre AS Cliente,
                        U.Nombre AS Usuario,
                        V.metodo_pago AS 'Método Pago',
                        SUM(DV.Cantidad * DV.precio_unitario) AS Total

                    FROM Venta V

                    INNER JOIN Cliente C
                    ON V.id_cliente = C.id_cliente

                    INNER JOIN Usuario U
                    ON V.id_usuario = U.id_usuario

                    INNER JOIN Detalle_Venta DV
                    ON V.id_venta = DV.id_venta

                    WHERE V.id_venta = @id

                    GROUP BY
                        V.id_venta,
                        V.Fecha_Venta,
                        C.Nombre,
                        U.Nombre,
                        V.metodo_pago";


                SqlCommand cmd = new SqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@id", txtBuscarID.Text);


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);


                dgvVentas.DataSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar venta: " + ex.Message);
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
            try
            {


                string consulta = @"
                    SELECT
                        V.id_venta AS 'ID Venta',
                        V.Fecha_Venta AS Fecha,
                        C.Nombre AS Cliente,
                        U.Nombre AS Usuario,
                        V.metodo_pago AS 'Método Pago',
                        SUM(DV.Cantidad * DV.precio_unitario) AS Total

                    FROM Venta V

                    INNER JOIN Cliente C
                    ON V.id_cliente = C.id_cliente

                    INNER JOIN Usuario U
                    ON V.id_usuario = U.id_usuario

                    INNER JOIN Detalle_Venta DV
                    ON V.id_venta = DV.id_venta

                    WHERE V.Fecha_Venta BETWEEN @inicio AND @fin

                    GROUP BY
                        V.id_venta,
                        V.Fecha_Venta,
                        C.Nombre,
                        U.Nombre,
                        V.metodo_pago";


                SqlCommand cmd = new SqlCommand(consulta, conexion);


                cmd.Parameters.AddWithValue("@inicio",
                    dtpDesde.Value.Date);


                cmd.Parameters.AddWithValue("@fin",
                    dtpHasta.Value.Date.AddDays(1));


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);


                dgvVentas.DataSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar fecha: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }


        private void CargarDetalleVenta(int idVenta)
        {
            try
            {
                conexion = ConexionBD.ObtenerConexion();

                string consulta = @"
        SELECT
            P.Nombre_Producto AS Producto,
            DV.Cantidad,
            DV.precio_unitario AS Precio,
            (DV.Cantidad * DV.precio_unitario) AS Subtotal
        FROM Detalle_Venta DV
        INNER JOIN Producto P
            ON DV.id_producto = P.id_producto
        WHERE DV.id_venta = @idVenta";

                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvDetalleVenta.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idVentaSeleccionada = Convert.ToInt32(
                    dgvVentas.Rows[e.RowIndex].Cells["ID Venta"].Value);

                CargarDetalleVenta(idVentaSeleccionada);
            }
        }


    }
}