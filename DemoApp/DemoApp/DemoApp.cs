using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DemoApp
{
    class DemoApp
    {
        static void Main(string[] args)
        {
            WriteLine("Main has started");
            Directions();
            SecondClass SClass = new SecondClass();
            SClass.Output();
            ReadLine();
        }

        static void Directions()
        {
            WriteLine("These are the directions");
        }
    }
}
