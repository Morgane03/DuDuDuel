using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoseCondition : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    { 
        if(other.tag == "Player")
        {
            OnPlayerDeath(other.gameObject);
        }
    }

    public void OnPlayerDeath(GameObject gameObject) //remove player from the list and game
    {
        gameObject.GetComponent<PlayerIDs>();
        ChanceGameManager.Instance.chanceGamePlayerList.Remove(gameObject.GetComponent<PlayerIDs>());

        if(ChanceGameManager.Instance.chanceGamePlayerList.Count == 1) //checks if th player list = 1, and call chanceGameManager
        {
            ChanceGameManager.Instance.ChanceGamePlayerWinner();
        }
        gameObject.SetActive(false);
    }
}
