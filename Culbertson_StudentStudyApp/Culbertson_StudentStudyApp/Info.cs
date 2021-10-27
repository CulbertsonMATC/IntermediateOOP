using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_StudentStudyApp
{
    class Display
    {
        public void DisplayInfo(string assignment)
        {
            const string barrier = "*******************************************************************************";
            WriteLine(barrier);
            WriteLine();
            WriteLine("Name:\t\tMatt Culbertson");
            WriteLine("Course:\t\tITDEV-115-501");
            WriteLine("Instructor:\tJanese Christie");
            WriteLine("Assignment:\t" + assignment);
            WriteLine("Date:\t\t" + DateTime.Today.ToShortDateString());
            WriteLine();
            WriteLine(barrier);
        }
    }
}
