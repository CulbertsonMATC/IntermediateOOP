using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNameSpace;
using ITravellerNameSpace;

namespace Student
{
    class Student : Person, ITraveller
    {
        private string major;
        private string studentId;
        public Student() : base() { }
        public Student(string id, string fname, string lname, string maj, string sid)
            :base(id, lname, fname)
        {
            major = maj;
            studentId = sid;
        }
        public string StudentId { get { return studentId; } }
        public string Major { get { return major; }set { major = value; } }
        public override int GetSleepAmt()
        {
            return 6;
        }
        public int CallOverriddenGetSleepAmt()
        {
            return base.GetSleepAmt();
        }
        public override string GetExerciseHabits()
        {
            return "Exercise Daily";
        }
        public string GetDestination()
        {
            return "Home";
        }
        public string GetStartLocation()
        {
            return "Start Here";
        }
        public double DetermineMile()
        {
            return 75.0;
        }


      /*  static void Main(string[] args)
        {
        }*/
    }
}
