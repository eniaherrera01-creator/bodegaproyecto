namespace bodegaproyecto
{
    partial class FrmCategoria
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

        // El diseñador de Visual Studio lee obligatoriamente este método
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblRegistros = new Label();
            lblActivas = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblContadorCaracteres = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            lblAlerta = new Label();
            lblListaTitulo = new Label();
            txtBuscar = new TextBox();
            dgvCategorias = new DataGridView();
            lblSeccion = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblRegistros);
            panelHeader.Controls.Add(lblActivas);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1193, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(15, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(305, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🏷️ Gestión de Categorías";
            // 
            // lblRegistros
            // 
            lblRegistros.BackColor = Color.FromArgb(60, 140, 210);
            lblRegistros.ForeColor = Color.White;
            lblRegistros.Location = new Point(919, 22);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(90, 25);
            lblRegistros.TabIndex = 1;
            lblRegistros.Text = "0 registros";
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActivas
            // 
            lblActivas.BackColor = Color.FromArgb(60, 140, 210);
            lblActivas.ForeColor = Color.White;
            lblActivas.Location = new Point(1019, 22);
            lblActivas.Name = "lblActivas";
            lblActivas.Size = new Size(90, 25);
            lblActivas.TabIndex = 2;
            lblActivas.Text = "✓ 0 activas";
            lblActivas.TextAlign = ContentAlignment.MiddleCenter;
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
            lblNombre.Size = new Size(161, 23);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre categoría *";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Location = new Point(20, 190);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 30);
            txtNombre.TabIndex = 5;
            txtNombre.Text = "Ej: Medicamentos...";
            // 
            // lblContadorCaracteres
            // 
            lblContadorCaracteres.AutoSize = true;
            lblContadorCaracteres.Font = new Font("Segoe UI", 8F);
            lblContadorCaracteres.ForeColor = Color.Gray;
            lblContadorCaracteres.Location = new Point(275, 225);
            lblContadorCaracteres.Name = "lblContadorCaracteres";
            lblContadorCaracteres.Size = new Size(38, 19);
            lblContadorCaracteres.TabIndex = 6;
            lblContadorCaracteres.Text = "0/80";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(20, 245);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(98, 23);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.ForeColor = Color.Gray;
            txtDescripcion.Location = new Point(20, 265);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(280, 80);
            txtDescripcion.TabIndex = 8;
            txtDescripcion.Text = "Descripción detallada de la categoría...";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.Enabled = false;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(20, 382);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(280, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(20, 438);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(280, 35);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "✕ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(40, 40, 40);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(20, 488);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(280, 35);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "🗑 Eliminar seleccionado";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lblAlerta
            // 
            lblAlerta.BackColor = Color.FromArgb(210, 45, 45);
            lblAlerta.ForeColor = Color.White;
            lblAlerta.Location = new Point(15, 545);
            lblAlerta.Name = "lblAlerta";
            lblAlerta.Size = new Size(280, 30);
            lblAlerta.TabIndex = 14;
            lblAlerta.Text = "Selecciona una fila primero";
            lblAlerta.TextAlign = ContentAlignment.MiddleCenter;
            lblAlerta.Visible = false;
            lblAlerta.Click += lblAlerta_Click;
            // 
            // lblListaTitulo
            // 
            lblListaTitulo.AutoSize = true;
            lblListaTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblListaTitulo.ForeColor = Color.FromArgb(28, 114, 187);
            lblListaTitulo.Location = new Point(340, 80);
            lblListaTitulo.Name = "lblListaTitulo";
            lblListaTitulo.Size = new Size(189, 28);
            lblListaTitulo.TabIndex = 15;
            lblListaTitulo.Text = "Lista de categorías";
            // 
            // txtBuscar
            // 
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Location = new Point(340, 115);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(745, 30);
            txtBuscar.TabIndex = 16;
            txtBuscar.Text = "🔍 Buscar...";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.BackgroundColor = Color.White;
            dgvCategorias.ColumnHeadersHeight = 29;
            dgvCategorias.Location = new Point(340, 150);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(745, 425);
            dgvCategorias.TabIndex = 17;
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
            // FrmCategoria
            // 
            BackColor = Color.White;
            ClientSize = new Size(1193, 653);
            Controls.Add(panelHeader);
            Controls.Add(lblSeccion);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblContadorCaracteres);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(lblAlerta);
            Controls.Add(lblListaTitulo);
            Controls.Add(txtBuscar);
            Controls.Add(dgvCategorias);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de categoría";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Definición de controles accesibles por el diseñador
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblActivas;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblContadorCaracteres;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.Label lblListaTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private Label lblSeccion;
    }
}