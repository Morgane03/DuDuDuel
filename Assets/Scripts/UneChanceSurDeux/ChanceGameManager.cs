using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChanceGameManager : MonoBehaviour
{
    private static ChanceGameManager _instance;
    public static ChanceGameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("ChanceGameManger is null");
            }
            return _instance;

        }
    }
    void Start()
    {
        // DontDestroyOnLoad(this);
        _instance = this;
    }
    public bool gameLauch;

    public BoxGenerator boxGenerator;
    public TextMeshProUGUI textWin;

    [SerializeField]
    public bool playerOneDie;
    public bool playerTwoDie;
    public bool playerThreeDie;
    public bool playerFourDie;

    public int scoreWin = 100;
    public void StartGame()
    {
        gameLauch = true;
        boxGenerator.CreateBox();
    }

    public void PlayerWin()
    {
        if (playerTwoDie && playerThreeDie && playerFourDie && !playerOneDie)
        {
            gameLauch = false;
            textWin.text = "player 1 win";
            scoreWin = 100;
            ScoreManager.Instance.ScoreUpdatePlayerOne += Notify;

        }

        if (playerOneDie && playerThreeDie && playerFourDie && !playerTwoDie)
        {
            gameLauch = false;
            textWin.text = "player 2 win";
        }

        if (playerOneDie && playerTwoDie && playerFourDie && !playerThreeDie)
        {
            gameLauch = false;
            textWin.text = "player 3 win";
        }

        if (playerOneDie && playerTwoDie && playerThreeDie && !playerFourDie)
        {
            gameLauch = false;
            textWin.text = "player 4 win";
        }

        if (playerOneDie && playerTwoDie && playerThreeDie && playerFourDie)
        {
            gameLauch = false;
            textWin.text = "no win";
        }
    }

    public void Notify(int score)
    {
        scoreWin += score;
        ScoreManager.Instance.SetScorePlayerOne(score);
    }
}
