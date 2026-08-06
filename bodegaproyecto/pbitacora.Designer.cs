namespace bodegaproyecto
{
    partial class pbitacora
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
            dataGridView1 = new DataGridView();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 89);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1519, 744);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(70, 130, 170);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Margin = new Padding(4);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1585, 69);
            pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BITACORA";
            // 
            // pbitacora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1585, 896);
            Controls.Add(pnlTitulo);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "pbitacora";
            Text = "pbitacora";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel pnlTitulo;
        private Label lblTitulo;
    }
}