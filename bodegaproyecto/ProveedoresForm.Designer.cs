namespace bodegaproyecto
{
    partial class ProveedoresForm
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
            lblRegistros = new Label();
            lblSeccion = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblAlerta = new Label();
            lblListaTitulo = new Label();
            txtBuscar = new TextBox();
            dgvProveedores = new DataGridView();
            btnEstado = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblRegistros);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1464, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(15, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(198, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🏷️ Proveedores";
            // 
            // lblRegistros
            // 
            lblRegistros.BackColor = Color.FromArgb(60, 140, 210);
            lblRegistros.Dock = DockStyle.Right;
            lblRegistros.ForeColor = Color.White;
            lblRegistros.Location = new Point(1354, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(110, 60);
            lblRegistros.TabIndex = 1;
            lblRegistros.Text = "0 registros";
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSeccion.ForeColor = Color.FromArgb(70, 130, 180);
            lblSeccion.Location = new Point(20, 80);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(164, 20);
            lblSeccion.TabIndex = 1;
            lblSeccion.Text = "DATOS DEL REGISTRO";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 110);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 23);
            lblId.TabIndex = 2;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(235, 245, 255);
            txtId.ForeColor = Color.DarkBlue;
            txtId.Location = new Point(20, 130);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(280, 30);
            txtId.TabIndex = 3;
            txtId.Text = "ID: Automático";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 170);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(168, 23);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre proveedor *";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Location = new Point(20, 190);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 30);
            txtNombre.TabIndex = 5;
            txtNombre.Text = "Ej: Distribuidora Norte...";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(20, 230);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 23);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.ForeColor = Color.Gray;
            txtTelefono.Location = new Point(20, 250);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(280, 30);
            txtTelefono.TabIndex = 7;
            txtTelefono.Text = "Ej: 9999-1111";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(20, 290);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(62, 23);
            lblCorreo.TabIndex = 8;
            lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.ForeColor = Color.Gray;
            txtCorreo.Location = new Point(20, 310);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(280, 30);
            txtCorreo.TabIndex = 9;
            txtCorreo.Text = "Ej: proveedor@gmail.com";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(20, 350);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(81, 23);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.ForeColor = Color.Gray;
            txtDireccion.Location = new Point(20, 370);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(280, 65);
            txtDireccion.TabIndex = 11;
            txtDireccion.Text = "Ej: Tegucigalpa...";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(20, 450);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(280, 35);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(20, 503);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(280, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "✕ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // lblAlerta
            // 
            lblAlerta.BackColor = Color.FromArgb(210, 45, 45);
            lblAlerta.ForeColor = Color.White;
            lblAlerta.Location = new Point(20, 631);
            lblAlerta.Name = "lblAlerta";
            lblAlerta.Size = new Size(280, 30);
            lblAlerta.TabIndex = 15;
            lblAlerta.Text = "Selecciona una fila primero";
            lblAlerta.TextAlign = ContentAlignment.MiddleCenter;
            lblAlerta.Visible = false;
            // 
            // lblListaTitulo
            // 
            lblListaTitulo.AutoSize = true;
            lblListaTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblListaTitulo.ForeColor = Color.FromArgb(28, 114, 187);
            lblListaTitulo.Location = new Point(340, 80);
            lblListaTitulo.Name = "lblListaTitulo";
            lblListaTitulo.Size = new Size(208, 28);
            lblListaTitulo.TabIndex = 16;
            lblListaTitulo.Text = "Lista de proveedores";
            // 
            // txtBuscar
            // 
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Location = new Point(669, 130);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(317, 30);
            txtBuscar.TabIndex = 17;
            txtBuscar.Text = "🔍 Buscar...";
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.ColumnHeadersHeight = 29;
            dgvProveedores.Location = new Point(340, 170);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(1068, 606);
            dgvProveedores.TabIndex = 18;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            // 
            // btnEstado
            // 
            btnEstado.BackColor = Color.White;
            btnEstado.Cursor = Cursors.Hand;
            btnEstado.FlatAppearance.BorderColor = Color.FromArgb(200, 40, 40);
            btnEstado.FlatStyle = FlatStyle.Flat;
            btnEstado.ForeColor = Color.Green;
            btnEstado.Location = new Point(20, 544);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(280, 34);
            btnEstado.TabIndex = 19;
            btnEstado.Text = "👤 Estado";
            btnEstado.UseVisualStyleBackColor = false;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.FromArgb(60, 60, 60);
            btnEditar.Location = new Point(20, 584);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(280, 34);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "✎ Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.White;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(340, 125);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(280, 35);
            btnNuevo.TabIndex = 21;
            btnNuevo.Text = "+ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // ProveedoresForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1464, 811);
            Controls.Add(btnNuevo);
            Controls.Add(btnEditar);
            Controls.Add(btnEstado);
            Controls.Add(panelHeader);
            Controls.Add(lblSeccion);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(lblAlerta);
            Controls.Add(lblListaTitulo);
            Controls.Add(txtBuscar);
            Controls.Add(dgvProveedores);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProveedoresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de proveedores";
            Load += ProveedoresForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.Label lblListaTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private Button btnEstado;
        private Button btnEditar;
        private Button btnNuevo;
    }
}