using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Culbertson_FarmerApp
{ 
    class Info
    {
        public void DisplayInfo(string assignment)
        {
            const string barrier = "*******************************************************************************";
            Console.WriteLine(barrier);
            Console.WriteLine();
            Console.WriteLine("Name:\t\tMatt Culbertson");
            Console.WriteLine("Course:\t\tITDEV-115-501");
            Console.WriteLine("Instructor:\tJanese Christie");
            Console.WriteLine("Assignment:\t" + assignment);
            Console.WriteLine("Date:\t\t" + DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine(barrier);
        }
    }
}
