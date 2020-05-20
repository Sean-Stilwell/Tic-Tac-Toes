package com.example.tictactoe;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private ImageButton[] buttons;
    private Board board;
    private int activeUser;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        board = new Board();
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
        if (!board.hasWon()){
            int counter = 0;
            int height = 0;
            while (counter < 9){
                int width = 0;
                while (width < 3){ // We iterate through the matrix and update the corresponding square.
                    if (board.getPos(height,width) == -1){
                        buttons[counter].setImageResource(R.drawable.empty);
                    }
                    else if (board.getPos(height, width) == 0){
                        buttons[counter].setImageResource(R.drawable.x);
                    }
                    else {
                        buttons[counter].setImageResource(R.drawable.o);
                    }
                    width++;
                    counter++;
                }
                height++;
            }
        }
        else{
            showWinner();
        }
    }

    public void onClick(View v){
        boolean placed = false;
        switch (v.getId()){
            // We determine which button was selected and insert the current user there.
            case R.id.imageButton:
                placed = board.placeValue(0, 0, activeUser);
                break;
            case R.id.imageButton2:
                placed = board.placeValue(0, 1, activeUser);
                break;
            case R.id.imageButton3:
                placed = board.placeValue(0, 2, activeUser);
                break;
            case R.id.imageButton4:
                placed = board.placeValue(1, 0, activeUser);
                break;
            case R.id.imageButton5:
                placed = board.placeValue(1, 1, activeUser);
                break;
            case R.id.imageButton6:
                placed = board.placeValue(1, 2, activeUser);
                break;
            case R.id.imageButton7:
                placed = board.placeValue(2, 0, activeUser);
                break;
            case R.id.imageButton8:
                placed = board.placeValue(2, 1, activeUser);
                break;
            case R.id.imageButton9:
                placed = board.placeValue(2, 2, activeUser);
                break;
            case R.id.button:
                board.resetBoard();
                activeUser = 0;
                break;
        }

        // If a winner is occurred, the game is ended.
        if (board.hasWon()){
            Toast.makeText(getApplicationContext(),"Winner! Well done!",Toast.LENGTH_SHORT).show();
            showWinner();
        }
        else if (!board.hasWon() && board.isFull()){
            Toast.makeText(getApplicationContext(),"Cat's game, no winner!",Toast.LENGTH_SHORT).show();
        }
        if (placed){
            swapActive();
        }
        updateView();
    }

    private void showWinner(){
        int winner = board.getWinner();
        switch (board.getWinnerLocation()){
            case 1:
                if (winner == 0){
                    buttons[0].setImageResource(R.drawable.xwin);
                    buttons[4].setImageResource(R.drawable.xwin);
                    buttons[8].setImageResource(R.drawable.xwin);
                }
                else{
                    buttons[0].setImageResource(R.drawable.owin);
                    buttons[4].setImageResource(R.drawable.owin);
                    buttons[8].setImageResource(R.drawable.owin);
                }
                break;
            case 2:
                if (winner == 0){
                    buttons[2].setImageResource(R.drawable.xwin);
                    buttons[4].setImageResource(R.drawable.xwin);
                    buttons[6].setImageResource(R.drawable.xwin);
                }
                else{
                    buttons[2].setImageResource(R.drawable.owin);
                    buttons[4].setImageResource(R.drawable.owin);
                    buttons[6].setImageResource(R.drawable.owin);
                }
                break;
            case 3:
                if (winner == 0){
                    buttons[0].setImageResource(R.drawable.xwin);
                    buttons[3].setImageResource(R.drawable.xwin);
                    buttons[6].setImageResource(R.drawable.xwin);
                }
                else{
                    buttons[0].setImageResource(R.drawable.owin);
                    buttons[3].setImageResource(R.drawable.owin);
                    buttons[6].setImageResource(R.drawable.owin);
                }
                break;
            case 4:
                if (winner == 0){
                    buttons[1].setImageResource(R.drawable.xwin);
                    buttons[4].setImageResource(R.drawable.xwin);
                    buttons[7].setImageResource(R.drawable.xwin);
                }
                else{
                    buttons[1].setImageResource(R.drawable.owin);
                    buttons[4].setImageResource(R.drawable.owin);
                    buttons[7].setImageResource(R.drawable.owin);
                }
                break;
            case 5:
                if (winner == 0){
                    buttons[2].setImageResource(R.drawable.xwin);
                    buttons[5].setImageResource(R.drawable.xwin);
                    buttons[8].setImageResource(R.drawable.xwin);
                }
                else{
                    buttons[2].setImageResource(R.drawable.owin);
                    buttons[5].setImageResource(R.drawable.owin);
                    buttons[8].setImageResource(R.drawable.owin);
                }
                break;
            case 6:
                if (winner == 0){
                    buttons[0].setImageResource(R.drawable.xwin);
                    buttons[1].setImageResource(R.drawable.xwin);
                    buttons[2].setImageResource(R.drawable.xwin);
                }
                else{
                    buttons[1].setImageResource(R.drawable.owin);
                    buttons[0].setImageResource(R.drawable.owin);
                    buttons[2].setImageResource(R.drawable.owin);
                }
                break;
            case 7:
                if (winner == 0){
                    buttons[3].setImageResource(R.drawable.xwin);
                    buttons[4].setImageResource(R.drawable.xwin);
                    buttons[5].setImageResource(R.drawable.xwin);
                }
                else{
                    buttons[3].setImageResource(R.drawable.owin);
                    buttons[4].setImageResource(R.drawable.owin);
                    buttons[5].setImageResource(R.drawable.owin);
                }
                break;
            case 8:
                if (winner == 0){
                    buttons[6].setImageResource(R.drawable.xwin);
                    buttons[7].setImageResource(R.drawable.xwin);
                    buttons[8].setImageResource(R.drawable.xwin);
                }
                else{
                    buttons[6].setImageResource(R.drawable.owin);
                    buttons[7].setImageResource(R.drawable.owin);
                    buttons[8].setImageResource(R.drawable.owin);
                }
                break;
        }
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
