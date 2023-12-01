using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTarget : MonoBehaviour
{
    public int targetLife = 100;

    public void OnCollisionEnter2D(Collision2D collision) {
        if(!TankGameManager.Instance.isGameFinished) {
            targetLife--;
            if (targetLife <= 0) {
                TankGameManager.Instance.EndOfTheGame();
            }
        }
       
    }



}
