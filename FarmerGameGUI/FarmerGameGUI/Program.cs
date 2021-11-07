using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerGameGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gameplay());



            /*string assignment = "Farmer Game";
            Info info = new Info();
            info.DisplayInfo(assignment);
            Gameplay form1 = new Gameplay();*/
        }
    }
}
