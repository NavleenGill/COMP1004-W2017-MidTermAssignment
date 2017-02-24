namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    partial class FinalForm
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
      this.MenuMenuStrip = new System.Windows.Forms.MenuStrip();
      this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.PrintMenuButton = new System.Windows.Forms.ToolStripMenuItem();
      this.ExitMenuButton = new System.Windows.Forms.ToolStripMenuItem();
      this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.FontMenuButton = new System.Windows.Forms.ToolStripMenuItem();
      this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.AbouMenuButton = new System.Windows.Forms.ToolStripMenuItem();
      this.CharInfoGroupBox = new System.Windows.Forms.GroupBox();
      this.WeightTextBox = new System.Windows.Forms.TextBox();
      this.HeightTextBox = new System.Windows.Forms.TextBox();
      this.AgeTextBox = new System.Windows.Forms.TextBox();
      this.NameTextBox = new System.Windows.Forms.TextBox();
      this.WeightLabel = new System.Windows.Forms.Label();
      this.HeightLabel = new System.Windows.Forms.Label();
      this.AgeLabel = new System.Windows.Forms.Label();
      this.NameLabel = new System.Windows.Forms.Label();
      this.MiscGroupBox = new System.Windows.Forms.GroupBox();
      this.HPTextBox = new System.Windows.Forms.TextBox();
      this.HPLabel = new System.Windows.Forms.Label();
      this.RaceTextBox = new System.Windows.Forms.TextBox();
      this.RaceLabel = new System.Windows.Forms.Label();
      this.JobTextBox = new System.Windows.Forms.TextBox();
      this.JobLabel = new System.Windows.Forms.Label();
      this.AbilitiesGroupBox = new System.Windows.Forms.GroupBox();
      this.ChaTextBox = new System.Windows.Forms.TextBox();
      this.PerTextBox = new System.Windows.Forms.TextBox();
      this.IntTextBox = new System.Windows.Forms.TextBox();
      this.EndTextBox = new System.Windows.Forms.TextBox();
      this.DexTextBox = new System.Windows.Forms.TextBox();
      this.StrTextBox = new System.Windows.Forms.TextBox();
      this.ChaTextLabel = new System.Windows.Forms.Label();
      this.PerTextLabel = new System.Windows.Forms.Label();
      this.IntTextLabel = new System.Windows.Forms.Label();
      this.EndTextLabel = new System.Windows.Forms.Label();
      this.DexTextLabel = new System.Windows.Forms.Label();
      this.StrTextLabel = new System.Windows.Forms.Label();
      this.RacePictureBox = new System.Windows.Forms.PictureBox();
      this.MenuMenuStrip.SuspendLayout();
      this.CharInfoGroupBox.SuspendLayout();
      this.MiscGroupBox.SuspendLayout();
      this.AbilitiesGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.RacePictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // MenuMenuStrip
      // 
      this.MenuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.HelpMenu});
      this.MenuMenuStrip.Location = new System.Drawing.Point(0, 0);
      this.MenuMenuStrip.Name = "MenuMenuStrip";
      this.MenuMenuStrip.Size = new System.Drawing.Size(821, 24);
      this.MenuMenuStrip.TabIndex = 0;
      this.MenuMenuStrip.Text = "menuStrip1";
      // 
      // FileMenu
      // 
      this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintMenuButton,
            this.ExitMenuButton});
      this.FileMenu.Name = "FileMenu";
      this.FileMenu.Size = new System.Drawing.Size(37, 20);
      this.FileMenu.Text = "&File";
      // 
      // PrintMenuButton
      // 
      this.PrintMenuButton.Name = "PrintMenuButton";
      this.PrintMenuButton.Size = new System.Drawing.Size(152, 22);
      this.PrintMenuButton.Text = "&Print";
      this.PrintMenuButton.Click += new System.EventHandler(this.PrintMenuButton_Click);
      // 
      // ExitMenuButton
      // 
      this.ExitMenuButton.Name = "ExitMenuButton";
      this.ExitMenuButton.Size = new System.Drawing.Size(99, 22);
      this.ExitMenuButton.Text = "E&xit";
      this.ExitMenuButton.Click += new System.EventHandler(this.ExitMenuButton_Click);
      // 
      // EditMenu
      // 
      this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontMenuButton});
      this.EditMenu.Name = "EditMenu";
      this.EditMenu.Size = new System.Drawing.Size(39, 20);
      this.EditMenu.Text = "&Edit";
      // 
      // FontMenuButton
      // 
      this.FontMenuButton.Name = "FontMenuButton";
      this.FontMenuButton.Size = new System.Drawing.Size(152, 22);
      this.FontMenuButton.Text = "&Font";
      this.FontMenuButton.Click += new System.EventHandler(this.FontMenuButton_Click);
      // 
      // HelpMenu
      // 
      this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbouMenuButton});
      this.HelpMenu.Name = "HelpMenu";
      this.HelpMenu.Size = new System.Drawing.Size(44, 20);
      this.HelpMenu.Text = "&Help";
      // 
      // AbouMenuButton
      // 
      this.AbouMenuButton.Name = "AbouMenuButton";
      this.AbouMenuButton.Size = new System.Drawing.Size(152, 22);
      this.AbouMenuButton.Text = "&About";
      this.AbouMenuButton.Click += new System.EventHandler(this.AbouMenuButton_Click);
      // 
      // CharInfoGroupBox
      // 
      this.CharInfoGroupBox.Controls.Add(this.WeightTextBox);
      this.CharInfoGroupBox.Controls.Add(this.HeightTextBox);
      this.CharInfoGroupBox.Controls.Add(this.AgeTextBox);
      this.CharInfoGroupBox.Controls.Add(this.NameTextBox);
      this.CharInfoGroupBox.Controls.Add(this.WeightLabel);
      this.CharInfoGroupBox.Controls.Add(this.HeightLabel);
      this.CharInfoGroupBox.Controls.Add(this.AgeLabel);
      this.CharInfoGroupBox.Controls.Add(this.NameLabel);
      this.CharInfoGroupBox.Location = new System.Drawing.Point(12, 40);
      this.CharInfoGroupBox.Name = "CharInfoGroupBox";
      this.CharInfoGroupBox.Size = new System.Drawing.Size(481, 115);
      this.CharInfoGroupBox.TabIndex = 1;
      this.CharInfoGroupBox.TabStop = false;
      this.CharInfoGroupBox.Text = "Character Information";
      // 
      // WeightTextBox
      // 
      this.WeightTextBox.Location = new System.Drawing.Point(331, 70);
      this.WeightTextBox.Name = "WeightTextBox";
      this.WeightTextBox.Size = new System.Drawing.Size(100, 22);
      this.WeightTextBox.TabIndex = 7;
      // 
      // HeightTextBox
      // 
      this.HeightTextBox.Location = new System.Drawing.Point(331, 28);
      this.HeightTextBox.Name = "HeightTextBox";
      this.HeightTextBox.Size = new System.Drawing.Size(100, 22);
      this.HeightTextBox.TabIndex = 6;
      // 
      // AgeTextBox
      // 
      this.AgeTextBox.Location = new System.Drawing.Point(93, 70);
      this.AgeTextBox.Name = "AgeTextBox";
      this.AgeTextBox.Size = new System.Drawing.Size(100, 22);
      this.AgeTextBox.TabIndex = 5;
      // 
      // NameTextBox
      // 
      this.NameTextBox.Location = new System.Drawing.Point(93, 28);
      this.NameTextBox.Name = "NameTextBox";
      this.NameTextBox.Size = new System.Drawing.Size(100, 22);
      this.NameTextBox.TabIndex = 4;
      // 
      // WeightLabel
      // 
      this.WeightLabel.AutoSize = true;
      this.WeightLabel.Location = new System.Drawing.Point(244, 73);
      this.WeightLabel.Name = "WeightLabel";
      this.WeightLabel.Size = new System.Drawing.Size(50, 16);
      this.WeightLabel.TabIndex = 3;
      this.WeightLabel.Text = "Weight";
      // 
      // HeightLabel
      // 
      this.HeightLabel.AutoSize = true;
      this.HeightLabel.Location = new System.Drawing.Point(244, 31);
      this.HeightLabel.Name = "HeightLabel";
      this.HeightLabel.Size = new System.Drawing.Size(47, 16);
      this.HeightLabel.TabIndex = 2;
      this.HeightLabel.Text = "Height";
      // 
      // AgeLabel
      // 
      this.AgeLabel.AutoSize = true;
      this.AgeLabel.Location = new System.Drawing.Point(16, 73);
      this.AgeLabel.Name = "AgeLabel";
      this.AgeLabel.Size = new System.Drawing.Size(33, 16);
      this.AgeLabel.TabIndex = 1;
      this.AgeLabel.Text = "Age";
      // 
      // NameLabel
      // 
      this.NameLabel.AutoSize = true;
      this.NameLabel.Location = new System.Drawing.Point(16, 31);
      this.NameLabel.Name = "NameLabel";
      this.NameLabel.Size = new System.Drawing.Size(45, 16);
      this.NameLabel.TabIndex = 0;
      this.NameLabel.Text = "Name";
      // 
      // MiscGroupBox
      // 
      this.MiscGroupBox.Controls.Add(this.HPTextBox);
      this.MiscGroupBox.Controls.Add(this.HPLabel);
      this.MiscGroupBox.Controls.Add(this.RaceTextBox);
      this.MiscGroupBox.Controls.Add(this.RaceLabel);
      this.MiscGroupBox.Controls.Add(this.JobTextBox);
      this.MiscGroupBox.Controls.Add(this.JobLabel);
      this.MiscGroupBox.Location = new System.Drawing.Point(287, 161);
      this.MiscGroupBox.Name = "MiscGroupBox";
      this.MiscGroupBox.Size = new System.Drawing.Size(206, 240);
      this.MiscGroupBox.TabIndex = 3;
      this.MiscGroupBox.TabStop = false;
      // 
      // HPTextBox
      // 
      this.HPTextBox.Location = new System.Drawing.Point(84, 103);
      this.HPTextBox.Name = "HPTextBox";
      this.HPTextBox.ReadOnly = true;
      this.HPTextBox.Size = new System.Drawing.Size(116, 22);
      this.HPTextBox.TabIndex = 22;
      // 
      // HPLabel
      // 
      this.HPLabel.AutoSize = true;
      this.HPLabel.Location = new System.Drawing.Point(6, 106);
      this.HPLabel.Name = "HPLabel";
      this.HPLabel.Size = new System.Drawing.Size(27, 16);
      this.HPLabel.TabIndex = 21;
      this.HPLabel.Text = "HP";
      // 
      // RaceTextBox
      // 
      this.RaceTextBox.Location = new System.Drawing.Point(84, 68);
      this.RaceTextBox.Name = "RaceTextBox";
      this.RaceTextBox.ReadOnly = true;
      this.RaceTextBox.Size = new System.Drawing.Size(116, 22);
      this.RaceTextBox.TabIndex = 20;
      // 
      // RaceLabel
      // 
      this.RaceLabel.AutoSize = true;
      this.RaceLabel.Location = new System.Drawing.Point(6, 71);
      this.RaceLabel.Name = "RaceLabel";
      this.RaceLabel.Size = new System.Drawing.Size(41, 16);
      this.RaceLabel.TabIndex = 19;
      this.RaceLabel.Text = "Race";
      // 
      // JobTextBox
      // 
      this.JobTextBox.Location = new System.Drawing.Point(84, 33);
      this.JobTextBox.Name = "JobTextBox";
      this.JobTextBox.ReadOnly = true;
      this.JobTextBox.Size = new System.Drawing.Size(116, 22);
      this.JobTextBox.TabIndex = 18;
      // 
      // JobLabel
      // 
      this.JobLabel.AutoSize = true;
      this.JobLabel.Location = new System.Drawing.Point(6, 36);
      this.JobLabel.Name = "JobLabel";
      this.JobLabel.Size = new System.Drawing.Size(31, 16);
      this.JobLabel.TabIndex = 17;
      this.JobLabel.Text = "Job";
      // 
      // AbilitiesGroupBox
      // 
      this.AbilitiesGroupBox.Controls.Add(this.ChaTextBox);
      this.AbilitiesGroupBox.Controls.Add(this.PerTextBox);
      this.AbilitiesGroupBox.Controls.Add(this.IntTextBox);
      this.AbilitiesGroupBox.Controls.Add(this.EndTextBox);
      this.AbilitiesGroupBox.Controls.Add(this.DexTextBox);
      this.AbilitiesGroupBox.Controls.Add(this.StrTextBox);
      this.AbilitiesGroupBox.Controls.Add(this.ChaTextLabel);
      this.AbilitiesGroupBox.Controls.Add(this.PerTextLabel);
      this.AbilitiesGroupBox.Controls.Add(this.IntTextLabel);
      this.AbilitiesGroupBox.Controls.Add(this.EndTextLabel);
      this.AbilitiesGroupBox.Controls.Add(this.DexTextLabel);
      this.AbilitiesGroupBox.Controls.Add(this.StrTextLabel);
      this.AbilitiesGroupBox.Location = new System.Drawing.Point(12, 161);
      this.AbilitiesGroupBox.Name = "AbilitiesGroupBox";
      this.AbilitiesGroupBox.Size = new System.Drawing.Size(269, 240);
      this.AbilitiesGroupBox.TabIndex = 4;
      this.AbilitiesGroupBox.TabStop = false;
      this.AbilitiesGroupBox.Text = "Abilities";
      // 
      // ChaTextBox
      // 
      this.ChaTextBox.Location = new System.Drawing.Point(93, 205);
      this.ChaTextBox.Name = "ChaTextBox";
      this.ChaTextBox.ReadOnly = true;
      this.ChaTextBox.Size = new System.Drawing.Size(155, 22);
      this.ChaTextBox.TabIndex = 16;
      // 
      // PerTextBox
      // 
      this.PerTextBox.Location = new System.Drawing.Point(93, 173);
      this.PerTextBox.Name = "PerTextBox";
      this.PerTextBox.ReadOnly = true;
      this.PerTextBox.Size = new System.Drawing.Size(155, 22);
      this.PerTextBox.TabIndex = 15;
      // 
      // IntTextBox
      // 
      this.IntTextBox.Location = new System.Drawing.Point(93, 138);
      this.IntTextBox.Name = "IntTextBox";
      this.IntTextBox.ReadOnly = true;
      this.IntTextBox.Size = new System.Drawing.Size(155, 22);
      this.IntTextBox.TabIndex = 14;
      // 
      // EndTextBox
      // 
      this.EndTextBox.Location = new System.Drawing.Point(93, 103);
      this.EndTextBox.Name = "EndTextBox";
      this.EndTextBox.ReadOnly = true;
      this.EndTextBox.Size = new System.Drawing.Size(155, 22);
      this.EndTextBox.TabIndex = 13;
      // 
      // DexTextBox
      // 
      this.DexTextBox.Location = new System.Drawing.Point(93, 68);
      this.DexTextBox.Name = "DexTextBox";
      this.DexTextBox.ReadOnly = true;
      this.DexTextBox.Size = new System.Drawing.Size(155, 22);
      this.DexTextBox.TabIndex = 12;
      // 
      // StrTextBox
      // 
      this.StrTextBox.Location = new System.Drawing.Point(93, 33);
      this.StrTextBox.Name = "StrTextBox";
      this.StrTextBox.ReadOnly = true;
      this.StrTextBox.Size = new System.Drawing.Size(155, 22);
      this.StrTextBox.TabIndex = 11;
      // 
      // ChaTextLabel
      // 
      this.ChaTextLabel.AutoSize = true;
      this.ChaTextLabel.Location = new System.Drawing.Point(9, 208);
      this.ChaTextLabel.Name = "ChaTextLabel";
      this.ChaTextLabel.Size = new System.Drawing.Size(32, 16);
      this.ChaTextLabel.TabIndex = 10;
      this.ChaTextLabel.Text = "Cha";
      // 
      // PerTextLabel
      // 
      this.PerTextLabel.AutoSize = true;
      this.PerTextLabel.Location = new System.Drawing.Point(9, 173);
      this.PerTextLabel.Name = "PerTextLabel";
      this.PerTextLabel.Size = new System.Drawing.Size(29, 16);
      this.PerTextLabel.TabIndex = 9;
      this.PerTextLabel.Text = "Per";
      // 
      // IntTextLabel
      // 
      this.IntTextLabel.AutoSize = true;
      this.IntTextLabel.Location = new System.Drawing.Point(9, 138);
      this.IntTextLabel.Name = "IntTextLabel";
      this.IntTextLabel.Size = new System.Drawing.Size(21, 16);
      this.IntTextLabel.TabIndex = 8;
      this.IntTextLabel.Text = "Int";
      // 
      // EndTextLabel
      // 
      this.EndTextLabel.AutoSize = true;
      this.EndTextLabel.Location = new System.Drawing.Point(9, 103);
      this.EndTextLabel.Name = "EndTextLabel";
      this.EndTextLabel.Size = new System.Drawing.Size(32, 16);
      this.EndTextLabel.TabIndex = 7;
      this.EndTextLabel.Text = "End";
      // 
      // DexTextLabel
      // 
      this.DexTextLabel.AutoSize = true;
      this.DexTextLabel.Location = new System.Drawing.Point(9, 68);
      this.DexTextLabel.Name = "DexTextLabel";
      this.DexTextLabel.Size = new System.Drawing.Size(32, 16);
      this.DexTextLabel.TabIndex = 6;
      this.DexTextLabel.Text = "Dex";
      // 
      // StrTextLabel
      // 
      this.StrTextLabel.AutoSize = true;
      this.StrTextLabel.Location = new System.Drawing.Point(9, 33);
      this.StrTextLabel.Name = "StrTextLabel";
      this.StrTextLabel.Size = new System.Drawing.Size(24, 16);
      this.StrTextLabel.TabIndex = 5;
      this.StrTextLabel.Text = "Str";
      // 
      // RacePictureBox
      // 
      this.RacePictureBox.Location = new System.Drawing.Point(499, 49);
      this.RacePictureBox.Name = "RacePictureBox";
      this.RacePictureBox.Size = new System.Drawing.Size(310, 350);
      this.RacePictureBox.TabIndex = 2;
      this.RacePictureBox.TabStop = false;
      // 
      // FinalForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(821, 413);
      this.Controls.Add(this.AbilitiesGroupBox);
      this.Controls.Add(this.MiscGroupBox);
      this.Controls.Add(this.RacePictureBox);
      this.Controls.Add(this.CharInfoGroupBox);
      this.Controls.Add(this.MenuMenuStrip);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.MenuMenuStrip;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FinalForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Your Character Selections";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FinalForm_FormClosed);
      this.MenuMenuStrip.ResumeLayout(false);
      this.MenuMenuStrip.PerformLayout();
      this.CharInfoGroupBox.ResumeLayout(false);
      this.CharInfoGroupBox.PerformLayout();
      this.MiscGroupBox.ResumeLayout(false);
      this.MiscGroupBox.PerformLayout();
      this.AbilitiesGroupBox.ResumeLayout(false);
      this.AbilitiesGroupBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.RacePictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.MenuStrip MenuMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem FileMenu;
    private System.Windows.Forms.ToolStripMenuItem PrintMenuButton;
    private System.Windows.Forms.ToolStripMenuItem ExitMenuButton;
    private System.Windows.Forms.ToolStripMenuItem EditMenu;
    private System.Windows.Forms.ToolStripMenuItem FontMenuButton;
    private System.Windows.Forms.ToolStripMenuItem HelpMenu;
    private System.Windows.Forms.ToolStripMenuItem AbouMenuButton;
    private System.Windows.Forms.GroupBox CharInfoGroupBox;
    private System.Windows.Forms.Label NameLabel;
    private System.Windows.Forms.Label WeightLabel;
    private System.Windows.Forms.Label HeightLabel;
    private System.Windows.Forms.Label AgeLabel;
    private System.Windows.Forms.TextBox NameTextBox;
    private System.Windows.Forms.TextBox WeightTextBox;
    private System.Windows.Forms.TextBox HeightTextBox;
    private System.Windows.Forms.TextBox AgeTextBox;
    private System.Windows.Forms.PictureBox RacePictureBox;
    private System.Windows.Forms.GroupBox MiscGroupBox;
    private System.Windows.Forms.GroupBox AbilitiesGroupBox;
    private System.Windows.Forms.Label StrTextLabel;
    private System.Windows.Forms.Label ChaTextLabel;
    private System.Windows.Forms.Label PerTextLabel;
    private System.Windows.Forms.Label IntTextLabel;
    private System.Windows.Forms.Label EndTextLabel;
    private System.Windows.Forms.Label DexTextLabel;
    private System.Windows.Forms.TextBox ChaTextBox;
    private System.Windows.Forms.TextBox PerTextBox;
    private System.Windows.Forms.TextBox IntTextBox;
    private System.Windows.Forms.TextBox EndTextBox;
    private System.Windows.Forms.TextBox DexTextBox;
    private System.Windows.Forms.TextBox StrTextBox;
    private System.Windows.Forms.TextBox JobTextBox;
    private System.Windows.Forms.Label JobLabel;
    private System.Windows.Forms.TextBox HPTextBox;
    private System.Windows.Forms.Label HPLabel;
    private System.Windows.Forms.TextBox RaceTextBox;
    private System.Windows.Forms.Label RaceLabel;
  }
}