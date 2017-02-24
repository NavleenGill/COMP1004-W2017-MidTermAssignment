namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
  partial class About
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
      this.StudentNameLabel = new System.Windows.Forms.Label();
      this.StudentIdLabel = new System.Windows.Forms.Label();
      this.NameLabel = new System.Windows.Forms.Label();
      this.IDLabel = new System.Windows.Forms.Label();
      this.OkButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // StudentNameLabel
      // 
      this.StudentNameLabel.AutoSize = true;
      this.StudentNameLabel.Location = new System.Drawing.Point(12, 47);
      this.StudentNameLabel.Name = "StudentNameLabel";
      this.StudentNameLabel.Size = new System.Drawing.Size(75, 13);
      this.StudentNameLabel.TabIndex = 0;
      this.StudentNameLabel.Text = "Student Name";
      // 
      // StudentIdLabel
      // 
      this.StudentIdLabel.AutoSize = true;
      this.StudentIdLabel.Location = new System.Drawing.Point(12, 21);
      this.StudentIdLabel.Name = "StudentIdLabel";
      this.StudentIdLabel.Size = new System.Drawing.Size(58, 13);
      this.StudentIdLabel.TabIndex = 1;
      this.StudentIdLabel.Text = "Student ID";
      // 
      // NameLabel
      // 
      this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.NameLabel.Location = new System.Drawing.Point(114, 21);
      this.NameLabel.Name = "NameLabel";
      this.NameLabel.Size = new System.Drawing.Size(159, 23);
      this.NameLabel.TabIndex = 2;
      this.NameLabel.Text = "200334989";
      // 
      // IDLabel
      // 
      this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.IDLabel.Location = new System.Drawing.Point(114, 47);
      this.IDLabel.Name = "IDLabel";
      this.IDLabel.Size = new System.Drawing.Size(159, 23);
      this.IDLabel.TabIndex = 3;
      this.IDLabel.Text = "Navleen kaur gill";
      // 
      // OkButton
      // 
      this.OkButton.Location = new System.Drawing.Point(183, 85);
      this.OkButton.Name = "OkButton";
      this.OkButton.Size = new System.Drawing.Size(90, 24);
      this.OkButton.TabIndex = 4;
      this.OkButton.Text = "Ok";
      this.OkButton.UseVisualStyleBackColor = true;
      this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
      // 
      // About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(300, 121);
      this.Controls.Add(this.OkButton);
      this.Controls.Add(this.IDLabel);
      this.Controls.Add(this.NameLabel);
      this.Controls.Add(this.StudentIdLabel);
      this.Controls.Add(this.StudentNameLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "About";
      this.Padding = new System.Windows.Forms.Padding(9);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "About";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label StudentNameLabel;
    private System.Windows.Forms.Label StudentIdLabel;
    private System.Windows.Forms.Label NameLabel;
    private System.Windows.Forms.Label IDLabel;
    private System.Windows.Forms.Button OkButton;
  }
}
