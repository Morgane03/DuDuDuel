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
        // DontDestroyOnLoad(this);
        _instance = this;
    }

    public bool gameLauched;
    public void WinnerOfAGame(int whichPlayer) {
        switch (whichPlayer) {
            case 1:

                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
        }
    }
}
