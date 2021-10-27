using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_StudentStudyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //  very minimal instantiation-type stuff happening here
            StudentUI view = new StudentUI();
            Display info = new Display();

            info.DisplayInfo("Student Study App");
            view.MainMethod();
        }
    }
}
