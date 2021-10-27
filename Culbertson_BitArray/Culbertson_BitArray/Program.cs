using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray firstBitArray = new BitArray(10);
            WriteLine("firstBitArray");
            DisplayBitArray(firstBitArray);
            BitArray secondBitArray = new BitArray(10, true);
            WriteLine("secondBitArray");    
            DisplayBitArray(secondBitArray);
            bool[] boolArray = new bool[10] { true, false, false, false, true, true, false, true, true, false };
            BitArray thirdBitArray = new BitArray(boolArray);
            DisplayBitArray(thirdBitArray);
            firstBitArray[3] = true;
            firstBitArray.Set(5, true);
            DisplayBitArray(firstBitArray);

            ReadKey();
        }

        public static void DisplayBitArray(BitArray bit)
        {
            WriteLine("\n\n\n");
            foreach (bool ba in bit)
            {
                Write("{0}\t",ba);
            }
        }
    }
}
