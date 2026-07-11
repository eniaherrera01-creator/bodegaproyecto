namespace bodegaproyecto
{
    partial class DashboardForm
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
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelCards = new FlowLayoutPanel();
            cardProductos = new Panel();
            lineaProductos = new Panel();
            lblTituloProductos = new Label();
            lblProductos = new Label();
            cardCategorias = new Panel();
            lineaCategorias = new Panel();
            lblTituloCategorias = new Label();
            lblCategorias = new Label();
            cardProveedores = new Panel();
            lineaProveedores = new Panel();
            lblTituloProveedores = new Label();
            lblProveedores = new Label();
            cardActivos = new Panel();
            lineaActivos = new Panel();
            lblTituloActivos = new Label();
            lblActivos = new Label();
            cardInactivos = new Panel();
            lineaInactivos = new Panel();
            lblTituloInactivos = new Label();
            lblInactivos = new Label();
            cardBajoStock = new Panel();
            lineaBajoStock = new Panel();
            lblTituloBajoStock = new Label();
            lblBajoStock = new Label();
            lblInfo = new Label();

            panelHeader.SuspendLayout();
            panelCards.SuspendLayout();
            cardProductos.SuspendLayout();
            cardCategorias.SuspendLayout();
            cardProveedores.SuspendLayout();
            cardActivos.SuspendLayout();
            cardInactivos.SuspendLayout();
            cardBajoStock.SuspendLayout();
            SuspendLayout();

            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 65);
            panelHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(255, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📊 Panel Principal";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSubtitulo.ForeColor = Color.FromArgb(70, 130, 180);
            lblSubtitulo.Location = new Point(30, 90);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(329, 30);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Resumen general del sistema";

            // 
            // panelCards
            // 
            panelCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCards.BackColor = Color.White;
            panelCards.Controls.Add(cardProductos);
            panelCards.Controls.Add(cardCategorias);
            panelCards.Controls.Add(cardProveedores);
            panelCards.Controls.Add(cardActivos);
            panelCards.Controls.Add(cardInactivos);
            panelCards.Controls.Add(cardBajoStock);
            panelCards.Location = new Point(30, 140);
            panelCards.Name = "panelCards";
            panelCards.Size = new Size(1120, 285);
            panelCards.TabIndex = 2;

            // 
            // cardProductos
            // 
            cardProductos.BackColor = Color.White;
            cardProductos.BorderStyle = BorderStyle.FixedSingle;
            cardProductos.Controls.Add(lineaProductos);
            cardProductos.Controls.Add(lblTituloProductos);
            cardProductos.Controls.Add(lblProductos);
            cardProductos.Location = new Point(10, 10);
            cardProductos.Margin = new Padding(10);
            cardProductos.Name = "cardProductos";
            cardProductos.Size = new Size(330, 110);
            cardProductos.TabIndex = 0;

            // 
            // lineaProductos
            // 
            lineaProductos.BackColor = Color.FromArgb(52, 152, 219);
            lineaProductos.Dock = DockStyle.Left;
            lineaProductos.Location = new Point(0, 0);
            lineaProductos.Name = "lineaProductos";
            lineaProductos.Size = new Size(8, 108);
            lineaProductos.TabIndex = 0;

            // 
            // lblTituloProductos
            // 
            lblTituloProductos.AutoSize = true;
            lblTituloProductos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloProductos.ForeColor = Color.FromArgb(60, 60, 60);
            lblTituloProductos.Location = new Point(25, 18);
            lblTituloProductos.Name = "lblTituloProductos";
            lblTituloProductos.Size = new Size(132, 25);
            lblTituloProductos.TabIndex = 1;
            lblTituloProductos.Text = "📦 Productos";

            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblProductos.ForeColor = Color.FromArgb(52, 152, 219);
            lblProductos.Location = new Point(25, 50);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(46, 54);
            lblProductos.TabIndex = 2;
            lblProductos.Text = "0";

            // 
            // cardCategorias
            // 
            cardCategorias.BackColor = Color.White;
            cardCategorias.BorderStyle = BorderStyle.FixedSingle;
            cardCategorias.Controls.Add(lineaCategorias);
            cardCategorias.Controls.Add(lblTituloCategorias);
            cardCategorias.Controls.Add(lblCategorias);
            cardCategorias.Location = new Point(360, 10);
            cardCategorias.Margin = new Padding(10);
            cardCategorias.Name = "cardCategorias";
            cardCategorias.Size = new Size(330, 110);
            cardCategorias.TabIndex = 1;

            // 
            // lineaCategorias
            // 
            lineaCategorias.BackColor = Color.FromArgb(155, 89, 182);
            lineaCategorias.Dock = DockStyle.Left;
            lineaCategorias.Location = new Point(0, 0);
            lineaCategorias.Name = "lineaCategorias";
            lineaCategorias.Size = new Size(8, 108);
            lineaCategorias.TabIndex = 0;

            // 
            // lblTituloCategorias
            // 
            lblTituloCategorias.AutoSize = true;
            lblTituloCategorias.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloCategorias.ForeColor = Color.FromArgb(60, 60, 60);
            lblTituloCategorias.Location = new Point(25, 18);
            lblTituloCategorias.Name = "lblTituloCategorias";
            lblTituloCategorias.Size = new Size(138, 25);
            lblTituloCategorias.TabIndex = 1;
            lblTituloCategorias.Text = "🏷 Categorías";

            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCategorias.ForeColor = Color.FromArgb(155, 89, 182);
            lblCategorias.Location = new Point(25, 50);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(46, 54);
            lblCategorias.TabIndex = 2;
            lblCategorias.Text = "0";

            // 
            // cardProveedores
            // 
            cardProveedores.BackColor = Color.White;
            cardProveedores.BorderStyle = BorderStyle.FixedSingle;
            cardProveedores.Controls.Add(lineaProveedores);
            cardProveedores.Controls.Add(lblTituloProveedores);
            cardProveedores.Controls.Add(lblProveedores);
            cardProveedores.Location = new Point(710, 10);
            cardProveedores.Margin = new Padding(10);
            cardProveedores.Name = "cardProveedores";
            cardProveedores.Size = new Size(330, 110);
            cardProveedores.TabIndex = 2;

            // 
            // lineaProveedores
            // 
            lineaProveedores.BackColor = Color.FromArgb(46, 204, 113);
            lineaProveedores.Dock = DockStyle.Left;
            lineaProveedores.Location = new Point(0, 0);
            lineaProveedores.Name = "lineaProveedores";
            lineaProveedores.Size = new Size(8, 108);
            lineaProveedores.TabIndex = 0;

            // 
            // lblTituloProveedores
            // 
            lblTituloProveedores.AutoSize = true;
            lblTituloProveedores.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloProveedores.ForeColor = Color.FromArgb(60, 60, 60);
            lblTituloProveedores.Location = new Point(25, 18);
            lblTituloProveedores.Name = "lblTituloProveedores";
            lblTituloProveedores.Size = new Size(161, 25);
            lblTituloProveedores.TabIndex = 1;
            lblTituloProveedores.Text = "🚚 Proveedores";

            // 
            // lblProveedores
            // 
            lblProveedores.AutoSize = true;
            lblProveedores.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblProveedores.ForeColor = Color.FromArgb(46, 204, 113);
            lblProveedores.Location = new Point(25, 50);
            lblProveedores.Name = "lblProveedores";
            lblProveedores.Size = new Size(46, 54);
            lblProveedores.TabIndex = 2;
            lblProveedores.Text = "0";

            // 
            // cardActivos
            // 
            cardActivos.BackColor = Color.White;
            cardActivos.BorderStyle = BorderStyle.FixedSingle;
            cardActivos.Controls.Add(lineaActivos);
            cardActivos.Controls.Add(lblTituloActivos);
            cardActivos.Controls.Add(lblActivos);
            cardActivos.Location = new Point(10, 140);
            cardActivos.Margin = new Padding(10);
            cardActivos.Name = "cardActivos";
            cardActivos.Size = new Size(330, 110);
            cardActivos.TabIndex = 3;

            // 
            // lineaActivos
            // 
            lineaActivos.BackColor = Color.FromArgb(39, 174, 96);
            lineaActivos.Dock = DockStyle.Left;
            lineaActivos.Location = new Point(0, 0);
            lineaActivos.Name = "lineaActivos";
            lineaActivos.Size = new Size(8, 108);
            lineaActivos.TabIndex = 0;

            // 
            // lblTituloActivos
            // 
            lblTituloActivos.AutoSize = true;
            lblTituloActivos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloActivos.ForeColor = Color.FromArgb(60, 60, 60);
            lblTituloActivos.Location = new Point(25, 18);
            lblTituloActivos.Name = "lblTituloActivos";
            lblTituloActivos.Size = new Size(202, 25);
            lblTituloActivos.TabIndex = 1;
            lblTituloActivos.Text = "✅ Productos activos";

            // 
            // lblActivos
            // 
            lblActivos.AutoSize = true;
            lblActivos.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblActivos.ForeColor = Color.FromArgb(39, 174, 96);
            lblActivos.Location = new Point(25, 50);
            lblActivos.Name = "lblActivos";
            lblActivos.Size = new Size(46, 54);
            lblActivos.TabIndex = 2;
            lblActivos.Text = "0";

            // 
            // cardInactivos
            // 
            cardInactivos.BackColor = Color.White;
            cardInactivos.BorderStyle = BorderStyle.FixedSingle;
            cardInactivos.Controls.Add(lineaInactivos);
            cardInactivos.Controls.Add(lblTituloInactivos);
            cardInactivos.Controls.Add(lblInactivos);
            cardInactivos.Location = new Point(360, 140);
            cardInactivos.Margin = new Padding(10);
            cardInactivos.Name = "cardInactivos";
            cardInactivos.Size = new Size(330, 110);
            cardInactivos.TabIndex = 4;

            // 
            // lineaInactivos
            // 
            lineaInactivos.BackColor = Color.FromArgb(231, 76, 60);
            lineaInactivos.Dock = DockStyle.Left;
            lineaInactivos.Location = new Point(0, 0);
            lineaInactivos.Name = "lineaInactivos";
            lineaInactivos.Size = new Size(8, 108);
            lineaInactivos.TabIndex = 0;

            // 
            // lblTituloInactivos
            // 
            lblTituloInactivos.AutoSize = true;
            lblTituloInactivos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloInactivos.ForeColor = Color.FromArgb(60, 60, 60);
            lblTituloInactivos.Location = new Point(25, 18);
            lblTituloInactivos.Name = "lblTituloInactivos";
            lblTituloInactivos.Size = new Size(221, 25);
            lblTituloInactivos.TabIndex = 1;
            lblTituloInactivos.Text = "⛔ Productos inactivos";

            // 
            // lblInactivos
            // 
            lblInactivos.AutoSize = true;
            lblInactivos.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblInactivos.ForeColor = Color.FromArgb(231, 76, 60);
            lblInactivos.Location = new Point(25, 50);
            lblInactivos.Name = "lblInactivos";
            lblInactivos.Size = new Size(46, 54);
            lblInactivos.TabIndex = 2;
            lblInactivos.Text = "0";

            // 
            // cardBajoStock
            // 
            cardBajoStock.BackColor = Color.White;
            cardBajoStock.BorderStyle = BorderStyle.FixedSingle;
            cardBajoStock.Controls.Add(lineaBajoStock);
            cardBajoStock.Controls.Add(lblTituloBajoStock);
            cardBajoStock.Controls.Add(lblBajoStock);
            cardBajoStock.Location = new Point(710, 140);
            cardBajoStock.Margin = new Padding(10);
            cardBajoStock.Name = "cardBajoStock";
            cardBajoStock.Size = new Size(330, 110);
            cardBajoStock.TabIndex = 5;

            // 
            // lineaBajoStock
            // 
            lineaBajoStock.BackColor = Color.FromArgb(243, 156, 18);
            lineaBajoStock.Dock = DockStyle.Left;
            lineaBajoStock.Location = new Point(0, 0);
            lineaBajoStock.Name = "lineaBajoStock";
            lineaBajoStock.Size = new Size(8, 108);
            lineaBajoStock.TabIndex = 0;

            // 
            // lblTituloBajoStock
            // 
            lblTituloBajoStock.AutoSize = true;
            lblTituloBajoStock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloBajoStock.ForeColor = Color.FromArgb(60, 60, 60);
            lblTituloBajoStock.Location = new Point(25, 18);
            lblTituloBajoStock.Name = "lblTituloBajoStock";
            lblTituloBajoStock.Size = new Size(141, 25);
            lblTituloBajoStock.TabIndex = 1;
            lblTituloBajoStock.Text = "⚠ Bajo stock";

            // 
            // lblBajoStock
            // 
            lblBajoStock.AutoSize = true;
            lblBajoStock.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBajoStock.ForeColor = Color.FromArgb(243, 156, 18);
            lblBajoStock.Location = new Point(25, 50);
            lblBajoStock.Name = "lblBajoStock";
            lblBajoStock.Size = new Size(46, 54);
            lblBajoStock.TabIndex = 2;
            lblBajoStock.Text = "0";

            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 11F);
            lblInfo.ForeColor = Color.Gray;
            lblInfo.Location = new Point(35, 455);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(554, 25);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Seleccione un módulo del menú superior para comenzar a trabajar.";

            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 650);
            Controls.Add(lblInfo);
            Controls.Add(panelCards);
            Controls.Add(lblSubtitulo);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "Dashboard";
            Load += DashboardForm_Load;

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCards.ResumeLayout(false);
            cardProductos.ResumeLayout(false);
            cardProductos.PerformLayout();
            cardCategorias.ResumeLayout(false);
            cardCategorias.PerformLayout();
            cardProveedores.ResumeLayout(false);
            cardProveedores.PerformLayout();
            cardActivos.ResumeLayout(false);
            cardActivos.PerformLayout();
            cardInactivos.ResumeLayout(false);
            cardInactivos.PerformLayout();
            cardBajoStock.ResumeLayout(false);
            cardBajoStock.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private FlowLayoutPanel panelCards;

        private Panel cardProductos;
        private Panel lineaProductos;
        private Label lblTituloProductos;
        private Label lblProductos;

        private Panel cardCategorias;
        private Panel lineaCategorias;
        private Label lblTituloCategorias;
        private Label lblCategorias;

        private Panel cardProveedores;
        private Panel lineaProveedores;
        private Label lblTituloProveedores;
        private Label lblProveedores;

        private Panel cardActivos;
        private Panel lineaActivos;
        private Label lblTituloActivos;
        private Label lblActivos;

        private Panel cardInactivos;
        private Panel lineaInactivos;
        private Label lblTituloInactivos;
        private Label lblInactivos;

        private Panel cardBajoStock;
        private Panel lineaBajoStock;
        private Label lblTituloBajoStock;
        private Label lblBajoStock;

        private Label lblInfo;
    }
}