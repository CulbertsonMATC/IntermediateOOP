using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_StudentStudyApp
{
    class Student
    {
        private int id;
        private string name;
        private double[] hours;

        public Student(int id, string name, double[] hours)
        {
            this.hours = hours;
            this.id = id;
            this.name = name;
        }

        public int ID
        {            
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public void CalculateAvg()
        {

        }

        private void EnterHours(double[] hours)
        {
            this.hours = hours;
        }

        public double[] GetNumberHours()
        {
            return hours;
        }

    }
}
