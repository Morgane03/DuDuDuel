using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoseCondition : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    { 
        if(other.name == "Player1")
        {
            ChanceGameManager.Instance.playerOneDie = true;
            other.gameObject.SetActive(false);
        }

        if (other.name == "Player2")
        {
            ChanceGameManager.Instance.playerTwoDie = true;
            other.gameObject.SetActive(false);
        }

        if (other.name == "Player3")
        {
            ChanceGameManager.Instance.playerThreeDie = true;
            other.gameObject.SetActive(false);
        }

        if (other.name == "Player4")
        {
            ChanceGameManager.Instance.playerFourDie = true;
            other.gameObject.SetActive(false);
        }

        if (other.tag != "Plateform")
        {
            ChanceGameManager.Instance.PlayerWin();
        }
    }
}
