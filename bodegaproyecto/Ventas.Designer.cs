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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTituloForm = new Label();
            pnlIzquierdo = new Panel();
            cmbTipoCliente = new ComboBox();
            lblTipoCliente = new Label();
            btnNuevoCliente = new Button();
            txtDNICliente = new Label();
            txtNombreCliente = new TextBox();
            txtClienteDNI = new TextBox();
            lblNombreCliente = new Label();
            btnBuscarCliente = new Button();
            txtBuscarCliente = new TextBox();
            lblTituloDatos = new Label();
            lblIDVenta = new Label();
            txtIDVenta = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblCliente = new Label();
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
            BTverRembolso = new Button();
            dgvDetallesVentas = new DataGridView();
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
            LBlRembolso = new Label();
            label1 = new Label();
            TXTProductoRembolso = new TextBox();
            lbcantidadRembolso = new Label();
            nudCantidadRembolso = new NumericUpDown();
            plRembolso = new Panel();
            lbldescripcion = new Label();
            BTrembolso = new Button();
            txtDescripcion = new TextBox();
            pnlHeader.SuspendLayout();
            pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            pnlDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            pnlTotales.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadRembolso).BeginInit();
            plRembolso.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTituloForm);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1680, 52);
            pnlHeader.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(18, 12);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(95, 30);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "VENTAS";
            // 
            // pnlIzquierdo
            // 
            pnlIzquierdo.BackColor = Color.White;
            pnlIzquierdo.Controls.Add(cmbTipoCliente);
            pnlIzquierdo.Controls.Add(lblTipoCliente);
            pnlIzquierdo.Controls.Add(btnNuevoCliente);
            pnlIzquierdo.Controls.Add(txtDNICliente);
            pnlIzquierdo.Controls.Add(txtNombreCliente);
            pnlIzquierdo.Controls.Add(txtClienteDNI);
            pnlIzquierdo.Controls.Add(lblNombreCliente);
            pnlIzquierdo.Controls.Add(btnBuscarCliente);
            pnlIzquierdo.Controls.Add(txtBuscarCliente);
            pnlIzquierdo.Controls.Add(lblTituloDatos);
            pnlIzquierdo.Controls.Add(lblIDVenta);
            pnlIzquierdo.Controls.Add(txtIDVenta);
            pnlIzquierdo.Controls.Add(lblFecha);
            pnlIzquierdo.Controls.Add(dtpFecha);
            pnlIzquierdo.Controls.Add(lblCliente);
            pnlIzquierdo.Controls.Add(lblUsuario);
            pnlIzquierdo.Controls.Add(cmbUsuario);
            pnlIzquierdo.Controls.Add(lblMetodoPago);
            pnlIzquierdo.Controls.Add(cmbMetodoPago);
            pnlIzquierdo.Location = new Point(10, 62);
            pnlIzquierdo.Margin = new Padding(3, 2, 3, 2);
            pnlIzquierdo.Name = "pnlIzquierdo";
            pnlIzquierdo.Size = new Size(306, 520);
            pnlIzquierdo.TabIndex = 1;
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoCliente.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            cmbTipoCliente.Location = new Point(16, 166);
            cmbTipoCliente.Margin = new Padding(3, 2, 3, 2);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(157, 23);
            cmbTipoCliente.TabIndex = 18;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(16, 149);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(71, 15);
            lblTipoCliente.TabIndex = 17;
            lblTipoCliente.Text = "Tipo Cliente";
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.SeaGreen;
            btnNuevoCliente.Cursor = Cursors.Hand;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.ForeColor = Color.White;
            btnNuevoCliente.Location = new Point(189, 166);
            btnNuevoCliente.Margin = new Padding(3, 2, 3, 2);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(98, 22);
            btnNuevoCliente.TabIndex = 4;
            btnNuevoCliente.Text = "+ Nuevo";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // txtDNICliente
            // 
            txtDNICliente.AutoSize = true;
            txtDNICliente.Location = new Point(16, 292);
            txtDNICliente.Name = "txtDNICliente";
            txtDNICliente.Size = new Size(27, 15);
            txtDNICliente.TabIndex = 15;
            txtDNICliente.Text = "DNI";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = Color.WhiteSmoke;
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Location = new Point(16, 263);
            txtNombreCliente.Margin = new Padding(3, 2, 3, 2);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.ReadOnly = true;
            txtNombreCliente.Size = new Size(272, 23);
            txtNombreCliente.TabIndex = 13;
            // 
            // txtClienteDNI
            // 
            txtClienteDNI.BackColor = Color.WhiteSmoke;
            txtClienteDNI.Enabled = false;
            txtClienteDNI.Location = new Point(16, 310);
            txtClienteDNI.Margin = new Padding(3, 2, 3, 2);
            txtClienteDNI.Name = "txtClienteDNI";
            txtClienteDNI.ReadOnly = true;
            txtClienteDNI.Size = new Size(272, 23);
            txtClienteDNI.TabIndex = 16;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(16, 246);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(44, 15);
            lblNombreCliente.TabIndex = 14;
            lblNombreCliente.Text = "Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackColor = Color.FromArgb(26, 115, 232);
            btnBuscarCliente.Cursor = Cursors.Hand;
            btnBuscarCliente.FlatAppearance.BorderSize = 0;
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.ForeColor = Color.White;
            btnBuscarCliente.Location = new Point(189, 216);
            btnBuscarCliente.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(98, 22);
            btnBuscarCliente.TabIndex = 12;
            btnBuscarCliente.Text = "🔍";
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click_1;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(16, 217);
            txtBuscarCliente.Margin = new Padding(3, 2, 3, 2);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(157, 23);
            txtBuscarCliente.TabIndex = 11;
            // 
            // lblTituloDatos
            // 
            lblTituloDatos.AutoSize = true;
            lblTituloDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloDatos.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloDatos.Location = new Point(16, 14);
            lblTituloDatos.Name = "lblTituloDatos";
            lblTituloDatos.Size = new Size(143, 21);
            lblTituloDatos.TabIndex = 0;
            lblTituloDatos.Text = "Datos de la Venta";
            // 
            // lblIDVenta
            // 
            lblIDVenta.AutoSize = true;
            lblIDVenta.Location = new Point(16, 49);
            lblIDVenta.Name = "lblIDVenta";
            lblIDVenta.Size = new Size(50, 15);
            lblIDVenta.TabIndex = 1;
            lblIDVenta.Text = "ID Venta";
            // 
            // txtIDVenta
            // 
            txtIDVenta.BackColor = Color.FromArgb(245, 245, 245);
            txtIDVenta.Enabled = false;
            txtIDVenta.Location = new Point(16, 66);
            txtIDVenta.Margin = new Padding(3, 2, 3, 2);
            txtIDVenta.Name = "txtIDVenta";
            txtIDVenta.Size = new Size(272, 23);
            txtIDVenta.TabIndex = 0;
            txtIDVenta.Text = "(Automático)";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(16, 96);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(16, 113);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(272, 23);
            dtpFecha.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(16, 202);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(82, 15);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Buscar Cliente";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(16, 346);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Enabled = false;
            cmbUsuario.Location = new Point(16, 363);
            cmbUsuario.Margin = new Padding(3, 2, 3, 2);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(272, 23);
            cmbUsuario.TabIndex = 5;
            cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(16, 394);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(95, 15);
            lblMetodoPago.TabIndex = 6;
            lblMetodoPago.Text = "Método de Pago";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            cmbMetodoPago.Location = new Point(16, 411);
            cmbMetodoPago.Margin = new Padding(3, 2, 3, 2);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(272, 23);
            cmbMetodoPago.TabIndex = 6;
            // 
            // lblTituloProducto
            // 
            lblTituloProducto.AutoSize = true;
            lblTituloProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloProducto.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloProducto.Location = new Point(18, 14);
            lblTituloProducto.Name = "lblTituloProducto";
            lblTituloProducto.Size = new Size(145, 21);
            lblTituloProducto.TabIndex = 7;
            lblTituloProducto.Text = "Agregar Producto";
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new Point(18, 40);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(94, 15);
            lblBuscarProducto.TabIndex = 8;
            lblBuscarProducto.Text = "Buscar Producto";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(18, 57);
            txtBuscarProducto.Margin = new Padding(3, 2, 3, 2);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(202, 23);
            txtBuscarProducto.TabIndex = 7;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.FromArgb(26, 115, 232);
            btnBuscarProducto.Cursor = Cursors.Hand;
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.ForeColor = Color.White;
            btnBuscarProducto.Location = new Point(228, 56);
            btnBuscarProducto.Margin = new Padding(3, 2, 3, 2);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(61, 22);
            btnBuscarProducto.TabIndex = 8;
            btnBuscarProducto.Text = "🔍";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(18, 86);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 9;
            lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.WhiteSmoke;
            txtProducto.Enabled = false;
            txtProducto.Location = new Point(18, 104);
            txtProducto.Margin = new Padding(3, 2, 3, 2);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(272, 23);
            txtProducto.TabIndex = 9;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(18, 133);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.WhiteSmoke;
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(18, 150);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(127, 23);
            txtPrecio.TabIndex = 10;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(162, 133);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(23, 15);
            lblImpuesto.TabIndex = 11;
            lblImpuesto.Text = "ISV";
            // 
            // txtImpuesto
            // 
            txtImpuesto.BackColor = Color.WhiteSmoke;
            txtImpuesto.Enabled = false;
            txtImpuesto.Location = new Point(162, 150);
            txtImpuesto.Margin = new Padding(3, 2, 3, 2);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.ReadOnly = true;
            txtImpuesto.Size = new Size(127, 23);
            txtImpuesto.TabIndex = 11;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(18, 179);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(95, 15);
            lblStock.TabIndex = 12;
            lblStock.Text = "Stock Disponible";
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.WhiteSmoke;
            txtStock.Enabled = false;
            txtStock.Location = new Point(18, 196);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(127, 23);
            txtStock.TabIndex = 12;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(162, 179);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 13;
            lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(162, 196);
            nudCantidad.Margin = new Padding(3, 2, 3, 2);
            nudCantidad.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(127, 23);
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
            btnAgregarProducto.Location = new Point(18, 235);
            btnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(271, 32);
            btnAgregarProducto.TabIndex = 14;
            btnAgregarProducto.Text = "+ Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // pnlDerecho
            // 
            pnlDerecho.BackColor = Color.White;
            pnlDerecho.Controls.Add(BTverRembolso);
            pnlDerecho.Controls.Add(dgvDetallesVentas);
            pnlDerecho.Controls.Add(lblTituloDetalle);
            pnlDerecho.Controls.Add(btnNuevo);
            pnlDerecho.Controls.Add(btnEditar);
            pnlDerecho.Controls.Add(btnActualizar);
            pnlDerecho.Controls.Add(txtBuscar);
            pnlDerecho.Controls.Add(dgvVentas);
            pnlDerecho.Controls.Add(pnlTotales);
            pnlDerecho.Controls.Add(btnGuardar);
            pnlDerecho.Controls.Add(btnCancelar);
            pnlDerecho.Location = new Point(338, 62);
            pnlDerecho.Margin = new Padding(3, 2, 3, 2);
            pnlDerecho.Name = "pnlDerecho";
            pnlDerecho.Size = new Size(1006, 551);
            pnlDerecho.TabIndex = 2;
            // 
            // BTverRembolso
            // 
            BTverRembolso.BackColor = Color.FromArgb(26, 115, 232);
            BTverRembolso.Cursor = Cursors.Hand;
            BTverRembolso.FlatAppearance.BorderSize = 0;
            BTverRembolso.FlatStyle = FlatStyle.Flat;
            BTverRembolso.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTverRembolso.ForeColor = Color.White;
            BTverRembolso.Location = new Point(312, 41);
            BTverRembolso.Margin = new Padding(3, 2, 3, 2);
            BTverRembolso.Name = "BTverRembolso";
            BTverRembolso.Size = new Size(88, 30);
            BTverRembolso.TabIndex = 23;
            BTverRembolso.Text = "Ver Rembolso";
            BTverRembolso.UseVisualStyleBackColor = false;
            BTverRembolso.Click += BTverRembolso_Click;
            // 
            // dgvDetallesVentas
            // 
            dgvDetallesVentas.AllowUserToAddRows = false;
            dgvDetallesVentas.AllowUserToDeleteRows = false;
            dgvDetallesVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(248, 250, 252);
            dgvDetallesVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvDetallesVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesVentas.BackgroundColor = Color.White;
            dgvDetallesVentas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvDetallesVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvDetallesVentas.ColumnHeadersHeight = 40;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvDetallesVentas.DefaultCellStyle = dataGridViewCellStyle11;
            dgvDetallesVentas.EnableHeadersVisualStyles = false;
            dgvDetallesVentas.Location = new Point(18, 263);
            dgvDetallesVentas.Margin = new Padding(3, 2, 3, 2);
            dgvDetallesVentas.MultiSelect = false;
            dgvDetallesVentas.Name = "dgvDetallesVentas";
            dgvDetallesVentas.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvDetallesVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvDetallesVentas.RowHeadersVisible = false;
            dgvDetallesVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(210, 227, 252);
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dgvDetallesVentas.RowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvDetallesVentas.RowTemplate.Height = 35;
            dgvDetallesVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetallesVentas.Size = new Size(964, 168);
            dgvDetallesVentas.TabIndex = 22;
            // 
            // lblTituloDetalle
            // 
            lblTituloDetalle.AutoSize = true;
            lblTituloDetalle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloDetalle.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloDetalle.Location = new Point(18, 14);
            lblTituloDetalle.Name = "lblTituloDetalle";
            lblTituloDetalle.Size = new Size(154, 21);
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
            btnNuevo.Location = new Point(18, 41);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(88, 30);
            btnNuevo.TabIndex = 15;
            btnNuevo.Text = "+ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(114, 41);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 30);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "✏ Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.White;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderColor = Color.Silver;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Location = new Point(210, 41);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(96, 30);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "↻ Refrescar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(753, 46);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar venta...";
            txtBuscar.Size = new Size(237, 23);
            txtBuscar.TabIndex = 18;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(248, 250, 252);
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvVentas.ColumnHeadersHeight = 40;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.Location = new Point(18, 75);
            dgvVentas.Margin = new Padding(3, 2, 3, 2);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(210, 227, 252);
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvVentas.RowTemplate.Height = 35;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(964, 174);
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
            pnlTotales.Location = new Point(649, 435);
            pnlTotales.Margin = new Padding(3, 2, 3, 2);
            pnlTotales.Name = "pnlTotales";
            pnlTotales.Size = new Size(333, 100);
            pnlTotales.TabIndex = 20;
            pnlTotales.Paint += pnlTotales_Paint;
            // 
            // lblSubtotalTexto
            // 
            lblSubtotalTexto.AutoSize = true;
            lblSubtotalTexto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtotalTexto.Location = new Point(16, 11);
            lblSubtotalTexto.Name = "lblSubtotalTexto";
            lblSubtotalTexto.Size = new Size(69, 19);
            lblSubtotalTexto.TabIndex = 0;
            lblSubtotalTexto.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10F);
            lblSubtotal.Location = new Point(122, 11);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(50, 19);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "L. 0.00";
            // 
            // lblImpuestoTexto
            // 
            lblImpuestoTexto.AutoSize = true;
            lblImpuestoTexto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblImpuestoTexto.Location = new Point(16, 34);
            lblImpuestoTexto.Name = "lblImpuestoTexto";
            lblImpuestoTexto.Size = new Size(34, 19);
            lblImpuestoTexto.TabIndex = 2;
            lblImpuestoTexto.Text = "ISV:";
            // 
            // lblImpuestoValor
            // 
            lblImpuestoValor.AutoSize = true;
            lblImpuestoValor.Font = new Font("Segoe UI", 10F);
            lblImpuestoValor.Location = new Point(122, 34);
            lblImpuestoValor.Name = "lblImpuestoValor";
            lblImpuestoValor.Size = new Size(50, 19);
            lblImpuestoValor.TabIndex = 3;
            lblImpuestoValor.Text = "L. 0.00";
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalTexto.ForeColor = Color.FromArgb(26, 115, 232);
            lblTotalTexto.Location = new Point(16, 58);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(60, 21);
            lblTotalTexto.TabIndex = 4;
            lblTotalTexto.Text = "TOTAL:";
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.FromArgb(26, 115, 232);
            lblTotalValor.Location = new Point(122, 58);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(57, 21);
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
            btnGuardar.Location = new Point(38, 470);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 34);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(220, 220, 220);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(175, 470);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 34);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "✖ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
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
            panel1.Location = new Point(1363, 62);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 286);
            panel1.TabIndex = 3;
            // 
            // LBlRembolso
            // 
            LBlRembolso.AutoSize = true;
            LBlRembolso.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LBlRembolso.ForeColor = Color.FromArgb(26, 42, 74);
            LBlRembolso.Location = new Point(19, 16);
            LBlRembolso.Name = "LBlRembolso";
            LBlRembolso.Size = new Size(165, 21);
            LBlRembolso.TabIndex = 15;
            LBlRembolso.Text = "Rembolsar Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 54);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 16;
            label1.Text = "Producto";
            // 
            // TXTProductoRembolso
            // 
            TXTProductoRembolso.BackColor = Color.WhiteSmoke;
            TXTProductoRembolso.Enabled = false;
            TXTProductoRembolso.Location = new Point(19, 71);
            TXTProductoRembolso.Margin = new Padding(3, 2, 3, 2);
            TXTProductoRembolso.Name = "TXTProductoRembolso";
            TXTProductoRembolso.ReadOnly = true;
            TXTProductoRembolso.Size = new Size(219, 23);
            TXTProductoRembolso.TabIndex = 17;
            // 
            // lbcantidadRembolso
            // 
            lbcantidadRembolso.AutoSize = true;
            lbcantidadRembolso.Location = new Point(19, 102);
            lbcantidadRembolso.Name = "lbcantidadRembolso";
            lbcantidadRembolso.Size = new Size(55, 15);
            lbcantidadRembolso.TabIndex = 18;
            lbcantidadRembolso.Text = "Cantidad";
            // 
            // nudCantidadRembolso
            // 
            nudCantidadRembolso.Location = new Point(19, 120);
            nudCantidadRembolso.Margin = new Padding(3, 2, 3, 2);
            nudCantidadRembolso.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudCantidadRembolso.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadRembolso.Name = "nudCantidadRembolso";
            nudCantidadRembolso.Size = new Size(127, 23);
            nudCantidadRembolso.TabIndex = 19;
            nudCantidadRembolso.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // plRembolso
            // 
            plRembolso.BackColor = Color.White;
            plRembolso.Controls.Add(txtDescripcion);
            plRembolso.Controls.Add(lbldescripcion);
            plRembolso.Controls.Add(nudCantidadRembolso);
            plRembolso.Controls.Add(BTrembolso);
            plRembolso.Controls.Add(LBlRembolso);
            plRembolso.Controls.Add(label1);
            plRembolso.Controls.Add(TXTProductoRembolso);
            plRembolso.Controls.Add(lbcantidadRembolso);
            plRembolso.Location = new Point(1362, 354);
            plRembolso.Margin = new Padding(3, 2, 3, 2);
            plRembolso.Name = "plRembolso";
            plRembolso.Size = new Size(306, 259);
            plRembolso.TabIndex = 15;
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.Location = new Point(19, 159);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(68, 15);
            lbldescripcion.TabIndex = 20;
            lbldescripcion.Text = "descripcion";
            lbldescripcion.Click += lbldescripcion_Click;
            // 
            // BTrembolso
            // 
            BTrembolso.BackColor = Color.SeaGreen;
            BTrembolso.Cursor = Cursors.Hand;
            BTrembolso.FlatAppearance.BorderSize = 0;
            BTrembolso.FlatStyle = FlatStyle.Flat;
            BTrembolso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTrembolso.ForeColor = Color.White;
            BTrembolso.Location = new Point(19, 211);
            BTrembolso.Margin = new Padding(3, 2, 3, 2);
            BTrembolso.Name = "BTrembolso";
            BTrembolso.Size = new Size(271, 32);
            BTrembolso.TabIndex = 14;
            BTrembolso.Text = "+ hacer rembolso";
            BTrembolso.UseVisualStyleBackColor = false;
            BTrembolso.Click += BTrembolso_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(19, 177);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.MaxLength = 250;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(202, 23);
            txtDescripcion.TabIndex = 21;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1680, 641);
            Controls.Add(plRembolso);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Controls.Add(pnlIzquierdo);
            Controls.Add(pnlDerecho);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            pnlTotales.ResumeLayout(false);
            pnlTotales.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadRembolso).EndInit();
            plRembolso.ResumeLayout(false);
            plRembolso.PerformLayout();
            ResumeLayout(false);

        }


        #endregion

        private Panel panel1;
        private DataGridView dgvDetallesVentas;
        private Label txtDNICliente;
        private TextBox txtNombreCliente;
        private TextBox txtClienteDNI;
        private Label lblNombreCliente;
        private Button btnBuscarCliente;
        private TextBox txtBuscarCliente;
        private ComboBox cmbTipoCliente;
        private Label lblTipoCliente;
        private Label LBlRembolso;
        private NumericUpDown nudCantidadRembolso;
        private Label lbcantidadRembolso;
        private TextBox TXTProductoRembolso;
        private Label label1;
        private Button BTrembolso;
        private Panel plRembolso;
        private Button BTverRembolso;
        private Label lbldescripcion;
        private TextBox txtDescripcion;
    }
}