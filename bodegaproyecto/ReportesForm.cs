using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace bodegaproyecto
{
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            CargarCategorias();

            cbReporte.SelectedIndex = 0;
            cbCategoria.Enabled = false;

            GenerarReporte();
        }

        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = "SELECT id_categoria, Nombre_Categoria FROM Categoria ORDER BY Nombre_Categoria";

                    SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbCategoria.DataSource = dt;
                    cbCategoria.DisplayMember = "Nombre_Categoria";
                    cbCategoria.ValueMember = "id_categoria";
                    cbCategoria.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbReporte.SelectedIndex = 0;
            cbCategoria.SelectedIndex = -1;
            cbCategoria.Enabled = false;

            GenerarReporte();
        }

        private void GenerarReporte()
        {
            if (cbReporte.SelectedItem == null)
                return;

            string tipoReporte = cbReporte.SelectedItem.ToString();

            if (tipoReporte == "Productos por categoría")
            {
                cbCategoria.Enabled = true;

                if (cbCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una categoría para generar el reporte.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                cbCategoria.Enabled = false;
            }

            string consulta = ObtenerConsulta(tipoReporte);

            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        if (tipoReporte == "Productos por categoría")
                        {
                            cmd.Parameters.AddWithValue("@categoria", cbCategoria.SelectedValue);
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvReporte.DataSource = dt;
                        dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reporte: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerConsulta(string tipoReporte)
        {
            string consultaBase = @"SELECT
                                        p.id_producto AS [ID],
                                        p.Nombre_Producto AS [Producto],
                                        c.Nombre_Categoria AS [Categoría],
                                        p.Precio_Compra AS [Precio Compra],
                                        p.Precio_Venta AS [Precio Venta],
                                        p.Stock AS [Stock],
                                        p.fecha_vencimiento AS [Fecha Vencimiento],
                                        p.impuesto AS [Impuesto],
                                        CASE 
                                            WHEN p.Estado = 1 THEN 'Activo'
                                            ELSE 'Inactivo'
                                        END AS [Estado]
                                    FROM Producto p
                                    INNER JOIN Categoria c
                                    ON p.id_categoria = c.id_categoria ";

            if (tipoReporte == "Productos activos")
            {
                consultaBase += " WHERE p.Estado = 1 ";
            }
            else if (tipoReporte == "Productos inactivos")
            {
                consultaBase += " WHERE p.Estado = 0 ";
            }
            else if (tipoReporte == "Productos con bajo stock")
            {
                consultaBase += " WHERE p.Stock <= 5 ";
            }
            else if (tipoReporte == "Productos por categoría")
            {
                consultaBase += " WHERE p.id_categoria = @categoria ";
            }

            consultaBase += " ORDER BY p.Nombre_Producto ASC";

            return consultaBase;
        }
    }
}