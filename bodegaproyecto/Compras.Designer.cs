namespace bodegaproyecto
{
    partial class Compras
    {
        /// <summary>
        /// Variable necesaria para el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            grpDatosCompra = new GroupBox();
            lblIdCompra = new Label();
            txtIdCompra = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblBuscarProveedor = new Label();
            txtBuscarProveedor = new TextBox();
            btnBuscarProveedor = new Button();
            lblProveedor = new Label();
            txtProveedor = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblUsuario = new Label();
            cmbUsuario = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            grpDetalleCompra = new GroupBox();
            btnNuevoCompra = new Button();
            btnEditarCompra = new Button();
            btnRefrescar = new Button();
            txtBuscarCompra = new TextBox();
            dgvCompras = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dgvDetalleCompra = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            pnlTotales = new Panel();
            lblSubtotalTexto = new Label();
            lblSubtotalValor = new Label();
            lblIsvTexto = new Label();
            lblIsvValor = new Label();
            lblTotalTexto = new Label();
            lblTotalValor = new Label();
            grpAgregarProducto = new GroupBox();
            lblBuscarProducto = new Label();
            txtBuscarProducto = new TextBox();
            btnBuscarProducto = new Button();
            lblProducto = new Label();
            txtProducto = new TextBox();
            lblCosto = new Label();
            txtCosto = new TextBox();
            lblIsvProducto = new Label();
            txtIsvProducto = new TextBox();
            lblStockActual = new Label();
            txtStockActual = new TextBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            btnAgregarProducto = new Button();
            pnlTitulo.SuspendLayout();
            grpDatosCompra.SuspendLayout();
            grpDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).BeginInit();
            pnlTotales.SuspendLayout();
            grpAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(70, 130, 170);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1252, 55);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "COMPRAS";
            // 
            // grpDatosCompra
            // 
            grpDatosCompra.BackColor = Color.White;
            grpDatosCompra.Controls.Add(lblIdCompra);
            grpDatosCompra.Controls.Add(txtIdCompra);
            grpDatosCompra.Controls.Add(lblFecha);
            grpDatosCompra.Controls.Add(dtpFecha);
            grpDatosCompra.Controls.Add(lblBuscarProveedor);
            grpDatosCompra.Controls.Add(txtBuscarProveedor);
            grpDatosCompra.Controls.Add(btnBuscarProveedor);
            grpDatosCompra.Controls.Add(lblProveedor);
            grpDatosCompra.Controls.Add(txtProveedor);
            grpDatosCompra.Controls.Add(lblTelefono);
            grpDatosCompra.Controls.Add(txtTelefono);
            grpDatosCompra.Controls.Add(lblUsuario);
            grpDatosCompra.Controls.Add(cmbUsuario);
            grpDatosCompra.FlatStyle = FlatStyle.Flat;
            grpDatosCompra.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpDatosCompra.Location = new Point(15, 70);
            grpDatosCompra.Name = "grpDatosCompra";
            grpDatosCompra.Size = new Size(230, 540);
            grpDatosCompra.TabIndex = 1;
            grpDatosCompra.TabStop = false;
            grpDatosCompra.Text = "Datos de la Compra";
            // 
            // lblIdCompra
            // 
            lblIdCompra.AutoSize = true;
            lblIdCompra.Font = new Font("Segoe UI", 9F);
            lblIdCompra.Location = new Point(15, 30);
            lblIdCompra.Name = "lblIdCompra";
            lblIdCompra.Size = new Size(64, 15);
            lblIdCompra.TabIndex = 0;
            lblIdCompra.Text = "ID Compra";
            // 
            // txtIdCompra
            // 
            txtIdCompra.Font = new Font("Segoe UI", 9F);
            txtIdCompra.Location = new Point(15, 50);
            txtIdCompra.Name = "txtIdCompra";
            txtIdCompra.ReadOnly = true;
            txtIdCompra.Size = new Size(200, 23);
            txtIdCompra.TabIndex = 0;
            txtIdCompra.Text = "(Automático)";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.Location = new Point(15, 85);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 9F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(15, 105);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 1;
            // 
            // lblBuscarProveedor
            // 
            lblBuscarProveedor.AutoSize = true;
            lblBuscarProveedor.Font = new Font("Segoe UI", 9F);
            lblBuscarProveedor.Location = new Point(15, 140);
            lblBuscarProveedor.Name = "lblBuscarProveedor";
            lblBuscarProveedor.Size = new Size(99, 15);
            lblBuscarProveedor.TabIndex = 2;
            lblBuscarProveedor.Text = "Buscar Proveedor";
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.Font = new Font("Segoe UI", 9F);
            txtBuscarProveedor.Location = new Point(15, 160);
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(155, 23);
            txtBuscarProveedor.TabIndex = 2;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.BackColor = Color.FromArgb(0, 123, 255);
            btnBuscarProveedor.FlatStyle = FlatStyle.Flat;
            btnBuscarProveedor.Font = new Font("Segoe UI", 9F);
            btnBuscarProveedor.ForeColor = Color.White;
            btnBuscarProveedor.Location = new Point(176, 159);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(39, 25);
            btnBuscarProveedor.TabIndex = 3;
            btnBuscarProveedor.Text = "🔍";
            btnBuscarProveedor.UseVisualStyleBackColor = false;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Segoe UI", 9F);
            lblProveedor.Location = new Point(15, 195);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(61, 15);
            lblProveedor.TabIndex = 4;
            lblProveedor.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            txtProveedor.Font = new Font("Segoe UI", 9F);
            txtProveedor.Location = new Point(15, 215);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.ReadOnly = true;
            txtProveedor.Size = new Size(200, 23);
            txtProveedor.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F);
            lblTelefono.Location = new Point(15, 250);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9F);
            txtTelefono.Location = new Point(15, 270);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F);
            lblUsuario.Location = new Point(15, 305);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Font = new Font("Segoe UI", 9F);
            cmbUsuario.Location = new Point(15, 325);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(200, 23);
            cmbUsuario.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 123, 255);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(15, 430);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 33);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(230, 230, 230);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancelar.Location = new Point(126, 430);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 33);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "✖ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // grpDetalleCompra
            // 
            grpDetalleCompra.BackColor = Color.White;
            grpDetalleCompra.Controls.Add(btnNuevoCompra);
            grpDetalleCompra.Controls.Add(btnEditarCompra);
            grpDetalleCompra.Controls.Add(btnRefrescar);
            grpDetalleCompra.Controls.Add(txtBuscarCompra);
            grpDetalleCompra.Controls.Add(dgvCompras);
            grpDetalleCompra.Controls.Add(dgvDetalleCompra);
            grpDetalleCompra.Controls.Add(pnlTotales);
            grpDetalleCompra.Controls.Add(btnGuardar);
            grpDetalleCompra.Controls.Add(btnCancelar);
            grpDetalleCompra.FlatStyle = FlatStyle.Flat;
            grpDetalleCompra.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpDetalleCompra.Location = new Point(255, 70);
            grpDetalleCompra.Name = "grpDetalleCompra";
            grpDetalleCompra.Size = new Size(730, 540);
            grpDetalleCompra.TabIndex = 2;
            grpDetalleCompra.TabStop = false;
            grpDetalleCompra.Text = "Detalle de la Compra";
            // 
            // btnNuevoCompra
            // 
            btnNuevoCompra.BackColor = Color.FromArgb(0, 123, 255);
            btnNuevoCompra.FlatStyle = FlatStyle.Flat;
            btnNuevoCompra.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNuevoCompra.ForeColor = Color.White;
            btnNuevoCompra.Location = new Point(15, 30);
            btnNuevoCompra.Name = "btnNuevoCompra";
            btnNuevoCompra.Size = new Size(95, 30);
            btnNuevoCompra.TabIndex = 0;
            btnNuevoCompra.Text = "+ Nuevo";
            btnNuevoCompra.UseVisualStyleBackColor = false;
            // 
            // btnEditarCompra
            // 
            btnEditarCompra.BackColor = Color.White;
            btnEditarCompra.FlatStyle = FlatStyle.Flat;
            btnEditarCompra.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditarCompra.Location = new Point(118, 30);
            btnEditarCompra.Name = "btnEditarCompra";
            btnEditarCompra.Size = new Size(95, 30);
            btnEditarCompra.TabIndex = 1;
            btnEditarCompra.Text = "✎ Editar";
            btnEditarCompra.UseVisualStyleBackColor = false;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.White;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefrescar.Location = new Point(221, 30);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(105, 30);
            btnRefrescar.TabIndex = 2;
            btnRefrescar.Text = "↻ Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarCompra
            // 
            txtBuscarCompra.Font = new Font("Segoe UI", 9F);
            txtBuscarCompra.Location = new Point(500, 33);
            txtBuscarCompra.Name = "txtBuscarCompra";
            txtBuscarCompra.PlaceholderText = "Buscar compra...";
            txtBuscarCompra.Size = new Size(210, 23);
            txtBuscarCompra.TabIndex = 3;
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 37, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCompras.ColumnHeadersHeight = 29;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dgvCompras.Location = new Point(15, 70);
            dgvCompras.MultiSelect = false;
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.RowHeadersWidth = 51;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.Size = new Size(695, 130);
            dgvCompras.TabIndex = 4;
            dgvCompras.SelectionChanged += dgvCompras_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dgvDetalleCompra
            // 
            dgvDetalleCompra.AllowUserToAddRows = false;
            dgvDetalleCompra.AllowUserToDeleteRows = false;
            dgvDetalleCompra.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 37, 60);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalleCompra.ColumnHeadersHeight = 29;
            dgvDetalleCompra.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvDetalleCompra.Location = new Point(15, 215);
            dgvDetalleCompra.MultiSelect = false;
            dgvDetalleCompra.Name = "dgvDetalleCompra";
            dgvDetalleCompra.ReadOnly = true;
            dgvDetalleCompra.RowHeadersVisible = false;
            dgvDetalleCompra.RowHeadersWidth = 51;
            dgvDetalleCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleCompra.Size = new Size(695, 200);
            dgvDetalleCompra.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // pnlTotales
            // 
            pnlTotales.BorderStyle = BorderStyle.FixedSingle;
            pnlTotales.Controls.Add(lblSubtotalTexto);
            pnlTotales.Controls.Add(lblSubtotalValor);
            pnlTotales.Controls.Add(lblIsvTexto);
            pnlTotales.Controls.Add(lblIsvValor);
            pnlTotales.Controls.Add(lblTotalTexto);
            pnlTotales.Controls.Add(lblTotalValor);
            pnlTotales.Location = new Point(430, 430);
            pnlTotales.Name = "pnlTotales";
            pnlTotales.Size = new Size(280, 95);
            pnlTotales.TabIndex = 6;
            // 
            // lblSubtotalTexto
            // 
            lblSubtotalTexto.AutoSize = true;
            lblSubtotalTexto.Font = new Font("Segoe UI", 10F);
            lblSubtotalTexto.Location = new Point(15, 10);
            lblSubtotalTexto.Name = "lblSubtotalTexto";
            lblSubtotalTexto.Size = new Size(63, 19);
            lblSubtotalTexto.TabIndex = 0;
            lblSubtotalTexto.Text = "Subtotal:";
            // 
            // lblSubtotalValor
            // 
            lblSubtotalValor.AutoSize = true;
            lblSubtotalValor.Font = new Font("Segoe UI", 10F);
            lblSubtotalValor.Location = new Point(140, 10);
            lblSubtotalValor.Name = "lblSubtotalValor";
            lblSubtotalValor.Size = new Size(50, 19);
            lblSubtotalValor.TabIndex = 1;
            lblSubtotalValor.Text = "L. 0.00";
            // 
            // lblIsvTexto
            // 
            lblIsvTexto.AutoSize = true;
            lblIsvTexto.Font = new Font("Segoe UI", 10F);
            lblIsvTexto.Location = new Point(15, 38);
            lblIsvTexto.Name = "lblIsvTexto";
            lblIsvTexto.Size = new Size(32, 19);
            lblIsvTexto.TabIndex = 2;
            lblIsvTexto.Text = "ISV:";
            // 
            // lblIsvValor
            // 
            lblIsvValor.AutoSize = true;
            lblIsvValor.Font = new Font("Segoe UI", 10F);
            lblIsvValor.Location = new Point(140, 38);
            lblIsvValor.Name = "lblIsvValor";
            lblIsvValor.Size = new Size(50, 19);
            lblIsvValor.TabIndex = 3;
            lblIsvValor.Text = "L. 0.00";
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalTexto.ForeColor = Color.FromArgb(0, 123, 255);
            lblTotalTexto.Location = new Point(15, 65);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(60, 21);
            lblTotalTexto.TabIndex = 4;
            lblTotalTexto.Text = "TOTAL:";
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.FromArgb(0, 123, 255);
            lblTotalValor.Location = new Point(140, 65);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(57, 21);
            lblTotalValor.TabIndex = 5;
            lblTotalValor.Text = "L. 0.00";
            // 
            // grpAgregarProducto
            // 
            grpAgregarProducto.BackColor = Color.White;
            grpAgregarProducto.Controls.Add(lblBuscarProducto);
            grpAgregarProducto.Controls.Add(txtBuscarProducto);
            grpAgregarProducto.Controls.Add(btnBuscarProducto);
            grpAgregarProducto.Controls.Add(lblProducto);
            grpAgregarProducto.Controls.Add(txtProducto);
            grpAgregarProducto.Controls.Add(lblCosto);
            grpAgregarProducto.Controls.Add(txtCosto);
            grpAgregarProducto.Controls.Add(lblIsvProducto);
            grpAgregarProducto.Controls.Add(txtIsvProducto);
            grpAgregarProducto.Controls.Add(lblStockActual);
            grpAgregarProducto.Controls.Add(txtStockActual);
            grpAgregarProducto.Controls.Add(lblCantidad);
            grpAgregarProducto.Controls.Add(nudCantidad);
            grpAgregarProducto.Controls.Add(btnAgregarProducto);
            grpAgregarProducto.FlatStyle = FlatStyle.Flat;
            grpAgregarProducto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpAgregarProducto.Location = new Point(1000, 70);
            grpAgregarProducto.Name = "grpAgregarProducto";
            grpAgregarProducto.Size = new Size(258, 377);
            grpAgregarProducto.TabIndex = 3;
            grpAgregarProducto.TabStop = false;
            grpAgregarProducto.Text = "Agregar Producto";
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Font = new Font("Segoe UI", 9F);
            lblBuscarProducto.Location = new Point(15, 30);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(94, 15);
            lblBuscarProducto.TabIndex = 0;
            lblBuscarProducto.Text = "Buscar Producto";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Font = new Font("Segoe UI", 9F);
            txtBuscarProducto.Location = new Point(15, 50);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(175, 23);
            txtBuscarProducto.TabIndex = 0;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.FromArgb(0, 123, 255);
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.Font = new Font("Segoe UI", 9F);
            btnBuscarProducto.ForeColor = Color.White;
            btnBuscarProducto.Location = new Point(196, 49);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(39, 25);
            btnBuscarProducto.TabIndex = 1;
            btnBuscarProducto.Text = "🔍";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F);
            lblProducto.Location = new Point(15, 85);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Segoe UI", 9F);
            txtProducto.Location = new Point(15, 105);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(220, 23);
            txtProducto.TabIndex = 2;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 9F);
            lblCosto.Location = new Point(15, 140);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(58, 15);
            lblCosto.TabIndex = 3;
            lblCosto.Text = "Costo (L.)";
            // 
            // txtCosto
            // 
            txtCosto.Font = new Font("Segoe UI", 9F);
            txtCosto.Location = new Point(15, 160);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(220, 23);
            txtCosto.TabIndex = 3;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // lblIsvProducto
            // 
            lblIsvProducto.AutoSize = true;
            lblIsvProducto.Font = new Font("Segoe UI", 9F);
            lblIsvProducto.Location = new Point(15, 195);
            lblIsvProducto.Name = "lblIsvProducto";
            lblIsvProducto.Size = new Size(43, 15);
            lblIsvProducto.TabIndex = 4;
            lblIsvProducto.Text = "ISV (L.)";
            // 
            // txtIsvProducto
            // 
            txtIsvProducto.Font = new Font("Segoe UI", 9F);
            txtIsvProducto.Location = new Point(15, 215);
            txtIsvProducto.Name = "txtIsvProducto";
            txtIsvProducto.ReadOnly = true;
            txtIsvProducto.Size = new Size(220, 23);
            txtIsvProducto.TabIndex = 4;
            txtIsvProducto.Text = "0.00";
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Font = new Font("Segoe UI", 9F);
            lblStockActual.Location = new Point(15, 250);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(73, 15);
            lblStockActual.TabIndex = 5;
            lblStockActual.Text = "Stock Actual";
            // 
            // txtStockActual
            // 
            txtStockActual.Font = new Font("Segoe UI", 9F);
            txtStockActual.Location = new Point(15, 270);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.ReadOnly = true;
            txtStockActual.Size = new Size(105, 23);
            txtStockActual.TabIndex = 5;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F);
            lblCantidad.Location = new Point(130, 250);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 9F);
            nudCantidad.Location = new Point(130, 270);
            nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(105, 23);
            nudCantidad.TabIndex = 6;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(40, 167, 69);
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(15, 305);
            btnAgregarProducto.Margin = new Padding(4);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(231, 30);
            btnAgregarProducto.TabIndex = 7;
            btnAgregarProducto.Text = "➕ Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1252, 599);
            Controls.Add(grpAgregarProducto);
            Controls.Add(grpDetalleCompra);
            Controls.Add(grpDatosCompra);
            Controls.Add(pnlTitulo);
            Name = "Compras";
            Text = "Módulo de Compras";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            grpDatosCompra.ResumeLayout(false);
            grpDatosCompra.PerformLayout();
            grpDetalleCompra.ResumeLayout(false);
            grpDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).EndInit();
            pnlTotales.ResumeLayout(false);
            pnlTotales.PerformLayout();
            grpAgregarProducto.ResumeLayout(false);
            grpAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.GroupBox grpDatosCompra;
        private System.Windows.Forms.Label lblIdCompra;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblBuscarProveedor;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.GroupBox grpDetalleCompra;
        private System.Windows.Forms.Button btnNuevoCompra;
        private System.Windows.Forms.Button btnEditarCompra;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.TextBox txtBuscarCompra;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.Label lblSubtotalTexto;
        private System.Windows.Forms.Label lblSubtotalValor;
        private System.Windows.Forms.Label lblIsvTexto;
        private System.Windows.Forms.Label lblIsvValor;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Label lblTotalValor;

        private System.Windows.Forms.GroupBox grpAgregarProducto;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblIsvProducto;
        private System.Windows.Forms.TextBox txtIsvProducto;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregarProducto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}