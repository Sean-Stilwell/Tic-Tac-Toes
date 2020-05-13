package com.example.tictactoe;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    ImageButton[] buttons;
    Board board;
    private int activeUser;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        board = new Board();

        System.out.println("Creating board");
        // Initializing the array for the visual of the board.
        buttons = new ImageButton[9];
        buttons[0] = (ImageButton)findViewById(R.id.imageButton);
        buttons[1] = (ImageButton)findViewById(R.id.imageButton2);
        buttons[2] = (ImageButton)findViewById(R.id.imageButton3);
        buttons[3] = (ImageButton)findViewById(R.id.imageButton4);
        buttons[4] = (ImageButton)findViewById(R.id.imageButton5);
        buttons[5] = (ImageButton)findViewById(R.id.imageButton6);
        buttons[6] = (ImageButton)findViewById(R.id.imageButton7);
        buttons[7] = (ImageButton)findViewById(R.id.imageButton8);
        buttons[8] = (ImageButton)findViewById(R.id.imageButton9);

        activeUser = 0; // 0 corresponds to X, which always goes first
    }

    // Code to update the game board on the screen
    private void updateView(){
        Context context = getApplicationContext();
        CharSequence text = "Updating the view!";
        int duration = Toast.LENGTH_SHORT;
        Toast toast = Toast.makeText(context, text, duration);
        toast.show();
        int counter = 0;
        int height = 0;
        System.out.println("Initating updateView");
        while (counter < 9){
            int width = 0;
            while (width < 3){ // We iterate through the matrix and update the corresponding square.
                if (board.getPos(height,width) == -1){
                    buttons[counter].setBackgroundResource(R.drawable.empty);
                }
                else if (board.getPos(height, width) == 0){
                    buttons[counter].setBackgroundResource(R.drawable.x);
                }
                else {
                    buttons[counter].setBackgroundResource(R.drawable.o);
                }
                width++;
                counter++;
            }
            height++;
        }
    }

    public void onClick(View v){
        boolean placed = false;
        System.out.println("Button clicked");
        switch (v.getId()){
            // We determine which button was selected and insert the current user there.
            case R.id.imageButton:
                placed = board.placeValue(0, 0, activeUser);
            case R.id.imageButton2:
                placed = board.placeValue(0, 1, activeUser);
            case R.id.imageButton3:
                placed = board.placeValue(0, 2, activeUser);
            case R.id.imageButton4:
                placed = board.placeValue(1, 0, activeUser);
            case R.id.imageButton5:
                placed = board.placeValue(1, 1, activeUser);
            case R.id.imageButton6:
                placed = board.placeValue(1, 2, activeUser);
            case R.id.imageButton7:
                placed = board.placeValue(2, 0, activeUser);
            case R.id.imageButton8:
                placed = board.placeValue(2, 1, activeUser);
            case R.id.imageButton9:
                placed = board.placeValue(2, 2, activeUser);
                // If the reset button was clicked, we reset the board.
            case R.id.button:
                board.resetBoard();
                activeUser = 1;
        }

        // If a winner is occurred, the game is ended.
        if (board.hasWon()){

        }
        if (placed){
            swapActive();
        }
        updateView();
    }

    // Code to swap the current user after a move
    private void swapActive(){
        if (activeUser == 0){
            activeUser = 1;
        }
        else {
            activeUser = 0;
        }
    }
}
