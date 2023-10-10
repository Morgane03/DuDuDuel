using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winer : MonoBehaviour
{
    public bool colliderZoneWinFP = false;
    public bool colliderZoneWinSP = false;

    


    public void OnTriggerEnter(Collider playercollider)
    {
        
       if(playercollider.gameObject.tag == "PlayerOne")
        {
            //Debug.Log("Player1 win");
            colliderZoneWinFP = true;
            GameManager.Instance.RaceResult();

            colliderZoneWinFP = false;
        }
        
       if(playercollider.gameObject.tag == "PlayerTwo")
        {
            //Debug.Log("Player2 win");
            colliderZoneWinSP = true;
            GameManager.Instance.RaceResult();
            colliderZoneWinSP = false;
        }
    }
}
