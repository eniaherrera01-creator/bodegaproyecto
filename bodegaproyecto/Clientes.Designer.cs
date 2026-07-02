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

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.Panel pnlDerecho;

        private System.Windows.Forms.Label lblTituloLista;

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnActualizar;

        private System.Windows.Forms.TextBox txtBuscar;

        private System.Windows.Forms.DataGridView dgvClientes;

        private System.Windows.Forms.Label lblTotal;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();

            this.pnlIzquierdo = new System.Windows.Forms.Panel();

            this.lblTituloDatos = new System.Windows.Forms.Label();

            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();

            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();

            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();

            this.lblRTN = new System.Windows.Forms.Label();
            this.txtRTN = new System.Windows.Forms.TextBox();

            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();

            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();

            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();

            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();

            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();

            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();

            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.pnlDerecho = new System.Windows.Forms.Panel();

            this.lblTituloLista = new System.Windows.Forms.Label();

            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();

            this.txtBuscar = new System.Windows.Forms.TextBox();

            this.dgvClientes = new System.Windows.Forms.DataGridView();

            this.lblTotal = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlIzquierdo.SuspendLayout();
            this.pnlDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();

            this.SuspendLayout();

            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.lblTituloForm);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Location = new Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new Size(1193, 55);
            this.pnlHeader.TabIndex = 0;

            //
            // lblTituloForm
            //
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTituloForm.ForeColor = Color.White;
            this.lblTituloForm.Location = new Point(20, 12);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new Size(105, 30);
            this.lblTituloForm.TabIndex = 0;
            this.lblTituloForm.Text = "Clientes";

            //
            // pnlIzquierdo
            //
            this.pnlIzquierdo.BackColor = Color.White;
            this.pnlIzquierdo.Location = new Point(10, 65);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new Size(310, 615);
            this.pnlIzquierdo.TabIndex = 1;

            this.pnlIzquierdo.Controls.Add(this.lblTituloDatos);

            this.pnlIzquierdo.Controls.Add(this.lblIDCliente);
            this.pnlIzquierdo.Controls.Add(this.txtIDCliente);

            this.pnlIzquierdo.Controls.Add(this.lblCodigoCliente);
            this.pnlIzquierdo.Controls.Add(this.txtCodigoCliente);

            this.pnlIzquierdo.Controls.Add(this.lblNombre);
            this.pnlIzquierdo.Controls.Add(this.txtNombre);

            this.pnlIzquierdo.Controls.Add(this.lblRTN);
            this.pnlIzquierdo.Controls.Add(this.txtRTN);

            this.pnlIzquierdo.Controls.Add(this.lblDNI);
            this.pnlIzquierdo.Controls.Add(this.txtDNI);

            this.pnlIzquierdo.Controls.Add(this.lblTelefono);
            this.pnlIzquierdo.Controls.Add(this.txtTelefono);

            this.pnlIzquierdo.Controls.Add(this.lblCorreo);
            this.pnlIzquierdo.Controls.Add(this.txtCorreo);

            this.pnlIzquierdo.Controls.Add(this.lblDireccion);
            this.pnlIzquierdo.Controls.Add(this.txtDireccion);

            this.pnlIzquierdo.Controls.Add(this.lblFechaRegistro);
            this.pnlIzquierdo.Controls.Add(this.dtpFechaRegistro);

            this.pnlIzquierdo.Controls.Add(this.lblEstado);
            this.pnlIzquierdo.Controls.Add(this.cmbEstado);

            this.pnlIzquierdo.Controls.Add(this.btnGuardar);
            this.pnlIzquierdo.Controls.Add(this.btnCancelar);

            //
            // lblTituloDatos
            //
            this.lblTituloDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTituloDatos.ForeColor = Color.FromArgb(26, 42, 74);
            this.lblTituloDatos.Location = new Point(15, 15);
            this.lblTituloDatos.Name = "lblTituloDatos";
            this.lblTituloDatos.Size = new Size(280, 25);
            this.lblTituloDatos.TabIndex = 0;
            this.lblTituloDatos.Text = "Datos del Cliente";

            //
            // lblIDCliente
            //
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new Point(15, 55);
            this.lblIDCliente.ForeColor = Color.FromArgb(80, 80, 80);
            this.lblIDCliente.Text = "ID Cliente";

            //
            // txtIDCliente
            //
            this.txtIDCliente.BackColor = Color.FromArgb(245, 245, 245);
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Location = new Point(15, 73);
            this.txtIDCliente.Size = new Size(275, 23);
            this.txtIDCliente.Text = "(Automático)";

            //
            // lblCodigoCliente
            //
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Location = new Point(15, 110);
            this.lblCodigoCliente.ForeColor = Color.FromArgb(80, 80, 80);
            this.lblCodigoCliente.Text = "Código";

            //
            // txtCodigoCliente
            //
            this.txtCodigoCliente.Location = new Point(15, 128);
            this.txtCodigoCliente.Size = new Size(275, 23);

            //
            // lblNombre
            //
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new Point(15, 165);
            this.lblNombre.ForeColor = Color.FromArgb(80, 80, 80);
            this.lblNombre.Text = "Nombre Completo";

            //
            // txtNombre
            //
            this.txtNombre.Location = new Point(15, 183);
            this.txtNombre.Size = new Size(275, 23);

            //
            // lblRTN
            //
            this.lblRTN.AutoSize = true;
            this.lblRTN.Location = new Point(15, 220);
            this.lblRTN.ForeColor = Color.FromArgb(80, 80, 80);
            this.lblRTN.Text = "RTN";

            //
            // txtRTN
            //
            this.txtRTN.Location = new Point(15, 238);
            this.txtRTN.Size = new Size(275, 23);

            //
            // lblDNI
            //
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new Point(15, 275);
            this.lblDNI.ForeColor = Color.FromArgb(80, 80, 80);
            this.lblDNI.Text = "DNI";

            //
            // txtDNI
            //
            this.txtDNI.Location = new Point(15, 293);
            this.txtDNI.Size = new Size(275, 23);

            //
            // lblTelefono
            //
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new Point(15, 330);
            this.lblTelefono.ForeColor = Color.FromArgb(80, 80, 80);
            this.lblTelefono.Text = "Teléfono";

            //
            // txtTelefono
            //
            this.txtTelefono.Location = new Point(15, 348);
            this.txtTelefono.Size = new Size(275, 23);

            //
            // lblCorreo
            //
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new Point(15, 385);
            this.lblCorreo.ForeColor = Color.FromArgb(80, 80, 80);
            this.lblCorreo.Text = "Correo";

            //
            // txtCorreo
            //
            this.txtCorreo.Location = new Point(15, 403);
            this.txtCorreo.Size = new Size(275, 23);

            //
            // lblDireccion
            //
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new Point(15, 440);
            this.lblDireccion.ForeColor = Color.FromArgb(80, 80, 80);
            this.lblDireccion.Text = "Dirección";

            //
            // txtDireccion
            //
            this.txtDireccion.Location = new Point(15, 458);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Size = new Size(275, 50);


            //
            // lblFechaRegistro
            //
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.ForeColor = Color.FromArgb(80, 80, 80);
            this.lblFechaRegistro.Location = new Point(15, 520);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new Size(91, 15);
            this.lblFechaRegistro.TabIndex = 18;
            this.lblFechaRegistro.Text = "Fecha Registro";

            //
            // dtpFechaRegistro
            //
            this.dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new Point(15, 538);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new Size(275, 23);
            this.dtpFechaRegistro.TabIndex = 19;

            //
            // lblEstado
            //
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = Color.FromArgb(80, 80, 80);
            this.lblEstado.Location = new Point(15, 570);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new Size(45, 15);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado";

            //
            // cmbEstado
            //
            this.cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[]
            {
                "Activo",
                "Inactivo"
            });
            this.cmbEstado.Location = new Point(15, 588);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new Size(275, 23);
            this.cmbEstado.TabIndex = 21;

            //
            // btnGuardar
            //
            this.btnGuardar.BackColor = Color.FromArgb(26, 115, 232);
            this.btnGuardar.Cursor = Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = FlatStyle.Flat;
            this.btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnGuardar.ForeColor = Color.White;
            this.btnGuardar.Location = new Point(15, 630);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(130, 38);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += btnGuardar_Click;

            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = Color.FromArgb(200, 200, 200);
            this.btnCancelar.Cursor = Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = FlatStyle.Flat;
            this.btnCancelar.ForeColor = Color.FromArgb(60, 60, 60);
            this.btnCancelar.Location = new Point(160, 630);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(130, 38);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "✖ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += btnCancelar_Click;

            //
            // pnlDerecho
            //
            this.pnlDerecho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlDerecho.BackColor = Color.White;
            this.pnlDerecho.Location = new Point(330, 65);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new Size(853, 615);
            this.pnlDerecho.TabIndex = 2;

            this.pnlDerecho.Controls.Add(this.lblTituloLista);
            this.pnlDerecho.Controls.Add(this.btnNuevo);
            this.pnlDerecho.Controls.Add(this.btnEditar);
            this.pnlDerecho.Controls.Add(this.btnEstado);
            this.pnlDerecho.Controls.Add(this.btnActualizar);
            this.pnlDerecho.Controls.Add(this.txtBuscar);
            this.pnlDerecho.Controls.Add(this.dgvClientes);
            this.pnlDerecho.Controls.Add(this.lblTotal);

            //
            // lblTituloLista
            //
            this.lblTituloLista.AutoSize = true;
            this.lblTituloLista.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTituloLista.ForeColor = Color.FromArgb(26, 42, 74);
            this.lblTituloLista.Location = new Point(15, 15);
            this.lblTituloLista.Name = "lblTituloLista";
            this.lblTituloLista.Size = new Size(131, 21);
            this.lblTituloLista.TabIndex = 0;
            this.lblTituloLista.Text = "Lista de Clientes";

            //
            // btnNuevo
            //
            this.btnNuevo.BackColor = Color.FromArgb(26, 115, 232);
            this.btnNuevo.Cursor = Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = FlatStyle.Flat;
            this.btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnNuevo.ForeColor = Color.White;
            this.btnNuevo.Location = new Point(15, 50);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new Size(95, 34);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "+ Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += btnNuevo_Click;

            //
            // btnEditar
            //
            this.btnEditar.BackColor = Color.White;
            this.btnEditar.Cursor = Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            this.btnEditar.FlatStyle = FlatStyle.Flat;
            this.btnEditar.ForeColor = Color.FromArgb(60, 60, 60);
            this.btnEditar.Location = new Point(120, 50);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new Size(95, 34);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "✎ Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += btnEditar_Click;

            //
            // btnEstado
            //
            this.btnEstado.BackColor = Color.White;
            this.btnEstado.Cursor = Cursors.Hand;
            this.btnEstado.FlatAppearance.BorderColor = Color.FromArgb(200, 40, 40);
            this.btnEstado.FlatStyle = FlatStyle.Flat;
            this.btnEstado.ForeColor = Color.Green;
            this.btnEstado.Location = new Point(225, 50);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new Size(105, 34);
            this.btnEstado.TabIndex = 3;
            this.btnEstado.Text = "👤 Estado";
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += btnEstado_Click;

            //
            // btnActualizar
            //
            this.btnActualizar.BackColor = Color.White;
            this.btnActualizar.Cursor = Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            this.btnActualizar.FlatStyle = FlatStyle.Flat;
            this.btnActualizar.ForeColor = Color.FromArgb(60, 60, 60);
            this.btnActualizar.Location = new Point(336, 50);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new Size(105, 34);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "↻ Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += btnActualizar_Click;

            //
            // txtBuscar
            //
            this.txtBuscar.Location = new Point(500, 55);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new Size(250, 23);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += txtBuscar_TextChanged;



            //
            // dgvClientes
            //
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;

            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

            this.dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = Color.White;
            this.dgvClientes.BorderStyle = BorderStyle.None;
            this.dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;

            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeight = 40;
            this.dgvClientes.EnableHeadersVisualStyles = false;

            this.dgvClientes.Font = new Font("Segoe UI", 9F);
            this.dgvClientes.GridColor = Color.Gainsboro;
            this.dgvClientes.Location = new Point(15, 100);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;

            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 227, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;

            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.RowTemplate.Height = 35;
            this.dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new Size(823, 465);
            this.dgvClientes.TabIndex = 6;

            this.dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            this.dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;

            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = Color.FromArgb(100, 100, 100);
            this.lblTotal.Location = new Point(15, 575);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new Size(92, 15);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total clientes: 0";

            //
            // Clientes
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.ClientSize = new Size(1193, 690);

            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlDerecho);

            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Clientes";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Clientes";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();

            this.pnlDerecho.ResumeLayout(false);
            this.pnlDerecho.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();

            this.ResumeLayout(false);

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
    }
}