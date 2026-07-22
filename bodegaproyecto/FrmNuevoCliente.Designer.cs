using System;
using System.Drawing;
using System.Windows.Forms;

namespace bodegaproyecto
{
    partial class FrmNuevoCliente
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Controles

        //===========================
        // HEADER
        //===========================

        private Panel pnlHeader;
        private Label lblTituloForm;

        //===========================
        // PANEL IZQUIERDO
        //===========================

        private Panel pnlIzquierdo;

        private Label lblTituloDatos;

        private Label lblIDCliente;
        private TextBox txtIDCliente;

        private Label lblDNI;
        private TextBox txtDNI;

        private Label lblNombre;
        private TextBox txtNombre;

        private Label lblRTN;
        private TextBox txtRTN;

        private Label lblTelefono;
        private TextBox txtTelefono;

        private Label lblCorreo;
        private TextBox txtCorreo;

        private Label lblDireccion;
        private TextBox txtDireccion;

        private Label lblFechaRegistro;
        private DateTimePicker dtpFechaRegistro;

        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnVolver;

        //===========================
        // PANEL DERECHO
        //===========================

        private Panel pnlDerecho;

        private Label lblTituloLista;
        private Label lblBuscar;

        private TextBox txtBuscar;

        private DataGridView dgvClientes;

        #endregion

        /// <summary>
        /// Liberar recursos.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTituloForm = new Label();
            pnlIzquierdo = new Panel();
            lblTituloDatos = new Label();
            lblIDCliente = new Label();
            txtIDCliente = new TextBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblRTN = new Label();
            txtRTN = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblFechaRegistro = new Label();
            dtpFechaRegistro = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnVolver = new Button();
            pnlDerecho = new Panel();
            lblTituloLista = new Label();
            lblBuscar = new Label();
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
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1396, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(20, 16);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(222, 37);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "NUEVO CLIENTE";
            // 
            // pnlIzquierdo
            // 
            pnlIzquierdo.BackColor = Color.White;
            pnlIzquierdo.Controls.Add(lblTituloDatos);
            pnlIzquierdo.Controls.Add(lblIDCliente);
            pnlIzquierdo.Controls.Add(txtIDCliente);
            pnlIzquierdo.Controls.Add(lblDNI);
            pnlIzquierdo.Controls.Add(txtDNI);
            pnlIzquierdo.Controls.Add(lblNombre);
            pnlIzquierdo.Controls.Add(txtNombre);
            pnlIzquierdo.Controls.Add(lblRTN);
            pnlIzquierdo.Controls.Add(txtRTN);
            pnlIzquierdo.Controls.Add(lblTelefono);
            pnlIzquierdo.Controls.Add(txtTelefono);
            pnlIzquierdo.Controls.Add(lblCorreo);
            pnlIzquierdo.Controls.Add(txtCorreo);
            pnlIzquierdo.Controls.Add(lblDireccion);
            pnlIzquierdo.Controls.Add(txtDireccion);
            pnlIzquierdo.Controls.Add(lblFechaRegistro);
            pnlIzquierdo.Controls.Add(dtpFechaRegistro);
            pnlIzquierdo.Controls.Add(btnGuardar);
            pnlIzquierdo.Controls.Add(btnCancelar);
            pnlIzquierdo.Controls.Add(btnVolver);
            pnlIzquierdo.Location = new Point(12, 82);
            pnlIzquierdo.Name = "pnlIzquierdo";
            pnlIzquierdo.Size = new Size(354, 702);
            pnlIzquierdo.TabIndex = 1;
            // 
            // lblTituloDatos
            // 
            lblTituloDatos.AutoSize = true;
            lblTituloDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloDatos.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloDatos.Location = new Point(17, 20);
            lblTituloDatos.Name = "lblTituloDatos";
            lblTituloDatos.Size = new Size(174, 28);
            lblTituloDatos.TabIndex = 0;
            lblTituloDatos.Text = "Datos del Cliente";
            // 
            // lblIDCliente
            // 
            lblIDCliente.AutoSize = true;
            lblIDCliente.Location = new Point(17, 58);
            lblIDCliente.Name = "lblIDCliente";
            lblIDCliente.Size = new Size(74, 20);
            lblIDCliente.TabIndex = 1;
            lblIDCliente.Text = "ID Cliente";
            // 
            // txtIDCliente
            // 
            txtIDCliente.BackColor = Color.FromArgb(245, 245, 245);
            txtIDCliente.Enabled = false;
            txtIDCliente.Location = new Point(17, 82);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.ReadOnly = true;
            txtIDCliente.Size = new Size(293, 27);
            txtIDCliente.TabIndex = 2;
            txtIDCliente.Text = "(Automático)";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(17, 118);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(35, 20);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(17, 142);
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "Ingrese el DNI";
            txtDNI.Size = new Size(293, 27);
            txtDNI.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 178);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(134, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(17, 202);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre completo";
            txtNombre.Size = new Size(293, 27);
            txtNombre.TabIndex = 6;
            // 
            // lblRTN
            // 
            lblRTN.AutoSize = true;
            lblRTN.Location = new Point(17, 238);
            lblRTN.Name = "lblRTN";
            lblRTN.Size = new Size(36, 20);
            lblRTN.TabIndex = 7;
            lblRTN.Text = "RTN";
            // 
            // txtRTN
            // 
            txtRTN.Location = new Point(17, 262);
            txtRTN.Name = "txtRTN";
            txtRTN.PlaceholderText = "Ingrese el RTN";
            txtRTN.Size = new Size(293, 27);
            txtRTN.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(17, 298);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(17, 322);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese el teléfono";
            txtTelefono.Size = new Size(293, 27);
            txtTelefono.TabIndex = 10;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(17, 358);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 11;
            lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(17, 382);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese el correo";
            txtCorreo.Size = new Size(293, 27);
            txtCorreo.TabIndex = 12;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(17, 418);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 13;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(17, 442);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese la dirección";
            txtDireccion.Size = new Size(293, 70);
            txtDireccion.TabIndex = 14;
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Location = new Point(17, 522);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(106, 20);
            lblFechaRegistro.TabIndex = 15;
            lblFechaRegistro.Text = "Fecha Registro";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Enabled = false;
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(17, 546);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(293, 27);
            dtpFechaRegistro.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(26, 115, 232);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(32, 602);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 40);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(220, 220, 220);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(178, 602);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 40);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "✖ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SeaGreen;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(32, 652);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(276, 40);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // pnlDerecho
            // 
            pnlDerecho.BackColor = Color.White;
            pnlDerecho.Controls.Add(lblTituloLista);
            pnlDerecho.Controls.Add(lblBuscar);
            pnlDerecho.Controls.Add(txtBuscar);
            pnlDerecho.Controls.Add(dgvClientes);
            pnlDerecho.Location = new Point(376, 82);
            pnlDerecho.Name = "pnlDerecho";
            pnlDerecho.Size = new Size(1008, 702);
            pnlDerecho.TabIndex = 2;
            // 
            // lblTituloLista
            // 
            lblTituloLista.AutoSize = true;
            lblTituloLista.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloLista.ForeColor = Color.FromArgb(26, 42, 74);
            lblTituloLista.Location = new Point(20, 20);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(204, 28);
            lblTituloLista.TabIndex = 0;
            lblTituloLista.Text = "Clientes Registrados";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(20, 67);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(102, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar Cliente";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(20, 92);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre, DNI o RTN...";
            txtBuscar.Size = new Size(330, 27);
            txtBuscar.TabIndex = 2;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeight = 40;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.Gainsboro;
            dgvClientes.Location = new Point(20, 135);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 227, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowTemplate.Height = 35;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(971, 545);
            dgvClientes.TabIndex = 3;
            // 
            // FrmNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1396, 800);
            Controls.Add(pnlHeader);
            Controls.Add(pnlIzquierdo);
            Controls.Add(pnlDerecho);
            Font = new Font("Segoe UI", 9F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNuevoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Cliente";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlIzquierdo.ResumeLayout(false);
            pnlIzquierdo.PerformLayout();
            pnlDerecho.ResumeLayout(false);
            pnlDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}