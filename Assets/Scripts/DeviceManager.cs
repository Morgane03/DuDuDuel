using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class DeviceManager : MonoBehaviour
{
    private static DeviceManager _instance;
    public static DeviceManager Instance { 
        get { 
            if (_instance == null) { 
                Debug.Log("DeviceManager is null"); 
            }
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }
    /// <summary>
    /// button input for wanted players to play the game
    /// </summary>
    public int playersWanted = 0;
    /// <summary>
    ///  Minimum players required to start a game
    /// </summary>
    public int minimumPlayers = 2;

   
    public bool areEnoughGamepadConnected = false;
    public bool isPlayersWantedSet = false;

    public GameObject playerNumberPage;
    public GameObject warningGamepadMessage;
    public TextMeshProUGUI warningText;


    public void SetPlayersWanted(int i) { 
        playersWanted = i;
        isPlayersWantedSet = true;
    }

    public void Update() {
        if (isPlayersWantedSet)
        {
            if (InputSystem.devices.OfType<Gamepad>().Count() == (playersWanted - minimumPlayers)) {

                warningGamepadMessage.SetActive(false);
                areEnoughGamepadConnected = true;
            }
            else {

                warningGamepadMessage.SetActive(true);
                warningText.text = $"Gamepad needed to be connected : {playersWanted - minimumPlayers}";
                areEnoughGamepadConnected = false;
            }
        }
    }

    public void NextPage() {
        if(areEnoughGamepadConnected) {
            playerNumberPage.SetActive(false);
            isPlayersWantedSet = false;
        }
    }
}
