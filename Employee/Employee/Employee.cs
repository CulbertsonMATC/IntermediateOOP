using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Employee
{
    class Payroll
    {
        private const double COMMISSIONINCOME = .07;
        private double federal;
        private const double FEDERALTAX = .18;
        private string firstName;
        private string lastName;
        private double retirement;
        private double retirementContribution;
        private double sales;
        private const double SOCIALSECURITY = .06;
        private double ss;
        private double commission;
        private double withholdings;
        private double takeHome;


        public Payroll() { }

        public Payroll(string firstName)
        {
            this.firstName = firstName;
        }

        public Payroll(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Payroll(string firstName, string lastName, double sales)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.sales = sales;
        }
        public double Federal
        {
            get { return FEDERALTAX; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public double Sales
        {
            get { return sales; }
            set { sales = value; }
        }
        public double Retirement
        {
            get { return retirement; }
            set { retirement = value; }
        }

        public double SS
        {
            get { return ss; }
            set { ss = value; }
        }

        public double CalculateCommissionIncome()
        {
            commission = sales * COMMISSIONINCOME;
            return commission;
        }

        public double CalculateFederal()
        {
            federal = commission * FEDERALTAX;
            return federal;
        }

        public double CalculateRetirement()
        {
            retirementContribution = commission * .1;
            return retirementContribution;
        }

        public double CalculateSS()
        {
            ss = commission * .06;
            return sales;
        }

        public double CalculateWithholdings()
        {
            withholdings = ss + federal + retirementContribution;
            return withholdings;
        }
        public double CalculateTakeHomePay()
        {
            CalculateCommissionIncome();
            CalculateFederal();
            CalculateRetirement();
            CalculateSS();
            CalculateWithholdings();
            double takeHome = commission - withholdings;
            return takeHome;
        }
        public override string ToString()
        {
            CalculateTakeHomePay();

            WriteLine("\nName: \t\t" + firstName + " " + lastName);
            WriteLine("\nEmployee Gross Income: \t\t{0,5:C}", commission);
            WriteLine("Federal Tax Withheld: \t\t{0,5:C}", federal);
            WriteLine("Social Security Tax Withheld: \t{0,5:C}", ss);
            WriteLine("Retirement Contribution: \t{0,5:C}", retirementContribution);
            WriteLine("\nEmployee Net Pay: \t\t{0,5:C}", CalculateTakeHomePay());
            return "\n";

            /*return "\nName: " + firstName + " " + lastName + "\n\tEmployee Gross Income: \t\t" + sales
                + "\n\tFederal Tax Withheld: " + federal + "\n\tSocial Security Tax Withheld: " + ss
                + "\n\tRetirement Contribution: " + retirement + "\n\nEmployee Net Pay: " + CalculateTakeHomePay().ToString("F2");*/
        }
    }
}
