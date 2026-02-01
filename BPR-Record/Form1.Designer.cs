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
            nudPlayerPower = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvBattles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPlayerPower).BeginInit();
            SuspendLayout();
            // 
            // dgvBattles
            // 
            dgvBattles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBattles.Dock = DockStyle.Fill;
            dgvBattles.Location = new Point(0, 0);
            dgvBattles.Name = "dgvBattles";
            dgvBattles.RowHeadersWidth = 51;
            dgvBattles.Size = new Size(800, 450);
            dgvBattles.TabIndex = 0;
            // 
            // nudPlayerPower
            // 
            nudPlayerPower.Location = new Point(8, 8);
            nudPlayerPower.Name = "nudPlayerPower";
            nudPlayerPower.Size = new Size(150, 27);
            nudPlayerPower.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudPlayerPower);
            Controls.Add(dgvBattles);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBattles).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPlayerPower).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBattles;
        private NumericUpDown nudPlayerPower;
    }
}
