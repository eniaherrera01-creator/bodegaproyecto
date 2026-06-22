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

        public static string RolUsuario = "";
        public static string UsuarioActual = "";

        public menu()
        {
            InitializeComponent();
        }



        private void menu_Load(object sender, EventArgs e)
        {
            btncerrar.Text = "✕";
            btnmaximizar.Text = "☐";
            btnminimizar.Text = "─";

            btncerrar.ForeColor = Color.White;
            btnmaximizar.ForeColor = Color.White;
            btnminimizar.ForeColor = Color.White;

            btncerrar.FlatStyle = FlatStyle.Flat;
            btnmaximizar.FlatStyle = FlatStyle.Flat;
            btnminimizar.FlatStyle = FlatStyle.Flat;

            btncerrar.FlatAppearance.BorderSize = 0;
            btnmaximizar.FlatAppearance.BorderSize = 0;
            btnminimizar.FlatAppearance.BorderSize = 0;


            ///Unicamente sera visible para el adminsitrador, el boton de administracion, para que los usuarios normales no puedan acceder a esa seccion.
            if (RolUsuario != "Administrador")
            {
                btnusuario.Visible = false;
            }

            Sesion.Text = UsuarioActual + " (" + RolUsuario + ")";
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

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sesionNombreDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "¿Seguro que deseas cerrar sesión?",
        "Cerrar Sesión",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            menuinventario.Visible = true;
        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            menuinventario.Visible = false;
            AbrirFormulario(new FrmCategoria());
        }

        private void menuinventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuadmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
