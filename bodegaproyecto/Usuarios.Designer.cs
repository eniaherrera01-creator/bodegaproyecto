namespace bodegaproyecto
{
    partial class Usuarios
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Label lblTituloDatos;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.Label lblTituloLista;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
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
            lblIDUsuario = new Label();
            txtIDUsuario = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pnlDerecho = new Panel();
            lblTituloLista = new Label();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEstado = new Button();
            btnActualizar = new Button();
            txtBuscar = new TextBox();
            dgvUsuarios = new DataGridView();
            lblTotal = new Label();
            pnlHeader.SuspendLayout();
            pnlIzquierdo.SuspendLayout();
            pnlDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTituloForm);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1193, 55);
            pnlHeader.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(20, 12);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(128, 37);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "Usuarios";
            // 
            // pnlIzquierdo
            // 
            pnlIzquierdo.BackColor = Color.White;
            pnlIzquierdo.Controls.Add(lblTituloDatos);
            pnlIzquierdo.Controls.Add(lblIDUsuario);
            pnlIzquierdo.Controls.Add(txtIDUsuario);
            pnlIzquierdo.Controls.Add(lblNombre);
            pnlIzquierdo.Controls.Add(txtNombre);
            pnlIzquierdo.Controls.Add(lblUsuario);
            pnlIzquierdo.Controls.Add(txtUsuario);
            pnlIzquierdo.Controls.Add(lblContrasena);
            pnlIzquierdo.Controls.Add(txtContrasena);
            pnlIzquierdo.Controls.Add(lblRol);
            pnlIzquierdo.Controls.Add(cmbRol);
            pnlIzquierdo.Controls.Add(btnGuardar);
            pnlIzquierdo.Controls.Add(btnCancelar);
            pnlIzquierdo.Location = new Point(10, 65);
            pnlIzquierdo.Name = "pnlIzquierdo";
            pnlIzquierdo.Size = new Size(310, 615);
            pnlIzquierdo.TabIndex = 1;
            // 
            // lblTituloDatos
            // 
            lblTituloDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloDatos.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloDatos.Location = new Point(15, 15);
            lblTituloDatos.Name = "lblTituloDatos";
            lblTituloDatos.Size = new Size(280, 25);
            lblTituloDatos.TabIndex = 0;
            lblTituloDatos.Text = "Datos del Usuario";
            // 
            // lblIDUsuario
            // 
            lblIDUsuario.AutoSize = true;
            lblIDUsuario.ForeColor = Color.FromArgb(80, 80, 80);
            lblIDUsuario.Location = new Point(15, 55);
            lblIDUsuario.Name = "lblIDUsuario";
            lblIDUsuario.Size = new Size(78, 20);
            lblIDUsuario.TabIndex = 1;
            lblIDUsuario.Text = "ID Usuario";
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.BackColor = Color.FromArgb(245, 245, 245);
            txtIDUsuario.Enabled = false;
            txtIDUsuario.Location = new Point(15, 73);
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.Size = new Size(275, 27);
            txtIDUsuario.TabIndex = 2;
            txtIDUsuario.Text = "(Automático)";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.FromArgb(80, 80, 80);
            lblNombre.Location = new Point(15, 115);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(134, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese nombre completo";
            txtNombre.Size = new Size(275, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.FromArgb(80, 80, 80);
            lblUsuario.Location = new Point(15, 175);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(139, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Nombre de Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(15, 193);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese nombre de usuario";
            txtUsuario.Size = new Size(275, 27);
            txtUsuario.TabIndex = 6;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.ForeColor = Color.FromArgb(80, 80, 80);
            lblContrasena.Location = new Point(15, 235);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(83, 20);
            lblContrasena.TabIndex = 7;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(15, 253);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '●';
            txtContrasena.PlaceholderText = "Ingrese contraseña";
            txtContrasena.Size = new Size(275, 27);
            txtContrasena.TabIndex = 8;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = Color.FromArgb(80, 80, 80);
            lblRol.Location = new Point(15, 295);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 20);
            lblRol.TabIndex = 9;
            lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Cajero", "Supervisor", "Vendedor", "Bodega" });
            cmbRol.Location = new Point(15, 313);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(275, 28);
            cmbRol.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(26, 115, 232);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(15, 365);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 38);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "💾  Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(200, 200, 200);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(60, 60, 60);
            btnCancelar.Location = new Point(160, 365);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 38);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "✖  Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnlDerecho
            // 
            pnlDerecho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDerecho.BackColor = Color.White;
            pnlDerecho.Controls.Add(lblTituloLista);
            pnlDerecho.Controls.Add(btnNuevo);
            pnlDerecho.Controls.Add(btnEditar);
            pnlDerecho.Controls.Add(btnEstado);
            pnlDerecho.Controls.Add(btnActualizar);
            pnlDerecho.Controls.Add(txtBuscar);
            pnlDerecho.Controls.Add(dgvUsuarios);
            pnlDerecho.Controls.Add(lblTotal);
            pnlDerecho.Location = new Point(330, 65);
            pnlDerecho.Name = "pnlDerecho";
            pnlDerecho.Size = new Size(861, 615);
            pnlDerecho.TabIndex = 2;
            // 
            // lblTituloLista
            // 
            lblTituloLista.AutoSize = true;
            lblTituloLista.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloLista.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloLista.Location = new Point(15, 15);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(172, 28);
            lblTituloLista.TabIndex = 0;
            lblTituloLista.Text = "Lista de Usuarios";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(26, 115, 232);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(15, 50);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(95, 34);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "+ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.FromArgb(60, 60, 60);
            btnEditar.Location = new Point(120, 50);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(95, 34);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "✎ Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEstado
            // 
            btnEstado.BackColor = Color.White;
            btnEstado.Cursor = Cursors.Hand;
            btnEstado.FlatAppearance.BorderColor = Color.FromArgb(200, 40, 40);
            btnEstado.FlatStyle = FlatStyle.Flat;
            btnEstado.ForeColor = Color.Green;
            btnEstado.Location = new Point(225, 50);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(105, 34);
            btnEstado.TabIndex = 3;
            btnEstado.Text = "👤 Estado";
            btnEstado.UseVisualStyleBackColor = false;
            btnEstado.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.White;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.FromArgb(60, 60, 60);
            btnActualizar.Location = new Point(336, 48);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(105, 34);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "↻ Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(490, 53);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar usuario...";
            txtBuscar.Size = new Size(240, 27);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.ColumnHeadersHeight = 40;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.Font = new Font("Segoe UI", 9F);
            dgvUsuarios.Location = new Point(15, 100);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 227, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.RowTemplate.Height = 35;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(785, 465);
            dgvUsuarios.TabIndex = 6;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.FromArgb(100, 100, 100);
            lblTotal.Location = new Point(15, 575);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(115, 20);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total usuarios: 0";
            // 
            // Usuarios
            // 
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1193, 653);
            Controls.Add(pnlHeader);
            Controls.Add(pnlIzquierdo);
            Controls.Add(pnlDerecho);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlIzquierdo.ResumeLayout(false);
            pnlIzquierdo.PerformLayout();
            pnlDerecho.ResumeLayout(false);
            pnlDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }
    }
}