using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_MathFun
{
    class Calculations
    {
        public double AddThem(double num1, double num2)
        {
            return num1 + num2;
        }

        public double MultiplyThem(double num1, double num2)
        {
            return num1 * num2;
        }

        public double DivideThem(double num1, double num2)
        {
            return num1 / num2;
        }

        public double SubtractThem(double num1, double num2)
        {
            return num1 - num2;
        }

        public double PerformSelected(int choice, double first, double second)
        {
            double answer = 0;

            switch (choice)
            {
                case 1:
                    answer = AddThem(first, second);
                    break;
                case 2:
                    answer = SubtractThem(first, second);
                    break;
                case 3:
                    answer = MultiplyThem(first, second);
                    break;
                case 4:
                    answer = DivideThem(first, second);
                    break;
                default:
                    answer = 5;
                    break;
            }
            return answer;
        }

        public string Symbol(int choice)
        {
            string answer = "";

            switch (choice)
            {
                case 1:
                    answer = "+";
                    break;
                case 2:
                    answer = "-";
                    break;
                case 3:
                    answer = "*";
                    break;
                case 4:
                    answer = "/";
                    break;
            }
            return answer;
        }
    }
}
