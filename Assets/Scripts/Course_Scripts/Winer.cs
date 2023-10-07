using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winer : MonoBehaviour
{
    private void OnTriggerEnter(Collider playercollider)
    {
        
       if(playercollider.gameObject.tag == "PlayerOne")
        {
            Debug.Log("Player1 win");
        }
        
       if(playercollider.gameObject.tag == "PlayerTwo")
        {
            Debug.Log("Player2 win");
        }
    }
}
