using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_MathFun
{
    class InputOutput
    {

        public void Introduction()
        {
            WriteLine("The program performs a mathematical operation on two numbers.");
            WriteLine("Press any key when you are ready to continue.");
            ReadKey();
        }

        public int Directions()
        {
            string inValue;
            int selection;
            Clear();
            WriteLine("Select operation you would like to perform:");
            WriteLine("\n\t1) Add\t2) Subtract\t3) Multiply\t4) Divide\t5) Exit");
            inValue = ReadLine();
            while (int.TryParse(inValue, out selection) == false){
                WriteLine("Please enter a valid integer.");
                inValue = ReadLine();
            }
            return selection;
        }


        /*public void CheckSelection(int number)
        {
            if ((number < 1) || (number > 5))
            {
                WriteLine("\n\nEnter a number between 1 and 5");
                WriteLine("Enter any key to continue.");
                ReadKey();
                Directions();
            }
        }*/ 

        public int Input(String numberOrder)
        {
            string inValue;
            int intValue;
            WriteLine("Enter the {0} value", numberOrder);
            inValue = ReadLine();

            while (int.TryParse(inValue, out intValue) == false)
            {
                WriteLine("Please enter a valid integer.");
                inValue = ReadLine();
            }

            return intValue;
        }

        public void DisplaySolution(double num1, double num2, string symbol, double solution)
        {
            WriteLine("The solution to the problem is: ");
            WriteLine("{0} {1} {2} = {3}", num1, symbol, num2, solution);
        }


    }
}
