using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_StudentStudyApp
{
    class StudentUI
    {
        private string[] days = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public void DisplayAverage(double[] hours)
        {
            //  loops through the hours array to get a sum of the values, then finds the average
            double sum = 0;
            double average = 0.0;

            for (int i = 0; i < hours.Length; i++)
            {
                sum += hours[i];
            }

            average = (float)sum / hours.Length;

            Write("\nThe average number of hours studied per day was ");
            Write("{0:0.00}.", average);
            Write("\nKeep it up!");
        }

        public void DisplayData(string name, int id,  double[] hours)
        {
            //  outputs the information requested by the user
            Clear();
            WriteLine("Name: " + name);
            WriteLine("Student ID: " + id);
            
            WriteLine("\nThe number of hours of study that you did during the week are as follows: \n");
            for (int i = 0; i < hours.Length; i++)
            {
                WriteLine(days[i] + ": " + hours[i]);
            }
        }

        public double[] FillHours()
        {
            //  loops through the array while filling in values
            //  i would have liked to make it so that when a user BLASTS through the program and forgets to add a value for a day, it wouldn't force-quit, but here we are
            double[] hours = new double[7];
            for (int i = 0; i < hours.Length; i++)
            {
                Write("Enter the number of hours that you studied ITDEV-115 on " + days[i] + ": ");
                hours[i] = int.Parse(ReadLine());
            }
            return hours;
        }

        public void MainMethod()
        {
            //  the bulk of the logic, which is odd to me, but it works
            Write("Please enter your name: ");
            string name = ReadLine();
            Write("Please enter your student ID: ");
            int id = int.Parse(ReadLine());
            double[] hours = FillHours();
            Student student = new Student(id, name, hours);
            
            DisplayData(name, id, hours);
            DisplayAverage(hours);
            ReadKey();
        }
    }
}
