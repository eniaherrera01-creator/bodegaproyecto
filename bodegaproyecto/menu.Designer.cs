namespace bodegaproyecto
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btncerrar = new Button();
            panel1 = new Panel();
            btnminimizar = new Button();
            btnmaximizar = new Button();
            panel2 = new Panel();
            menuadmin = new Panel();
            btnusuarios = new Button();
            btnusuario = new Button();
            panelcontenedor = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuadmin.SuspendLayout();
            SuspendLayout();
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.FlatAppearance.BorderSize = 0;
            btncerrar.FlatStyle = FlatStyle.Flat;
            btncerrar.Location = new Point(1357, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(81, 51);
            btncerrar.TabIndex = 0;
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(btnminimizar);
            panel1.Controls.Add(btnmaximizar);
            panel1.Controls.Add(btncerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1450, 83);
            panel1.TabIndex = 1;
            // 
            // btnminimizar
            // 
            btnminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnminimizar.FlatAppearance.BorderSize = 0;
            btnminimizar.FlatStyle = FlatStyle.Flat;
            btnminimizar.Location = new Point(1183, 12);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(81, 51);
            btnminimizar.TabIndex = 2;
            btnminimizar.UseVisualStyleBackColor = true;
            // 
            // btnmaximizar
            // 
            btnmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmaximizar.FlatAppearance.BorderSize = 0;
            btnmaximizar.FlatStyle = FlatStyle.Flat;
            btnmaximizar.Location = new Point(1270, 12);
            btnmaximizar.Name = "btnmaximizar";
            btnmaximizar.Size = new Size(81, 51);
            btnmaximizar.TabIndex = 1;
            btnmaximizar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(menuadmin);
            panel2.Controls.Add(btnusuario);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 690);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // menuadmin
            // 
            menuadmin.Controls.Add(btnusuarios);
            menuadmin.Location = new Point(24, 162);
            menuadmin.Name = "menuadmin";
            menuadmin.Size = new Size(156, 98);
            menuadmin.TabIndex = 3;
            menuadmin.Visible = false;
            // 
            // btnusuarios
            // 
            btnusuarios.FlatAppearance.BorderSize = 0;
            btnusuarios.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnusuarios.FlatStyle = FlatStyle.Flat;
            btnusuarios.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnusuarios.ForeColor = Color.White;
            btnusuarios.Location = new Point(6, 16);
            btnusuarios.Name = "btnusuarios";
            btnusuarios.Size = new Size(153, 51);
            btnusuarios.TabIndex = 4;
            btnusuarios.Text = "Usuarios";
            btnusuarios.UseVisualStyleBackColor = true;
            btnusuarios.Click += button2_Click;
            // 
            // btnusuario
            // 
            btnusuario.FlatAppearance.BorderSize = 0;
            btnusuario.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnusuario.FlatStyle = FlatStyle.Flat;
            btnusuario.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnusuario.ForeColor = Color.White;
            btnusuario.Location = new Point(12, 105);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(153, 51);
            btnusuario.TabIndex = 3;
            btnusuario.Text = "Administracion";
            btnusuario.UseVisualStyleBackColor = true;
            btnusuario.Click += btnusuario_Click;
            // 
            // panelcontenedor
            // 
            panelcontenedor.Dock = DockStyle.Fill;
            panelcontenedor.Location = new Point(183, 83);
            panelcontenedor.Name = "panelcontenedor";
            panelcontenedor.Size = new Size(1267, 690);
            panelcontenedor.TabIndex = 3;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 773);
            Controls.Add(panelcontenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menu";
            WindowState = FormWindowState.Maximized;
            Load += menu_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            menuadmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btncerrar;
        private Panel panel1;
        private Panel panel2;
        private Button btnusuario;
        private Panel menuadmin;
        private Button btnusuarios;
        private Panel panelcontenedor;
        private Button btnminimizar;
        private Button btnmaximizar;
    }
}