using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerGameGUI
{
    class Farmer
        {
            // ENUMS
            // ****************************************************

            public enum Direction
            {
                North,
                South
            }

            public enum GameState
            {
                InProgress,
                Won,
                LostFoxAteChicken,
                LostChickenAteGrain
            }


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

            public void Move(string userInput)
            {
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
