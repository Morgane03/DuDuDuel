using System;
using System.Collections.Generic;
using UnityEngine;

public class TankGameManager : MonoBehaviour
{
    [Header("Players")]
    public GameObject PlayerOne;
    public GameObject PlayerTwo;
    public GameObject PlayerThree;
    public GameObject PlayerFour;

    [Header("Players Scores")]
    public int P1TankGameScore;
    public int P2TankGameScore;
    public int P3TankGameScore;
    public int P4TankGameScore;
    public List<int> playersScoresEndOfTheGame = new List<int>();


    [Header("Game State")]
    public GameObject startCanvas;
    public bool isGameStarted = false;
    public bool isGameFinished = false;

    [Header("UI Indications for Players in Game")]
    public GameObject uiPlayer3Indication;
    public GameObject uiPlayer4Indication;
   

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
        isGameFinished = false;


        startCanvas.SetActive(true);
    }


    public void LaunchGame() {
        isGameStarted = true;
        startCanvas.SetActive(false);

        if(DeviceManager.Instance.playersWanted == 3) {
            PlayerFour.SetActive(false);
            uiPlayer3Indication.SetActive(false);
        }
        else if(DeviceManager.Instance.playersWanted == 2) {
            PlayerFour.SetActive(false);
            PlayerThree.SetActive(false);

            uiPlayer3Indication.SetActive(false);
            uiPlayer4Indication.SetActive(false);
        }
    }


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
        isGameFinished = true;

        playersScoresEndOfTheGame.Add(P1TankGameScore);
        playersScoresEndOfTheGame.Add(P2TankGameScore);
        playersScoresEndOfTheGame.Add(P3TankGameScore);
        playersScoresEndOfTheGame.Add(P4TankGameScore);

        GameResults();
        
    }

    public void GameResults() {

        int maxScore = 0;
        // picks up loop index to know which player has won.
        int loopIndex = 0;

        for (int i = 0; i < playersScoresEndOfTheGame.Count; i++) {

            if (playersScoresEndOfTheGame[i] > maxScore) {

                maxScore = playersScoresEndOfTheGame[i];
                loopIndex = i;
            }
        }

        GameManager.Instance.WinnerOfAGame(loopIndex + 1);

    }
}
