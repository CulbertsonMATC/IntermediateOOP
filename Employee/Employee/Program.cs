using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Employee
{
    class Employee
    {
        static void Main(string[] args)
        {
            View view = new View();
            Info info = new Info();
            info.DisplayInfo("Employee Payroll Class Assignment");
            Payroll newEmployee = new Payroll(view.EmployeeName("First"), view.EmployeeName("Last"));
            newEmployee.Sales = view.EmployeeSales(newEmployee.FirstName);
            WriteLine(newEmployee);
            ReadKey();

            
            
        }
    }
}
