using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Winer : MonoBehaviour
{
    private bool colliderZoneWinFP = false;
    private bool colliderZoneWinSP = false;
    private bool colliderZoneWinTP = false;
    private bool colliderZoneWinFoP = false;

    public GameObject winCanva;
    public TextMeshProUGUI winText;

    public void OnTriggerEnter(Collider playercollider)
    {
        
       if(playercollider.gameObject.tag == "PlayerOne")
        {
            colliderZoneWinFP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            colliderZoneWinFP = false;
            Debug.Log("Player One Win");
            winCanva.SetActive(true);
            winText.text = "Player One Win";
        }
        
       if(playercollider.gameObject.tag == "PlayerTwo")
        {
            colliderZoneWinSP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            colliderZoneWinSP = false;
            winCanva.SetActive(true);
            winText.text = "Player Two Win";
        }

        if (playercollider.gameObject.tag == "PlayerThree")
        {
            colliderZoneWinTP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            colliderZoneWinTP = false;
            winCanva.SetActive(true);
            winText.text = "Player Three Win";
        }

        if (playercollider.gameObject.tag == "PlayerFour")
        {
            colliderZoneWinFoP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            colliderZoneWinFoP = false;
            winCanva.SetActive(true);
            winText.text = "Player Four Win";
        }
    }
}
