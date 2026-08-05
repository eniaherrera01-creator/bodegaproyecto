using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bodegaproyecto
{
    public partial class pbitacora : Form
    {
        public pbitacora()
        {
            InitializeComponent();

            this.Load += pbitacora_Load;
        }

        private void pbitacora_Load(object sender, EventArgs e)
        {
            MostrarBitacora();
        }

        private void MostrarBitacora()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    string consulta = @"SELECT
                        id_bitacora AS ID,
                        fecha AS Fecha,
                        usuario AS Usuario,
                        modulo AS [Módulo],
                        accion AS [Acción],
                        descripcion AS Descripción
                    FROM Bitacora
                    ORDER BY fecha DESC";

                    SqlDataAdapter da = new SqlDataAdapter(consulta, cn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    ConfigurarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la bitácora: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            if (dataGridView1.Columns.Count == 0)
                return;

            dataGridView1.Columns["ID"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}