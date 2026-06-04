using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bodegaproyecto
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            menuadmin.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuadmin.Visible = false;
            AbrirFormulario(new Usuarios());
        }

        private void AbrirFormulario(Form formulario)
        {
            panelcontenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelcontenedor.Controls.Add(formulario);
            panelcontenedor.Tag = formulario;
            formulario.Show();
        }



    }
}
