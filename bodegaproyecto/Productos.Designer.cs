namespace bodegaproyecto
{
    partial class Productos
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
            pnlHeader = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            cbcategoria = new ComboBox();
            txtstock = new TextBox();
            label10 = new Label();
            txtprecioventa = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txtimpuesto = new TextBox();
            dtpfv = new DateTimePicker();
            txtpreciocompra = new TextBox();
            txtdescripcion = new TextBox();
            txtnombre = new TextBox();
            txtId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblId = new Label();
            lblListaTitulo = new Label();
            panel2 = new Panel();
            txtbuscar = new TextBox();
            dgvproductos = new DataGridView();
            btnguardar = new Button();
            btnestado = new Button();
            label5 = new Label();
            btneditar = new Button();
            btnnuevo = new Button();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvproductos).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1199, 47);
            pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(cbcategoria);
            panel1.Controls.Add(txtstock);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtprecioventa);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtimpuesto);
            panel1.Controls.Add(dtpfv);
            panel1.Controls.Add(txtpreciocompra);
            panel1.Controls.Add(txtdescripcion);
            panel1.Controls.Add(txtnombre);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(lblListaTitulo);
            panel1.Location = new Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 520);
            panel1.TabIndex = 2;
            // 
            // cbcategoria
            // 
            cbcategoria.DisplayMember = "Snacks";
            cbcategoria.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Items.AddRange(new object[] { "Bebidas", "Snacks", "Lacteos", "Otro" });
            cbcategoria.Location = new Point(11, 467);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(280, 25);
            cbcategoria.TabIndex = 38;
            // 
            // txtstock
            // 
            txtstock.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtstock.ForeColor = Color.Gray;
            txtstock.Location = new Point(11, 306);
            txtstock.Multiline = true;
            txtstock.Name = "txtstock";
            txtstock.PlaceholderText = "Ej: 70";
            txtstock.Size = new Size(280, 22);
            txtstock.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F);
            label10.Location = new Point(11, 288);
            label10.Name = "label10";
            label10.Size = new Size(43, 17);
            label10.TabIndex = 36;
            label10.Text = "Stock";
            // 
            // txtprecioventa
            // 
            txtprecioventa.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtprecioventa.ForeColor = Color.Gray;
            txtprecioventa.Location = new Point(12, 257);
            txtprecioventa.Multiline = true;
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.PlaceholderText = "Ej: 1000";
            txtprecioventa.Size = new Size(280, 23);
            txtprecioventa.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(12, 239);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 34;
            label6.Text = "Precio Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(11, 441);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 32;
            label3.Text = "Categoria";
            // 
            // txtimpuesto
            // 
            txtimpuesto.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtimpuesto.ForeColor = Color.Gray;
            txtimpuesto.Location = new Point(12, 409);
            txtimpuesto.Multiline = true;
            txtimpuesto.Name = "txtimpuesto";
            txtimpuesto.PlaceholderText = "Ej: 49";
            txtimpuesto.Size = new Size(280, 22);
            txtimpuesto.TabIndex = 31;
            // 
            // dtpfv
            // 
            dtpfv.Format = DateTimePickerFormat.Short;
            dtpfv.Location = new Point(12, 357);
            dtpfv.Name = "dtpfv";
            dtpfv.Size = new Size(280, 23);
            dtpfv.TabIndex = 30;
            dtpfv.Value = new DateTime(2027, 7, 7, 21, 37, 0, 0);
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtpreciocompra.ForeColor = Color.Gray;
            txtpreciocompra.Location = new Point(12, 206);
            txtpreciocompra.Multiline = true;
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.PlaceholderText = "Ej: 700 ";
            txtpreciocompra.Size = new Size(280, 23);
            txtpreciocompra.TabIndex = 29;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtdescripcion.ForeColor = Color.Gray;
            txtdescripcion.Location = new Point(12, 153);
            txtdescripcion.Multiline = true;
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.PlaceholderText = "Ej: Galletas Chocolates";
            txtdescripcion.Size = new Size(280, 24);
            txtdescripcion.TabIndex = 28;
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtnombre.ForeColor = Color.Gray;
            txtnombre.Location = new Point(12, 104);
            txtnombre.Multiline = true;
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Ej: Snacks";
            txtnombre.Size = new Size(280, 22);
            txtnombre.TabIndex = 27;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(235, 245, 255);
            txtId.Enabled = false;
            txtId.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtId.ForeColor = Color.DarkBlue;
            txtId.Location = new Point(12, 54);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "ID: Automático";
            txtId.ReadOnly = true;
            txtId.Size = new Size(280, 23);
            txtId.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F);
            label9.Location = new Point(12, 339);
            label9.Name = "label9";
            label9.Size = new Size(128, 17);
            label9.TabIndex = 26;
            label9.Text = "Fecha Vencimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F);
            label8.Location = new Point(12, 391);
            label8.Name = "label8";
            label8.Size = new Size(65, 17);
            label8.TabIndex = 25;
            label8.Text = "Impuesto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.Location = new Point(12, 188);
            label7.Name = "label7";
            label7.Size = new Size(101, 17);
            label7.TabIndex = 24;
            label7.Text = "Precio Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 21;
            label4.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 19;
            label2.Text = "Nombre Producto";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblId.Location = new Point(12, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(82, 17);
            lblId.TabIndex = 18;
            lblId.Text = "ID Producto";
            // 
            // lblListaTitulo
            // 
            lblListaTitulo.AutoSize = true;
            lblListaTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblListaTitulo.ForeColor = Color.Black;
            lblListaTitulo.Location = new Point(12, 10);
            lblListaTitulo.Name = "lblListaTitulo";
            lblListaTitulo.Size = new Size(156, 21);
            lblListaTitulo.TabIndex = 17;
            lblListaTitulo.Text = "Datos del Producto";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(txtbuscar);
            panel2.Controls.Add(dgvproductos);
            panel2.Controls.Add(btnguardar);
            panel2.Controls.Add(btnestado);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btneditar);
            panel2.Controls.Add(btnnuevo);
            panel2.Location = new Point(312, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(1303, 670);
            panel2.TabIndex = 3;
            // 
            // txtbuscar
            // 
            txtbuscar.ForeColor = Color.Gray;
            txtbuscar.Location = new Point(14, 75);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.PlaceholderText = "🔍 Buscar...";
            txtbuscar.Size = new Size(942, 23);
            txtbuscar.TabIndex = 37;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // dgvproductos
            // 
            dgvproductos.AllowUserToAddRows = false;
            dgvproductos.AllowUserToDeleteRows = false;
            dgvproductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvproductos.BackgroundColor = Color.White;
            dgvproductos.BorderStyle = BorderStyle.None;
            dgvproductos.ColumnHeadersHeight = 29;
            dgvproductos.Location = new Point(14, 110);
            dgvproductos.Name = "dgvproductos";
            dgvproductos.ReadOnly = true;
            dgvproductos.RowHeadersVisible = false;
            dgvproductos.RowHeadersWidth = 51;
            dgvproductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvproductos.Size = new Size(1199, 560);
            dgvproductos.TabIndex = 36;
            dgvproductos.CellContentClick += dgvproductos_CellContentClick;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(26, 115, 232);
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderSize = 0;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnguardar.ForeColor = SystemColors.Window;
            btnguardar.Location = new Point(14, 38);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(83, 26);
            btnguardar.TabIndex = 35;
            btnguardar.Text = "💾 Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnestado
            // 
            btnestado.BackColor = Color.White;
            btnestado.Cursor = Cursors.Hand;
            btnestado.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnestado.FlatStyle = FlatStyle.Flat;
            btnestado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnestado.ForeColor = SystemColors.Highlight;
            btnestado.Location = new Point(281, 38);
            btnestado.Name = "btnestado";
            btnestado.Size = new Size(83, 26);
            btnestado.TabIndex = 7;
            btnestado.Text = "👤 Estado";
            btnestado.UseVisualStyleBackColor = false;
            btnestado.Click += btnestado_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 10);
            label5.Name = "label5";
            label5.Size = new Size(149, 21);
            label5.TabIndex = 34;
            label5.Text = "Lista de Productos";
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.White;
            btneditar.Cursor = Cursors.Hand;
            btneditar.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btneditar.ForeColor = SystemColors.InfoText;
            btneditar.Location = new Point(192, 38);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(83, 26);
            btneditar.TabIndex = 6;
            btneditar.Text = "✎ Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btnnuevo
            // 
            btnnuevo.BackColor = Color.FromArgb(26, 115, 232);
            btnnuevo.Cursor = Cursors.Hand;
            btnnuevo.FlatAppearance.BorderSize = 0;
            btnnuevo.FlatStyle = FlatStyle.Flat;
            btnnuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnnuevo.ForeColor = Color.White;
            btnnuevo.Location = new Point(103, 38);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(83, 26);
            btnnuevo.TabIndex = 5;
            btnnuevo.Text = "+ Nuevo";
            btnnuevo.UseVisualStyleBackColor = false;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 562);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvproductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Panel panel1;
        private Label lblListaTitulo;
        private Label lblId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label2;
        private TextBox txtId;
        private TextBox txtnombre;
        private TextBox txtpreciocompra;
        private TextBox txtdescripcion;
        private TextBox txtimpuesto;
        private DateTimePicker dtpfv;
        private Label label3;
        private Panel panel2;
        private Button btnnuevo;
        private Button btneditar;
        private Label label5;
        private TextBox txtstock;
        private Label label10;
        private TextBox txtprecioventa;
        private Label label6;
        private ComboBox cbcategoria;
        private Button btnguardar;
        private DataGridView dgvproductos;
        private TextBox txtbuscar;
        private Button btnestado;
    }
}