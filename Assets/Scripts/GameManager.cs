using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("GameManger is null");
            }
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this);
    }

    public int scorePlayerOne;
    public int scorePlayerTwo;

    public GameObject duelCanva;
    public GameObject raceCanva;
    public GameObject chanceGameCanva;


}
