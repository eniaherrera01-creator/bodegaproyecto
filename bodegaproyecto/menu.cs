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
            AbrirFormulario(new DashboardForm());

        }

        private void AbrirFormulario(Form formulario)
        {
            panelContenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);
            formulario.Show();
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
            barButtonclientes.Enabled = false;
            barButtonreportes.Enabled = false;
            BTbitacora.Enabled = false;
            barButtoncategorias.Enabled = false;
            barButtomproveedores.Enabled = false;
            barButtonproductos.Enabled = false;
            barButtoncompras.Enabled = false;
            barButtondetallecompra.Enabled = false;
            barButtonventas.Enabled = false;
            barButtondetalleventa.Enabled = false;



            switch (rol)
            {


                case "administrador":
                    barButtonusuarios.Enabled = true;
                    barButtonclientes.Enabled = true;
                    barButtonreportes.Enabled = true;
                    BTbitacora.Enabled = true;
                    barButtoncategorias.Enabled = true;
                    barButtomproveedores.Enabled = true;
                    barButtonproductos.Enabled = true;
                    barButtoncompras.Enabled = true;
                    barButtondetallecompra.Enabled = true;
                    barButtonventas.Enabled = true;
                    barButtondetalleventa.Enabled = true;


                    break;



                case "supervisor":
                    barButtoncategorias.Enabled = true;
                    barButtomproveedores.Enabled = true;
                    barButtonproductos.Enabled = true;
                    barButtonventas.Enabled = true;
                    barButtondetalleventa.Enabled = true;
                    barButtoncompras.Enabled = true;
                    barButtondetallecompra.Enabled = true;

                    break;



                case "bodega":

                    barButtoncategorias.Enabled = true;
                    barButtomproveedores.Enabled = true;
                    barButtonproductos.Enabled = true;
                    barButtoncompras.Enabled = true;
                    barButtondetallecompra.Enabled = true;


                    break;



                case "vendedor":

                    barButtonventas.Enabled = true;
                    barButtondetalleventa.Enabled = true;


                    break;



                case "cajero":

                    barButtonventas.Enabled = true;
                    barButtondetalleventa.Enabled = true;

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

        private void barButtonclientes_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clientes frm = new Clientes();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frm);

            frm.Show();
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Productos frm = new Productos();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frm);

            frm.Show();
        }

        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Ventas frm = new Ventas();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frm);

            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDetellesVenta frm = new FrmDetellesVenta();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frm);

            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();

            dashboard.TopLevel = false;
            dashboard.FormBorderStyle = FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(dashboard);

            dashboard.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Compras frm = new Compras();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frm);

            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirFormulario(new ReportesForm());
        }

        private void BTbitacora_ItemClick(object sender, ItemClickEventArgs e)
        {
            pbitacora frm = new pbitacora();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(frm);

            frm.Show();
        }
    }
}