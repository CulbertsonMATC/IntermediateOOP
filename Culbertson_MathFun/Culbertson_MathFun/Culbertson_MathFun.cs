using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_MathFun
{
    class Culbertson_MathFun
    {
        static void Main(string[] args)
        {
            int choice;
            bool continueOn;
            const int ExitProgram = 5;
            double firstNumber, secondNumber, solution;

            InputOutput IO = new InputOutput();
            Calculations Calc = new Calculations();
            IO.Introduction();
            choice = IO.Directions();

            if (continueOn = (choice == ExitProgram ? false: true))
            {
                firstNumber = IO.Input("First");
                secondNumber = IO.Input("Second");
                solution = Calc.PerformSelected(choice, firstNumber, secondNumber);
                IO.DisplaySolution(firstNumber, secondNumber, Calc.Symbol(choice), solution);
            }
            Console.ReadKey();
        }
    }
}
