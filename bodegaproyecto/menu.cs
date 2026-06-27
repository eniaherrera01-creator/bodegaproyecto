using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace bodegaproyecto
{
    public partial class menu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string RolUsuario = "";
        public static string UsuarioActual = "";

        public menu()
        {
            InitializeComponent();

        }



        private void menu_Load(object sender, EventArgs e)
        {

            barStaticItemusuarios.Caption =
        "Usuario: " + UsuarioActual +
        " | Rol: " + RolUsuario;

            AplicarPermisos();


            ribbonStatusBar.BackColor = Color.FromArgb(35, 80, 150);

        }
        private void AplicarPermisos()
        {

            string rol = RolUsuario.ToLower();


            // Bloquear los botones primero
            barButtonusuarios.Enabled = false;
            barButtoncategorias.Enabled = false;
            barButtomproveedores.Enabled = false;



            switch (rol)
            {


                case "administrador":
                    barButtonusuarios.Enabled = true;
                    barButtoncategorias.Enabled = true;
                    barButtomproveedores.Enabled = true;

                    break;



                case "supervisor":
                    barButtoncategorias.Enabled = true;
                    barButtomproveedores.Enabled = true;

                    break;



                case "bodega":

                    barButtoncategorias.Enabled = true;
                    barButtomproveedores.Enabled = true;

                    break;



                case "vendedor":

                    // No tiene acceso todavía

                    break;



                case "cajero":

                    // No tiene acceso todavía

                    break;


            }

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Usuarios frm = new Usuarios();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frm);

            frm.Show();


        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frm);

            frm.Show();

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProveedoresForm frm = new ProveedoresForm();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frm);

            frm.Show();

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtoncerrarsesion_ItemClick(object sender, ItemClickEventArgs e)
        {


        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.Close();

        }

        private void ribbon_Click(object sender, EventArgs e)
        {
           
        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }
    }
}