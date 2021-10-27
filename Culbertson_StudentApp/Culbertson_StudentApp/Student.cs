using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_StudentApp
{
    class Student
    {
        private string studentNumber;
        private string studentFirstName;
        private string studentLastName;
        private string major;
        private double score1;
        private double score2;
        private double score3;
        private const double TOTALSCORE = 3;

        public Student() { }

        public Student(string studentNumber) 
        {
            this.studentNumber = studentNumber;
        }

        public Student(string studentFirstName, string studentLastName)
        {
            this.studentFirstName = studentFirstName;
            this.studentLastName = studentLastName;
        }

        public Student(string studentFirstName, string studentLastName, string studentNumber, string Major, double score1, double score2, double score3)
        {
            this.studentFirstName = studentFirstName;
            this.studentLastName = studentLastName;
            this.studentNumber = studentNumber;
            this.major = major;
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        public string StudentNumber 
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }

        public string StudentFirstName
        {
            get { return studentFirstName; }
            set { studentFirstName = value; }
        }
        public string StudentLastName
        {
            get { return studentLastName; }
            set { studentLastName = value; }
        }
        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        public double Score1
        {
            get { return score1; }
            set { score1 = value; }
        }
        public double Score2
        {
            get { return score2; }
            set { score2 = value; }
        }
        public double Score3
        {
            get { return score3; }
            set { score3 = value; }
        }
        public string FullName
        {
            get { return StudentFirstName+" "+studentLastName; }
        }
        public double CalculateAverage()
        {
            return (score1 + score2 + score3) / TOTALSCORE;
        }
        public override string ToString()
        {
            return "\nName: \t\t" + FullName + "\n\tMajor: \t\t" + major + "\n\tScore Average: " +
                CalculateAverage().ToString("F2");
        }

        /* public void setStudentNumber(string sNum)
        {
            studentNumber = sNum;
        }
        public string getStudentNumber()
        {
            return StudentNumber;
        } */
    }
}
