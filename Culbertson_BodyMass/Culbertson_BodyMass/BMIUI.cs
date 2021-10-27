using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_BodyMass
{
    class BMIUI
    {

        public string NameInput()
        {
            string name;
            Write("Please type your name: ");
            name = ReadLine();
            return name;
        }
        public void Welcome(string name)
        {
            WriteLine("\nWelcome {0}! This program will calculate you Body Mass Index,", name);
            WriteLine("or BMI, based on a weight and height that you input.");
        }

        public double UserHeight()
        {
            WriteLine("\nPlease enter your height in inches: ");
            double value;
            value = double.Parse(ReadLine());
            return value;        
        }

        public double UserWeight()
        {
            WriteLine("Please enter your weight in pounds: ");
            double value;
            value = double.Parse(ReadLine());
            return value;
        }

        public void DisplayResults(double height, double weight, double bmi, string assessment)
        {
            /* WriteLine("Based on your input data of {0} inches and {1} pounds, ", height, weight);
            WriteLine("your BMI is {2}, which is considered {3}.", bmi, assessment); */
            WriteLine("Based on your input data of {0} inches and {1} pounds, \nyour BMI is {2:F2}, which is considered {3}.", height, weight, bmi, assessment);
            ReadKey();
        }
    }
}
