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
            tabMain = new TabControl();
            tabIllusionStrength = new TabPage();
            tabProduction = new TabPage();
            panelProduction = new Panel();
            lblProductionAmount = new Label();
            txtProductionAmount = new TextBox();
            lblProductionResult = new Label();
            txtProductionResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBattles).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPlayerPower).BeginInit();
            tabMain.SuspendLayout();
            tabIllusionStrength.SuspendLayout();
            tabProduction.SuspendLayout();
            panelProduction.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBattles
            // 
            dgvBattles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBattles.Dock = DockStyle.Fill;
            dgvBattles.Location = new Point(0, 40);
            dgvBattles.Name = "dgvBattles";
            dgvBattles.RowHeadersWidth = 51;
            dgvBattles.Size = new Size(792, 382);
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
            panelTop.Size = new Size(792, 40);
            panelTop.TabIndex = 1;
            // 
            // nudPlayerPower
            // 
            nudPlayerPower.Dock = DockStyle.Right;
            nudPlayerPower.Location = new Point(664, 8);
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
            // tabMain
            // 
            tabMain.Controls.Add(tabIllusionStrength);
            tabMain.Controls.Add(tabProduction);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(800, 450);
            tabMain.TabIndex = 2;
            // 
            // tabIllusionStrength
            // 
            tabIllusionStrength.Controls.Add(dgvBattles);
            tabIllusionStrength.Controls.Add(panelTop);
            tabIllusionStrength.Location = new Point(4, 29);
            tabIllusionStrength.Name = "tabIllusionStrength";
            tabIllusionStrength.Padding = new Padding(3);
            tabIllusionStrength.Size = new Size(792, 417);
            tabIllusionStrength.TabIndex = 0;
            tabIllusionStrength.Text = "illusion Strenght";
            tabIllusionStrength.UseVisualStyleBackColor = true;
            // 
            // tabProduction
            // 
            tabProduction.Controls.Add(panelProduction);
            tabProduction.Location = new Point(4, 29);
            tabProduction.Name = "tabProduction";
            tabProduction.Padding = new Padding(3);
            tabProduction.Size = new Size(792, 417);
            tabProduction.TabIndex = 1;
            tabProduction.Text = "Producción";
            tabProduction.UseVisualStyleBackColor = true;
            // 
            // panelProduction
            // 
            panelProduction.Controls.Add(txtProductionResult);
            panelProduction.Controls.Add(lblProductionResult);
            panelProduction.Controls.Add(txtProductionAmount);
            panelProduction.Controls.Add(lblProductionAmount);
            panelProduction.Dock = DockStyle.Top;
            panelProduction.Location = new Point(3, 3);
            panelProduction.Name = "panelProduction";
            panelProduction.Padding = new Padding(16);
            panelProduction.Size = new Size(786, 132);
            panelProduction.TabIndex = 0;
            // 
            // lblProductionAmount
            // 
            lblProductionAmount.AutoSize = true;
            lblProductionAmount.Location = new Point(16, 20);
            lblProductionAmount.Name = "lblProductionAmount";
            lblProductionAmount.Size = new Size(180, 20);
            lblProductionAmount.TabIndex = 0;
            lblProductionAmount.Text = "Cantidad a producir (int)";
            // 
            // txtProductionAmount
            // 
            txtProductionAmount.Location = new Point(16, 43);
            txtProductionAmount.Name = "txtProductionAmount";
            txtProductionAmount.Size = new Size(200, 27);
            txtProductionAmount.TabIndex = 1;
            txtProductionAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblProductionResult
            // 
            lblProductionResult.AutoSize = true;
            lblProductionResult.Location = new Point(16, 78);
            lblProductionResult.Name = "lblProductionResult";
            lblProductionResult.Size = new Size(195, 20);
            lblProductionResult.TabIndex = 2;
            lblProductionResult.Text = "Material necesario (x8)";
            // 
            // txtProductionResult
            // 
            txtProductionResult.Location = new Point(16, 101);
            txtProductionResult.Name = "txtProductionResult";
            txtProductionResult.ReadOnly = true;
            txtProductionResult.Size = new Size(200, 27);
            txtProductionResult.TabIndex = 3;
            txtProductionResult.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabMain);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvBattles).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPlayerPower).EndInit();
            tabMain.ResumeLayout(false);
            tabIllusionStrength.ResumeLayout(false);
            tabProduction.ResumeLayout(false);
            panelProduction.ResumeLayout(false);
            panelProduction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBattles;
        private Panel panelTop;
        private NumericUpDown nudPlayerPower;
        private Label lblPlayerPower;
        private TabControl tabMain;
        private TabPage tabIllusionStrength;
        private TabPage tabProduction;
        private Panel panelProduction;
        private Label lblProductionAmount;
        private TextBox txtProductionAmount;
        private Label lblProductionResult;
        private TextBox txtProductionResult;
    }
}
