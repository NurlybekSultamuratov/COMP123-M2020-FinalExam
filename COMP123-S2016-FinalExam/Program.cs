using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();
        //I want to create a field for SplashForm//
        //and for GenerateNameForm let's do this//

        //FIELDS
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
            //instatiate our forms after the setcompatibletextrenderingdefault(false) 
            //otherwise it is going to give me an error
            splashForm = new SplashForm();
            generateNameForm = new GenerateNameForm();
            abilityGeneratorForm = new AbilityGeneratorForm();
            Application.Run(generateNameForm);
            //Application.Run(new AbilityGeneratorForm());
        }
    }
}
