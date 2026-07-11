using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace bodegaproyecto
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            lblProductos.Text = ObtenerCantidad("SELECT COUNT(*) FROM Producto").ToString();
            lblCategorias.Text = ObtenerCantidad("SELECT COUNT(*) FROM Categoria").ToString();
            lblProveedores.Text = ObtenerCantidad("SELECT COUNT(*) FROM Proveedor").ToString();

            lblActivos.Text = ObtenerCantidad("SELECT COUNT(*) FROM Producto WHERE Estado = 1").ToString();
            lblInactivos.Text = ObtenerCantidad("SELECT COUNT(*) FROM Producto WHERE Estado = 0").ToString();

            lblBajoStock.Text = ObtenerCantidad("SELECT COUNT(*) FROM Producto WHERE Stock <= 5").ToString();
        }

        private int ObtenerCantidad(string consulta)
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }

                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}