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
    }

    void Update()
    {
        if (isRunning)
        {
            _currentTime += Time.deltaTime;
            PlayerPrefs.SetFloat("RaceBestTiming", _currentTime);
            //Debug.Log(_currentTime);
        }
    }
}
