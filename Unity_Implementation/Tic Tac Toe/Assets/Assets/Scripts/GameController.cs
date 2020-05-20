using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public int WhosTurn; // 0 = X, 1 = O's turn
    public int TurnCount; // Counts the number of turns played
    public GameObject[] turnIcons; // Displays whose turn it is
    public Sprite[] PlayerIcons; // 0 = X icon, 1 = O's icon.
    public Button[] TicTacToeSpaces; // Playable spaces for our game
    public int[] MarkedSpaces;
    public Text winnerText;
    public GameObject[] winningLines;
    public int XScore;
    public int OScore;
    public Text XScoreText;
    public Text OScoreText;

	// Use this for initialization
	void Start () {
        GameSetup();
	}

    void GameSetup()
    {
        WhosTurn = 0;
        TurnCount = 0;
        turnIcons[0].SetActive(true);
        turnIcons[1].SetActive(false);

        for (int i = 0; i < TicTacToeSpaces.Length; i++)
        {
            TicTacToeSpaces[i].interactable = true;
            TicTacToeSpaces[i].GetComponent<Image>().sprite = null;

        }

        for (int i = 0; i < MarkedSpaces.Length; i++)
        {
            MarkedSpaces[i] = -100;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TicTacToeButton(int WhichNumber)
    {
        TicTacToeSpaces[WhichNumber].image.sprite = PlayerIcons[WhosTurn];
        TicTacToeSpaces[WhichNumber].interactable = false;

        MarkedSpaces[WhichNumber] = WhosTurn+1;
        TurnCount++;
        if (TurnCount > 4)
        {
            WinnerCheck();
        }

        if (WhosTurn == 0)
        {
            WhosTurn = 1;
            turnIcons[1].SetActive(true);
            turnIcons[0].SetActive(false);
        }
        else if (WhosTurn == 1)
        {
            WhosTurn = 0;
            turnIcons[0].SetActive(true);
            turnIcons[1].SetActive(false);
        }
    }

    void WinnerCheck()
    {
        int s1 = MarkedSpaces[0] + MarkedSpaces[1] + MarkedSpaces[2];
        int s2 = MarkedSpaces[3] + MarkedSpaces[4] + MarkedSpaces[5];
        int s3 = MarkedSpaces[6] + MarkedSpaces[7] + MarkedSpaces[8];
        int s4 = MarkedSpaces[0] + MarkedSpaces[4] + MarkedSpaces[6];
        int s5 = MarkedSpaces[1] + MarkedSpaces[3] + MarkedSpaces[7];
        int s6 = MarkedSpaces[2] + MarkedSpaces[5] + MarkedSpaces[8];
        int s7 = MarkedSpaces[0] + MarkedSpaces[3] + MarkedSpaces[8];
        int s8 = MarkedSpaces[2] + MarkedSpaces[3] + MarkedSpaces[6];

        var solutions = new int[] { s1, s2, s3, s4, s5, s6, s7, s8 };

        for (int i = 0; i < solutions.Length; i++)
        {
            if (solutions[i] == 3*(WhosTurn+1))
            {
                WinnerDisplay(i);
                return;
            }
        }

    }

    void WinnerDisplay(int indexIn)
    {
        winnerText.gameObject.SetActive(true);
        if (WhosTurn == 0)
        {
            winnerText.text = "X Wins!";
            XScore++;
            XScoreText.text = XScore.ToString();
        }
        else if (WhosTurn == 1)
        {
            winnerText.text = "O Wins!";
            OScore++;
            OScoreText.text = OScore.ToString();
        }
        winningLines[indexIn].SetActive(true);
        for (int i = 0; i < TicTacToeSpaces.Length; i++)
        {
            TicTacToeSpaces[i].interactable = false;
        }
    }

    public void Rematch()
    {
        GameSetup();
        for (int i = 0; i < winningLines.Length; i++)
        {
            winningLines[i].SetActive(false);
        }
        winnerText.gameObject.SetActive(false);
    }

    public void Restart()
    {
        Rematch();
        XScore = 0;
        OScore = 0;
        XScoreText.text = "0";
        OScoreText.text = "0";
    }
}
