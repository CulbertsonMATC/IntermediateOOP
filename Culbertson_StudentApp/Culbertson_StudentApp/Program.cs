using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student();
            Questions ask = new Questions();

            newStudent.StudentFirstName = ask.StudentName("First");
            newStudent.StudentLastName = ask.StudentName("Last");
            newStudent.StudentNumber = ask.StudentNumber();
            newStudent.Major = ask.Major(newStudent.StudentFirstName);
            newStudent.Score1 = ask.ExamScore(1);
            newStudent.Score2 = ask.ExamScore(2);
            newStudent.Score3 = ask.ExamScore(3);
            WriteLine(newStudent);

            Student nextStudent = new Student("Mary", "Smith", "91901", "Music", 91, 67, 89);
            WriteLine(nextStudent);
            ReadKey();
        }
    }
}
