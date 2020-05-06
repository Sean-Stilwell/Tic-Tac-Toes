import java.io.Console;

public class Play{
    private static Console console = System.console();

    public static void main(String[] args){
        Board board = new Board();

        // The game continues until a player has won, according to the board method;
        while (!board.hasWon() && !board.isFull()){

            // We has a boolean to determine if player X has successfully made their next move.
            boolean xHasMoved = false;
            while (!xHasMoved){
                // We get the user's input for a row and column
                System.out.println("Player 0, please enter the row you would like to use");
                String row = console.readLine();
                System.out.println("Player 0, please enter the column you would like to use");
                String column = console.readLine();
                
                // Since this is designed for testing, we will initially trust the user entered integer values.
                int rowInt = Integer.parseInt(row);
                int columnInt = Integer.parseInt(column);
                
                // We ensure first that the user chose a valid space, and share an error message if they did not.
                if (rowInt < 3 && rowInt >= 0 && columnInt < 3 && columnInt >= 0){
                    // We then ensure that the space they chose is not occupied already. If not, we set the value to the player's
                    if (board.getPos(rowInt, columnInt) == -1){
                        board.placeValue(rowInt, columnInt, 0);
                        xHasMoved = true;
                    }
                    // If it is occupied, we warn them.
                    else{
                        System.out.println("Invalid position. That space is already taken!");
                    }
                }
                // If the user entered an invalid position, we warn them.
                else{
                    System.out.println("Invalid position. Remember that positions are from 0 to 2!");
                }
            }
            
        

            // We has a boolean to determine if player X has successfully made their next move.
            boolean yHasMoved = false;
            System.out.println(board.toString());

            // If the player has won with their move, or caused a cat's game, we immediately break so the O player can't make a move.
            if (board.hasWon() || board.isFull()){
                yHasMoved = true;
            }

            while (!yHasMoved){
                // We get the user's input for a row and column
                System.out.println("Player 1, please enter the row you would like to use");
                String row = console.readLine();
                System.out.println("Player 1, please enter the column you would like to use");
                String column = console.readLine();
                
                // Since this is designed for testing, we will initially trust the user entered integer values.
                int rowInt = Integer.parseInt(row);
                int columnInt = Integer.parseInt(column);
                
                // We ensure first that the user chose a valid space, and share an error message if they did not.
                if (rowInt < 3 && rowInt >= 0 && columnInt < 3 && columnInt >= 0){
                    // We then ensure that the space they chose is not occupied already. If not, we set the value to the player's
                    if (board.getPos(rowInt, columnInt) == -1){
                        board.placeValue(rowInt, columnInt, 1);
                        yHasMoved = true;
                    }
                    // If it is occupied, we warn them.
                    else{
                        System.out.println("Invalid position. That space is already taken!");
                    }
                }
                // If the user entered an invalid position, we warn them.
                else{
                    System.out.println("Invalid position. Remember that positions are from 0 to 2!");
                }
            }
            
            System.out.println(board.toString());  
        }
        // We then display the winner.
        if (board.hasWon()){
            System.out.println("Player " +board.getWinner() + " has won!");
        }
        else{
            System.out.println("Cat's game! No winner :(");
        }
    }
}
