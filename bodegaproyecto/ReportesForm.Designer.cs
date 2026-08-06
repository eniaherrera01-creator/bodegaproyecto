namespace bodegaproyecto
{
    partial class ReportesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitulo = new Label();
            panelFiltros = new Panel();
            lblTipoReporte = new Label();
            cbReporte = new ComboBox();
            lblCategoria = new Label();
            cbCategoria = new ComboBox();
            btnGenerar = new Button();
            btnLimpiar = new Button();
            btnExportarPDF = new Button();
            lblListaTitulo = new Label();
            dgvReporte = new DataGridView();
            pnlHeader.SuspendLayout();
            panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(178, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📄 Reportes";
            // 
            // panelFiltros
            // 
            panelFiltros.BackColor = Color.White;
            panelFiltros.BorderStyle = BorderStyle.FixedSingle;
            panelFiltros.Controls.Add(lblTipoReporte);
            panelFiltros.Controls.Add(cbReporte);
            panelFiltros.Controls.Add(lblCategoria);
            panelFiltros.Controls.Add(cbCategoria);
            panelFiltros.Controls.Add(btnGenerar);
            panelFiltros.Controls.Add(btnLimpiar);
            panelFiltros.Controls.Add(btnExportarPDF);
            panelFiltros.Location = new Point(25, 80);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(1150, 120);
            panelFiltros.TabIndex = 1;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipoReporte.Location = new Point(20, 20);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(136, 23);
            lblTipoReporte.TabIndex = 0;
            lblTipoReporte.Text = "Tipo de reporte";
            // 
            // cbReporte
            // 
            cbReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReporte.Font = new Font("Segoe UI", 10F);
            cbReporte.FormattingEnabled = true;
            cbReporte.Items.AddRange(new object[] {"Inventario general","Productos activos","Productos inactivos","Productos con bajo stock","Productos por categoría","Productos próximos a vencer","Productos vencidos","Productos con mayor stock","Inventario valorizado","Reporte de categorías","Reporte de proveedores"});
            cbReporte.Location = new Point(20, 50);
            cbReporte.Name = "cbReporte";
            cbReporte.Size = new Size(280, 31);
            cbReporte.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategoria.Location = new Point(330, 20);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 23);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoría";
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.Font = new Font("Segoe UI", 10F);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(330, 50);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(280, 31);
            cbCategoria.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(26, 115, 232);
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(625, 50);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(212, 35);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar vista previa";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(26, 115, 232);
            btnLimpiar.Location = new Point(995, 50);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 35);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = Color.FromArgb(26, 115, 232);
            btnExportarPDF.Cursor = Cursors.Hand;
            btnExportarPDF.FlatAppearance.BorderSize = 0;
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportarPDF.ForeColor = Color.White;
            btnExportarPDF.Location = new Point(849, 50);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(140, 35);
            btnExportarPDF.TabIndex = 6;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // lblListaTitulo
            // 
            lblListaTitulo.AutoSize = true;
            lblListaTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblListaTitulo.ForeColor = Color.FromArgb(70, 130, 180);
            lblListaTitulo.Location = new Point(25, 220);
            lblListaTitulo.Name = "lblListaTitulo";
            lblListaTitulo.Size = new Size(236, 28);
            lblListaTitulo.TabIndex = 2;
            lblListaTitulo.Text = "Vista previa del reporte";
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.ColumnHeadersHeight = 29;
            dgvReporte.Location = new Point(25, 260);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(1150, 400);
            dgvReporte.TabIndex = 3;
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlHeader);
            Controls.Add(panelFiltros);
            Controls.Add(lblListaTitulo);
            Controls.Add(dgvReporte);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportesForm";
            Text = "Reportes";
            Load += ReportesForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

       

        private Panel pnlHeader;
        private Label lblTitulo;
        private Panel panelFiltros;
        private Label lblTipoReporte;
        private ComboBox cbReporte;
        private Label lblCategoria;
        private ComboBox cbCategoria;
        private Button btnGenerar;
        private Button btnLimpiar;
        private Label lblListaTitulo;
        private DataGridView dgvReporte;
        private Button btnExportarPDF;
    }
}