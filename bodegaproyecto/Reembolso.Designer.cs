using Org.BouncyCastle.Asn1.Crmf;

namespace bodegaproyecto
{
    partial class Reembolso
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            pnlHeader = new Panel();
            lblTitulo = new Label();
            plRembolso = new Panel();
            lblDatosVenta = new Label();
            lblVenta = new Label();
            txtVenta = new TextBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblFecha = new Label();
            txtFecha = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblDetalleVenta = new Label();
            dgvDetalleVenta = new DataGridView();
            lblProducto = new Label();
            txtProducto = new TextBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnAgregarReembolso = new Button();
            lblProductosReembolso = new Label();
            dgvDetallesRembolso = new DataGridView();
            pnlTotales = new Panel();
            lblTotalTexto = new Label();
            lblTotal = new Label();
            btnGuardarReembolso = new Button();
            btnCancelar = new Button();
            BTVolver = new Button();
            pnlHeader.SuspendLayout();
            plRembolso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesRembolso).BeginInit();
            pnlTotales.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1405, 65);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(356, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REEMBOLSO DE PRODUCTOS";
            // 
            // plRembolso
            // 
            plRembolso.BackColor = Color.White;
            plRembolso.Controls.Add(lblDatosVenta);
            plRembolso.Controls.Add(lblVenta);
            plRembolso.Controls.Add(txtVenta);
            plRembolso.Controls.Add(lblCliente);
            plRembolso.Controls.Add(txtCliente);
            plRembolso.Controls.Add(lblFecha);
            plRembolso.Controls.Add(txtFecha);
            plRembolso.Controls.Add(lblUsuario);
            plRembolso.Controls.Add(txtUsuario);
            plRembolso.Controls.Add(lblDetalleVenta);
            plRembolso.Controls.Add(dgvDetalleVenta);
            plRembolso.Controls.Add(lblProducto);
            plRembolso.Controls.Add(txtProducto);
            plRembolso.Controls.Add(lblCantidad);
            plRembolso.Controls.Add(nudCantidad);
            plRembolso.Controls.Add(lblDescripcion);
            plRembolso.Controls.Add(txtDescripcion);
            plRembolso.Controls.Add(btnAgregarReembolso);
            plRembolso.Controls.Add(lblProductosReembolso);
            plRembolso.Controls.Add(dgvDetallesRembolso);
            plRembolso.Controls.Add(pnlTotales);
            plRembolso.Controls.Add(btnGuardarReembolso);
            plRembolso.Controls.Add(btnCancelar);
            plRembolso.Controls.Add(BTVolver);
            plRembolso.Location = new Point(12, 78);
            plRembolso.Name = "plRembolso";
            plRembolso.Size = new Size(1380, 805);
            plRembolso.TabIndex = 0;
            // 
            // lblDatosVenta
            // 
            lblDatosVenta.AutoSize = true;
            lblDatosVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDatosVenta.ForeColor = Color.FromArgb(26, 42, 74);
            lblDatosVenta.Location = new Point(25, 20);
            lblDatosVenta.Name = "lblDatosVenta";
            lblDatosVenta.Size = new Size(179, 28);
            lblDatosVenta.TabIndex = 0;
            lblDatosVenta.Text = "Datos de la Venta";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVenta.Location = new Point(25, 60);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(49, 20);
            lblVenta.TabIndex = 1;
            lblVenta.Text = "Venta";
            // 
            // txtVenta
            // 
            txtVenta.Enabled = false;
            txtVenta.Location = new Point(25, 82);
            txtVenta.Name = "txtVenta";
            txtVenta.ReadOnly = true;
            txtVenta.Size = new Size(120, 27);
            txtVenta.TabIndex = 2;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCliente.Location = new Point(170, 60);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(57, 20);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(170, 82);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(360, 27);
            txtCliente.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFecha.Location = new Point(560, 60);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(49, 20);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(560, 82);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(180, 27);
            txtFecha.TabIndex = 6;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.Location = new Point(770, 60);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(770, 82);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(250, 27);
            txtUsuario.TabIndex = 8;
            // 
            // lblDetalleVenta
            // 
            lblDetalleVenta.AutoSize = true;
            lblDetalleVenta.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDetalleVenta.ForeColor = Color.FromArgb(26, 42, 74);
            lblDetalleVenta.Location = new Point(25, 135);
            lblDetalleVenta.Name = "lblDetalleVenta";
            lblDetalleVenta.Size = new Size(176, 25);
            lblDetalleVenta.TabIndex = 9;
            lblDetalleVenta.Text = "Detalle de la Venta";
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.AllowUserToAddRows = false;
            dgvDetalleVenta.AllowUserToDeleteRows = false;
            dgvDetalleVenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleVenta.BackgroundColor = Color.White;
            dgvDetalleVenta.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalleVenta.ColumnHeadersHeight = 40;
            dgvDetalleVenta.EnableHeadersVisualStyles = false;
            dgvDetalleVenta.Location = new Point(25, 170);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.ReadOnly = true;
            dgvDetalleVenta.RowHeadersVisible = false;
            dgvDetalleVenta.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 227, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleVenta.Size = new Size(1330, 230);
            dgvDetalleVenta.TabIndex = 10;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProducto.ForeColor = Color.FromArgb(26, 42, 74);
            lblProducto.Location = new Point(25, 420);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(73, 20);
            lblProducto.TabIndex = 11;
            lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Enabled = false;
            txtProducto.Location = new Point(25, 445);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(360, 27);
            txtProducto.TabIndex = 12;
            txtProducto.UseWaitCursor = true;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(26, 42, 74);
            lblCantidad.Location = new Point(415, 420);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(71, 20);
            lblCantidad.TabIndex = 13;
            lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(415, 445);
            nudCantidad.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 27);
            nudCantidad.TabIndex = 14;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.FromArgb(26, 42, 74);
            lblDescripcion.Location = new Point(565, 420);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 15;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(565, 445);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(500, 60);
            txtDescripcion.TabIndex = 16;
            // 
            // btnAgregarReembolso
            // 
            btnAgregarReembolso.BackColor = Color.SteelBlue;
            btnAgregarReembolso.Cursor = Cursors.Hand;
            btnAgregarReembolso.FlatAppearance.BorderSize = 0;
            btnAgregarReembolso.FlatStyle = FlatStyle.Flat;
            btnAgregarReembolso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarReembolso.ForeColor = Color.White;
            btnAgregarReembolso.Location = new Point(1095, 445);
            btnAgregarReembolso.Name = "btnAgregarReembolso";
            btnAgregarReembolso.Size = new Size(260, 45);
            btnAgregarReembolso.TabIndex = 1;
            btnAgregarReembolso.Text = "Agregar al Reembolso";
            btnAgregarReembolso.UseVisualStyleBackColor = false;
            // 
            // lblProductosReembolso
            // 
            lblProductosReembolso.AutoSize = true;
            lblProductosReembolso.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblProductosReembolso.ForeColor = Color.FromArgb(26, 42, 74);
            lblProductosReembolso.Location = new Point(25, 530);
            lblProductosReembolso.Name = "lblProductosReembolso";
            lblProductosReembolso.Size = new Size(228, 25);
            lblProductosReembolso.TabIndex = 17;
            lblProductosReembolso.Text = "Productos a Reembolsar";
            // 
            // dgvDetallesRembolso
            // 
            dgvDetallesRembolso.AllowUserToAddRows = false;
            dgvDetallesRembolso.AllowUserToDeleteRows = false;
            dgvDetallesRembolso.AllowUserToResizeRows = false;
            dgvDetallesRembolso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesRembolso.BackgroundColor = Color.White;
            dgvDetallesRembolso.BorderStyle = BorderStyle.None;
            dgvDetallesRembolso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDetallesRembolso.ColumnHeadersHeight = 40;
            dgvDetallesRembolso.EnableHeadersVisualStyles = false;
            dgvDetallesRembolso.Location = new Point(25, 565);
            dgvDetallesRembolso.MultiSelect = false;
            dgvDetallesRembolso.Name = "dgvDetallesRembolso";
            dgvDetallesRembolso.ReadOnly = true;
            dgvDetallesRembolso.RowHeadersVisible = false;
            dgvDetallesRembolso.RowHeadersWidth = 51;
            dgvDetallesRembolso.RowTemplate.Height = 35;
            dgvDetallesRembolso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetallesRembolso.Size = new Size(1330, 165);
            dgvDetallesRembolso.TabIndex = 2;
            // 
            // pnlTotales
            // 
            pnlTotales.BackColor = Color.FromArgb(245, 247, 250);
            pnlTotales.BorderStyle = BorderStyle.FixedSingle;
            pnlTotales.Controls.Add(lblTotalTexto);
            pnlTotales.Controls.Add(lblTotal);
            pnlTotales.Location = new Point(1035, 740);
            pnlTotales.Name = "pnlTotales";
            pnlTotales.Size = new Size(320, 55);
            pnlTotales.TabIndex = 18;
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalTexto.ForeColor = Color.FromArgb(26, 42, 74);
            lblTotalTexto.Location = new Point(15, 15);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(163, 25);
            lblTotalTexto.TabIndex = 0;
            lblTotalTexto.Text = "Total Reembolso:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkGreen;
            lblTotal.Location = new Point(190, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "L. 0.00";
            // 
            // btnGuardarReembolso
            // 
            btnGuardarReembolso.BackColor = Color.SeaGreen;
            btnGuardarReembolso.Cursor = Cursors.Hand;
            btnGuardarReembolso.FlatAppearance.BorderSize = 0;
            btnGuardarReembolso.FlatStyle = FlatStyle.Flat;
            btnGuardarReembolso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarReembolso.ForeColor = Color.White;
            btnGuardarReembolso.Location = new Point(25, 745);
            btnGuardarReembolso.Name = "btnGuardarReembolso";
            btnGuardarReembolso.Size = new Size(210, 45);
            btnGuardarReembolso.TabIndex = 3;
            btnGuardarReembolso.Text = "Guardar Reembolso";
            btnGuardarReembolso.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(255, 745);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 45);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // BTVolver
            // 
            BTVolver.BackColor = Color.SteelBlue;
            BTVolver.Cursor = Cursors.Hand;
            BTVolver.FlatAppearance.BorderSize = 0;
            BTVolver.FlatStyle = FlatStyle.Flat;
            BTVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTVolver.ForeColor = Color.White;
            BTVolver.Location = new Point(450, 745);
            BTVolver.Name = "BTVolver";
            BTVolver.Size = new Size(180, 45);
            BTVolver.TabIndex = 5;
            BTVolver.Text = "Volver";
            BTVolver.UseVisualStyleBackColor = false;
            // 
            // Reembolso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1405, 897);
            Controls.Add(plRembolso);
            Controls.Add(pnlHeader);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Reembolso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reembolso";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            plRembolso.ResumeLayout(false);
            plRembolso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesRembolso).EndInit();
            pnlTotales.ResumeLayout(false);
            pnlTotales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitulo;

        private Panel plRembolso;

        private Label lblDatosVenta;

        private Label lblVenta;
        private TextBox txtVenta;

        private Label lblCliente;
        private TextBox txtCliente;

        private Label lblFecha;
        private TextBox txtFecha;

        private Label lblUsuario;
        private TextBox txtUsuario;

        private Label lblDetalleVenta;
        private DataGridView dgvDetalleVenta;

        private Label lblProducto;
        private TextBox txtProducto;

        private Label lblCantidad;
        private NumericUpDown nudCantidad;

        private Label lblDescripcion;
        private TextBox txtDescripcion;

        private Button btnAgregarReembolso;

        private Label lblProductosReembolso;

        // ESTE ES EL MISMO DGV QUE USA TU CÓDIGO ACTUAL
        private DataGridView dgvDetallesRembolso;

        private Panel pnlTotales;

        private Label lblTotalTexto;
        private Label lblTotal;

        private Button btnGuardarReembolso;
        private Button btnCancelar;
        private Button BTVolver;
    }
}