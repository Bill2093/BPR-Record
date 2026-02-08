namespace BPR_Record;

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
        tableLayoutProduction = new TableLayoutPanel();
        lblProductionAmount = new Label();
        txtProductionAmount = new TextBox();
        lblProductionResult = new Label();
        txtProductionResult = new TextBox();
        lblLifeSkillCost = new Label();
        txtLifeSkillCost = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dgvBattles).BeginInit();
        panelTop.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudPlayerPower).BeginInit();
        tabMain.SuspendLayout();
        tabIllusionStrength.SuspendLayout();
        tabProduction.SuspendLayout();
        panelProduction.SuspendLayout();
        tableLayoutProduction.SuspendLayout();
        SuspendLayout();
        // 
        // dgvBattles
        // 
        dgvBattles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvBattles.Dock = DockStyle.Fill;
        dgvBattles.Location = new Point(3, 43);
        dgvBattles.Name = "dgvBattles";
        dgvBattles.RowHeadersWidth = 51;
        dgvBattles.Size = new Size(746, 874);
        dgvBattles.TabIndex = 0;
        // 
        // panelTop
        // 
        panelTop.Controls.Add(nudPlayerPower);
        panelTop.Controls.Add(lblPlayerPower);
        panelTop.Dock = DockStyle.Top;
        panelTop.Location = new Point(3, 3);
        panelTop.Name = "panelTop";
        panelTop.Padding = new Padding(8);
        panelTop.Size = new Size(746, 40);
        panelTop.TabIndex = 1;
        // 
        // nudPlayerPower
        // 
        nudPlayerPower.Dock = DockStyle.Right;
        nudPlayerPower.Location = new Point(618, 8);
        nudPlayerPower.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
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
        lblPlayerPower.Size = new Size(128, 20);
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
        tabMain.Size = new Size(760, 953);
        tabMain.TabIndex = 2;
        // 
        // tabIllusionStrength
        // 
        tabIllusionStrength.Controls.Add(dgvBattles);
        tabIllusionStrength.Controls.Add(panelTop);
        tabIllusionStrength.Location = new Point(4, 29);
        tabIllusionStrength.Name = "tabIllusionStrength";
        tabIllusionStrength.Padding = new Padding(3);
        tabIllusionStrength.Size = new Size(752, 920);
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
        tabProduction.Size = new Size(752, 920);
        tabProduction.TabIndex = 1;
        tabProduction.Text = "Producción";
        tabProduction.UseVisualStyleBackColor = true;
        // 
        // panelProduction
        // 
        panelProduction.AutoSize = true;
        panelProduction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        panelProduction.Controls.Add(tableLayoutProduction);
        panelProduction.Dock = DockStyle.Top;
        panelProduction.Location = new Point(3, 3);
        panelProduction.Name = "panelProduction";
        panelProduction.Padding = new Padding(16);
        panelProduction.Size = new Size(746, 161);
        panelProduction.TabIndex = 0;
        // 
        // tableLayoutProduction
        // 
        tableLayoutProduction.AutoSize = true;
        tableLayoutProduction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        tableLayoutProduction.ColumnCount = 2;
        tableLayoutProduction.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        tableLayoutProduction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
        tableLayoutProduction.Controls.Add(lblProductionAmount, 0, 0);
        tableLayoutProduction.Controls.Add(txtProductionAmount, 1, 0);
        tableLayoutProduction.Controls.Add(lblProductionResult, 0, 1);
        tableLayoutProduction.Controls.Add(txtProductionResult, 1, 1);
        tableLayoutProduction.Controls.Add(lblLifeSkillCost, 0, 2);
        tableLayoutProduction.Controls.Add(txtLifeSkillCost, 1, 2);
        tableLayoutProduction.Dock = DockStyle.Top;
        tableLayoutProduction.Location = new Point(16, 16);
        tableLayoutProduction.Name = "tableLayoutProduction";
        tableLayoutProduction.RowCount = 3;
        tableLayoutProduction.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        tableLayoutProduction.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        tableLayoutProduction.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        tableLayoutProduction.Size = new Size(407, 129);
        tableLayoutProduction.TabIndex = 0;
        // 
        // lblProductionAmount
        // 
        lblProductionAmount.Anchor = AnchorStyles.Left;
        lblProductionAmount.AutoSize = true;
        lblProductionAmount.Location = new Point(3, 6);
        lblProductionAmount.Name = "lblProductionAmount";
        lblProductionAmount.Size = new Size(172, 20);
        lblProductionAmount.TabIndex = 0;
        lblProductionAmount.Text = "Cantidad a producir (int)";
        // 
        // txtProductionAmount
        // 
        txtProductionAmount.Anchor = AnchorStyles.Left;
        txtProductionAmount.Location = new Point(190, 3);
        txtProductionAmount.Name = "txtProductionAmount";
        txtProductionAmount.Size = new Size(200, 27);
        txtProductionAmount.TabIndex = 1;
        txtProductionAmount.TextAlign = HorizontalAlignment.Right;
        // 
        // lblProductionResult
        // 
        lblProductionResult.AutoSize = true;
        lblProductionResult.Location = new Point(3, 43);
        lblProductionResult.Name = "lblProductionResult";
        lblProductionResult.Size = new Size(160, 20);
        lblProductionResult.TabIndex = 2;
        lblProductionResult.Text = "Material necesario (x8)";
        // 
        // txtProductionResult
        // 
        txtProductionResult.Anchor = AnchorStyles.Left;
        txtProductionResult.Location = new Point(190, 46);
        txtProductionResult.Name = "txtProductionResult";
        txtProductionResult.ReadOnly = true;
        txtProductionResult.Size = new Size(200, 27);
        txtProductionResult.TabIndex = 3;
        txtProductionResult.TextAlign = HorizontalAlignment.Right;
        // 
        // lblLifeSkillCost
        // 
        lblLifeSkillCost.Anchor = AnchorStyles.Left;
        lblLifeSkillCost.AutoSize = true;
        lblLifeSkillCost.Location = new Point(3, 86);
        lblLifeSkillCost.Name = "lblLifeSkillCost";
        lblLifeSkillCost.Size = new Size(126, 20);
        lblLifeSkillCost.TabIndex = 4;
        lblLifeSkillCost.Text = "Costo de Life Skill";
        // 
        // txtLifeSkillCost
        // 
        txtLifeSkillCost.Anchor = AnchorStyles.Left;
        txtLifeSkillCost.Location = new Point(190, 89);
        txtLifeSkillCost.Name = "txtLifeSkillCost";
        txtLifeSkillCost.ReadOnly = true;
        txtLifeSkillCost.Size = new Size(200, 27);
        txtLifeSkillCost.TabIndex = 5;
        txtLifeSkillCost.TextAlign = HorizontalAlignment.Right;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(760, 953);
        Controls.Add(tabMain);
        Name = "Form1";
        Text = "BPR Balance Calculator";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dgvBattles).EndInit();
        panelTop.ResumeLayout(false);
        panelTop.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudPlayerPower).EndInit();
        tabMain.ResumeLayout(false);
        tabIllusionStrength.ResumeLayout(false);
        tabProduction.ResumeLayout(false);
        panelProduction.ResumeLayout(false);
        panelProduction.PerformLayout();
        tableLayoutProduction.ResumeLayout(false);
        tableLayoutProduction.PerformLayout();
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
    private TableLayoutPanel tableLayoutProduction;
    private Label lblProductionAmount;
    private TextBox txtProductionAmount;
    private Label lblProductionResult;
    private TextBox txtProductionResult;
    private Label lblLifeSkillCost;
    private TextBox txtLifeSkillCost;
}
