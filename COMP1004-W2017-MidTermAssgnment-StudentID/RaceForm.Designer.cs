namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    partial class RaceForm
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
      this.CharacterPictureBox = new System.Windows.Forms.PictureBox();
      this.NextButton = new System.Windows.Forms.Button();
      this.RacialBonusLabel = new System.Windows.Forms.Label();
      this.RacialBonusTextBox = new System.Windows.Forms.TextBox();
      this.RacesGroupBox = new System.Windows.Forms.GroupBox();
      this.HalflingRadioButton = new System.Windows.Forms.RadioButton();
      this.ElfRadioButton = new System.Windows.Forms.RadioButton();
      this.DwarfRadioButton = new System.Windows.Forms.RadioButton();
      this.HumanRadioButton = new System.Windows.Forms.RadioButton();
      ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).BeginInit();
      this.RacesGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // CharacterPictureBox
      // 
      this.CharacterPictureBox.Location = new System.Drawing.Point(282, 12);
      this.CharacterPictureBox.Margin = new System.Windows.Forms.Padding(4);
      this.CharacterPictureBox.Name = "CharacterPictureBox";
      this.CharacterPictureBox.Size = new System.Drawing.Size(290, 262);
      this.CharacterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.CharacterPictureBox.TabIndex = 5;
      this.CharacterPictureBox.TabStop = false;
      // 
      // NextButton
      // 
      this.NextButton.Location = new System.Drawing.Point(472, 299);
      this.NextButton.Margin = new System.Windows.Forms.Padding(4);
      this.NextButton.Name = "NextButton";
      this.NextButton.Size = new System.Drawing.Size(100, 28);
      this.NextButton.TabIndex = 4;
      this.NextButton.Text = "Next";
      this.NextButton.UseVisualStyleBackColor = true;
      this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
      // 
      // RacialBonusLabel
      // 
      this.RacialBonusLabel.AutoSize = true;
      this.RacialBonusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.RacialBonusLabel.Location = new System.Drawing.Point(65, 209);
      this.RacialBonusLabel.Name = "RacialBonusLabel";
      this.RacialBonusLabel.Size = new System.Drawing.Size(86, 17);
      this.RacialBonusLabel.TabIndex = 6;
      this.RacialBonusLabel.Text = "Racial Bonus";
      // 
      // RacialBonusTextBox
      // 
      this.RacialBonusTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.RacialBonusTextBox.Location = new System.Drawing.Point(12, 245);
      this.RacialBonusTextBox.Name = "RacialBonusTextBox";
      this.RacialBonusTextBox.ReadOnly = true;
      this.RacialBonusTextBox.Size = new System.Drawing.Size(205, 29);
      this.RacialBonusTextBox.TabIndex = 7;
      // 
      // RacesGroupBox
      // 
      this.RacesGroupBox.Controls.Add(this.HalflingRadioButton);
      this.RacesGroupBox.Controls.Add(this.ElfRadioButton);
      this.RacesGroupBox.Controls.Add(this.DwarfRadioButton);
      this.RacesGroupBox.Controls.Add(this.HumanRadioButton);
      this.RacesGroupBox.Location = new System.Drawing.Point(12, 12);
      this.RacesGroupBox.Name = "RacesGroupBox";
      this.RacesGroupBox.Size = new System.Drawing.Size(205, 167);
      this.RacesGroupBox.TabIndex = 8;
      this.RacesGroupBox.TabStop = false;
      this.RacesGroupBox.Text = "Races";
      // 
      // HalflingRadioButton
      // 
      this.HalflingRadioButton.AutoSize = true;
      this.HalflingRadioButton.Location = new System.Drawing.Point(6, 124);
      this.HalflingRadioButton.Name = "HalflingRadioButton";
      this.HalflingRadioButton.Size = new System.Drawing.Size(60, 17);
      this.HalflingRadioButton.TabIndex = 3;
      this.HalflingRadioButton.Text = "Halfling";
      this.HalflingRadioButton.UseVisualStyleBackColor = true;
      this.HalflingRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadio_CheckedChanged);
      // 
      // ElfRadioButton
      // 
      this.ElfRadioButton.AutoSize = true;
      this.ElfRadioButton.Location = new System.Drawing.Point(6, 94);
      this.ElfRadioButton.Name = "ElfRadioButton";
      this.ElfRadioButton.Size = new System.Drawing.Size(37, 17);
      this.ElfRadioButton.TabIndex = 2;
      this.ElfRadioButton.Text = "Elf";
      this.ElfRadioButton.UseVisualStyleBackColor = true;
      this.ElfRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadio_CheckedChanged);
      // 
      // DwarfRadioButton
      // 
      this.DwarfRadioButton.AutoSize = true;
      this.DwarfRadioButton.Location = new System.Drawing.Point(6, 64);
      this.DwarfRadioButton.Name = "DwarfRadioButton";
      this.DwarfRadioButton.Size = new System.Drawing.Size(53, 17);
      this.DwarfRadioButton.TabIndex = 1;
      this.DwarfRadioButton.Text = "Dwarf";
      this.DwarfRadioButton.UseVisualStyleBackColor = true;
      this.DwarfRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadio_CheckedChanged);
      // 
      // HumanRadioButton
      // 
      this.HumanRadioButton.AutoSize = true;
      this.HumanRadioButton.Location = new System.Drawing.Point(6, 34);
      this.HumanRadioButton.Name = "HumanRadioButton";
      this.HumanRadioButton.Size = new System.Drawing.Size(59, 17);
      this.HumanRadioButton.TabIndex = 0;
      this.HumanRadioButton.Text = "Human";
      this.HumanRadioButton.UseVisualStyleBackColor = true;
      this.HumanRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadio_CheckedChanged);
      // 
      // RaceForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(594, 339);
      this.Controls.Add(this.RacesGroupBox);
      this.Controls.Add(this.RacialBonusTextBox);
      this.Controls.Add(this.RacialBonusLabel);
      this.Controls.Add(this.CharacterPictureBox);
      this.Controls.Add(this.NextButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.Name = "RaceForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Select Character Race";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RaceForm_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).EndInit();
      this.RacesGroupBox.ResumeLayout(false);
      this.RacesGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox CharacterPictureBox;
        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label RacialBonusLabel;
        private System.Windows.Forms.TextBox RacialBonusTextBox;
    private System.Windows.Forms.GroupBox RacesGroupBox;
    private System.Windows.Forms.RadioButton HalflingRadioButton;
    private System.Windows.Forms.RadioButton ElfRadioButton;
    private System.Windows.Forms.RadioButton DwarfRadioButton;
    private System.Windows.Forms.RadioButton HumanRadioButton;
  }
}