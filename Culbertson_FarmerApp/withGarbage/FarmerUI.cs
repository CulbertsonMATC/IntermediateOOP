using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace Culbertson_FarmerApp
{
    class FarmerUI
    {
        Farmer farmer;
        bool playing = true;

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
            string north = "North Bank  ************************************  North Bank";
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.Green;
            WriteLine(north + "\n"+ north + "\n" + north + "\n" + north + "\n");
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
            string river = "~~~~~~~~~~~~~~~~~~~~~~~~~~RIVER~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            BackgroundColor = ConsoleColor.Blue;
            WriteLine(river + "\n"+ river + "\n" + river + "\n" + river + "\n");
        }

        private void DisplaySouthBank()
        {
            string south = "South Bank  ************************************  South Bank";
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
            WriteLine(south + "\n"+ south + "\n" + south + "\n" + south + "\n");
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

        public void Play()
        {
            while (farmer.CurrentState == GameState.InProgress)
            {
                DisplayGameState();
                farmer.Move(PromptForMove());
            }
            if (farmer.CurrentState == GameState.Won)
            {
                //i won
                WriteLine("won!");
            }
            if (farmer.CurrentState == GameState.LostFoxAteChicken)
            {
                //clever fox
                WriteLine("fox ate chick");
            }
            if (farmer.CurrentState == GameState.LostChickenAteGrain)
            {
                //dumb bird
                WriteLine("chicken ate grain");
            }
            PromptPlayAgain();
        }



            // bool playAgain = true;
            // int ateFood = 0;
            // int win = 0;
            // while (playAgain == true)
            // {
            //     if (win == 0)
            //     {
            //         DisplayGameState();
            //         farmer.Move(PromptForMove());
            //         ateFood = farmer.AnimalAteFood();
            //         win = farmer.DetermineWin(ateFood);
            //         if (win == 1)
            //         {
            //             // print a win and exit
            //             WriteLine("Congratulations!");
            //         }
            //         if (ateFood == 1)
            //         {
            //             // print failure condition and exit
            //             WriteLine("Aww darnit!");
            //         }
            //         if (ateFood == 1)
            //         {
            //             Clear();
            //             WriteLine("\n\n\n\nConsarnit, Lucius done eated that chicken!");
            //         }
            //         else if (ateFood == 2)
            //         {
            //             Clear();
            //             WriteLine("That dang chicken gone and pecked up all the barley!");
            //         }

                    //     WriteLine("Would you like to play again?\t\t(Y)es or (N)o");
                    //     var playAsString = ReadLine();

                    //     char play;
                    //     bool parseSuccess = char.TryParse(playAsString, out play);

                    //     if (parseSuccess)
                    //     {
                    //         if (play == 'y')
                    //         {
                    //             playAgain = true;
                    //         }
                    //         else if (play == 'n')
                    //         {
                    //             playAgain = false;
                    //         }
                    //     } else 
                    //     {

                    //     }
                    // }
                    // else if (win == 3)
                    // {
                    //     WriteLine("Well I'll be a golden goose, y'all gone and done it! Y'all make an ol' hillbilly like me so proud ya do!");
                    // }
        //         }
        //     }
        //     return playAgain;
        // }

        public void PlayGame()
        {
            
            while (playing == true)
            {
                farmer = new Farmer();
                DisplayWelcome();
                Play();
            }
        }

        private string PromptForMove()
        {
            Write("Whatchu gon' have Ol' Joe haul across that mighty crick?\n");
            bool invalidInput = true;
            string input = "";
            while (invalidInput)
            {
                Write("Valid options are fox, chicken, grain, or nothing(blank):");
                input = ReadLine().ToLower();
                if (new[] {"fox", "chicken", "grain", ""}.Contains(input))
                //if (input == "fox" || input == "chicken" || input == "grain" || input == "")
                {
                    invalidInput = false;
                }
            }
            return input;
        }

        private void PromptPlayAgain()
        {
            Write("play again?");
            bool.TryParse(ReadLine(), out playing);
        }
    }
}
