using System;
using System.Drawing;
using System.Windows.Forms;

namespace bodegaproyecto
{
    partial class Clientes
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Controles

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloForm;

        private System.Windows.Forms.Panel pnlIzquierdo;

        private System.Windows.Forms.Label lblTituloDatos;

        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox txtIDCliente;

        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;

        private System.Windows.Forms.Label lblRTN;
        private System.Windows.Forms.TextBox txtRTN;

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;

        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;

        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;

        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;

        private System.Windows.Forms.Panel pnlDerecho;

        private System.Windows.Forms.Label lblTituloLista;

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnActualizar;

        private System.Windows.Forms.TextBox txtBuscar;

        private System.Windows.Forms.DataGridView dgvClientes;

        #endregion

        /// <summary>
        /// Limpiar recursos.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTituloForm = new Label();
            pnlIzquierdo = new Panel();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblTituloDatos = new Label();
            lblIDCliente = new Label();
            txtIDCliente = new TextBox();
            lblCodigoCliente = new Label();
            txtCodigoCliente = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblRTN = new Label();
            txtRTN = new TextBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblFechaRegistro = new Label();
            dtpFechaRegistro = new DateTimePicker();
            pnlDerecho = new Panel();
            lblTituloLista = new Label();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEstado = new Button();
            btnActualizar = new Button();
            txtBuscar = new TextBox();
            dgvClientes = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlIzquierdo.SuspendLayout();
            pnlDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
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
            pnlHeader.Size = new Size(1363, 63);
            pnlHeader.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(15, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(119, 37);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "Clientes";
            // 
            // pnlIzquierdo
            // 
            pnlIzquierdo.BackColor = Color.White;
            pnlIzquierdo.Controls.Add(btnGuardar);
            pnlIzquierdo.Controls.Add(btnCancelar);
            pnlIzquierdo.Controls.Add(lblTituloDatos);
            pnlIzquierdo.Controls.Add(lblIDCliente);
            pnlIzquierdo.Controls.Add(txtIDCliente);
            pnlIzquierdo.Controls.Add(lblCodigoCliente);
            pnlIzquierdo.Controls.Add(txtCodigoCliente);
            pnlIzquierdo.Controls.Add(lblNombre);
            pnlIzquierdo.Controls.Add(txtNombre);
            pnlIzquierdo.Controls.Add(lblRTN);
            pnlIzquierdo.Controls.Add(txtRTN);
            pnlIzquierdo.Controls.Add(lblDNI);
            pnlIzquierdo.Controls.Add(txtDNI);
            pnlIzquierdo.Controls.Add(lblTelefono);
            pnlIzquierdo.Controls.Add(txtTelefono);
            pnlIzquierdo.Controls.Add(lblCorreo);
            pnlIzquierdo.Controls.Add(txtCorreo);
            pnlIzquierdo.Controls.Add(lblDireccion);
            pnlIzquierdo.Controls.Add(txtDireccion);
            pnlIzquierdo.Controls.Add(lblFechaRegistro);
            pnlIzquierdo.Controls.Add(dtpFechaRegistro);
            pnlIzquierdo.Location = new Point(12, 71);
            pnlIzquierdo.Margin = new Padding(3, 4, 3, 4);
            pnlIzquierdo.Name = "pnlIzquierdo";
            pnlIzquierdo.Size = new Size(354, 702);
            pnlIzquierdo.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(26, 115, 232);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(25, 623);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 38);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "💾  Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(200, 200, 200);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(60, 60, 60);
            btnCancelar.Location = new Point(170, 623);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 38);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "✖  Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblTituloDatos
            // 
            lblTituloDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloDatos.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloDatos.Location = new Point(17, 20);
            lblTituloDatos.Name = "lblTituloDatos";
            lblTituloDatos.Size = new Size(320, 33);
            lblTituloDatos.TabIndex = 0;
            lblTituloDatos.Text = "Datos del Cliente";
            // 
            // lblIDCliente
            // 
            lblIDCliente.AutoSize = true;
            lblIDCliente.ForeColor = Color.FromArgb(80, 80, 80);
            lblIDCliente.Location = new Point(17, 53);
            lblIDCliente.Name = "lblIDCliente";
            lblIDCliente.Size = new Size(74, 20);
            lblIDCliente.TabIndex = 1;
            lblIDCliente.Text = "ID Cliente";
            // 
            // txtIDCliente
            // 
            txtIDCliente.BackColor = Color.FromArgb(245, 245, 245);
            txtIDCliente.Enabled = false;
            txtIDCliente.Location = new Point(17, 77);
            txtIDCliente.Margin = new Padding(3, 4, 3, 4);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(293, 27);
            txtIDCliente.TabIndex = 2;
            txtIDCliente.Text = "(Automático)";
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.ForeColor = Color.FromArgb(80, 80, 80);
            lblCodigoCliente.Location = new Point(17, 108);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(58, 20);
            lblCodigoCliente.TabIndex = 3;
            lblCodigoCliente.Text = "Código";
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(17, 132);
            txtCodigoCliente.Margin = new Padding(3, 4, 3, 4);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.PlaceholderText = "Ingrese el codigo del cliente";
            txtCodigoCliente.Size = new Size(293, 27);
            txtCodigoCliente.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.FromArgb(80, 80, 80);
            lblNombre.Location = new Point(17, 163);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(134, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(17, 187);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre Completo";
            txtNombre.Size = new Size(293, 27);
            txtNombre.TabIndex = 6;
            // 
            // lblRTN
            // 
            lblRTN.AutoSize = true;
            lblRTN.ForeColor = Color.FromArgb(80, 80, 80);
            lblRTN.Location = new Point(17, 218);
            lblRTN.Name = "lblRTN";
            lblRTN.Size = new Size(36, 20);
            lblRTN.TabIndex = 7;
            lblRTN.Text = "RTN";
            // 
            // txtRTN
            // 
            txtRTN.Location = new Point(17, 242);
            txtRTN.Margin = new Padding(3, 4, 3, 4);
            txtRTN.Name = "txtRTN";
            txtRTN.PlaceholderText = "Ingrese RTN";
            txtRTN.Size = new Size(293, 27);
            txtRTN.TabIndex = 8;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.ForeColor = Color.FromArgb(80, 80, 80);
            lblDNI.Location = new Point(18, 273);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(35, 20);
            lblDNI.TabIndex = 9;
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(17, 297);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "Ingrese DNI";
            txtDNI.Size = new Size(293, 27);
            txtDNI.TabIndex = 10;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.FromArgb(80, 80, 80);
            lblTelefono.Location = new Point(17, 328);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(17, 352);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese telefono";
            txtTelefono.Size = new Size(293, 27);
            txtTelefono.TabIndex = 12;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.ForeColor = Color.FromArgb(80, 80, 80);
            lblCorreo.Location = new Point(19, 383);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 13;
            lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(17, 407);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese correo electrónico";
            txtCorreo.Size = new Size(293, 27);
            txtCorreo.TabIndex = 14;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.FromArgb(80, 80, 80);
            lblDireccion.Location = new Point(19, 438);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 15;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(19, 462);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese dirección";
            txtDireccion.Size = new Size(293, 65);
            txtDireccion.TabIndex = 16;
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.ForeColor = Color.FromArgb(80, 80, 80);
            lblFechaRegistro.Location = new Point(19, 531);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(106, 20);
            lblFechaRegistro.TabIndex = 18;
            lblFechaRegistro.Text = "Fecha Registro";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(19, 555);
            dtpFechaRegistro.Margin = new Padding(3, 4, 3, 4);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(293, 27);
            dtpFechaRegistro.TabIndex = 19;
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
            pnlDerecho.Controls.Add(dgvClientes);
            pnlDerecho.Location = new Point(376, 71);
            pnlDerecho.Margin = new Padding(3, 4, 3, 4);
            pnlDerecho.Name = "pnlDerecho";
            pnlDerecho.Size = new Size(975, 702);
            pnlDerecho.TabIndex = 2;
            // 
            // lblTituloLista
            // 
            lblTituloLista.AutoSize = true;
            lblTituloLista.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloLista.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloLista.Location = new Point(17, 20);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(166, 28);
            lblTituloLista.TabIndex = 0;
            lblTituloLista.Text = "Lista de Clientes";
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
            btnEditar.Location = new Point(120, 67);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
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
            btnEstado.Location = new Point(221, 67);
            btnEstado.Margin = new Padding(3, 4, 3, 4);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(95, 34);
            btnEstado.TabIndex = 3;
            btnEstado.Text = "👤 Estado";
            btnEstado.UseVisualStyleBackColor = false;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.White;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.FromArgb(60, 60, 60);
            btnActualizar.Location = new Point(322, 67);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(105, 34);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "↻ Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(449, 74);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(240, 27);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 250, 252);
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvClientes.ColumnHeadersHeight = 40;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Font = new Font("Segoe UI", 9F);
            dgvClientes.GridColor = Color.Gainsboro;
            dgvClientes.Location = new Point(17, 121);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(210, 227, 252);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvClientes.RowTemplate.Height = 35;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(941, 461);
            dgvClientes.TabIndex = 6;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1363, 800);
            Controls.Add(pnlHeader);
            Controls.Add(pnlIzquierdo);
            Controls.Add(pnlDerecho);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlIzquierdo.ResumeLayout(false);
            pnlIzquierdo.PerformLayout();
            pnlDerecho.ResumeLayout(false);
            pnlDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
    }
}