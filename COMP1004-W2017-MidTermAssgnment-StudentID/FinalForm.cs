using System;
using System.Drawing;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
  public partial class FinalForm : Form
  {
    #region Fields

    private const int MIN_FONT_SIZE = 10;
    private const int MAX_FONT_SIZE = 18;

    #endregion
    
    /// <summary>
    /// Default Constructor
    /// </summary>
    public FinalForm()
    {
      InitializeComponent();
      LoadCharacterInfo();
    }

    /// <summary>
    /// Load the character info
    /// </summary>
    private void LoadCharacterInfo()
    {
      StrTextBox.Text = Program.AbilityForm.Str.ToString();
      DexTextBox.Text = Program.AbilityForm.Dex.ToString();
      IntTextBox.Text = Program.AbilityForm.Int.ToString();
      EndTextBox.Text = Program.AbilityForm.End.ToString();
      PerTextBox.Text = Program.AbilityForm.Per.ToString();
      ChaTextBox.Text = Program.AbilityForm.Cha.ToString();
      HPTextBox.Text = Program.JobForm.HP.ToString();
      JobTextBox.Text = Program.JobForm.Job;
      RaceTextBox.Text = Program.RaceForm.Race;
      RacePictureBox.Image = Program.RaceForm.CharacterPictureBox.Image;
    }

    /// <summary>
    /// Exit the application
    /// </summary>
    private void Exit()
    {
      Application.Exit();
    }

    /// <summary>
    /// Exit the application
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FinalForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Exit();
    }

    /// <summary>
    /// Exit menu event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ExitMenuButton_Click(object sender, EventArgs e)
    {
      Exit();
    }

    /// <summary>
    /// About menu event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AbouMenuButton_Click(object sender, EventArgs e)
    {
      new About().ShowDialog();
    }

    /// <summary>
    /// Increase font size
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FontMenuButton_Click(object sender, EventArgs e)
    {
      if (Font.Size < MAX_FONT_SIZE)
        Font = new Font(Font.FontFamily, Font.Size + 1.0f);
      else
        Font = new Font(Font.FontFamily, MIN_FONT_SIZE);
    }

    /// <summary>
    /// Print preview
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PrintMenuButton_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Print the final form?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    }
  }
}
