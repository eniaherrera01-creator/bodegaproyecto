using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

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

        private void ExportarPDF()
        {
            if (dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivo PDF|*.pdf";
                sfd.FileName = $"Reporte_{cbReporte.Text}_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Crear documento PDF
                    Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    // Título
                    Paragraph titulo = new Paragraph("Reporte - " + cbReporte.Text,
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.SpacingAfter = 10;
                    doc.Add(titulo);

                    // Subtítulo con fecha de generación
                    Paragraph fecha = new Paragraph("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                        FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.DARK_GRAY));
                    fecha.Alignment = Element.ALIGN_CENTER;
                    fecha.SpacingAfter = 20;
                    doc.Add(fecha);

                    // Crear tabla PDF con el mismo número de columnas
                    PdfPTable pdfTable = new PdfPTable(dgvReporte.Columns.Count);
                    pdfTable.WidthPercentage = 100;

                    // Agregar encabezados
                    foreach (DataGridViewColumn column in dgvReporte.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.WHITE)));
                        cell.BackgroundColor = new BaseColor(0, 102, 204); // Azul suave
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Padding = 5;
                        pdfTable.AddCell(cell);
                    }

                    // Agregar filas
                    foreach (DataGridViewRow row in dgvReporte.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell dataCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", FontFactory.GetFont(FontFactory.HELVETICA, 9)));
                                dataCell.Padding = 4;
                                pdfTable.AddCell(dataCell);
                            }
                        }
                    }

                    doc.Add(pdfTable);
                    doc.Close();

                    MessageBox.Show("PDF exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Bitacora.Registrar("Reportas", "Exportar PDF", $"Exportar el reporte '{cbReporte.Text}' a PDF ({sfd.FileName})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar PDF: " + ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ExportarPDF();

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