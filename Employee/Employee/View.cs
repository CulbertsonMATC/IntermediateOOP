using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Employee
{
    class View
    {
        public string EmployeeName(string whichOne)
        {
            string temp;
            Write("Please enter the employee's {0} name: ", whichOne);
            temp = ReadLine();
            return temp;
        }
        public double EmployeeSales(string EmployeeFirstName)
        {
            string inValue;
            double aScore;
            Write("Please enter {0}'s sales for the month: ", EmployeeFirstName);
            inValue = ReadLine();
            while (double.TryParse(inValue, out aScore) == false)
            {
                Write("Please enter {0}'s sales for the month: ", EmployeeFirstName);
                inValue = ReadLine();
            }
            return aScore;
        }

    }
}
