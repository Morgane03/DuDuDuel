using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankGameManager : MonoBehaviour
{
    public event Action<int> PlayerOneScore;
    public event Action<int> PlayerTwoScore;
    public event Action<int> PlayerThreeScore;
    public event Action<int> PlayerFourScore;


    private static TankGameManager instance;
    public static TankGameManager Instance
    {
        get
        {
            if (instance == null) { }
            return instance;
        }
    }

    void Awake() {
        if (Instance == null) {

            instance = this;
        }

    }



}
