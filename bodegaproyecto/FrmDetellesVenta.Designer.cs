namespace bodegaproyecto
{
    partial class FrmDetellesVenta
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Controles

        private Panel pnlHeader;
        private Label lblTitulo;

        private Panel pnlFiltros1;

        private Label lblBuscarCodigo;
        private TextBox txtBuscarID;
        private Button btnBuscar;

        private Label lblBuscarFecha;
        private Label lblDesde;
        private Label lblHasta;

        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;

        private Button btnBuscarFecha;

        private DataGridView dgvVentas;

        #endregion

        /// <summary>
        /// Limpiar recursos.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitulo = new Label();
            pnlFiltros1 = new Panel();
            lblBuscarCodigo = new Label();
            txtBuscarID = new TextBox();
            btnBuscar = new Button();
            lblBuscarFecha = new Label();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            btnBuscarFecha = new Button();
            dgvVentas = new DataGridView();
            pnlFiltros2 = new Panel();
            dgvDetalleVenta = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlFiltros1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            pnlFiltros2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1920, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AccessibleRole = AccessibleRole.IpAddress;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(249, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DETALLES VENTAS";
            // 
            // pnlFiltros1
            // 
            pnlFiltros1.BackColor = Color.White;
            pnlFiltros1.Controls.Add(lblBuscarCodigo);
            pnlFiltros1.Controls.Add(txtBuscarID);
            pnlFiltros1.Controls.Add(btnBuscar);
            pnlFiltros1.Location = new Point(20, 90);
            pnlFiltros1.Name = "pnlFiltros1";
            pnlFiltros1.Size = new Size(365, 233);
            pnlFiltros1.TabIndex = 1;
            // 
            // lblBuscarCodigo
            // 
            lblBuscarCodigo.AutoSize = true;
            lblBuscarCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBuscarCodigo.Location = new Point(23, 37);
            lblBuscarCodigo.Name = "lblBuscarCodigo";
            lblBuscarCodigo.Size = new Size(183, 28);
            lblBuscarCodigo.TabIndex = 0;
            lblBuscarCodigo.Text = "Buscar por código";
            // 
            // txtBuscarID
            // 
            txtBuscarID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarID.Location = new Point(45, 88);
            txtBuscarID.Name = "txtBuscarID";
            txtBuscarID.PlaceholderText = "Ingrese el ID de la venta";
            txtBuscarID.Size = new Size(250, 30);
            txtBuscarID.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(26, 115, 232);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(45, 148);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 35);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblBuscarFecha
            // 
            lblBuscarFecha.AutoSize = true;
            lblBuscarFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBuscarFecha.Location = new Point(23, 27);
            lblBuscarFecha.Name = "lblBuscarFecha";
            lblBuscarFecha.Size = new Size(171, 28);
            lblBuscarFecha.TabIndex = 3;
            lblBuscarFecha.Text = "Buscar por fecha";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10.2F);
            lblDesde.Location = new Point(45, 88);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(57, 23);
            lblDesde.TabIndex = 4;
            lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Segoe UI", 10.2F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(107, 83);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(120, 30);
            dtpDesde.TabIndex = 5;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10.2F);
            lblHasta.Location = new Point(45, 137);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(53, 23);
            lblHasta.TabIndex = 6;
            lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Segoe UI", 10.2F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(108, 131);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(120, 30);
            dtpHasta.TabIndex = 7;
            // 
            // btnBuscarFecha
            // 
            btnBuscarFecha.BackColor = Color.FromArgb(26, 115, 232);
            btnBuscarFecha.Cursor = Cursors.Hand;
            btnBuscarFecha.FlatAppearance.BorderSize = 0;
            btnBuscarFecha.FlatStyle = FlatStyle.Flat;
            btnBuscarFecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarFecha.ForeColor = Color.White;
            btnBuscarFecha.Location = new Point(45, 185);
            btnBuscarFecha.Name = "btnBuscarFecha";
            btnBuscarFecha.Size = new Size(150, 35);
            btnBuscarFecha.TabIndex = 8;
            btnBuscarFecha.Text = "📅 Buscar Fecha";
            btnBuscarFecha.UseVisualStyleBackColor = false;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.ColumnHeadersHeight = 40;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.Location = new Point(408, 90);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 227, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvVentas.RowTemplate.Height = 35;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(1487, 321);
            dgvVentas.TabIndex = 2;
            // 
            // pnlFiltros2
            // 
            pnlFiltros2.BackColor = Color.White;
            pnlFiltros2.Controls.Add(lblBuscarFecha);
            pnlFiltros2.Controls.Add(btnBuscarFecha);
            pnlFiltros2.Controls.Add(dtpHasta);
            pnlFiltros2.Controls.Add(lblHasta);
            pnlFiltros2.Controls.Add(dtpDesde);
            pnlFiltros2.Controls.Add(lblDesde);
            pnlFiltros2.Location = new Point(20, 356);
            pnlFiltros2.Name = "pnlFiltros2";
            pnlFiltros2.Size = new Size(365, 249);
            pnlFiltros2.TabIndex = 3;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.AllowUserToAddRows = false;
            dgvDetalleVenta.AllowUserToDeleteRows = false;
            dgvDetalleVenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 250, 252);
            dgvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleVenta.BackgroundColor = Color.White;
            dgvDetalleVenta.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDetalleVenta.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDetalleVenta.EnableHeadersVisualStyles = false;
            dgvDetalleVenta.Location = new Point(408, 444);
            dgvDetalleVenta.MultiSelect = false;
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDetalleVenta.RowHeadersVisible = false;
            dgvDetalleVenta.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(210, 227, 252);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dgvDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvDetalleVenta.RowTemplate.Height = 35;
            dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleVenta.Size = new Size(1487, 313);
            dgvDetalleVenta.TabIndex = 5;
            // 
            // FrmDetellesVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1920, 855);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(pnlFiltros2);
            Controls.Add(pnlHeader);
            Controls.Add(pnlFiltros1);
            Controls.Add(dgvVentas);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDetellesVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Ventas";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFiltros1.ResumeLayout(false);
            pnlFiltros1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            pnlFiltros2.ResumeLayout(false);
            pnlFiltros2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlFiltros2;
        private DataGridView dgvDetalleVenta;
    }
}