using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TheSurvivor.Source.Utilities;


namespace TheSurvivor
{
    class Survivor
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logging.Log(LogType.LOG, "Initialising application");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);


            
            Application.Run(new Forms.MainMenu());
        }
    }
}
