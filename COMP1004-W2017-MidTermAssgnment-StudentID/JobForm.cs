using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
  public partial class JobForm : Form
  {
    #region Fields

    private int _hp;
    private string _job;

    #endregion

    #region Properties

    public int HP
    {
      get { return _hp; }
      set { _hp = value; }
    }

    public string Job
    {
      get { return _job; }
      set { _job = value; }
    }

    #endregion

    public JobForm()
    {
      InitializeComponent();
      SoldierRadioButton.Checked = true;
    }

    /// <summary>
    /// Update the job according to the job selected
    /// </summary>
    private void UpdateJobHp(string job)
    {
      switch (job)
      {
        case "SoldierRadioButton":
          _hp = 30 + Program.AbilityForm.End;
          _job = "Soldier";
          break;
        case "RogueRadioButton":
          _hp = 28 + Program.AbilityForm.Dex;
          _job = "Rogue";
          break;
        case "MagickerRadioButton":
          _hp = 15 + Program.AbilityForm.Int;
          _job = "Magicker";
          break;
        case "CultistRadioButton":
          _hp = 24 + Program.AbilityForm.Cha;
          _job = "Cultist";
          break;
      }
      HPLabel.Text = _hp.ToString();
    }

    /// <summary>
    /// Hide the current form and open the final form
    /// </summary>
    private void NextForm()
    {
      Program.FinalForm = new FinalForm();
      Program.FinalForm.Show();
      Hide();
    }

    /// <summary>
    /// Call the update hp function passing as argument the job
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void JobRadioButton_CheckedChanged(object sender, System.EventArgs e)
    {
      RadioButton jobRadio = sender as RadioButton;
      UpdateJobHp(jobRadio.Name);
    }

    /// <summary>
    /// Close the application
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void JobForm_FormClosed(object sender, FormClosedEventArgs e)
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
