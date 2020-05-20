package com.example.tictactoe;

public class Board{
    private int[][] board;

    /**
     * Constructor. Initiates a board object using a
     * 3x3 matrix to represent the board. Sets all
     * positions to -1 to indicate unused.
     */
    public Board(){
        board = new int[3][3];

        // Loops will set each position to -1.
        int x = 0;
        while (x < 3){
            int y = 0;
            while (y < 3){
                board[x][y] = -1;
                y++;
            }
            x++;
        }
    }

    /**
     * Places a player's token at a desired space.
     * @param row - the row value to be placed
     * @param column - the column value to be placed
     * @param value - the user's value (0 = X, 1 = O)
     * @return whether the value was placed successfully
     */
    public boolean placeValue(int row, int column, int value){
        if (value != 0 && value != 1){
            throw new IllegalArgumentException("Tried to place " + value + " at row " + row + " and column " + column);
        }
        if (board[row][column] != -1){
            return false;
        }
        else{
            board[row][column] = value;
            return true;
        }
    }

    /**
     * Resets the board
     */
    public void resetBoard(){
        int x = 0;
        while (x < 3){
            int y = 0;
            while (y < 3){
                board[x][y] = -1;
                y++;
            }
            x++;
        }
    }

    /**
     * Determines if the board has been completely filled
     * @return whether the board is full
     */
    public boolean isFull(){
        int x = 0;
        boolean full = true;
        while (x < 3){
            int y = 0;
            while (y < 3){
                if (board[x][y] == -1){
                    full = false;
                }
                y++;
            }
            x++;
        }
        return full;
    }

    /**
     * Creates a string representation of the board
     * @return - String representation of the board
     */
    public String toString(){
        String returnVal = "["+board[0][0]+board[0][1]+board[0][2]+"\n"+
                board[1][0]+board[1][1]+board[1][2]+"\n"+
                board[2][0]+board[2][1]+board[2][2]+"]";
        return returnVal;
    }

    /**
     * Retrieves the value at a desired space
     * @param row - the row value to be retrieved
     * @param column - the column value to be retrieved
     * @return - the current position at the space (-1 = unused, 0 = X, 1 = O)
     */
    public int getPos(int row, int column){
        return board[row][column];
    }

    /**
     * Determines if a user has won.
     * @return - true if there's a winner
     */
    public boolean hasWon(){
        // Diagonal, top left to bottom right
        if (board[0][0] == board[1][1] && board[1][1] == board[2][2]  && board[1][1] != -1){
            return true;
        }
        // Diagonal, top right to bottom left
        else if (board[0][2] == board[1][1] && board[1][1] == board[2][0]  && board[2][0] != -1){
            return true;
        }
        // Vertical, left
        else if (board[0][0] == board[1][0] && board[1][0] == board[2][0]  && board[2][0] != -1){
            return true;
        }
        // Vertical, middle
        else if (board[0][1] == board[1][1] && board[1][1] == board[2][1]  && board[2][1] != -1){
            return true;
        }
        // Vertical, right
        else if (board[0][2] == board[1][2] && board[1][2] == board[2][2]  && board[1][2] != -1){
            return true;
        }
        // Horizontal, top
        else if (board[0][0] == board[0][1] && board[0][1] == board[0][2]  && board[0][1] != -1){
            return true;
        }
        // Horizontal, middle
        else if (board[1][0] == board[1][1] && board[1][1] == board[1][2]  && board[1][2] != -1){
            return true;
        }
        // Horizontal, bottom
        else if (board[2][0] == board[2][1] && board[2][1] == board[2][2]  && board[2][1] != -1){
            return true;
        }
        // No winner
        else{
            return false;
        }
    }

    /**
     * Determines the winner of the game
     * @return - the winning user
     */
    public int getWinner(){
        if (hasWon()){
            // Diagonal, top left to bottom right
            if (board[0][0] == board[1][1] && board[1][1] == board[2][2]){
                return board[0][0];
            }
            // Diagonal, top right to bottom left
            else if (board[0][2] == board[1][1] && board[1][1] == board[2][0]){
                return board[0][2];
            }
            // Vertical, left
            else if (board[0][0] == board[1][0] && board[1][0] == board[2][0]){
                return board[0][0];
            }
            // Vertical, middle
            else if (board[0][1] == board[1][1] && board[1][1] == board[2][1]){
                return board[0][1];
            }
            // Vertical, right
            else if (board[0][2] == board[1][2] && board[1][2] == board[2][2]){
                return board[0][2];
            }
            // Horizontal, top
            else if (board[0][0] == board[0][1] && board[0][1] == board[0][2]){
                return board[0][0];
            }
            // Horizontal, middle
            else if (board[1][0] == board[1][1] && board[1][1] == board[1][2]){
                return board[1][0];
            }
            // Horizontal, bottom
            else if (board[2][0] == board[2][1] && board[2][1] == board[2][2]){
                return board[2][0];
            }
            // this just means something went wrong
            else{
                throw new IllegalStateException("getWinner() failed");
            }
        }
        else{
            return -1;
        }
    }

    public int getWinnerLocation(){
        // Diagonal, top left to bottom right
        if (board[0][0] == board[1][1] && board[1][1] == board[2][2]){
            return 1;
        }
        // Diagonal, top right to bottom left
        else if (board[0][2] == board[1][1] && board[1][1] == board[2][0]){
            return 2;
        }
        // Vertical, left
        else if (board[0][0] == board[1][0] && board[1][0] == board[2][0]){
            return 3;
        }
        // Vertical, middle
        else if (board[0][1] == board[1][1] && board[1][1] == board[2][1]){
            return 4;
        }
        // Vertical, right
        else if (board[0][2] == board[1][2] && board[1][2] == board[2][2]){
            return 5;
        }
        // Horizontal, top
        else if (board[0][0] == board[0][1] && board[0][1] == board[0][2]){
            return 6;
        }
        // Horizontal, middle
        else if (board[1][0] == board[1][1] && board[1][1] == board[1][2]){
            return 7;
        }
        // Horizontal, bottom
        else if (board[2][0] == board[2][1] && board[2][1] == board[2][2]){
            return 8;
        }
        // No winner.
        else{
            return -1;
        }
    }
}
