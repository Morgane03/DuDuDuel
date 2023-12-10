using TMPro;
using UnityEngine;

public class Winer : MonoBehaviour
{
    /// <summary>
    /// FP = First Player
    /// SP = Second Player
    /// TP = Third Player
    /// FoP = Fourth Player
    /// </summary>
    private bool _colliderZoneWinFP = false;
    private bool _colliderZoneWinSP = false;
    private bool _colliderZoneWinTP = false;
    private bool _colliderZoneWinFoP = false;

    public GameObject winCanva;
    public TextMeshProUGUI winText;

    public Timer timer;
    public GameLauched gameLauched;

    // Detects the player entering the area
    public void OnTriggerEnter(Collider playercollider)
    {
        
       if(playercollider.gameObject.tag == "PlayerOne")
        {
            _colliderZoneWinFP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            _colliderZoneWinFP = false;
            Debug.Log("Player One Win");
            timer.StopTimer();
            gameLauched.canMove = false;
            winCanva.SetActive(true);
            winText.text = "Player One Win";
        }
        
       if(playercollider.gameObject.tag == "PlayerTwo")
        {
            _colliderZoneWinSP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            _colliderZoneWinSP = false;
            timer.StopTimer();
            gameLauched.canMove = false;
            winCanva.SetActive(true);
            winText.text = "Player Two Win";
        }

        if (playercollider.gameObject.tag == "PlayerThree")
        {
            _colliderZoneWinTP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            _colliderZoneWinTP = false;
            timer.StopTimer();
            gameLauched.canMove = false;
            winCanva.SetActive(true);
            winText.text = "Player Three Win";
        }

        if (playercollider.gameObject.tag == "PlayerFour")
        {
            _colliderZoneWinFoP = true;
            GameManager.Instance.WinnerOfAGame(playercollider.gameObject.GetComponent<PlayerIDs>().GetPlayerID());
            _colliderZoneWinFoP = false;
            timer.StopTimer();
            gameLauched.canMove = false;
            winCanva.SetActive(true);
            winText.text = "Player Four Win";
        }
    }
}
