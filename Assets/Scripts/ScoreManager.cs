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
        _instance = this;
    }


    public int scorePlayerOne;
    public int scorePlayerTwo;
    public int scorePlayerThree;
    public int scorePlayerFour;
}
