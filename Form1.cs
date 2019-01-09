using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public bool isPlayer1 = true;
        string[,] marks = new string[,] { };
        List<Button> gameButtons = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            
            //List of game buttons
            gameButtons.Add(button1);
            gameButtons.Add(button2);
            gameButtons.Add(button3);
            gameButtons.Add(button4);
            gameButtons.Add(button5);
            gameButtons.Add(button6);
            gameButtons.Add(button7);
            gameButtons.Add(button8);
            gameButtons.Add(button9);

        }

        // Set 'X' or 'O' on buttons and swaps active player;
        private void MakeMove(object sender)
        {
            Button button = sender as Button;
            if (isPlayer1) { button.Text = "X"; isPlayer1 = !isPlayer1; button.Enabled = false; WinCheck(); }
            else { button.Text = "O"; isPlayer1 = !isPlayer1; button.Enabled = false; WinCheck(); }
        }

        // Removes marks on buttons and enables them again
        private void ResetGame()
        {
            foreach (Button button in gameButtons)
            {
                button.Text = "";
                button.Enabled = true;
                isPlayer1 = true;
            }
        }

        private void WinCheck()
        {
            //Create and fill 2d array          
            string[,] marks = new string[,] {
                {button1.Text, button2.Text, button3.Text},
                {button6.Text, button5.Text, button4.Text},
                {button9.Text, button8.Text, button7.Text}
            };

            //Inadequate win check 
            
            //Check for player 1 aka 'X'
            if (marks[0, 0] == "X" && marks[0, 1] == "X" && marks[0, 2] == "X" ||   //Checking rows 
                marks[1, 0] == "X" && marks[1, 1] == "X" && marks[1, 2] == "X" ||
                marks[2, 0] == "X" && marks[2, 1] == "X" && marks[2, 2] == "X" ||

                marks[0, 0] == "X" && marks[1, 0] == "X" && marks[2, 0] == "X" ||   //Checking columns
                marks[0, 1] == "X" && marks[1, 1] == "X" && marks[2, 1] == "X" ||
                marks[0, 2] == "X" && marks[1, 2] == "X" && marks[2, 2] == "X" ||

                marks[0, 0] == "X" && marks[1, 1] == "X" && marks[2, 2] == "X" ||   //Checking diag
                marks[0, 2] == "X" && marks[1, 1] == "X" && marks[2, 0] == "X") { MessageBox.Show("Player 1 Wins!"); ResetGame();}
            //Check for player 2 aka 'O'
            else if 
               (marks[0, 0] == "O" && marks[0, 1] == "O" && marks[0, 2] == "O" ||   //Checking rows 
                marks[1, 0] == "O" && marks[1, 1] == "O" && marks[1, 2] == "O" ||
                marks[2, 0] == "O" && marks[2, 1] == "O" && marks[2, 2] == "O" ||

                marks[0, 0] == "O" && marks[1, 0] == "O" && marks[2, 0] == "O" ||   //Checking columns
                marks[0, 1] == "O" && marks[1, 1] == "O" && marks[2, 1] == "O" ||
                marks[0, 2] == "O" && marks[1, 2] == "O" && marks[2, 2] == "O" ||

                marks[0, 0] == "O" && marks[1, 1] == "O" && marks[2, 2] == "O" ||   //Checking diag
                marks[0, 2] == "O" && marks[1, 1] == "O" && marks[2, 0] == "O") { MessageBox.Show("Player 2 Wins!"); ResetGame();}
            //Check for draw
            else if
               (marks[0, 0] != "" && marks[0, 1] != "" && marks[0, 2] != "" &&    
                marks[1, 0] != "" && marks[1, 1] != "" && marks[1, 2] != "" &&
                marks[2, 0] != "" && marks[2, 1] != "" && marks[2, 2] != "") { MessageBox.Show("Draw!"); ResetGame(); }
                 
        }


        #region //Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            MakeMove(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakeMove(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MakeMove(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MakeMove(sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MakeMove(sender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MakeMove(sender);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MakeMove(sender);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MakeMove(sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MakeMove(sender);

        }       
        #endregion

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

    }
}
