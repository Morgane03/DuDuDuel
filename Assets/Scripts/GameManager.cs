using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    [Header("Player Scores")]
    public int scorePlayerOne;
    public int scorePlayerTwo;

    [Header("Game Canvas")]
    public GameObject DuelCanva;
    public GameObject raceCanva;
    public GameObject chanceGameCanva;


    [Header("Cooldown Before Game Launched")]
    public int number = 5;

    [Header("Game State")]
    public bool gameLauched = false;

    public void LaunchGame()
    {
        StartCoroutine(CooldownBeforeLaunch());
    }

    public void TankDuelResults()
    {
        DuelCanva.gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }



    IEnumerator CooldownBeforeLaunch()
    {
        yield return new WaitForSeconds(1);
        number--;

        if (number != -1)
        {
            StartCoroutine(CooldownBeforeLaunch());
        }
        if (number == -1)
        {
            gameLauched = true;
            StopCoroutine(CooldownBeforeLaunch());
        }
    }
}
