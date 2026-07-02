namespace bodegaproyecto
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            barStaticItemusuarios = new DevExpress.XtraBars.BarStaticItem();
            barStaticItemrol = new DevExpress.XtraBars.BarStaticItem();
            barButtoncerrarsesion = new DevExpress.XtraBars.BarButtonItem();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonusuarios = new DevExpress.XtraBars.BarButtonItem();
            barButtoncategorias = new DevExpress.XtraBars.BarButtonItem();
            barButtomproveedores = new DevExpress.XtraBars.BarButtonItem();
            barStaticusuario = new DevExpress.XtraBars.BarStaticItem();
            barStaticrol = new DevExpress.XtraBars.BarStaticItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonclientes = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            panelContenedor = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelContenedor).BeginInit();
            SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.BackColor = Color.SteelBlue;
            ribbonStatusBar.ForeColor = Color.Silver;
            ribbonStatusBar.ItemLinks.Add(barStaticItemusuarios);
            ribbonStatusBar.ItemLinks.Add(barStaticItemrol);
            ribbonStatusBar.ItemLinks.Add(barButtoncerrarsesion);
            ribbonStatusBar.Location = new Point(0, 437);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1013, 30);
            ribbonStatusBar.Click += ribbonStatusBar_Click;
            // 
            // barStaticItemusuarios
            // 
            barStaticItemusuarios.Caption = "Usuario";
            barStaticItemusuarios.Id = 10;
            barStaticItemusuarios.Name = "barStaticItemusuarios";
            // 
            // barStaticItemrol
            // 
            barStaticItemrol.Id = 11;
            barStaticItemrol.Name = "barStaticItemrol";
            // 
            // barButtoncerrarsesion
            // 
            barButtoncerrarsesion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barButtoncerrarsesion.Id = 12;
            barButtoncerrarsesion.Name = "barButtoncerrarsesion";
            barButtoncerrarsesion.ItemClick += barButtoncerrarsesion_ItemClick;
            // 
            // ribbon
            // 
            ribbon.BackColor = Color.FromArgb(192, 255, 255);
            ribbon.CaptionBarItemLinks.Add(barButtonItem1);
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1, ribbon.ExpandCollapseItem, barButtonusuarios, barButtoncategorias, barButtomproveedores, barStaticusuario, barStaticrol, barButtonItem4, barStaticItemusuarios, barStaticItemrol, barButtoncerrarsesion, barButtonclientes, barButtonItem2 });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 20;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2 });
            ribbon.Size = new Size(1013, 193);
            ribbon.StatusBar = ribbonStatusBar;
            ribbon.Click += ribbon_Click;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Id = 15;
            barButtonItem1.ImageOptions.Image = (Image)resources.GetObject("barButtonItem1.ImageOptions.Image");
            barButtonItem1.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick_1;
            // 
            // barButtonusuarios
            // 
            barButtonusuarios.Caption = "Usuarios";
            barButtonusuarios.Id = 1;
            barButtonusuarios.ImageOptions.Image = (Image)resources.GetObject("barButtonusuarios.ImageOptions.Image");
            barButtonusuarios.Name = "barButtonusuarios";
            barButtonusuarios.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtonusuarios.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtoncategorias
            // 
            barButtoncategorias.Caption = "Categorias";
            barButtoncategorias.Id = 2;
            barButtoncategorias.ImageOptions.Image = (Image)resources.GetObject("barButtoncategorias.ImageOptions.Image");
            barButtoncategorias.Name = "barButtoncategorias";
            barButtoncategorias.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtoncategorias.ItemClick += barButtonItem2_ItemClick;
            // 
            // barButtomproveedores
            // 
            barButtomproveedores.Caption = "Proveedores";
            barButtomproveedores.Id = 3;
            barButtomproveedores.ImageOptions.Image = (Image)resources.GetObject("barButtomproveedores.ImageOptions.Image");
            barButtomproveedores.Name = "barButtomproveedores";
            barButtomproveedores.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtomproveedores.ItemClick += barButtonItem3_ItemClick;
            // 
            // barStaticusuario
            // 
            barStaticusuario.Caption = "Usuario";
            barStaticusuario.Id = 5;
            barStaticusuario.Name = "barStaticusuario";
            // 
            // barStaticrol
            // 
            barStaticrol.Caption = "Rol";
            barStaticrol.Id = 6;
            barStaticrol.Name = "barStaticrol";
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "barButtonItem4";
            barButtonItem4.Id = 7;
            barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonclientes
            // 
            barButtonclientes.Caption = "Clientes";
            barButtonclientes.Id = 18;
            barButtonclientes.ImageOptions.Image = (Image)resources.GetObject("barButtonclientes.ImageOptions.Image");
            barButtonclientes.Name = "barButtonclientes";
            barButtonclientes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtonclientes.ItemClick += barButtonclientes_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Productos";
            barButtonItem2.Id = 19;
            barButtonItem2.ImageOptions.Image = (Image)resources.GetObject("barButtonItem2.ImageOptions.Image");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup4 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Administracion";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonusuarios);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(barButtonclientes);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2, ribbonPageGroup3, ribbonPageGroup5 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Inventario";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtoncategorias);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtomproveedores);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 193);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1013, 244);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 467);
            Controls.Add(panelContenedor);
            Controls.Add(ribbon);
            Controls.Add(ribbonStatusBar);
            Name = "menu";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "Mini Super La Fortaleza";
            WindowState = FormWindowState.Maximized;
            Load += menu_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelContenedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl panelContenedor;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonusuarios;
        private DevExpress.XtraBars.BarButtonItem barButtoncategorias;
        private DevExpress.XtraBars.BarButtonItem barButtomproveedores;
        private DevExpress.XtraBars.BarStaticItem barStaticusuario;
        private DevExpress.XtraBars.BarStaticItem barStaticrol;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarStaticItem barStaticItemusuarios;
        private DevExpress.XtraBars.BarStaticItem barStaticItemrol;
        private DevExpress.XtraBars.BarButtonItem barButtoncerrarsesion;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonclientes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}