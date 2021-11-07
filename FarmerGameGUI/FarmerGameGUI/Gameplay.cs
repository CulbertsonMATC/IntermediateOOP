using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerGameGUI
{
    public partial class Gameplay : Form
    {
        Farmer farmer = new Farmer();

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

        private Direction direction;
        private ArrayList northBank = new ArrayList();
        private ArrayList southBank = new ArrayList();

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
            get { return direction; }
        }

        public GameState CurrentState
        {
            private set;
            get;
        }

        public Gameplay()
        {
            InitializeComponent();
            this.MouseClick += new MouseEventHandler(this.button1_Click);
            Play();


        }

        public void Play(string userInput)
        {
            if (userInput == "")
            {
                if (direction == Direction.North)
                {
                    direction = Direction.South;
                }
                else if (direction == Direction.South)
                {
                    direction = Direction.North;
                }
            }
            else if (direction == Direction.North)
            {
                northBank.Remove(userInput);
                southBank.Add(userInput);
                direction = Direction.South;
            }
            else if (direction == Direction.South)
            {
                southBank.Remove(userInput);
                northBank.Add(userInput);
                direction = Direction.North;
            }

            // check conditions and update game state
            if (northBank.Count == 0 && direction == Direction.South)
            {
                CurrentState = GameState.Won;
            }
            else
            {
                if (direction == Direction.North)
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

        public void Play()
        {
            while (farmer.CurrentState == Farmer.GameState.InProgress)
            {
                
            }
            if (farmer.CurrentState == Farmer.GameState.Won)
            {
                MessageBox.Show("Well I'll be a golden goose, y'all gone and done it! Y'all make an ol' hillbilly like me so proud ya do!");
            }
            if (farmer.CurrentState == Farmer.GameState.LostFoxAteChicken)
            {
                MessageBox.Show("Aww darnit! Consarnit, Lucius done eated that chicken!");
            }
            if (farmer.CurrentState == Farmer.GameState.LostChickenAteGrain)
            {
                MessageBox.Show("Aww darnit! That dang chicken gone and pecked up all the barley!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Well goodbye now, y'all!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string choice = "";
            choice += (radioButton1.Checked ? "Fox" : "");
            choice += (radioButton2.Checked ? "Chicken" : "");
            choice += (radioButton3.Checked ? "Grain" : "");
            choice += (radioButton4.Checked ? "" : "");

            MessageBox.Show(choice + " selected.");
        }


     }
}
