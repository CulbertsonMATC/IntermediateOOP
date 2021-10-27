using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Culbertson_FarmerApp1
{
    public class FarmerUI
    {
        Farmer farmer = new Farmer();

        public FarmerUI() { }
        public void DisplayGameState()
        {
            /*Clear();*/
            DisplayNorthBank();
            DisplayRiver();
            DisplaySouthBank();
            WriteLine("\nOl' Joe is on the {0} bank of the river.", farmer.TheFarmer);
        }

        private void DisplayNorthBank()
        {
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.Green;
            WriteLine("North Bank  ************************************  North Bank");
            WriteLine("North Bank  ************************************  North Bank");
            WriteLine("North Bank  ************************************  North Bank");
            WriteLine("North Bank  ************************************  North Bank");
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < farmer.NorthBank.Count; i++)
            {
                BackgroundColor = ConsoleColor.White;
                ForegroundColor = ConsoleColor.Black;
                Write(farmer.NorthBank[i]);
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.White;
                Write(" ");
            }
        }

        private void DisplayRiver()
        {
            BackgroundColor = ConsoleColor.Blue;
            WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~RIVER~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~RIVER~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~RIVER~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~RIVER~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        private void DisplaySouthBank()
        {           
            for (int i = 0; i < farmer.SouthBank.Count; i++)
            {
                BackgroundColor = ConsoleColor.White;
                ForegroundColor = ConsoleColor.Black;
                Write(farmer.SouthBank[i]);
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.White;
                Write(" ");
            }
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.Green;
            WriteLine("\nSouth Bank  ************************************  South Bank");
            WriteLine("South Bank  ************************************  South Bank");
            WriteLine("South Bank  ************************************  South Bank");
            WriteLine("South Bank  ************************************  South Bank");
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
        }

        private void DisplayWelcome()
        {
            int height = 55;
            int width = 80;
            SetWindowSize(width, height);
            
            WriteLine("                  ░░░░░░░░░░░░░░░░░░░░░░░░░░                ");
            WriteLine("                ░░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░              ");
            WriteLine("                ░░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░              ");
            WriteLine("                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              ");
            WriteLine("                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              ");
            WriteLine("                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              ");
            WriteLine("                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              ");
            WriteLine("                ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒              ");
            WriteLine("                ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓              ");
            WriteLine("    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            WriteLine("    ▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            WriteLine("    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            WriteLine("        ▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒    ");
            WriteLine("          ░░▒▒▓▓▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▓▓░░░░░░░░    ");
            WriteLine("              ▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░▓▓▓▓            ");
            WriteLine("              ▓▓▓▓░░░░░░░░░░░░░░░░▒▒░░░░░░░░▓▓▓▓            ");
            WriteLine("              ░░▓▓░░░░░░████░░░░░░░░████░░░░▓▓░░            ");
            WriteLine("              ░░░░░░░░░░██  ░░░░░░░░██  ░░░░░░░░            ");
            WriteLine("  ░░  ░░  ░░  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░            ");
            WriteLine("  ▒▒  ▒▒  ▒▒  ▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              ");
            WriteLine("  ▒▒  ▒▒  ▒▒  ▒▒  ░░░░░░░░░░░░░░░░░░░░░░░░░░                ");
            WriteLine("  ▒▒  ▒▒  ▒▒  ▒▒    ░░░░░░░░░░░░░░░░░░░░░░    Welcome to the");
            WriteLine("  ▒▒░░▒▒▒▒▒▒▒▒▒▒      ░░░░░░░░░░░░░░░░░░      Farmer Game!  ");
            WriteLine("    ░░  ▒▒    ░░    ░░  ░░░░░░░░░░░░░░                      ");
            WriteLine("        ▒▒          ░░▓▓▒▒░░░░░░░░░░▒▒▓▓░░                  ");
            WriteLine("        ░░        ░░░░▓▓▒▒░░░░▒▒░░░░▒▒▓▓░░░░                ");
            WriteLine("        ▒▒      ░░░░░░▓▓▒▒░░░░▒▒░░░░▒▒▓▓░░░░░░              ");
            WriteLine("        ▒▒      ░░░░▒▒▓▓▒▒░░░░▒▒░░░░▒▒▓▓░░░░░░              ");
            WriteLine("        ▒▒    ░░░░▒▒  ▓▓▒▒░░░░▒▒░░░░▒▒▓▓  ▒▒░░░░            ");
            WriteLine("        ▒▒    ░░▒▒    ▓▓▒▒░░░░▒▒░░░░░░▓▓  ▒▒░░░░            ");
            WriteLine("        ▒▒  ░░░░▒▒    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░░░              ");
            WriteLine("        ░░░░░░░░      ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░░░                ");
            WriteLine("        ░░░░░░░░      ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓░░░░                ");
            WriteLine("        ▒▒            ▓▓▓▓▓▓▒▒▒▒▒▒▓▓▓▓▓▓░░░░░░              ");
            WriteLine("        ▒▒            ▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓░░░░░░              ");
            WriteLine("        ▒▒            ▓▓▓▓▓▓▓▓  ▓▓▓▓▓▓▓▓░░                  ");
            WriteLine("        ▒▒            ▓▓▓▓▓▓      ▓▓▓▓▓▓                    ");
            WriteLine("        ▒▒            ▓▓▓▓░░      ░░▓▓▓▓                    ");
            WriteLine("        ▒▒            ▓▓▓▓          ▓▓▓▓                    ");
            WriteLine("        ▒▒            ▓▓▓▓          ▓▓▓▓                    ");
            WriteLine("        ▒▒            ▓▓▓▓          ▓▓▓▓                    ");
            WriteLine("        ▒▒            ████          ████                    ");
            WriteLine("        ▒▒            ████          ████                    ");
            WriteLine("        ▒▒          ██████          ██████   Press Enter    ");
            WriteLine("        ▒▒        ████████          ████████     To Play    ");
            ReadKey();
            /*Clear();*/ 
            WriteLine("Well a-howdy y'all and welcome to the ol' Farmer Game!\n\nOur good ol' friend The Farmer here has a dilemma. Well ya see right here now, ");
            WriteLine("Ol' Joe needs to get his pet fox Lucius, a wild chicken, \nand a big ol' bag o' barley across the river now.");
            Write("\nOnly thing is---that there fox is a-hungry for that chicken...");
            WriteLine("\nAnd that li'l chicken is a-miiiiighty hungry for that there barley.");
            WriteLine("\nNow Ol' Joe's arms don't work so good no more, so his sorry caboose\ncan only carry one at a time 'cross that river.");
            WriteLine("Think you'cn solve THAT problem there, City Slicker?\n\nPress Enter to show this folksy redneck who's who.");
            ReadKey();
            /*Clear();*/
        }

        public bool Play()
        {
            bool playAgain = true;
            int ateFood = 0;
            int win = 0;
            while (playAgain == true)
            {                            
                DisplayGameState();            
                farmer.Move(PromptForMove());            
                ateFood = farmer.AnimalAteFood();           
                win = farmer.DetermineWin(ateFood);
            
                if (win == 1)
                {
                    Clear();
                    WriteLine("\n\n\n\nConsarnit, Lucius done eated that chicken!");



                else if (win == 2)
                    {
                        WriteLine("That dang chicken gone and pecked up all the barley!");
                    }

                    WriteLine("Would you like to play again?\t\t(Y)es or (N)o");
                    var playAsString = ReadLine();

                    char play;
                    bool parseSuccess = char.TryParse(playAsString, out play);

                    if (parseSuccess)
                    {
                        if (play == 'y')
                        {
                            playAgain = true;
                        }
                        else if (play == 'n')
                        {
                            playAgain = false;
                        }
                    else 
                            

                    }
                }
                else if (win == 3)
                {
                    WriteLine("Well I'll be a golden goose, y'all gone and done it! Y'all make an ol' hillbilly like me so proud ya do!");
                }
            }
        }

        public void PlayGame()
        {
            int playAgain = 1;
            int winStatus = 0;
            DisplayWelcome(); 
            do
            {  
                Play();  
            } while (winStatus == 0);
        }

        private string PromptForMove()
        {
            Write("Whatchu gon' have Ol' Joe haul across that mighty crick?");
            string temp = ReadLine();
            temp.ToLower();
            return temp;
        }
    }
}
