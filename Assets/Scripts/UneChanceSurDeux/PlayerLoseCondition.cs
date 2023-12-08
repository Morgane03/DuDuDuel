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

    public void OnPlayerDeath(GameObject gameObject) //retire le joueur de la liste et de la partie
    {
        gameObject.GetComponent<PlayerIDs>();
        ChanceGameManager.Instance.chanceGamePlayerList.Remove(gameObject.GetComponent<PlayerIDs>());
        gameObject.SetActive(false);
        Debug.Log(gameObject.name);

        ChanceGameManager.Instance.ChanceGamePlayerNumber();
    }
}
