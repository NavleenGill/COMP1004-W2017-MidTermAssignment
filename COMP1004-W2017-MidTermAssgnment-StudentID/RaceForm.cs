using COMP1004_W2017_MidTermAssgnment_StudentID.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
  public partial class RaceForm : Form
  {
    #region Fields

    private const int MAX_POINT_ABILITY = 50;
    private const int MIN_POINT_ABILITY = 3;
    private string _race;

    #endregion

    #region Properties

    public string Race
    {
      get { return _race; }
      set { _race = value; }
    }

    #endregion

    public RaceForm()
    {
      InitializeComponent();
      Font = SystemFonts.MessageBoxFont;

      // Initial control values
      HumanRadioButton.Checked = true;
    }

    /// <summary>
    /// Update the data related with the race
    /// </summary>
    /// <param name="characterSelected"></param>
    private void UpdateCharacterData(string characterSelected)
    {
      switch (characterSelected)
      {
        case "HumanRadioButton":
          CharacterPictureBox.Image = Resources.M_Human1;
          _race = "Human";
          RacialBonusTextBox.Text = "ALL ABILITIES +5";
          break;
        case "DwarfRadioButton":
          CharacterPictureBox.Image = Resources.M_Dwarf1;
          _race = "Dwarf";
          RacialBonusTextBox.Text = "STR+20, PER+20, CHA-10";
          break;
        case "ElfRadioButton":
          CharacterPictureBox.Image = Resources.M_Elf1;
          _race = "Elf";
          RacialBonusTextBox.Text = "DEX+15, CHA+15";
          break;
        case "HalflingRadioButton":
          CharacterPictureBox.Image = Resources.M_Halfling2;
          _race = "Halfling";
          RacialBonusTextBox.Text = "DEX+20, INT+20, STR-10";
          break;
      }
    }

    /// <summary>
    /// Increment the ability between a range
    /// </summary>
    /// <param name="oldValue"></param>
    /// <param name="increment"></param>
    private int IncrementAbility(int oldValue, int increment)
    {
      int total = oldValue + increment;
      if (total > MAX_POINT_ABILITY)
        total = MAX_POINT_ABILITY;
      return total;
    }

    /// <summary>
    /// Decrement the ability between a range
    /// </summary>
    /// <param name="oldValue"></param>
    /// <param name="decrement"></param>
    /// <returns></returns>
    private int DecrementAbility(int oldValue, int decrement)
    {
      int total = oldValue - decrement;
      if (total < MIN_POINT_ABILITY)
        total = MIN_POINT_ABILITY;
      return total;
    }

    /// <summary>
    /// Update the ability point according to the race selected
    /// </summary>
    private void UpdateAbilityPoints()
    {
      switch (_race)
      {
        case "Human":
          Program.AbilityForm.Str = IncrementAbility(Program.AbilityForm.Str, 5);
          Program.AbilityForm.Dex = IncrementAbility(Program.AbilityForm.Dex, 5);
          Program.AbilityForm.Int = IncrementAbility(Program.AbilityForm.Int, 5);
          Program.AbilityForm.End = IncrementAbility(Program.AbilityForm.End, 5);
          Program.AbilityForm.Per = IncrementAbility(Program.AbilityForm.Per, 5);
          Program.AbilityForm.Cha = IncrementAbility(Program.AbilityForm.Cha, 5);
          break;
        case "Dwarf":
          Program.AbilityForm.Str = IncrementAbility(Program.AbilityForm.Str, 20);
          Program.AbilityForm.Per = IncrementAbility(Program.AbilityForm.Per, 20);
          Program.AbilityForm.Cha = DecrementAbility(Program.AbilityForm.Cha, 10);
          break;
        case "Elf":
          Program.AbilityForm.Dex = IncrementAbility(Program.AbilityForm.Dex, 15);
          Program.AbilityForm.Cha = IncrementAbility(Program.AbilityForm.Cha, 15);
          break;
        case "Halfling":
          Program.AbilityForm.Dex = IncrementAbility(Program.AbilityForm.Dex, 20);
          Program.AbilityForm.Int = IncrementAbility(Program.AbilityForm.Int, 20);
          Program.AbilityForm.Str = DecrementAbility(Program.AbilityForm.Str, 10);
          break;
      }
    }

    /// <summary>
    /// Apply changes to the race and go to the next form
    /// </summary>
    private void NextForm()
    {
      UpdateAbilityPoints();
      Program.JobForm = new JobForm();
      Program.JobForm.Show();
      Hide();
    }

    /// <summary>
    /// Call the function to change the race image passing as argument the name of the
    /// radio button selected
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RaceRadio_CheckedChanged(object sender, System.EventArgs e)
    {
      RadioButton radio = sender as RadioButton;
      UpdateCharacterData(radio.Name);
    }

    /// <summary>
    /// Close the main from to exit the program
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RaceForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    /// <summary>
    /// Next button event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NextButton_Click(object sender, System.EventArgs e)
    {
      NextForm();
    }
  }
}
