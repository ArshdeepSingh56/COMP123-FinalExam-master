using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{

    /*Name = Arshdeep Singh
     * Student id no = 301118326
     * Final test Part B
     * Date = 20/08/2020
     * Modify Date = 21/08/2020
     Program Description :  Using the Project Template Provided, complete the project that 
     generates the first few pages of a RolePlaying Game Character. */
    public static class Program
    {
        public static SplashForm splashform;
        public static GenerateNameForm generateNameForm;
        public static AbilityGeneratorForm AbilityGenerator;
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            splashform = new SplashForm();
            generateNameForm = new GenerateNameForm();
            AbilityGenerator = new AbilityGeneratorForm();
            Application.Run(splashform);
     


        }
    }
}
