using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_TicTacToe
{
    class Game
    {
        Player playerX;
        Player playerY;
        Board gameBoard;
        string[] gameArray = new string[9];
        string gamePlayer;

        public void PlayAgain()
        {

            string response;

            DisplayWelcome();


            do
            {
                Console.Clear();
                Play();
                Console.Write("\n\n\nWould you like to play again? ");
                response = Console.ReadLine().ToUpper();
                response = response.Substring(0, 1);
            }
            while (response == "Y");
        }

        public void DisplayWelcome()
        {
            /* Welcome the player to the game, be fun about it */
            Console.ReadLine();
            Console.Clear();
        }

        public void Play()
        {
            bool result = false;
            bool tieGame = false;
            int selection;

            playerX = new Player();
            playerY = new Player();
            gameBoard = new Board();

            for (int i = 0; i < gameArray.Length; i++)
                gameArray[i] = " ";

            gamePlayer = "X";

            DisplayBoardGrid();

            do
            {
                selection = IsPlaying(gamePlayer);
                DisplayBoardGrid();
                DisplayGrid(selection);

                if (gamePlayer == "X")
                    result = gameBoard.IsWinner(playerX);
                else
                    result = gameBoard.IsWinner(playerY);

                if (result)
                    AnnounceWinner();
                else
                    tieGame = gameBoard.IsFull();

                if (tieGame)
                    IsTie();

                if (gamePlayer == "X")
                    gamePlayer = "Y";
                else
                    gamePlayer = "X";
            }
            while (!(tieGame) || result);
        }

        public void DisplayBoardGrid()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t 0 | 1 | 2");
            Console.WriteLine("\t----------");
            Console.WriteLine("\t 3 | 4 | 5");
            Console.WriteLine("\t----------");
            Console.WriteLine("\t 6 | 7 | 8");
            Console.WriteLine("\n\n");
        }

        public int IsPlaying(string thePlayer)
        {
            int userSelection;

            Console.Write("Alright {0}, make your move.", thePlayer);

            while ((int.TryParse(Console.ReadLine(), out userSelection) == false) || (userSelection > 8) || (gameArray[userSelection] != " "))
            {
                Console.WriteLine("\nPlease enter a number that is available");
                Console.Write("Player {0}, do the thing.", thePlayer);
            }

            if (thePlayer == "X")
            {
                playerX.MakeMove(userSelection);
            }
            else
            {
                playerY.MakeMove(userSelection);
            }

            Console.Clear();

            return userSelection;
        }

        public void DisplayGrid(int theSelection)
        {
            gameArray[theSelection] = gamePlayer;

            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t {0} | {1} | {2} ", gameArray[0], gameArray[1], gameArray[2]);
            Console.WriteLine("\t----------------");
            Console.WriteLine("\t {3} | {4} | {5} ", gameArray[3], gameArray[4], gameArray[5]);
            Console.WriteLine("\t----------------");
            Console.WriteLine("\t {6} | {7} | {8} ", gameArray[6], gameArray[7], gameArray[8]);
            Console.WriteLine("\n\n\n");
        }

        public void AnnounceWinner()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Player {0} is the winner!\n\n\n", gamePlayer);
        }

        public void IsTie()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Nope. No winners here.\n\n\n");
        }
    }
}
