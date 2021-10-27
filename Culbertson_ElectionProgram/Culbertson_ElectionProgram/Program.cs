using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_ElectionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            ElectionUI view = new ElectionUI();
            info.DisplayInfo("Election Results");
            view.MainMethod();
            Console.ReadKey();
            
            
            /* for (int i = 0; i < 5; i++){
                view.MainMethod(i+1);
            }
            for (int i = 0; i < 5; i++)
            {
                view.(i + 1);
            } */



        }
    }
}
