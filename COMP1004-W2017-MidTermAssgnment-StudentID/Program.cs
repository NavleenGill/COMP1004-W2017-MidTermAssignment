using System;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
  static class Program
  {
    public static AbilityForm AbilityForm;
    public static JobForm JobForm;
    public static RaceForm RaceForm;
    public static FinalForm FinalForm;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      AbilityForm = new AbilityForm();
      Application.Run(AbilityForm);
    }
  }
}
