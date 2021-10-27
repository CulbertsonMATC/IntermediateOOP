using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_MagicPCApp
{
    class MagicPCUI
    {
        private string userMagic;

        private string GetUserQuestion()
        {
            string answer;
            WriteLine("\n\nPlease write out your query for the cursed demons that live in the computer to fetch \nfor me, and I shall reveal to you fortune true!\n");
            answer = ReadLine();
            return answer;
        }

        public void RespondToQuestion()
        {
            MagicPC answer = new MagicPC();
            
            userMagic = answer.GetUserAnswer();
            Write("\n\nAND SO IT IS WRITTEN, YOUR FORTUNE IS AS FOLLOWS:\n\n\n{0}", userMagic, "/n/n/nNo refunds, I hope you enjoyed this but I'm sorry we're closed.");
            ReadKey();
        }

        public string Start()
        {
            string answer;
            Write("Welcome to this, my House of Fortune!");
            UserInstructions();
            answer = GetUserQuestion();
            if (answer != "")
            {                
                RespondToQuestion();
                return answer;
            }
            else
            {
                return null;
            }
        }

        private void UserInstructions()
        {
            Write("\n\nI sincerely hope you've brought a pocket full of \"yes or no\" questions, \nfor it is I, the Reader of Fortunes!");
        }
    }
}
