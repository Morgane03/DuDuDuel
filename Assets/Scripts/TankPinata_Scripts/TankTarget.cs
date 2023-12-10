using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTarget : MonoBehaviour
{
    public int targetLife;
    public CreateScriptableObject tankTargetCustomLife;

    public void Start()
    {
        GetTargetCustomLife(tankTargetCustomLife);
    }
    public void OnCollisionEnter2D(Collision2D collision) {
        if(TankGameManager.Instance.isGameStarted) {
            targetLife--;
            if (targetLife <= 0) {
                TankGameManager.Instance.EndOfTheGame();
            }
        }
       
    }

    public void GetTargetCustomLife(CreateScriptableObject scriptableObject)
    {
        targetLife = scriptableObject.life;
    }

}
