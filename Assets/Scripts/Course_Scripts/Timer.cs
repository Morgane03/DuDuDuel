using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public float _currentTime = 0f;
    public bool isRunning = false;

    public void StartTimer()
    {
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
        if (PlayerPrefs.GetFloat("RaceBestTiming") > _currentTime){

            PlayerPrefs.SetFloat("RaceBestTiming", _currentTime);
        }
    }

    void Update()
    {
        if (isRunning)
        {
            _currentTime += Time.deltaTime;
        }
    }
}
