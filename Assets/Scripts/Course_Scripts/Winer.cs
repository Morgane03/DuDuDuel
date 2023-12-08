using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winer : MonoBehaviour
{
    public bool colliderZoneWinFP = false;
    public bool colliderZoneWinSP = false;
    public bool colliderZoneWinTP = false;
    public bool colliderZoneWinFoP = false;

    public void OnTriggerEnter(Collider playercollider)
    {
        
       if(playercollider.gameObject.tag == "PlayerOne")
        {
            colliderZoneWinFP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            colliderZoneWinFP = false;
            Debug.Log("Player One Win");
        }
        
       if(playercollider.gameObject.tag == "PlayerTwo")
        {
            colliderZoneWinSP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            colliderZoneWinSP = false;
        }

        if (playercollider.gameObject.tag == "PlayerThree")
        {
            colliderZoneWinTP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            colliderZoneWinTP = false;
        }

        if (playercollider.gameObject.tag == "PlayerFour")
        {
            colliderZoneWinFoP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            colliderZoneWinFoP = false;
        }
    }
}
