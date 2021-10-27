using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_MagicPCApp
{
    class MagicPC
    {

        public string GetUserAnswer()
        {   
            Random gen = new Random();           
            string response;
            int number;
            
            number = gen.Next(0, 9);

            switch (number)
            {             
                case 0:
                    response = "It does not seem likely, my child.";
                    break;
                case 1:
                    response = "Your chances are impressive, and my hopes for you are high.";
                    break;
                case 2:
                    response = "I would sooner buy a lottery ticket than expect that.";
                    break;
                case 3:
                    response = "There's always a chance.";
                    break;
                case 4:
                    response = "I have seen this in your future.";
                    break;
                case 5:
                    response = "I'm not saying never, but yeah, never.";
                    break;
                case 6:
                    response = "This would be wise.";
                    break;
                case 7:
                    response = "You shouldn't bet on it.";
                    break;
                case 8:
                    response = "Listen, just give up hope for that. Like, now.";
                    break;
                case 9:
                    response = "It could very well be. But it could very well NOT be, as well.";
                    break;
                default:
                    response = "This number shouldn't even be here. You should leave before something bad happens to spacetime.";
                    break;
            };
            return response;
        }
    }
}
