using System;
using System.Drawing;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
  public partial class AbilityForm : Form
  {
    #region Fields

    // Random Number object
    Random random = new Random();

    // We use this to check if the abilities have been generated
    private bool _abilitiesInitialized;

    // Ability points fields
    private int _str;
    private int _dex;
    private int _int;
    private int _end;
    private int _per;
    private int _cha;

    #endregion

    #region Properties

    public int Cha
    {
      get { return _cha; }
      set { _cha = value; }
    }
    
    public int Per
    {
      get { return _per; }
      set { _per = value; }
    }
    
    public int End
    {
      get { return _end; }
      set { _end = value; }
    }
    
    public int Int
    {
      get { return _int; }
      set { _int = value; }
    }
    
    public int Dex
    {
      get { return _dex; }
      set { _dex = value; }
    }

    public int Str
    {
      get { return _str; }
      set { _str = value; }
    }

    #endregion
        
    /// <summary>
    /// Ctor
    /// </summary>
    public AbilityForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// This method simulates the rolling of three 10-sided dice
    /// </summary>
    /// <returns>
    /// This method returns a number between 3 and 30 (The result of rolling 3d10)
    /// </returns>
    private int Roll3D10()
    {
      int result = 0;
      for (int dice = 0; dice < 3; dice++)
      {
        result += random.Next(1, 11);
      }
      return result;
    }

    /// <summary>
    /// Generate the character ability points in a random way
    /// </summary>
    private void GenerateAbilityPoints()
    {
      // Set the abilities properties a value
      _str = Roll3D10();
      _dex = Roll3D10();
      _int = Roll3D10();
      _end = Roll3D10();
      _per = Roll3D10();
      _cha = Roll3D10();

      // Put the corresponding value of the property on the respective textbox
      STRTextBox.Text = _str.ToString();
      DEXTextBox.Text = _dex.ToString();
      INTTextBox.Text = _int.ToString();
      ENDTextBox.Text = _end.ToString();
      PERTextBox.Text = _per.ToString();
      CHATextBox.Text = _cha.ToString();

      // Set the abilities as initialized
      _abilitiesInitialized = true;
    }

    /// <summary>
    /// Hide this form and advance to the next
    /// </summary>
    private void NextForm()
    {
      if (_abilitiesInitialized == false)
      {
        MessageBox.Show("You have not initialized the player abilities", "Abilities",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      Program.RaceForm = new RaceForm();
      Program.RaceForm.Show();
      Hide();
    }

    #region Event Handlers

    /// <summary>
    /// Roll button event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RollButton_Click(object sender, EventArgs e)
    {
      GenerateAbilityPoints();
    }

    /// <summary>
    /// Next button event  handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NextButton_Click(object sender, EventArgs e)
    {
      NextForm();
    }

    #endregion
  }
}
