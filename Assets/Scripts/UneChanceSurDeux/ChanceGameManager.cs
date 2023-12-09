using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

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

    public List<PlayerIDs> chanceGamePlayerList = new List<PlayerIDs>();

    public GameObject PlayerOne;
    public GameObject PlayerTwo;
    public GameObject PlayerThree;
    public GameObject PlayerFour;

    public GameObject PlayerThreeText;
    public GameObject PlayerFourText;

    public GameObject canvaEndGame;

    public void SetupGame()
    {
        gameLauch = false;
        chanceGamePlayerList.Clear(); 

        chanceGamePlayerList.Add(PlayerOne.GetComponent<PlayerIDs>()); //add player id to the list
        chanceGamePlayerList.Add(PlayerTwo.GetComponent<PlayerIDs>());

        if(DeviceManager.Instance.playerNumber == 3)
        {
            PlayerThree.SetActive(true);
            PlayerThreeText.SetActive(true);
            chanceGamePlayerList.Add(PlayerThree.GetComponent<PlayerIDs>());
        }

        if (DeviceManager.Instance.playerNumber == 4) //active player 3 and 4 and add them to the list
        {
            PlayerThree.SetActive(true);
            PlayerFour.SetActive(true);

            PlayerThreeText.SetActive(true);
            PlayerFourText.SetActive(true);

            chanceGamePlayerList.Add(PlayerThree.GetComponent<PlayerIDs>());
            chanceGamePlayerList.Add(PlayerFour.GetComponent<PlayerIDs>());
        }
    }


    public void StartGame()
    {
        gameLauch = true;         //start the game
        boxGenerator.CreateBox(); //The box beging to fall
    }

    public void ChanceGamePlayerWinner()
    {
        gameLauch = false;

        GameManager.Instance.WinnerOfAGame(chanceGamePlayerList[0].GetPlayerID()); //the winner is the last player in the list

        StartCoroutine(WaitBeforeStopGame()); //wait a few second to stop game for a better transition
    }

    IEnumerator WaitBeforeStopGame()
    {
        yield return new WaitForSeconds(1);

        canvaEndGame.SetActive(true);
        textWin.text = " winner : Player " + chanceGamePlayerList[0].GetPlayerID();
    }

}
