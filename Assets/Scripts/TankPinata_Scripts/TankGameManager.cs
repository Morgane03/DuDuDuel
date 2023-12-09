using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TankGameManager : MonoBehaviour
{
    [Header("Players")]
    public GameObject PlayerOne;
    public GameObject PlayerTwo;
    public GameObject PlayerThree;
    public GameObject PlayerFour;
    private List<GameObject> PlayerList = new List<GameObject>();

    [Header("Players Scores")]
    public int P1TankGameScore;
    public int P2TankGameScore;
    public int P3TankGameScore;
    public int P4TankGameScore;
    public List<int> PlayersScoresEndOfTheGame = new List<int>();


    [Header("Game State")]
    public GameObject startCanvas;
    public GameObject endCanvas;
    public TextMeshProUGUI uiWinnerText;
    public bool isGameStarted = false;

    public GameObject uiPlayerIndicator;

    private static TankGameManager _instance;
    public static TankGameManager Instance { 
        get { 
            if (_instance == null) {
                Debug.Log("TankGameManager is null");
            }
            return _instance;
        }
    }

    void Awake() {
        _instance = this; 
    }

    public event Action<int> PlayerOneScore;
    public event Action<int> PlayerTwoScore;
    public event Action<int> PlayerThreeScore;
    public event Action<int> PlayerFourScore;

    public void Start() {
        isGameStarted = false;


        startCanvas.SetActive(true);
        uiPlayerIndicator.SetActive(true);
        endCanvas.SetActive(false);


        PlayerList.Add(PlayerOne);
        PlayerList.Add(PlayerTwo);
        PlayerList.Add(PlayerThree);
        PlayerList.Add(PlayerFour);
    }


    public void LaunchGame() {
        isGameStarted = true;
        startCanvas.SetActive(false);

        if(DeviceManager.Instance.playerNumber == 3) { // UI Keeps only three players 
            PlayerFour.SetActive(false);
            uiPlayerIndicator.gameObject.transform.GetChild(3).gameObject.SetActive(false);

        }
        else if(DeviceManager.Instance.playerNumber == 2) { // UI Keeps only two players 
            PlayerFour.SetActive(false);
            PlayerThree.SetActive(false);

            uiPlayerIndicator.gameObject.transform.GetChild(2).gameObject.SetActive(false);
            uiPlayerIndicator.gameObject.transform.GetChild(3).gameObject.SetActive(false);

        }
    }

    // Controls which players are getting points
    public void GetPoint(int i, TankShooting tankShooting) {
        // Debug.Log(tankShooting);
        if (tankShooting.name == PlayerOne.name) {
            P1TankGameScore += i;
            PlayerOneScore?.Invoke(P1TankGameScore);

        }
        else if(tankShooting.name == PlayerTwo.name) {
            P2TankGameScore += i;
            PlayerTwoScore?.Invoke(P2TankGameScore);

        }
        else if (tankShooting.name == PlayerThree.name) {
            P3TankGameScore += i;
            PlayerThreeScore?.Invoke(P3TankGameScore);

        }
        else if (tankShooting.name == PlayerFour.name) {
            P4TankGameScore += i;
            PlayerFourScore?.Invoke(P4TankGameScore);
        }
    }



    public void EndOfTheGame() {

        isGameStarted = false;

        PlayersScoresEndOfTheGame.Add(P1TankGameScore);
        PlayersScoresEndOfTheGame.Add(P2TankGameScore);
        PlayersScoresEndOfTheGame.Add(P3TankGameScore);
        PlayersScoresEndOfTheGame.Add(P4TankGameScore);

        GameResults();
        endCanvas.SetActive(true);
        uiPlayerIndicator.SetActive(false);
    }

    public void GameResults() {

        int maxScore = 0;
        // picks up loop index to know which player has won.
        int loopIndex = 0;

        for (int i = 0; i < PlayersScoresEndOfTheGame.Count; i++) {

            if (PlayersScoresEndOfTheGame[i] > maxScore) {

                maxScore = PlayersScoresEndOfTheGame[i];
                loopIndex = i;
            }
        }

        GameManager.Instance.WinnerOfAGame(loopIndex + 1);

        // Display winner in UI
        switch (loopIndex + 1) {
            case 1:

                uiWinnerText.text = "Winner : Player 1";
                break; 
            case 2:

                uiWinnerText.text = "Winner : Player 2";
                break;
            case 3:

                uiWinnerText.text = "Winner : Player 3";
                break;
            case 4:

                uiWinnerText.text = "Winner : Player 4";
                break;
        }
    }
}