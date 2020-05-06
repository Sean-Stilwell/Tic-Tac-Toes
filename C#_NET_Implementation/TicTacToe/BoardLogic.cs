using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class BoardLogic
    {
        private int[,] board;

        /**
         * Constructor for the class, initializes a board.
         */
        public BoardLogic()
        {
            board = new int[3,3];
            for (int i=0; i<3; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    board[i, j] = 0; // 0 will indicate nobody has moved there.
                }
            }
        }

        /**
         * Returns the current player at a position.
         */
        public int getPos(int i, int j)
        {
            if (i < 3 && j < 3 && i >= 0 && j >= 0)
            {
                return board[i, j];
            }
            else
            {
                throw new System.ArgumentException("Parameters are invalid!");
            }
        }

        /**
        * Allows a placement of a value on the board (assumes valid)
        * parameters
        * int i - the height value of the piece to be changed
        * int j - the width value of the piece to be changed
        * int value - the value to be placed, 0=nobody, 1=X, 2=O
        */
        public void placeValue(int i, int j, int value)
        {
            if (i < 3 && j < 3 && value <3 && i >= 0 && j >= 0 && value >= 0)
            {
                board[i, j] = value;
            }
            else
            {
                throw new System.ArgumentException("Parameters are invalid!");
            }
        }

        /**
        * Determines if there is a move left to be made. If true, the game is over.
        * If false, the game should continue
        */
        public Boolean isFinished()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0 && !hasWinner())
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        /**
        * Determines if there's currently a winner.
        */
        public Boolean hasWinner()
        {
            if (findWinningPos() == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /**
         * Determines the position at which a winner is occurring
         * Returns -1 if there is no winner, otherwise each position is assigned a number
         * which is returned.
         */
        public int findWinningPos()
        {
            // Determines if the horizontal win at the top is successful;
            if (board[0,0] == board[0,1] && board[0,1] == board[0, 2])
            {
                if (board[0,0] == 0)
                {
                    return -1;
                }
                return 1;
            }
            //Determines if the horizontal win at the middle is successful
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                if (board[1, 0] == 0)
                {
                    return -1;
                }
                return 2;
            }
            //Determines if the horizontal win at the bottom is successful
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                if (board[2, 0] == 0)
                {
                    return -1;
                }
                return 3;
            }
            //Determines if the vertical win at the left is successful
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                if (board[0, 0] == 0)
                {
                    return -1;
                }
                return 4;
            }
            //Determines if the vertical win at the middle is successful
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            {
                if (board[0, 1] == 0)
                {
                    return -1;
                }
                return 5;
            }
            //Determines if the vertical win at the right is successful
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                if (board[0, 2] == 0)
                {
                    return -1;
                }
                return 6;
            }
            //Determines if the diagonal win from TL to BR is successful
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                if (board[0, 0] == 0)
                {
                    return -1;
                }
                return 7;
            }
            //Determines if the vertical win at the right is successful
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[0, 2] == 0)
                {
                    return -1;
                }
                return 8;
            }
            // Otherwise, we signal that nobody won.
            return -1;
        }

        /**
         * Determines the winning player.
         * returns int - 0 for no winner, 1 for X, 2 for O.
         */
        public int findWinner()
        {
            // If there is no winner, this returns -1 (and the function shouldn't have been called)
            if (!hasWinner())
            {
                return -1;
            }
            // Otherwise, we use a switch to find the winning position & therefore player.
            int caseSwitch = findWinningPos();
            switch (caseSwitch)
            {
                case -1:
                    throw new System.ArgumentException("Somehow this happened... Line 180 of BoardLogic.cs");
                    break;
                case 1:
                    return board[0, 0];
                case 2:
                    return board[1, 0];
                case 3:
                    return board[2, 0];
                case 4:
                    return board[0, 0];
                case 5:
                    return board[0, 1];
                case 6:
                    return board[0, 2];
                case 7:
                    return board[0, 0];
                case 8:
                    return board[0, 2];
            }
            return -1;
        }
    }
}
