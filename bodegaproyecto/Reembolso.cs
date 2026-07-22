using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class Reembolso : Form
    {

        private int idProductoSeleccionado = 0;
        private decimal precioProducto = 0;
        private int cantidadDisponible = 0;

        private int idVentaSeleccionada = 0;
        private int idUsuarioSeleccionado = 0;


        public Reembolso()
        {
            InitializeComponent();


            dgvDetalleVenta.CellClick += dgvDetalleVenta_CellClick;

            btnAgregarReembolso.Click += btnAgregarReembolso_Click;

            btnGuardarReembolso.Click += btnGuardarReembolso_Click;

            BTVolver.Click += BTVolver_Click;


            ConfigurarDgvReembolso();

        }



        private void ConfigurarDgvReembolso()
        {

            dgvDetallesRembolso.Columns.Clear();


            dgvDetallesRembolso.Columns.Add("ID", "ID");
            dgvDetallesRembolso.Columns.Add("Producto", "Producto");
            dgvDetallesRembolso.Columns.Add("Precio", "Precio");
            dgvDetallesRembolso.Columns.Add("Cantidad", "Cantidad");
            dgvDetallesRembolso.Columns.Add("Total", "Total");
            dgvDetallesRembolso.Columns.Add("Descripcion", "Descripción");


            dgvDetallesRembolso.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            dgvDetallesRembolso.ReadOnly = true;

            dgvDetallesRembolso.AllowUserToAddRows = false;


            dgvDetallesRembolso.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

        }



        public void RecibirVenta(int idVenta)
        {
            idVentaSeleccionada = idVenta;
            txtVenta.Text = idVenta.ToString();
        }


        public void RecibirUsuario(int idUsuario)
        {
            idUsuarioSeleccionado = idUsuario;
        }




        public TextBox TxtVenta
        {
            get { return txtVenta; }
        }



        public TextBox TxtCliente
        {
            get { return txtCliente; }
        }



        public TextBox TxtFecha
        {
            get { return txtFecha; }
        }



        public TextBox TxtUsuario
        {
            get { return txtUsuario; }
        }




        public DataGridView GridDetalleVenta
        {
            get
            {
                return dgvDetalleVenta;
            }
        }




        private void dgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;


            DataGridViewRow fila = dgvDetalleVenta.Rows[e.RowIndex];



            idProductoSeleccionado =
                Convert.ToInt32(fila.Cells["ID"].Value);



            txtProducto.Text =
                fila.Cells["Producto"].Value.ToString();



            precioProducto =
                Convert.ToDecimal(fila.Cells["Precio"].Value);



            cantidadDisponible =
                Convert.ToInt32(fila.Cells["Cantidad"].Value);



            nudCantidad.Minimum = 1;

            nudCantidad.Maximum = cantidadDisponible;

            nudCantidad.Value = 1;

        }




        private void btnAgregarReembolso_Click(object sender, EventArgs e)
        {

            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }



            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show(
                    "Ingrese una descripción del motivo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }




            int cantidad =
                Convert.ToInt32(nudCantidad.Value);



            decimal total =
                precioProducto * cantidad;




            foreach (DataGridViewRow fila in dgvDetallesRembolso.Rows)
            {

                if (Convert.ToInt32(fila.Cells["ID"].Value) == idProductoSeleccionado)
                {

                    MessageBox.Show(
                        "Este producto ya está agregado.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    return;

                }

            }




            dgvDetallesRembolso.Rows.Add(
                idProductoSeleccionado,
                txtProducto.Text,
                precioProducto,
                cantidad,
                total,
                txtDescripcion.Text
            );



            CalcularTotalReembolso();



            txtDescripcion.Clear();

        }




        private void CalcularTotalReembolso()
        {

            decimal total = 0;



            foreach (DataGridViewRow fila in dgvDetallesRembolso.Rows)
            {

                total +=
                    Convert.ToDecimal(fila.Cells["Total"].Value);

            }



            lblTotal.Text =
                "L. " + total.ToString("N2");

        }




        private bool ValidarReembolso()
        {
            if (dgvDetallesRembolso.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Agregue productos al reembolso.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }


            if (idVentaSeleccionada == 0)
            {
                MessageBox.Show(
                    "No se encontró la venta.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }


            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show(
                    "No se encontró el usuario.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }


            return true;
        }


        private void GuardarReembolsoBD()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State == System.Data.ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    SqlTransaction trans = cn.BeginTransaction();

                    try
                    {
                        foreach (DataGridViewRow fila in dgvDetallesRembolso.Rows)
                        {
                            int idProducto =
                                Convert.ToInt32(fila.Cells["ID"].Value);

                            int cantidad =
                                Convert.ToInt32(fila.Cells["Cantidad"].Value);

                            string descripcion =
                                fila.Cells["Descripcion"].Value.ToString();


                            // GUARDAR REEMBOLSO
                            string insertar = @"
                    INSERT INTO Reembolso
                    (
                        descripcion,
                        id_venta,
                        id_usuario,
                        id_producto,
                        cantidad
                    )
                    VALUES
                    (
                        @descripcion,
                        @venta,
                        @usuario,
                        @producto,
                        @cantidad
                    )";


                            using (SqlCommand cmd = new SqlCommand(insertar, cn, trans))
                            {
                                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                                cmd.Parameters.AddWithValue("@venta", idVentaSeleccionada);
                                cmd.Parameters.AddWithValue("@usuario", idUsuarioSeleccionado);
                                cmd.Parameters.AddWithValue("@producto", idProducto);
                                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                                cmd.ExecuteNonQuery();
                            }



                            // DEVOLVER PRODUCTO AL STOCK
                            string actualizarStock = @"
                    UPDATE Producto
                    SET Stock = Stock + @cantidad
                    WHERE id_producto = @producto";


                            using (SqlCommand cmdStock = new SqlCommand(actualizarStock, cn, trans))
                            {
                                cmdStock.Parameters.AddWithValue("@cantidad", cantidad);
                                cmdStock.Parameters.AddWithValue("@producto", idProducto);

                                cmdStock.ExecuteNonQuery();
                            }



                            // RESTAR PRODUCTO DE LA VENTA
                            string actualizarDetalle = @"
                    UPDATE Detalle_Venta
                    SET Cantidad = Cantidad - @cantidad
                    WHERE id_venta = @venta
                    AND id_producto = @producto";


                            using (SqlCommand cmdDetalle = new SqlCommand(actualizarDetalle, cn, trans))
                            {
                                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                                cmdDetalle.Parameters.AddWithValue("@venta", idVentaSeleccionada);
                                cmdDetalle.Parameters.AddWithValue("@producto", idProducto);

                                cmdDetalle.ExecuteNonQuery();
                            }



                            // ELIMINAR DETALLE SI LLEGA A CERO
                            string eliminarDetalle = @"
                    DELETE FROM Detalle_Venta
                    WHERE id_venta = @venta
                    AND id_producto = @producto
                    AND Cantidad <= 0";


                            using (SqlCommand cmdEliminar = new SqlCommand(eliminarDetalle, cn, trans))
                            {
                                cmdEliminar.Parameters.AddWithValue("@venta", idVentaSeleccionada);
                                cmdEliminar.Parameters.AddWithValue("@producto", idProducto);

                                cmdEliminar.ExecuteNonQuery();
                            }

                        }


                        trans.Commit();
                        ActualizarDetalleVenta();


                        MessageBox.Show(
                            "Reembolso guardado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


                            dgvDetallesRembolso.Rows.Clear();

                            lblTotal.Text = "L. 0.00";

                            txtProducto.Clear();

                            txtDescripcion.Clear();

                        }
                    catch (Exception ex)
                    {
                        if (trans.Connection != null)
                        {
                            trans.Rollback();
                        }

                        MessageBox.Show(ex.ToString());
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error de conexión: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ActualizarDetalleVenta()
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                string sql = @"
        SELECT
            p.id_producto,
            p.Nombre_Producto,
            dv.precio_unitario,
            p.impuesto,
            dv.Cantidad,
            dv.Cantidad * dv.precio_unitario AS Subtotal
        FROM Detalle_Venta dv
        INNER JOIN Producto p
            ON p.id_producto = dv.id_producto
        WHERE dv.id_venta = @venta";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@venta", idVentaSeleccionada);

                SqlDataReader dr = cmd.ExecuteReader();

                dgvDetalleVenta.Rows.Clear();

                while (dr.Read())
                {
                    dgvDetalleVenta.Rows.Add(
                        dr["id_producto"],
                        dr["Nombre_Producto"],
                        dr["precio_unitario"],
                        dr["impuesto"],
                        dr["Cantidad"],
                        dr["Subtotal"]);
                }

                dr.Close();
            }
        }

        private void btnGuardarReembolso_Click(object sender, EventArgs e)
        {

            if (!ValidarReembolso())
                return;


            GuardarReembolsoBD();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea cancelar el reembolso?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                dgvDetallesRembolso.Rows.Clear();

                lblTotal.Text = "L. 0.00";

                txtProducto.Clear();

                txtDescripcion.Clear();

                idProductoSeleccionado = 0;
                precioProducto = 0;
                cantidadDisponible = 0;

                nudCantidad.Value = 1;

                MessageBox.Show(
                    "Reembolso cancelado.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }


        private void BTVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}