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

    [SerializeField]
    public bool isPlayerOneDied;
    public bool isPlayerTwoDied;
    public bool isPlayerThreeDied;
    public bool isPlayerFourDied;

    public List<GameObject> playerList;

    public int scoreWin = 1;
    public void StartGame()
    {
        gameLauch = true;
        boxGenerator.CreateBox();
    }

    public void PlayerWin()
    {

    }

}
