using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _instance;
    public static ScoreManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("ScoreManager is null");
            }
            return _instance;
        }
    }

    public void Start()
    {
        DontDestroyOnLoad(this);
        _instance = this;
    }


    public int Score { get; private set; }

    public event Action<int> ScoreUpdatePlayerOne;
    //public event Action<int> ScoreUpdatePlayerTwo;
    //public event Action<int> ScoreUpdatePlayerThree;
    //public event Action<int> ScoreUpdatePlayerFour;

    public int scorePlayerOne;
    public int scorePlayerTwo;
    public int scorePlayerThree;
    public int scorePlayerFour;

    public void SetScorePlayerOne(int updateScoreOne)
    {
        scorePlayerOne += updateScoreOne;
        ScoreUpdatePlayerOne?.Invoke(scorePlayerOne);
        Debug.Log("dxfcgvhj");
    }
}
