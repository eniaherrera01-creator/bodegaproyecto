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
            txtcontra = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            btncerrar = new Button();
            btningresar = new Button();
            txtusuario = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtcontra
            // 
            txtcontra.BorderStyle = BorderStyle.None;
            txtcontra.Location = new Point(476, 259);
            txtcontra.Multiline = true;
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(285, 27);
            txtcontra.TabIndex = 4;
            txtcontra.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 243, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 550);
            panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(85, 85, 119);
            label4.Location = new Point(54, 315);
            label4.Name = "label4";
            label4.Size = new Size(200, 72);
            label4.TabIndex = 9;
            label4.Text = "Accede a tu cuenta para continuar";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(62, 258);
            label1.Name = "label1";
            label1.Size = new Size(192, 46);
            label1.TabIndex = 10;
            label1.Text = "Bienvenido";
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.Transparent;
            btncerrar.BackgroundImageLayout = ImageLayout.Center;
            btncerrar.FlatAppearance.BorderSize = 0;
            btncerrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btncerrar.FlatStyle = FlatStyle.Flat;
            btncerrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncerrar.ForeColor = Color.FromArgb(59, 130, 246);
            btncerrar.Location = new Point(461, 437);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(300, 45);
            btncerrar.TabIndex = 15;
            btncerrar.Text = "Cerrar";
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.FromArgb(59, 130, 246);
            btningresar.BackgroundImageLayout = ImageLayout.Stretch;
            btningresar.FlatAppearance.BorderSize = 0;
            btningresar.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btningresar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btningresar.FlatStyle = FlatStyle.Flat;
            btningresar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btningresar.ForeColor = Color.White;
            btningresar.Location = new Point(461, 373);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(300, 45);
            btningresar.TabIndex = 14;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += button3_Click;
            // 
            // txtusuario
            // 
            txtusuario.BorderStyle = BorderStyle.None;
            txtusuario.ForeColor = Color.Black;
            txtusuario.Location = new Point(476, 206);
            txtusuario.Multiline = true;
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(285, 28);
            txtusuario.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveBorder;
            label5.Location = new Point(362, 259);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 18;
            label5.Text = "🔒 Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveBorder;
            label6.Location = new Point(362, 214);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 17;
            label6.Text = "👤 Usuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(248, 250, 252);
            label7.Font = new Font("Segoe Fluent Icons", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(492, 95);
            label7.Name = "label7";
            label7.Size = new Size(215, 40);
            label7.TabIndex = 11;
            label7.Text = "Iniciar Sesión";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(panel1);
            Controls.Add(btncerrar);
            Controls.Add(btningresar);
            Controls.Add(txtusuario);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtcontra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtcontra;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
        private Button btncerrar;
        private Button btningresar;
        private TextBox txtusuario;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
