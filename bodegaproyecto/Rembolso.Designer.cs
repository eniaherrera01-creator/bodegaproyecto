namespace bodegaproyecto
{
    partial class Rembolso
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            plRembolso = new Panel();
            BTVolver = new Button();
            dgvDetallesRembolso = new DataGridView();
            LBLver = new Label();
            label1 = new Label();
            plRembolso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesRembolso).BeginInit();
            SuspendLayout();
            // 
            // plRembolso
            // 
            plRembolso.BackColor = Color.White;
            plRembolso.Controls.Add(BTVolver);
            plRembolso.Controls.Add(dgvDetallesRembolso);
            plRembolso.Controls.Add(LBLver);
            plRembolso.Controls.Add(label1);
            plRembolso.Location = new Point(12, 11);
            plRembolso.Margin = new Padding(3, 2, 3, 2);
            plRembolso.Name = "plRembolso";
            plRembolso.Size = new Size(1016, 407);
            plRembolso.TabIndex = 16;
            // 
            // BTVolver
            // 
            BTVolver.BackColor = Color.DeepSkyBlue;
            BTVolver.Cursor = Cursors.Hand;
            BTVolver.FlatAppearance.BorderSize = 0;
            BTVolver.FlatStyle = FlatStyle.Flat;
            BTVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTVolver.ForeColor = Color.White;
            BTVolver.Location = new Point(19, 361);
            BTVolver.Margin = new Padding(3, 2, 3, 2);
            BTVolver.Name = "BTVolver";
            BTVolver.Size = new Size(271, 32);
            BTVolver.TabIndex = 14;
            BTVolver.Text = "volver";
            BTVolver.UseVisualStyleBackColor = false;
            BTVolver.Click += this.BTVolver_Click;
            // 
            // dgvDetallesRembolso
            // 
            dgvDetallesRembolso.AllowUserToAddRows = false;
            dgvDetallesRembolso.AllowUserToDeleteRows = false;
            dgvDetallesRembolso.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvDetallesRembolso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetallesRembolso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesRembolso.BackgroundColor = Color.White;
            dgvDetallesRembolso.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 42, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDetallesRembolso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetallesRembolso.ColumnHeadersHeight = 40;
            dgvDetallesRembolso.EnableHeadersVisualStyles = false;
            dgvDetallesRembolso.Location = new Point(19, 39);
            dgvDetallesRembolso.Margin = new Padding(3, 2, 3, 2);
            dgvDetallesRembolso.MultiSelect = false;
            dgvDetallesRembolso.Name = "dgvDetallesRembolso";
            dgvDetallesRembolso.ReadOnly = true;
            dgvDetallesRembolso.RowHeadersVisible = false;
            dgvDetallesRembolso.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 227, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvDetallesRembolso.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetallesRembolso.RowTemplate.Height = 35;
            dgvDetallesRembolso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetallesRembolso.Size = new Size(982, 239);
            dgvDetallesRembolso.TabIndex = 20;
            // 
            // LBLver
            // 
            LBLver.AutoSize = true;
            LBLver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LBLver.ForeColor = Color.FromArgb(26, 42, 74);
            LBLver.Location = new Point(19, 16);
            LBLver.Name = "LBLver";
            LBLver.Size = new Size(190, 21);
            LBLver.TabIndex = 15;
            LBLver.Text = "Detalles de Remmbolso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 92);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 16;
            // 
            // Rembolso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 673);
            Controls.Add(plRembolso);
            Name = "Rembolso";
            Text = "Form2";
            plRembolso.ResumeLayout(false);
            plRembolso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesRembolso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plRembolso;
        private Button BTVolver;
        private Label LBLver;
        private Label label1;
        private DataGridView dgvDetallesRembolso;
    }
}