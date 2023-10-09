using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public int number = 2;
    public TextMeshProUGUI cooldownText;


    [Header("Game State")]
    public bool gameLauched = false;
    public TanksWinCondition firstPlayerTank;
    public TanksWinCondition secondPlayerTank;

    [Header("Chance Game")]
    public PlayerOneWinCondition playerOneWinCondition;
    public PlayerTwoWinCondition playerTwoWinCondition;

    [Header("Winner Race Game")]
    public Winer playerOneWin;
    public Winer playerTwoWin;


    public void LaunchGame()
    {

        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "1v1")
        {
            cooldownText = DuelCanva.gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshProUGUI>();
        }
        if (scene.name == "UneChanceSurDeux")
        {
            cooldownText = chanceGameCanva.gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        }
        if (scene.name == "Course")
        {
            cooldownText = raceCanva.gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        }
        StartCoroutine(CooldownBeforeLaunch());
    }

    public void TankDuelResults()
    {
        DuelCanva.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameLauched = false;

        if (!firstPlayerTank.isAlive)
        {

            DuelCanva.gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = "Player Two has won !";
        }
        else
        {

            DuelCanva.gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = "Player One has won !";
        }
    }

    public void ChanceGameResult()
    {
        gameLauched = false;

        if (playerOneWinCondition.firstDie)
        {
            chanceGameCanva.gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = "Player Two has won !";
        }
        if (playerTwoWinCondition.secondDie)
        {
            chanceGameCanva.gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = "Player One has won !";
        }
        if (playerOneWinCondition.firstDie && playerTwoWinCondition.secondDie)
        {
            chanceGameCanva.gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = "Nobody has won";
        }
        if (playerOneWinCondition.firstDie == false && playerTwoWinCondition.secondDie == false)
        {
            chanceGameCanva.gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = "Everyone has won";
        }
    }

    public void RaceResult()
    {
        gameLauched = false;
        if(playerOneWin.colliderZoneWinFP)
        {
            raceCanva.gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = " Player One has won !";
        }
        if(playerTwoWin.colliderZoneWinSP)
        {
            raceCanva.gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = " Player Two has won !";
        }
    }

    IEnumerator CooldownBeforeLaunch()
    {
        cooldownText.text = number.ToString();
        yield return new WaitForSeconds(1);
        number--;

        if (number != -1)
        {
            StartCoroutine(CooldownBeforeLaunch());
        }
        if (number == -1)
        {
            cooldownText.text = " ";
            gameLauched = true;
            StopCoroutine(CooldownBeforeLaunch());
        }
    }
}
