using System;
using System.Collections;
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
    public int P1Score;
    public int P2Score;
    public int P3Score;
    public int P4Score;

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

        P1Score= 0;
        P2Score= 0;
        P3Score= 0;
        P4Score= 0;

        startCanvas.SetActive(true);
    }

    public void GetPoint(int i, TankShooting tankShooting) {
        // Debug.Log(tankShooting);
        if (tankShooting.name == PlayerOne.name) {
            P1Score += i;
            PlayerOneScore?.Invoke(P1Score);

        }
        else if(tankShooting.name == PlayerTwo.name) {
            P2Score += i;
            PlayerTwoScore?.Invoke(P2Score);

        }
        else if (tankShooting.name == PlayerThree.name) {
            P3Score += i;
            PlayerThreeScore?.Invoke(P3Score);

        }
        else if (tankShooting.name == PlayerFour.name) {
            P4Score += i;
            PlayerFourScore?.Invoke(P4Score);

        }

    }




    public void EndOfTheGame() {
        Debug.Log("fin du duel");
        isGameStarted= false;
        isGameFinished= true;
        
        if(P3Score > P1Score) {
        
        }
    }
}
