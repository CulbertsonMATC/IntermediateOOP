using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Culbertson_FarmerApp
{
    enum Direction
    {
        North,
        South
    }

    enum GameState
    {
        InProgress,
        Won,
        LostFoxAteChicken,
        LostChickenAteGrain
    }

    class Farmer
    {
        //  VARIABLES
        //  *****************************************************

        private Direction farmer;
        private ArrayList northBank = new ArrayList();
        private ArrayList southBank = new ArrayList();




        //  PROPERTIES
        //  *****************************************************

        public ArrayList NorthBank
        {
            set { northBank = value; }
            get { return northBank; }
        }

        public ArrayList SouthBank
        {
            set { southBank = value; }
            get { return southBank; }
        }

        public Direction TheFarmer
        {
            get { return farmer; }
        }

        public GameState CurrentState
        {
            private set;
            get;
        } 
        //  METHODS
        //  *****************************************************

        public Farmer()
        {
            northBank.Add("fox");
            northBank.Add("chicken");
            northBank.Add("grain");
            farmer = Direction.North;
        }

        public int AnimalAteFood()
        {
            
            int ateFood;
            
            if (northBank.Contains("chicken") && !northBank.Contains("fox") && !northBank.Contains("grain") ||
                northBank.Contains("fox") && northBank.Contains("grain") && !northBank.Contains("chicken") ||
                northBank.Contains("fox") && northBank.Contains("chicken") && northBank.Contains("grain"))
            {
                ateFood = 0;
                WriteLine(ateFood);
                return ateFood;
            }
            else if (northBank.Contains("chicken") && northBank.Contains("fox") && !northBank.Contains("grain") ||
                northBank.Contains("grain") && !northBank.Contains("chicken") && !northBank.Contains("fox"))
            {
                ateFood = 1;
                WriteLine(ateFood);
                return ateFood;
            }
            else if (northBank.Contains("fox") && !northBank.Contains("chicken") && !northBank.Contains("grain") ||
                northBank.Contains("grain") && northBank.Contains("chicken") && !northBank.Contains("fox"))
            {
                ateFood = 2;
                WriteLine(ateFood);
                return ateFood;
            }
            else if (!northBank.Contains("grain") && !northBank.Contains("fox") && !northBank.Contains("chicken") ||
                southBank.Contains("grain") && southBank.Contains("fox") && southBank.Contains("chicken"))
            {
                ateFood = 3;
                WriteLine(ateFood);
                return ateFood;
            }
            else
            {
                ateFood = 0;
                WriteLine(ateFood);
                return ateFood;
            }
        }

        public int DetermineWin(int ate)
        {
            int status = ate;
            switch(status)
            {
                case 0:
                    return status;
                    break;
                case 1:
                    status = 1;
                    return status;
                    break;
                case 2:
                    status = 2;
                    return status;
                    break;
                case 3:
                    status = 3;
                    return status;
                    break;
                default:
                    return status;
            }
        }

        public void Move(string userInput)
        {
            //bool playAgain = true;
            //int i = 0;
            if (userInput == "")
            {
                if (farmer == Direction.North)
                {
                    farmer = Direction.South;
                }
                else if (farmer == Direction.South)
                {
                    farmer = Direction.North;
                }
            }
            else if (farmer == Direction.North)
            {
                northBank.Remove(userInput);
                southBank.Add(userInput);
                farmer = Direction.South;
            }
            else if (farmer == Direction.South)
            {
                southBank.Remove(userInput);
                northBank.Add(userInput);
                farmer = Direction.North;
            }
            // check conditions and update game state
            if (northBank.Count == 0 && farmer == Direction.South)
            {
                CurrentState = GameState.Won;
            }
            else
            {
                if (farmer == Direction.North)
                {
                    //check south bank for failure condition
                    if (southBank.Contains("fox") && southBank.Contains("chicken"))
                    {
                        CurrentState = GameState.LostFoxAteChicken;
                    }
                    else if (southBank.Contains("chicken") && southBank.Contains("grain"))
                    {
                        CurrentState = GameState.LostChickenAteGrain;
                    }                    
                }
                else
                {
                    //check north bank for failure condition
                    if (northBank.Contains("fox") && northBank.Contains("chicken"))
                    {
                        CurrentState = GameState.LostFoxAteChicken;
                    }
                    else if (northBank.Contains("chicken") && northBank.Contains("grain"))
                    {
                        CurrentState = GameState.LostChickenAteGrain;
                    }
                }
            }
        }
    } 
}

//             if (j == 1 || j == 2 || j == 3)
//             {
//                 northBank.Clear();
//                 southBank.Clear();
//                 farmer = Direction.North;
//                 northBank.Add("fox");
//                 northBank.Add("chicken");
//                 northBank.Add("grain");
//             }
//             return j;
