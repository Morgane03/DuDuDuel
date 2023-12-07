using System;
using System.Collections.Generic;
using UnityEngine;

public class TankGameManager : MonoBehaviour
{
    public event Action<int> PlayerOneScore;
    public event Action<int> PlayerTwoScore;
    public event Action<int> PlayerThreeScore;
    public event Action<int> PlayerFourScore;

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


    [Header("PlayerIDList")]
    public List<PlayerIDs> PlayerIDs;

    [Header("Game State")]
    public GameObject startCanvas;
    public bool isGameStarted = false;
    public bool isGameFinished = false;

   

    private static TankGameManager instance;
    public static TankGameManager Instance { get { if (instance == null) { }
            return instance;
        }
    }

    void Awake() {
        if (Instance == null) { instance = this; }
    }

    public void Start() {
        isGameStarted = false;
        isGameFinished = false;


        startCanvas.SetActive(true);
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

    public void LaunchGame() {
        isGameStarted= true;
        startCanvas.SetActive(false);
    }


    public void EndOfTheGame() {
        Debug.Log("fin du duel");
        isGameStarted= false;
        isGameFinished= true;

        playersScoresEndOfTheGame.Add(P1TankGameScore);
        playersScoresEndOfTheGame.Add(P2TankGameScore);
        playersScoresEndOfTheGame.Add(P3TankGameScore);
        playersScoresEndOfTheGame.Add(P4TankGameScore);

        GameResults();
        
    }

    public void GameResults() {

        int maxScore = 0;
        // va servir à récupérer l'index de la boucle pour connaître le gagnant de la partie
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
