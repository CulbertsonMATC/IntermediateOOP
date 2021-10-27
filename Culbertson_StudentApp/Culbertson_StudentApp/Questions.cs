using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_StudentApp
{
    class Questions
    {   
        public string StudentName(string whichOne)
        {
            string inValue;
            Write("Enter Student's {0} Name: ", whichOne);
            inValue = ReadLine();
            return inValue;
        }
        public string StudentNumber()
        {
            string inValue;
            Write("Enter Student Number: ");
            inValue = ReadLine();
            return inValue;
        }
        public string Major(string name)
        {
            string inValue;
            Write("Enter {0}'s Major: ", name);
            inValue = ReadLine();
            return inValue;
        }
        public double ExamScore(int whichOne)
        {
            string inValue;
            double aScore;
            Write("Enter a value for Score {0}: ", whichOne);
            inValue = ReadLine();
            while (double.TryParse(inValue, out aScore) == false){
                Write("Please enter a double value for Score{0}", whichOne);
                inValue = ReadLine();   
            }
            return aScore;
        }
    }
}
