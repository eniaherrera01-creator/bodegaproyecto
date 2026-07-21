using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class Rembolso : Form
    {
        public Rembolso()
        {
            InitializeComponent();
            this.Load += Rembolso_Load;
        }

        private void Rembolso_Load(object sender, EventArgs e)
        {
            CargarReembolsos();
        }

        private void BTVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarReembolsos()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"
                     SELECT
                        r.id_reembolso,
                        r.fecha_reembolso,
                        u.Nombre AS Usuario,
                        p.Nombre_Producto AS Producto,
                        r.cantidad,
                        r.descripcion
                    FROM Reembolso r
                    INNER JOIN Usuario u
                        ON r.id_usuario = u.id_usuario
                    INNER JOIN Producto p
                        ON r.id_producto = p.id_producto
                    ORDER BY r.fecha_reembolso DESC";

                    SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDetallesRembolso.DataSource = dt;

                    dgvDetallesRembolso.Columns["id_reembolso"].HeaderText = "ID";
                    dgvDetallesRembolso.Columns["fecha_reembolso"].HeaderText = "Fecha";
                    dgvDetallesRembolso.Columns["usuario"].HeaderText = "Usuario";
                    dgvDetallesRembolso.Columns["Producto"].HeaderText = "Producto";
                    dgvDetallesRembolso.Columns["cantidad"].HeaderText = "cantidad";
                    dgvDetallesRembolso.Columns["descripcion"].HeaderText = "Descripcion";

                    dgvDetallesRembolso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvDetallesRembolso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvDetallesRembolso.ReadOnly = true;
                    dgvDetallesRembolso.AllowUserToAddRows = false;
                    dgvDetallesRembolso.AllowUserToDeleteRows = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Reembolso" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
 
    }


}
