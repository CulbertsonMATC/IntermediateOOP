using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_BodyMass
{
    class BMI
    {
        private string userName;
        private double height;
        private double weight;
        private double bmi;
        private const int MULTIPLIER = 703;
        private string assessment;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double CalculateBMI()
        {
            /* BMI = (weightInPounds / (heightInInches * heightInInches)) * 703.0 */
            bmi = (weight / (height * height)) * MULTIPLIER;
            return bmi;
        }

        public double Bmi
        {
            get { return bmi; }
        }

        public string Assessment
        {
            get { return assessment; }
        }

        public string CalculateAssessment()
        {
            if (bmi > 30)
            {
                assessment = "obese";
            }
            else if (bmi > 25)
            {
                assessment = "overweight";
            }
            else if (bmi > 18.5)
            {
                assessment = "normal";
            }
            else
            {
                assessment = "underweight";
            }
            return assessment;
        }
    }
}
