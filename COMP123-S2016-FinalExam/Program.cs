using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// FILE NAME : Program.cs
/// AUTHOR'S NAME : NURLYBEK SULTAMURATOV
/// STUDENT NUMBER : 301103746
/// CHANGES MADE : 
/// 1. CREATED FIELDS TO INSTANTIATE
/// 2. INSTANTIATED NEW OBJECTS FOR FORMS
/// 3. CHANGED APPLICATION RUN FROM ABILITYGENERATORFORM TO SPLASHFORM
/// </summary>

namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();
        //I want to create a field for SplashForm
        //and for GenerateNameForm

        //PUBLIC FIELDS
        public static SplashForm splashForm;
        public static GenerateNameForm generateNameForm;
        public static AbilityGeneratorForm abilityGeneratorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //instatiate our forms after the Application.SetCompatibleTextRenderingDefault(false);
            //otherwise it is going to give me an error
            splashForm = new SplashForm();
            generateNameForm = new GenerateNameForm();
            abilityGeneratorForm = new AbilityGeneratorForm();
            Application.Run(splashForm);
        }
    }
}
