namespace bodegaproyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtusuario = new TextBox();
            txtcontra = new TextBox();
            btningresar = new Button();
            button1 = new Button();
            pnlHeader = new Panel();
            lblTituloForm = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pnlHeader.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(207, 203);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(238, 27);
            txtusuario.TabIndex = 3;
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(207, 285);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(238, 27);
            txtcontra.TabIndex = 4;
            txtcontra.UseSystemPasswordChar = true;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.Transparent;
            btningresar.FlatAppearance.BorderSize = 0;
            btningresar.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btningresar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btningresar.FlatStyle = FlatStyle.Flat;
            btningresar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btningresar.Location = new Point(221, 380);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(105, 58);
            btningresar.TabIndex = 5;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(332, 380);
            button1.Name = "button1";
            button1.Size = new Size(113, 58);
            button1.TabIndex = 6;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 42, 74);
            pnlHeader.Controls.Add(lblTituloForm);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(201, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(307, 55);
            pnlHeader.TabIndex = 9;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(20, 12);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(187, 37);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "Iniciar Sesión";
            lblTituloForm.Click += lblTituloForm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(72, 285);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(72, 203);
            label2.Name = "label2";
            label2.Size = new Size(90, 31);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 42, 74);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 478);
            panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(239, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 478);
            Controls.Add(pictureBox2);
            Controls.Add(pnlHeader);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(btningresar);
            Controls.Add(txtcontra);
            Controls.Add(txtusuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtusuario;
        private TextBox txtcontra;
        private Button btningresar;
        private Button button1;
        private Panel pnlHeader;
        private Label lblTituloForm;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}
