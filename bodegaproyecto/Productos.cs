using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace bodegaproyecto
{





    public partial class Productos : Form
    {
        DataTable tabla = new DataTable();


        public Productos()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            if (txtnombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del producto");
                txtnombre.Focus();
                return false;
            }

            if (txtdescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la descripción");
                txtdescripcion.Focus();
                return false;
            }

            if (txtpreciocompra.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el precio de compra");
                txtpreciocompra.Focus();
                return false;
            }

            if (txtprecioventa.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el precio de venta");
                txtprecioventa.Focus();
                return false;
            }

            if (txtstock.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el stock");
                txtstock.Focus();
                return false;
            }

            if (txtimpuesto.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el impuesto");
                txtimpuesto.Focus();
                return false;
            }

            if (cbcategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría");
                return false;
            }

            return true;
        }

        private bool EsNumero(string valor)
        {
            return decimal.TryParse(valor, out _);
        }

        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_categoria, Nombre_Categoria FROM Categoria", cn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cbcategoria.DataSource = dt;

                    cbcategoria.DisplayMember = "Nombre_Categoria";

                    cbcategoria.ValueMember = "id_categoria";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void lblTituloForm_Click(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {

            MostrarProductos();
            CargarCategorias();

        }

        private void MostrarProductos()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"SELECT
                                p.id_producto,
                                p.Nombre_Producto,
                                p.Descripcion,
                                p.Precio_Compra,
                                p.Precio_Venta,
                                p.Stock,
                                p.fecha_vencimiento,
                                p.impuesto,
                                p.id_categoria,
                                c.Nombre_Categoria,
                                p.Estado
                            FROM Producto p
                            INNER JOIN Categoria c
                            ON p.id_categoria = c.id_categoria";

                    SqlDataAdapter da = new SqlDataAdapter(consulta, cn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvproductos.DataSource = dt;

                    
                    dgvproductos.Columns["id_producto"].HeaderText = "ID";
                    dgvproductos.Columns["Nombre_Producto"].HeaderText = "Nombre del Producto";
                    dgvproductos.Columns["Descripcion"].HeaderText = "Descripción";
                    dgvproductos.Columns["Precio_Compra"].HeaderText = "Precio Compra";
                    dgvproductos.Columns["Precio_Venta"].HeaderText = "Precio Venta";
                    dgvproductos.Columns["Stock"].HeaderText = "Stock";
                    dgvproductos.Columns["fecha_vencimiento"].HeaderText = "Fecha de Vencimiento";
                    dgvproductos.Columns["impuesto"].HeaderText = "Impuesto";
                    dgvproductos.Columns["Nombre_Categoria"].HeaderText = "Categoría";
                    dgvproductos.Columns["Estado"].HeaderText = "Estado";
                    dgvproductos.Columns["id_categoria"].HeaderText = "ID Categoria";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"INSERT INTO Producto
                                (Nombre_Producto, Descripcion, Precio_Compra, Precio_Venta,
                                 Stock, fecha_vencimiento, impuesto, id_categoria)
                                VALUES
                                (@nombre, @descripcion, @compra, @venta,
                                 @stock, @fecha, @impuesto, @categoria)";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
                    cmd.Parameters.AddWithValue("@compra", decimal.Parse(txtpreciocompra.Text));
                    cmd.Parameters.AddWithValue("@venta", decimal.Parse(txtprecioventa.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(txtstock.Text));
                    cmd.Parameters.AddWithValue("@fecha", dtpfv.Value);
                    cmd.Parameters.AddWithValue("@impuesto", decimal.Parse(txtimpuesto.Text));
                    cmd.Parameters.AddWithValue("@categoria", cbcategoria.SelectedValue);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Producto guardado correctamente");

                    MostrarProductos();
                    btnnuevo.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (!EsNumero(txtpreciocompra.Text) || !EsNumero(txtprecioventa.Text) || !EsNumero(txtimpuesto.Text))
            {
                MessageBox.Show("Ingrese valores numéricos válidos");
                return;
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgvproductos.CurrentRow != null)
            {
                txtId.Text = dgvproductos.CurrentRow.Cells["id_producto"].Value.ToString();
                txtnombre.Text = dgvproductos.CurrentRow.Cells["Nombre_Producto"].Value.ToString();
                txtdescripcion.Text = dgvproductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtpreciocompra.Text = dgvproductos.CurrentRow.Cells["Precio_Compra"].Value.ToString();
                txtprecioventa.Text = dgvproductos.CurrentRow.Cells["Precio_Venta"].Value.ToString();
                txtstock.Text = dgvproductos.CurrentRow.Cells["Stock"].Value.ToString();

                if (dgvproductos.CurrentRow.Cells["fecha_vencimiento"].Value == DBNull.Value)
                {
                    dtpfv.Value = DateTime.Now;
                }
                else
                {
                    dtpfv.Value = Convert.ToDateTime(
                        dgvproductos.CurrentRow.Cells["fecha_vencimiento"].Value);
                }

                txtimpuesto.Text = dgvproductos.CurrentRow.Cells["impuesto"].Value.ToString();

                cbcategoria.SelectedValue = dgvproductos.CurrentRow.Cells["id_categoria"].Value;
            }
        }

        private void btnestado_Click(object sender, EventArgs e)
        {

            if (txtId.Text == "")
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"UPDATE Producto
                                SET Estado = CASE
                                WHEN Estado=1 THEN 0
                                ELSE 1
                                END
                                WHERE id_producto=@id";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue("@id", txtId.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Estado actualizado.");

                    MostrarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"SELECT
                                    p.id_producto,
                                    p.Nombre_Producto,
                                    p.Descripcion,
                                    p.Precio_Compra,
                                    p.Precio_Venta,
                                    p.Stock,
                                    p.fecha_vencimiento,
                                    p.impuesto,
                                    p.id_categoria,
                                    c.Nombre_Categoria,
                                    p.Estado
                                FROM Producto p
                                INNER JOIN Categoria c
                                ON p.id_categoria = c.id_categoria
                                WHERE p.Nombre_Producto LIKE @buscar";

                    SqlDataAdapter da = new SqlDataAdapter(consulta, cn);

                    da.SelectCommand.Parameters.AddWithValue("@buscar",
                        "%" + txtbuscar.Text + "%");

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvproductos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"UPDATE Producto
            SET Nombre_Producto=@nombre,
                Descripcion=@descripcion,
                Precio_Compra=@compra,
                Precio_Venta=@venta,
                Stock=@stock,
                fecha_vencimiento=@fecha,
                impuesto=@impuesto,
                id_categoria=@categoria
            WHERE id_producto=@id";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
                    cmd.Parameters.AddWithValue("@compra", decimal.Parse(txtpreciocompra.Text));
                    cmd.Parameters.AddWithValue("@venta", decimal.Parse(txtprecioventa.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(txtstock.Text));
                    cmd.Parameters.AddWithValue("@fecha", dtpfv.Value);
                    cmd.Parameters.AddWithValue("@impuesto", decimal.Parse(txtimpuesto.Text));
                    cmd.Parameters.AddWithValue("@categoria", cbcategoria.SelectedValue);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Producto actualizado correctamente.");

                    MostrarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            txtId.Clear();
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtpreciocompra.Clear();
            txtprecioventa.Clear();
            txtstock.Clear();
            txtimpuesto.Clear();

            cbcategoria.SelectedIndex = 0;

            dtpfv.Value = DateTime.Now;

            txtnombre.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Seleccione un producto válido.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection cn = ConexionBD.ObtenerConexion())
                    {
                        string consulta = "DELETE FROM Producto WHERE id_producto = @id";

                        SqlCommand cmd = new SqlCommand(consulta, cn);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Producto eliminado correctamente.");

                        MostrarProductos();
                        btnnuevo.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}


