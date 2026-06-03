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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtusuario = new TextBox();
            txtcontra = new TextBox();
            btningresar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(679, 82);
            label1.Name = "label1";
            label1.Size = new Size(209, 46);
            label1.TabIndex = 0;
            label1.Text = "Iniciar sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label2.Location = new Point(514, 225);
            label2.Name = "label2";
            label2.Size = new Size(90, 31);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label3.Location = new Point(514, 317);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(665, 225);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(238, 27);
            txtusuario.TabIndex = 3;
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(665, 317);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(238, 27);
            txtcontra.TabIndex = 4;
            // 
            // btningresar
            // 
            btningresar.FlatAppearance.BorderSize = 0;
            btningresar.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btningresar.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btningresar.FlatStyle = FlatStyle.Flat;
            btningresar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btningresar.Location = new Point(707, 471);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(94, 29);
            btningresar.TabIndex = 5;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1062, 116);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 820);
            Controls.Add(button1);
            Controls.Add(btningresar);
            Controls.Add(txtcontra);
            Controls.Add(txtusuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtusuario;
        private TextBox txtcontra;
        private Button btningresar;
        private Button button1;
    }
}
