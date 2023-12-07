using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoseCondition : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    { 
        if(other.name == "Player1")
        {
            ChanceGameManager.Instance.isPlayerOneDied = true;
            other.gameObject.SetActive(false);
            ChanceGameManager.Instance.PlayerWin();
        }

        if (other.name == "Player2")
        {
            ChanceGameManager.Instance.isPlayerTwoDied = true;
            other.gameObject.SetActive(false);
            ChanceGameManager.Instance.PlayerWin();
        }

        if (other.name == "Player3")
        {
            ChanceGameManager.Instance.isPlayerThreeDied = true;
            other.gameObject.SetActive(false);
            ChanceGameManager.Instance.PlayerWin();
        }

        if (other.name == "Player4")
        {
            ChanceGameManager.Instance.isPlayerFourDied = true;
            other.gameObject.SetActive(false);
            ChanceGameManager.Instance.PlayerWin();
        }
    }
}
