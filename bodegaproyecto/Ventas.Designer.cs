namespace bodegaproyecto
{
    partial class Ventas
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        //=========================================
        // PANEL SUPERIOR
        //=========================================

        private Panel pnlHeader;
        private Label lblTituloForm;

        //=========================================
        // PANEL IZQUIERDO
        //=========================================

        private Panel pnlIzquierdo;

        private Label lblTituloDatos;

        private Label lblIDVenta;
        private TextBox txtIDVenta;

        private Label lblFecha;
        private DateTimePicker dtpFecha;

        private Label lblCliente;
        private ComboBox cmbCliente;

        private Button btnBuscarCliente;
        private Button btnNuevoCliente;

        private Label lblUsuario;
        private ComboBox cmbUsuario;

        private Label lblMetodoPago;
        private ComboBox cmbMetodoPago;

        //=========================================
        // PRODUCTOS
        //=========================================

        private Label lblTituloProducto;

        private Label lblBuscarProducto;
        private TextBox txtBuscarProducto;
        private Button btnBuscarProducto;

        private Label lblProducto;
        private TextBox txtProducto;

        private Label lblPrecio;
        private TextBox txtPrecio;

        private Label lblImpuesto;
        private TextBox txtImpuesto;

        private Label lblStock;
        private TextBox txtStock;

        private Label lblCantidad;
        private NumericUpDown nudCantidad;

        private Button btnAgregarProducto;

        //=========================================
        // PANEL DERECHO
        //=========================================

        private Panel pnlDerecho;

        private Label lblTituloDetalle;

        private DataGridView dgvVentas;

        //=========================================
        // TOTALES
        //=========================================

        private Panel pnlTotales;

        private Label lblSubtotalTexto;
        private Label lblSubtotal;

        private Label lblImpuestoTexto;
        private Label lblImpuestoValor;

        private Label lblTotalTexto;
        private Label lblTotalValor;

        //=========================================
        // BOTONES
        //=========================================

        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnNuevo;
        private Button btnActualizar;
        private Button btnEditar;

        //=========================================
        // BUSCADOR
        //=========================================

        private TextBox txtBuscar;


        /// <summary>
        /// Limpiar recursos.
        /// </summary>
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
            btnBuscarCliente = new Button();
            btnNuevoCliente = new Button();
            lblUsuario = new Label();
            cmbUsuario = new ComboBox();
            lblMetodoPago = new Label();
            cmbMetodoPago = new ComboBox();
            lblTituloProducto = new Label();
            lblBuscarProducto = new Label();
            txtBuscarProducto = new TextBox();
            btnBuscarProducto = new Button();
            lblProducto = new Label();
            txtProducto = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblImpuesto = new Label();
            txtImpuesto = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            btnAgregarProducto = new Button();
            pnlDerecho = new Panel();
            lblTituloDetalle = new Label();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnActualizar = new Button();
            txtBuscar = new TextBox();
            dgvVentas = new DataGridView();
            pnlTotales = new Panel();
            lblSubtotalTexto = new Label();
            lblSubtotal = new Label();
            lblImpuestoTexto = new Label();
            lblImpuestoValor = new Label();
            lblTotalTexto = new Label();
            lblTotalValor = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            pnlHeader.SuspendLayout();
            pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            pnlDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            pnlTotales.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTituloForm);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1920, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(20, 16);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(118, 37);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "VENTAS";
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
            pnlIzquierdo.Controls.Add(btnBuscarCliente);
            pnlIzquierdo.Controls.Add(btnNuevoCliente);
            pnlIzquierdo.Controls.Add(lblUsuario);
            pnlIzquierdo.Controls.Add(cmbUsuario);
            pnlIzquierdo.Controls.Add(lblMetodoPago);
            pnlIzquierdo.Controls.Add(cmbMetodoPago);
            pnlIzquierdo.Location = new Point(12, 82);
            pnlIzquierdo.Name = "pnlIzquierdo";
            pnlIzquierdo.Size = new Size(350, 693);
            pnlIzquierdo.TabIndex = 1;
            // 
            // lblTituloDatos
            // 
            lblTituloDatos.AutoSize = true;
            lblTituloDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloDatos.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloDatos.Location = new Point(18, 18);
            lblTituloDatos.Name = "lblTituloDatos";
            lblTituloDatos.Size = new Size(179, 28);
            lblTituloDatos.TabIndex = 0;
            lblTituloDatos.Text = "Datos de la Venta";
            // 
            // lblIDVenta
            // 
            lblIDVenta.AutoSize = true;
            lblIDVenta.Location = new Point(18, 65);
            lblIDVenta.Name = "lblIDVenta";
            lblIDVenta.Size = new Size(65, 20);
            lblIDVenta.TabIndex = 1;
            lblIDVenta.Text = "ID Venta";
            // 
            // txtIDVenta
            // 
            txtIDVenta.BackColor = Color.FromArgb(245, 245, 245);
            txtIDVenta.Enabled = false;
            txtIDVenta.Location = new Point(18, 88);
            txtIDVenta.Name = "txtIDVenta";
            txtIDVenta.Size = new Size(310, 27);
            txtIDVenta.TabIndex = 0;
            txtIDVenta.Text = "(Automático)";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(18, 128);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(18, 151);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(310, 27);
            dtpFecha.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(18, 192);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Location = new Point(18, 215);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(310, 28);
            cmbCliente.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackColor = Color.FromArgb(26, 115, 232);
            btnBuscarCliente.Cursor = Cursors.Hand;
            btnBuscarCliente.FlatAppearance.BorderSize = 0;
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.ForeColor = Color.White;
            btnBuscarCliente.Location = new Point(18, 253);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(145, 36);
            btnBuscarCliente.TabIndex = 3;
            btnBuscarCliente.Text = "🔍 Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.SeaGreen;
            btnNuevoCliente.Cursor = Cursors.Hand;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.ForeColor = Color.White;
            btnNuevoCliente.Location = new Point(183, 253);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(145, 36);
            btnNuevoCliente.TabIndex = 4;
            btnNuevoCliente.Text = "+ Nuevo";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(18, 306);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Enabled = false;
            cmbUsuario.Location = new Point(18, 329);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(310, 28);
            cmbUsuario.TabIndex = 5;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(18, 370);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(120, 20);
            lblMetodoPago.TabIndex = 6;
            lblMetodoPago.Text = "Método de Pago";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            cmbMetodoPago.Location = new Point(18, 393);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(310, 28);
            cmbMetodoPago.TabIndex = 6;
            // 
            // lblTituloProducto
            // 
            lblTituloProducto.AutoSize = true;
            lblTituloProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloProducto.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloProducto.Location = new Point(20, 18);
            lblTituloProducto.Name = "lblTituloProducto";
            lblTituloProducto.Size = new Size(180, 28);
            lblTituloProducto.TabIndex = 7;
            lblTituloProducto.Text = "Agregar Producto";
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new Point(20, 53);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(116, 20);
            lblBuscarProducto.TabIndex = 8;
            lblBuscarProducto.Text = "Buscar Producto";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(20, 76);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(230, 27);
            txtBuscarProducto.TabIndex = 7;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.FromArgb(26, 115, 232);
            btnBuscarProducto.Cursor = Cursors.Hand;
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.ForeColor = Color.White;
            btnBuscarProducto.Location = new Point(260, 75);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(70, 29);
            btnBuscarProducto.TabIndex = 8;
            btnBuscarProducto.Text = "🔍";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(20, 115);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 9;
            lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.WhiteSmoke;
            txtProducto.Location = new Point(20, 138);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(310, 27);
            txtProducto.TabIndex = 9;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(20, 177);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.WhiteSmoke;
            txtPrecio.Location = new Point(20, 200);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(145, 27);
            txtPrecio.TabIndex = 10;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(185, 177);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(30, 20);
            lblImpuesto.TabIndex = 11;
            lblImpuesto.Text = "ISV";
            // 
            // txtImpuesto
            // 
            txtImpuesto.BackColor = Color.WhiteSmoke;
            txtImpuesto.Location = new Point(185, 200);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.ReadOnly = true;
            txtImpuesto.Size = new Size(145, 27);
            txtImpuesto.TabIndex = 11;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(20, 239);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(121, 20);
            lblStock.TabIndex = 12;
            lblStock.Text = "Stock Disponible";
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.WhiteSmoke;
            txtStock.Location = new Point(20, 262);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(145, 27);
            txtStock.TabIndex = 12;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(185, 239);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 13;
            lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(185, 262);
            nudCantidad.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(145, 27);
            nudCantidad.TabIndex = 13;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.SeaGreen;
            btnAgregarProducto.Cursor = Cursors.Hand;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(20, 313);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(310, 42);
            btnAgregarProducto.TabIndex = 14;
            btnAgregarProducto.Text = "+ Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // pnlDerecho
            // 
            pnlDerecho.BackColor = Color.White;
            pnlDerecho.Controls.Add(lblTituloDetalle);
            pnlDerecho.Controls.Add(btnNuevo);
            pnlDerecho.Controls.Add(btnEditar);
            pnlDerecho.Controls.Add(btnActualizar);
            pnlDerecho.Controls.Add(txtBuscar);
            pnlDerecho.Controls.Add(dgvVentas);
            pnlDerecho.Controls.Add(pnlTotales);
            pnlDerecho.Controls.Add(btnGuardar);
            pnlDerecho.Controls.Add(btnCancelar);
            pnlDerecho.Location = new Point(386, 82);
            pnlDerecho.Name = "pnlDerecho";
            pnlDerecho.Size = new Size(1150, 693);
            pnlDerecho.TabIndex = 2;
            // 
            // lblTituloDetalle
            // 
            lblTituloDetalle.AutoSize = true;
            lblTituloDetalle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloDetalle.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloDetalle.Location = new Point(20, 18);
            lblTituloDetalle.Name = "lblTituloDetalle";
            lblTituloDetalle.Size = new Size(192, 28);
            lblTituloDetalle.TabIndex = 0;
            lblTituloDetalle.Text = "Detalle de la Venta";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(26, 115, 232);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(20, 55);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 40);
            btnNuevo.TabIndex = 15;
            btnNuevo.Text = "+ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(130, 55);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 40);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "✏ Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.White;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderColor = Color.Silver;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Location = new Point(240, 55);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(110, 40);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "↻ Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(861, 62);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar venta...";
            txtBuscar.Size = new Size(270, 27);
            txtBuscar.TabIndex = 18;
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
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.ColumnHeadersHeight = 40;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.Location = new Point(20, 110);
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
            dgvVentas.Size = new Size(1102, 433);
            dgvVentas.TabIndex = 19;
            // 
            // pnlTotales
            // 
            pnlTotales.BackColor = Color.FromArgb(248, 250, 252);
            pnlTotales.BorderStyle = BorderStyle.FixedSingle;
            pnlTotales.Controls.Add(lblSubtotalTexto);
            pnlTotales.Controls.Add(lblSubtotal);
            pnlTotales.Controls.Add(lblImpuestoTexto);
            pnlTotales.Controls.Add(lblImpuestoValor);
            pnlTotales.Controls.Add(lblTotalTexto);
            pnlTotales.Controls.Add(lblTotalValor);
            pnlTotales.Location = new Point(751, 561);
            pnlTotales.Name = "pnlTotales";
            pnlTotales.Size = new Size(380, 115);
            pnlTotales.TabIndex = 20;
            // 
            // lblSubtotalTexto
            // 
            lblSubtotalTexto.AutoSize = true;
            lblSubtotalTexto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtotalTexto.Location = new Point(18, 15);
            lblSubtotalTexto.Name = "lblSubtotalTexto";
            lblSubtotalTexto.Size = new Size(84, 23);
            lblSubtotalTexto.TabIndex = 0;
            lblSubtotalTexto.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10F);
            lblSubtotal.Location = new Point(140, 15);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(58, 23);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "L. 0.00";
            // 
            // lblImpuestoTexto
            // 
            lblImpuestoTexto.AutoSize = true;
            lblImpuestoTexto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblImpuestoTexto.Location = new Point(18, 45);
            lblImpuestoTexto.Name = "lblImpuestoTexto";
            lblImpuestoTexto.Size = new Size(41, 23);
            lblImpuestoTexto.TabIndex = 2;
            lblImpuestoTexto.Text = "ISV:";
            // 
            // lblImpuestoValor
            // 
            lblImpuestoValor.AutoSize = true;
            lblImpuestoValor.Font = new Font("Segoe UI", 10F);
            lblImpuestoValor.Location = new Point(140, 45);
            lblImpuestoValor.Name = "lblImpuestoValor";
            lblImpuestoValor.Size = new Size(58, 23);
            lblImpuestoValor.TabIndex = 3;
            lblImpuestoValor.Text = "L. 0.00";
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalTexto.ForeColor = Color.FromArgb(26, 115, 232);
            lblTotalTexto.Location = new Point(18, 78);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(77, 28);
            lblTotalTexto.TabIndex = 4;
            lblTotalTexto.Text = "TOTAL:";
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.FromArgb(26, 115, 232);
            lblTotalValor.Location = new Point(140, 78);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(74, 28);
            lblTotalValor.TabIndex = 5;
            lblTotalValor.Text = "L. 0.00";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(26, 115, 232);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(40, 597);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 45);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(220, 220, 220);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(200, 597);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 45);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "✖ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTituloProducto);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(txtProducto);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(lblProducto);
            panel1.Controls.Add(lblImpuesto);
            panel1.Controls.Add(btnBuscarProducto);
            panel1.Controls.Add(txtImpuesto);
            panel1.Controls.Add(txtBuscarProducto);
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(btnAgregarProducto);
            panel1.Controls.Add(lblBuscarProducto);
            panel1.Controls.Add(nudCantidad);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(lblCantidad);
            panel1.Location = new Point(1558, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 693);
            panel1.TabIndex = 3;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1920, 803);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Controls.Add(pnlIzquierdo);
            Controls.Add(pnlDerecho);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlIzquierdo.ResumeLayout(false);
            pnlIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            pnlDerecho.ResumeLayout(false);
            pnlDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            pnlTotales.ResumeLayout(false);
            pnlTotales.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }


        #endregion

        private Panel panel1;
    }
}