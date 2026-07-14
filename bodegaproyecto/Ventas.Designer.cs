namespace bodegaproyecto
{
    partial class Ventas
    {
        private System.ComponentModel.IContainer components = null;

        //========================
        // PANEL SUPERIOR
        //========================
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloForm;

        //========================
        // PANEL IZQUIERDO
        //========================
        private System.Windows.Forms.Panel pnlIzquierdo;

        private System.Windows.Forms.Label lblTituloDatos;

        private System.Windows.Forms.Label lblIDVenta;
        private System.Windows.Forms.TextBox txtIDVenta;

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;

        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox cmbMetodoPago;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

        //========================
        // PANEL DERECHO
        //========================
        private System.Windows.Forms.Panel pnlDerecho;

        private System.Windows.Forms.Label lblTituloLista;

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnActualizar;

        private System.Windows.Forms.TextBox txtBuscar;

        private System.Windows.Forms.DataGridView dgvVentas;

        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTituloForm = new Label();
            pnlIzquierdo = new Panel();
            lblTituloDatos = new Label();
            lblIDVenta = new Label();
            txtIDVenta = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            lblUsuario = new Label();
            cmbUsuario = new ComboBox();
            lblMetodoPago = new Label();
            cmbMetodoPago = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pnlDerecho = new Panel();
            lblTituloLista = new Label();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnActualizar = new Button();
            txtBuscar = new TextBox();
            dgvVentas = new DataGridView();
            lblTotal = new Label();
            pnlHeader.SuspendLayout();
            pnlIzquierdo.SuspendLayout();
            pnlDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTituloForm);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1371, 73);
            pnlHeader.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(23, 16);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(102, 37);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "Ventas";
            // 
            // pnlIzquierdo
            // 
            pnlIzquierdo.BackColor = Color.White;
            pnlIzquierdo.Controls.Add(lblTituloDatos);
            pnlIzquierdo.Controls.Add(lblIDVenta);
            pnlIzquierdo.Controls.Add(txtIDVenta);
            pnlIzquierdo.Controls.Add(lblFecha);
            pnlIzquierdo.Controls.Add(dtpFecha);
            pnlIzquierdo.Controls.Add(lblCliente);
            pnlIzquierdo.Controls.Add(cmbCliente);
            pnlIzquierdo.Controls.Add(lblUsuario);
            pnlIzquierdo.Controls.Add(cmbUsuario);
            pnlIzquierdo.Controls.Add(lblMetodoPago);
            pnlIzquierdo.Controls.Add(cmbMetodoPago);
            pnlIzquierdo.Controls.Add(btnGuardar);
            pnlIzquierdo.Controls.Add(btnCancelar);
            pnlIzquierdo.Location = new Point(11, 87);
            pnlIzquierdo.Margin = new Padding(3, 4, 3, 4);
            pnlIzquierdo.Name = "pnlIzquierdo";
            pnlIzquierdo.Size = new Size(354, 820);
            pnlIzquierdo.TabIndex = 0;
            // 
            // lblTituloDatos
            // 
            lblTituloDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloDatos.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloDatos.Location = new Point(17, 20);
            lblTituloDatos.Name = "lblTituloDatos";
            lblTituloDatos.Size = new Size(320, 33);
            lblTituloDatos.TabIndex = 0;
            lblTituloDatos.Text = "Datos de la Venta";
            // 
            // lblIDVenta
            // 
            lblIDVenta.AutoSize = true;
            lblIDVenta.Location = new Point(17, 73);
            lblIDVenta.Name = "lblIDVenta";
            lblIDVenta.Size = new Size(65, 20);
            lblIDVenta.TabIndex = 1;
            lblIDVenta.Text = "ID Venta";
            // 
            // txtIDVenta
            // 
            txtIDVenta.BackColor = Color.FromArgb(245, 245, 245);
            txtIDVenta.Enabled = false;
            txtIDVenta.Location = new Point(17, 97);
            txtIDVenta.Margin = new Padding(3, 4, 3, 4);
            txtIDVenta.Name = "txtIDVenta";
            txtIDVenta.Size = new Size(314, 27);
            txtIDVenta.TabIndex = 2;
            txtIDVenta.Text = "(Automático)";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(17, 153);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(17, 177);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(314, 27);
            dtpFecha.TabIndex = 4;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(17, 233);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Location = new Point(17, 257);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(314, 28);
            cmbCliente.TabIndex = 6;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(17, 313);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Location = new Point(17, 337);
            cmbUsuario.Margin = new Padding(3, 4, 3, 4);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(314, 28);
            cmbUsuario.TabIndex = 8;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(17, 393);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(120, 20);
            lblMetodoPago.TabIndex = 9;
            lblMetodoPago.Text = "Método de Pago";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            cmbMetodoPago.Location = new Point(17, 417);
            cmbMetodoPago.Margin = new Padding(3, 4, 3, 4);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(314, 28);
            cmbMetodoPago.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(26, 115, 232);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(17, 487);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 51);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(200, 200, 200);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(183, 487);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 51);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "✖ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pnlDerecho
            // 
            pnlDerecho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDerecho.BackColor = Color.White;
            pnlDerecho.Controls.Add(lblTituloLista);
            pnlDerecho.Controls.Add(btnNuevo);
            pnlDerecho.Controls.Add(btnEditar);
            pnlDerecho.Controls.Add(btnActualizar);
            pnlDerecho.Controls.Add(txtBuscar);
            pnlDerecho.Controls.Add(dgvVentas);
            pnlDerecho.Controls.Add(lblTotal);
            pnlDerecho.Location = new Point(377, 87);
            pnlDerecho.Margin = new Padding(3, 4, 3, 4);
            pnlDerecho.Name = "pnlDerecho";
            pnlDerecho.Size = new Size(984, 820);
            pnlDerecho.TabIndex = 0;
            // 
            // lblTituloLista
            // 
            lblTituloLista.AutoSize = true;
            lblTituloLista.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloLista.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloLista.Location = new Point(17, 20);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(154, 28);
            lblTituloLista.TabIndex = 0;
            lblTituloLista.Text = "Lista de Ventas";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(26, 115, 232);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(17, 67);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(109, 45);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "+ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.FromArgb(60, 60, 60);
            btnEditar.Location = new Point(137, 67);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(109, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "✎ Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.White;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.FromArgb(60, 60, 60);
            btnActualizar.Location = new Point(264, 67);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 45);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "↻ Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(423, 76);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar venta...";
            txtBuscar.Size = new Size(274, 27);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.ColumnHeadersHeight = 40;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.Location = new Point(17, 133);
            dgvVentas.Margin = new Padding(3, 4, 3, 4);
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
            dgvVentas.Size = new Size(897, 620);
            dgvVentas.TabIndex = 6;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick_1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.FromArgb(100, 100, 100);
            lblTotal.Location = new Point(17, 767);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(103, 20);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total ventas: 0";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1371, 933);
            Controls.Add(pnlHeader);
            Controls.Add(pnlIzquierdo);
            Controls.Add(pnlDerecho);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            Load += Ventas_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlIzquierdo.ResumeLayout(false);
            pnlIzquierdo.PerformLayout();
            pnlDerecho.ResumeLayout(false);
            pnlDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }
    }
}