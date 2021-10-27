using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Culbertson_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add("I can add string data");
            myArrayList.Add(34);
            myArrayList.Add(54.345);
            myArrayList.Add('b');

            DisplayMyList(myArrayList);
            myArrayList.RemoveAt(2);
            DisplayMyList(myArrayList);
            myArrayList.Insert(2, "Hello again, just added new data");
            DisplayMyList(myArrayList);
            myArrayList.Reverse();
            DisplayMyList(myArrayList);


            ReadKey();
        }

        public static void DisplayMyList(ArrayList list)
        {
            WriteLine("\n\n\n");

            for (int i = 0; i < list.Count; i++)
            {
                WriteLine("Arraylist {0} = {1}", i, list[i]);
            }
        }
    }
}
