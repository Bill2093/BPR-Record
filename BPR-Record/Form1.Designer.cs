namespace BPR_Record
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
            dgvBattles = new DataGridView();
            panelTop = new Panel();
            nudPlayerPower = new NumericUpDown();
            lblPlayerPower = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBattles).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPlayerPower).BeginInit();
            SuspendLayout();
            // 
            // dgvBattles
            // 
            dgvBattles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBattles.Dock = DockStyle.Fill;
            dgvBattles.Location = new Point(0, 40);
            dgvBattles.Name = "dgvBattles";
            dgvBattles.RowHeadersWidth = 51;
            dgvBattles.Size = new Size(800, 410);
            dgvBattles.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(nudPlayerPower);
            panelTop.Controls.Add(lblPlayerPower);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(8);
            panelTop.Size = new Size(800, 40);
            panelTop.TabIndex = 1;
            // 
            // nudPlayerPower
            // 
            nudPlayerPower.Dock = DockStyle.Right;
            nudPlayerPower.Location = new Point(672, 8);
            nudPlayerPower.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudPlayerPower.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudPlayerPower.Name = "nudPlayerPower";
            nudPlayerPower.Size = new Size(120, 27);
            nudPlayerPower.TabIndex = 0;
            nudPlayerPower.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPlayerPower
            // 
            lblPlayerPower.AutoSize = true;
            lblPlayerPower.Dock = DockStyle.Left;
            lblPlayerPower.Location = new Point(8, 8);
            lblPlayerPower.Name = "lblPlayerPower";
            lblPlayerPower.Size = new Size(122, 20);
            lblPlayerPower.TabIndex = 1;
            lblPlayerPower.Text = "Poder del jugador";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBattles);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvBattles).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPlayerPower).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBattles;
        private Panel panelTop;
        private NumericUpDown nudPlayerPower;
        private Label lblPlayerPower;
    }
}
