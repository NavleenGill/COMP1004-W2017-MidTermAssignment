using System;
using System.Windows.Forms;

/// <summary>
/// App name: Character Generator
/// Author's name: Navleen Kaur Gill
/// Student ID: 200334989
/// App Creation Date: February 24, 2017
/// App Description: This app generates	the	first few pages of an RPG character	and display	the	
///results of randomly generated abilities and the users selections.
/// 
/// </summary>
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
