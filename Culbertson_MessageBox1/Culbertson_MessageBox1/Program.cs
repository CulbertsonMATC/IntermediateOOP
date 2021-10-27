using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;

namespace Culbertson_MessageBox1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string result = "\tn\tSquared\n";

            while (counter < 10)
            {
                counter++;
                result += "\t" + counter + "\t" + Math.Pow(counter, 2) + "\n";
            }

            MessageBox.Show(result, "1 - 10 and their squares");
        }
    }
}
