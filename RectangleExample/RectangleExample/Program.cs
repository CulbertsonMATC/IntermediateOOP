using System;
using static System.Console;

namespace CarpetExampleWithClassMethods
{
    public class CarpetWithClassMethods
    {
        public static void Main()
        {
            double roomWidth, roomLength, pricePerSqYard, noOfSquareYards;

            // Call getDimension( ) to get length
            roomLength = GetDimension("Length");
            roomWidth = GetDimension("Width");
            pricePerSqYard = GetPrice();
            noOfSquareYards = DetermineSquareYards(roomWidth, roomLength);
            DisplayResults(noOfSquareYards, pricePerSqYard);
        } // End of Main ( )

        public static double GetDimension(string side)
        {
            string inputValue;     // local variables
            int feet,                    // needed only by this 
                 inches;               // method
            Write("Enter the {0} in feet: ", side);
            inputValue = ReadLine();
            feet = int.Parse(inputValue);
            Write("Enter the {0} in inches: ", side);
            inputValue = ReadLine();
            inches = int.Parse(inputValue);
            // Note: cast required to avoid int division
            return (feet + (double)inches / 12);
        }

        public static double GetPrice()
        {
            string inputValue;        // local variables 
            double price;
            Write("Enter the price per Square Yard: ");
            inputValue = ReadLine();
            price = double.Parse(inputValue);
            return price;
        }

        public static double DetermineSquareYards(double width, double length)
        {
            const int SQ_FT_PER_SQ_YARD = 9;
            double noOfSquareYards;
            noOfSquareYards = length * width / SQ_FT_PER_SQ_YARD;
            return noOfSquareYards;
        }

        public static double DeterminePrice(double squareYards, double pricePerSquareYard)
        {
            return (pricePerSquareYard * squareYards);
        }

        public static void DisplayResults(double squareYards, double pricePerSquareYard)
        {
            WriteLine();
            Write("Square Yards needed: ");
            WriteLine("{0:N2}", squareYards);
            Write("Total Cost at {0:C} ", pricePerSquareYard);
            WriteLine(" per Square Yard: {0:C}",
                              DeterminePrice(squareYards,
                              pricePerSquareYard));
        }
    }   // end of class   
}  // end of namespace