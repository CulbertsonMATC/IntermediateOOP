/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace FarmerGameGUI
{
    class FarmerUI
    {
        Farmer farmer;
        bool playing = true;

        public void DisplayGameState()
        {
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
            WriteLine(north + "\n" + north + "\n" + north + "\n" + north + "\n");
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
            Write("\n");
        }

        private void DisplayRiver()
        {
            string river = "~~~~~~~~~~~~~~~~~~~~~~~~~~RIVER~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            BackgroundColor = ConsoleColor.Blue;
            WriteLine(river + "\n" + river + "\n" + river + "\n" + river + "\n");
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
            Write("\n");
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.Green;
            WriteLine(south + "\n" + south + "\n" + south + "\n" + south + "\n");
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
        }

        private void DisplayWelcome()
        {
            *//*int height = 55;
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
            Clear();
            WriteLine("Well a-howdy y'all and welcome to the ol' Farmer Game!\n\nOur good ol' friend The Farmer here has a dilemma. Well ya see right here now, ");
            WriteLine("Ol' Joe needs to get his pet fox Lucius, a wild chicken, \nand a big ol' bag o' barley across the river now.");
            Write("\nOnly thing is---that there fox is a-hungry for that chicken...");
            WriteLine("\nAnd that li'l chicken is a-miiiiighty hungry for that there barley.");
            WriteLine("\nNow Ol' Joe's arms don't work so good no more, so his sorry caboose\ncan only carry one at a time 'cross that river.");
            WriteLine("Think you'cn solve THAT problem there, City Slicker?\n\nPress Enter to show this folksy redneck who's who.");
            ReadKey();
            Clear();*//*
        }

        public void Play()
        {
            while (farmer.CurrentState == Farmer.GameState.InProgress)
            {
                DisplayGameState();
                farmer.Move(PromptForMove());
            }
            if (farmer.CurrentState == Farmer.GameState.Won)
            {
                WriteLine("Well I'll be a golden goose, y'all gone and done it! Y'all make an ol' hillbilly like me so proud ya do!");
            }
            if (farmer.CurrentState == Farmer.GameState.LostFoxAteChicken)
            {
                WriteLine("Aww darnit! Consarnit, Lucius done eated that chicken!");
            }
            if (farmer.CurrentState == Farmer.GameState.LostChickenAteGrain)
            {
                WriteLine("Aww darnit! That dang chicken gone and pecked up all the barley!");
            }
            PromptPlayAgain();
            Clear();
        }

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
            bool validInput = false;
            string input = "";
            while (!validInput)
            {
                Write("Valid options are fox, chicken, grain, or nothing(blank):");
                input = ReadLine().ToLower();
                if (new[] { "fox", "chicken", "grain", "" }.Contains(input))
                {
                    validInput = true;
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
}*/