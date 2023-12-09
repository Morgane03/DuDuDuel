using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLauched : MonoBehaviour
{
    private static GameLauched _instance;
    public static GameLauched Instance
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

    private void Awake()
    {
        // DontDestroyOnLoad(this);
        _instance = this;
    }

    public bool canMove;
    
    public void StartMovement()
    {
        canMove = true;
    }
}
