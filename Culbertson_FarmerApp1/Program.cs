using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_FarmerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string assignment = "Farmer Game";
            Info info = new Info();
            info.DisplayInfo(assignment);
            FarmerUI view = new FarmerUI();
            view.PlayGame();
        }
    }
}
