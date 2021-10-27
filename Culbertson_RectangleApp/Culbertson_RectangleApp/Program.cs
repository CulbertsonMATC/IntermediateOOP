using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_RectangleApp
{
    public class Culbertson_RectangleApp
    {
        public static void Main(string[] args)
        {
            double RectWidth, RectHeight, RectPerimeter, RectArea;
            AssignmentInfo();
            Directions();
            RectWidth = InputWidth();
            RectHeight = InputHeight();
            RectPerimeter = CalculatePerimeter(RectWidth, RectHeight);
            RectArea = CalculateArea(RectWidth, RectHeight);
            DisplayResults(RectWidth, RectHeight, RectPerimeter, RectArea);    
        }
            public static void AssignmentInfo()
            {
            WriteLine("********************************************************");
            WriteLine("Name:\t\tMatt Culbertson");
            WriteLine("Course:\t\tITDEV-115");
            WriteLine("Instructor:\tJ. Christie");
            WriteLine("Assignment:\tRectangle Assignment");
            WriteLine("Date:\t\t8/28/2021");
            WriteLine("********************************************************");

        }

            public static void Directions()
            {
            WriteLine("This program will help you find the area and perimeter of a rectangle.");
            }

            public static double InputHeight()
            {
                string InputValue;
                int RectHeight;
                Write("Please enter the rectangle's height in whole inches: ");
                InputValue = ReadLine();
                RectHeight = int.Parse(InputValue);
                return RectHeight;
            }

            public static double InputWidth()
            {
                string InputValue;
                int RectWidth;
                Write("Please enter the rectangle's width in whole inches: ");
                InputValue = ReadLine();
                RectWidth = int.Parse(InputValue);
                return RectWidth;
            }

            public static double CalculateArea(double width, double height)
            {
                double area = width * height;
                return area;
            }

            public static double CalculatePerimeter(double width, double height)
            {
                double perimeter = 2 * (height + width);
                return perimeter;
            }

            public static void DisplayResults(double width, double height, double perimeter, double area)
            {
                WriteLine("\nThe width of the rectangle is " + width + " inches.");
                WriteLine("The height of the rectangle is " + height + " inches.");
                WriteLine("The perimeter of the rectangle is " + perimeter + " inches.");
                WriteLine("The area of the rectangle is " + area + " inches.");
            WriteLine("\nPress enter to exit.");
            ReadKey();
        }
            }
    }

