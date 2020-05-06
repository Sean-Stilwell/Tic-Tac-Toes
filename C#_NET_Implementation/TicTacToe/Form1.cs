using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormTicTacToe : Form
    {

        private BoardLogic board = new BoardLogic();
        private string currentPlayer;
        private int xScoreVal;
        private int oScoreVal;
        private Boolean activeGame;

        /** 
         * Updates the appearance of the board.
        */
        public void UpdateView()
        {
            // First, the function simply updates the text in each box.
            buttonTL.Text = TranslateIntToPlayer(board.getPos(0, 0));
            buttonTC.Text = TranslateIntToPlayer(board.getPos(0, 1));
            buttonTR.Text = TranslateIntToPlayer(board.getPos(0, 2));
            buttonML.Text = TranslateIntToPlayer(board.getPos(1, 0));
            buttonMC.Text = TranslateIntToPlayer(board.getPos(1, 1));
            buttonMR.Text = TranslateIntToPlayer(board.getPos(1, 2));
            buttonBL.Text = TranslateIntToPlayer(board.getPos(2, 0));
            buttonBC.Text = TranslateIntToPlayer(board.getPos(2, 1));
            buttonBR.Text = TranslateIntToPlayer(board.getPos(2, 2));

            // We also update the score values on the form (primarily for reset)
            xScore.Text = Convert.ToString(xScoreVal);
            oScore.Text = Convert.ToString(oScoreVal);

            // If a player has won, the board gets disabled to prevent further moves
            // until a reset occurs.
            if (board.hasWinner() && activeGame)
            {
                buttonTL.Enabled = false;
                buttonTC.Enabled = false;
                buttonTR.Enabled = false;
                buttonML.Enabled = false;
                buttonMC.Enabled = false;
                buttonMR.Enabled = false;
                buttonBL.Enabled = false;
                buttonBC.Enabled = false;
                buttonBR.Enabled = false;
                // Aditionally, the active game boolean is toggled. This indicates that there is
                // no current game, so the score won't increase if the reset button is clicked.
                activeGame = false;

                // We give a point to the winning player.
                if (board.findWinner() == 1)
                {
                    xScoreVal = xScoreVal + 1;
                }
                else
                {
                    oScoreVal = oScoreVal + 1;
                }

                // We update scores again (to immediately display a win)
                xScore.Text = Convert.ToString(xScoreVal);
                oScore.Text = Convert.ToString(oScoreVal);

                // We will then highlight the positions that led to a win
                int caseSwitch = board.findWinningPos();
                switch (caseSwitch)
                {
                    case 1:
                        buttonTL.BackColor = Color.Yellow;
                        buttonTC.BackColor = Color.Yellow;
                        buttonTR.BackColor = Color.Yellow;
                        break;
                    case 2:
                        buttonML.BackColor = Color.Yellow;
                        buttonMC.BackColor = Color.Yellow;
                        buttonMR.BackColor = Color.Yellow;
                        break;
                    case 3:
                        buttonBL.BackColor = Color.Yellow;
                        buttonBC.BackColor = Color.Yellow;
                        buttonBR.BackColor = Color.Yellow;
                        break;
                    case 4:
                        buttonBL.BackColor = Color.Yellow;
                        buttonML.BackColor = Color.Yellow;
                        buttonTL.BackColor = Color.Yellow;
                        break;
                    case 5:
                        buttonBC.BackColor = Color.Yellow;
                        buttonMC.BackColor = Color.Yellow;
                        buttonTC.BackColor = Color.Yellow;
                        break;
                    case 6:
                        buttonBR.BackColor = Color.Yellow;
                        buttonMR.BackColor = Color.Yellow;
                        buttonTR.BackColor = Color.Yellow;
                        break;
                    case 7:
                        buttonTL.BackColor = Color.Yellow;
                        buttonMC.BackColor = Color.Yellow;
                        buttonBR.BackColor = Color.Yellow;
                        break;
                    case 8:
                        buttonBL.BackColor = Color.Yellow;
                        buttonMC.BackColor = Color.Yellow;
                        buttonTR.BackColor = Color.Yellow;
                        break;
                }
            }
        }

        /**
         * Converts a BoardLogic value to the position
         * Parameter - int from BoardLogic
         * Return - String representation of the character.
         */
        private string TranslateIntToPlayer(int j)
        {
            // A simple switch is all we need, as there are only 3 cases.
            switch (j)
            {
                case 0:
                    return " ";
                case 1:
                    return "X";
                case 2:
                    return "O";
            }
            // If nothing is returned we can throw an error. (Should be impossible)
            throw new System.SystemException("Error occurred.");
        }

        /**
         * Converts a player letter to the BoardLogic int
         * Parameter - string representation of the player
         * Return - int representation of the player.
         */
        private int TranslatePlayerToInt(string j)
        {
            // Similar to the other, all we need is a switch to show the three choices
            switch (j)
            {
                case " ":
                    return 0;
                case "X":
                    return 1;
                case "O":
                    return 2;
            }
            // If none of the switches occurs, an error is thrown.
            throw new System.SystemException("Error occurred.");
        }

        /**
         * Swaps the active player (such as after a move).
         */
        private void swapPlayer()
        {
            // After every move, the player is swapped.
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else
            {
                currentPlayer = "X";
            }
        }

        /**
        * Initializes the form. 
        */
        public FormTicTacToe()
        {
            InitializeComponent();
            currentPlayer = "X"; // X is always the first to go.
            activeGame = true; // Indicates that a game is occurring.
            UpdateView(); // Immediately updates view to show the active game
        }

        /**
         * Resets the player scores and updates the view.
         */
        private void ScoreReset_Click(object sender, EventArgs e)
        {
            xScoreVal = 0;
            oScoreVal = 0;
            UpdateView(); // Must use update view to indicate the change in score.
        }
        /**
         *  GENERAL EXPLANATION FOR BUTTONS
         *  
         *  For each of the 9 main board buttons, there is a matching position on
         *  the BoardLogic instance matrix. These buttons simply place the current
         *  player's ID on the button they click.
         *  
         *  If a player attempts to click on a position already occupied, we simply
         *  display a message box to warn them.
         *  
         *  After every move, we swap the active player to give the opponent a turn.
         */

        /**
         * Code for when the top left button is clicked.
         */
        private void ButtonTL_Click(object sender, EventArgs e)
        {
            if (board.getPos(0,0) == 0)
            {
                board.placeValue(0, 0, TranslatePlayerToInt(currentPlayer));
                swapPlayer();
            }
            else
            {
                MessageBox.Show("You can't move here!");
            }
            UpdateView();
        }

        /**
         * Code for when the top middle button is clicked.
         */
        private void ButtonTC_Click(object sender, EventArgs e)
        {
            if (board.getPos(0,1) == 0)
            {
                board.placeValue(0, 1, TranslatePlayerToInt(currentPlayer));
                swapPlayer();
            }
            else
            {
                MessageBox.Show("You can't move here!");
            }
            UpdateView();
        }

        /**
         * Code for when the top right button is clicked.
         */
        private void ButtonTR_Click(object sender, EventArgs e)
        {
            if (board.getPos(0, 2) == 0)
            {
                board.placeValue(0, 2, TranslatePlayerToInt(currentPlayer));
                UpdateView();
                swapPlayer();
            }
            else
            {
                MessageBox.Show("You can't move here!");
            }
            UpdateView();
        }

        /**
         * Code for when the middle left button is clicked.
         */
        private void ButtonML_Click(object sender, EventArgs e)
        {
            if (board.getPos(1, 0) == 0)
            {
                board.placeValue(1, 0, TranslatePlayerToInt(currentPlayer));
                swapPlayer();
            }
            else
            {
                MessageBox.Show("You can't move here!");
            }
            UpdateView();
        }

        /**
         * Code for when the middle centre button is clicked.
         */
        private void ButtonMC_Click(object sender, EventArgs e)
        {
            if (board.getPos(1, 1) == 0)
            {
                board.placeValue(1, 1, TranslatePlayerToInt(currentPlayer));
                swapPlayer();
            }
            else
            {
                MessageBox.Show("You can't move here!");
            }
            UpdateView();
        }

        /**
         * Code for when the middle right button is clicked.
         */
        private void ButtonMR_Click(object sender, EventArgs e)
        {
            if (board.getPos(1, 2) == 0)
            {
                board.placeValue(1, 2, TranslatePlayerToInt(currentPlayer));
                swapPlayer();
            }
            else
            {
                MessageBox.Show("You can't move here!");
            }
            UpdateView();
        }

        /**
         * Code for when the bottom left button is clicked.
         */
        private void ButtonBL_Click(object sender, EventArgs e)
        {
            if (board.getPos(2, 0) == 0)
            {
                board.placeValue(2, 0, TranslatePlayerToInt(currentPlayer));
                swapPlayer();
            }
            else
            {
                MessageBox.Show("You can't move here!");
            }
            UpdateView();
        }

        /**
         * Code for when the bottom centre button is clicked.
         */
        private void ButtonBC_Click(object sender, EventArgs e)
        {
            if (board.getPos(2, 1) == 0)
            {
                board.placeValue(2, 1, TranslatePlayerToInt(currentPlayer));
                swapPlayer();
            }
            else
            {
                MessageBox.Show("You can't move here!");
            }
            UpdateView();
        }

        /**
         * Code for when the bottom right button is clicked.
         */
        private void ButtonBR_Click(object sender, EventArgs e)
        {
            if (board.getPos(2, 2) == 0)
            {
                board.placeValue(2, 2, TranslatePlayerToInt(currentPlayer));
                swapPlayer();
            }
            else
            {
                MessageBox.Show("You can't move here!");
            }
            UpdateView();
        }

        /**
         * Creates a new board and updates the view.
         */
        private void BoardReset_Click(object sender, EventArgs e)
        {
            board = new BoardLogic();
            activeGame = true;
            UpdateView();

            // Enables the buttons
            buttonTL.Enabled = true;
            buttonTC.Enabled = true;
            buttonTR.Enabled = true;
            buttonML.Enabled = true;
            buttonMC.Enabled = true;
            buttonMR.Enabled = true;
            buttonBL.Enabled = true;
            buttonBC.Enabled = true;
            buttonBR.Enabled = true;

            // Updates the colour
            buttonTL.BackColor = Color.Gainsboro;
            buttonTC.BackColor = Color.Gainsboro;
            buttonTR.BackColor = Color.Gainsboro;
            buttonML.BackColor = Color.Gainsboro;
            buttonMC.BackColor = Color.Gainsboro;
            buttonMR.BackColor = Color.Gainsboro;
            buttonBL.BackColor = Color.Gainsboro;
            buttonBC.BackColor = Color.Gainsboro;
            buttonBR.BackColor = Color.Gainsboro;

            //Updates current player
            currentPlayer = "X";
        }
    }
}
