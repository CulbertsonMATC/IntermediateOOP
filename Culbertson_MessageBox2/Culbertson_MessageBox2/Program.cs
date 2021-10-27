using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;

namespace Culbertson_MessageBox2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moreData = true;
            int number;
            Random random = new Random();
            number = random.Next(100);

            while (moreData)
            {
                Write("{0} ", number);

                if (MessageBox.Show("Do you want another number?", "State-Controlled Loop",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    moreData = false;
                }
                else
                {
                    number = random.Next(100);
                }
            }

        }
    }
}
