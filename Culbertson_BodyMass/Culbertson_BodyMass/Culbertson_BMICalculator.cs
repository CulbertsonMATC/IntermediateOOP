using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_BodyMass
{
    class Culbertson_BMICalculator
    {
        static void Main(string[] args)
        {
            BMI model = new BMI();
            BMIUI view = new BMIUI();
            Display info = new Display();

            info.DisplayInfo("Body Mass Index");
            model.UserName = view.NameInput();
            view.Welcome(model.UserName);
            model.Height = view.UserHeight();
            model.Weight = view.UserWeight();
            model.CalculateBMI();
            model.CalculateAssessment();
            view.DisplayResults(model.Height, model.Weight, model.Bmi, model.Assessment);


        }
    }
}
