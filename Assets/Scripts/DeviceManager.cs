using System;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
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

    public event Action<int> playersWanted;

    public int playerNumber = 0;
    /// <summary>
    ///  Minimum players required to start a game, 2 by default.
    /// </summary>
    public int minimumPlayers = 2;

    public bool areEnoughGamepadConnected = false;
    public bool isPlayersWantedSet = false;

    public GameObject playerNumberPage;
    public GameObject warningGamepadMessage;
    public TextMeshProUGUI warningText;


    public void SetPlayersWanted(int i) { 
        playerNumber = i;
        playersWanted?.Invoke(playerNumber);
        isPlayersWantedSet = true;
    }

    public void Update() {
        if (isPlayersWantedSet)
        {
            if (InputSystem.devices.OfType<Gamepad>().Count() == (playerNumber - minimumPlayers)) {

                warningGamepadMessage.SetActive(false);
                areEnoughGamepadConnected = true;
            }
            else {

                warningGamepadMessage.SetActive(true);
                warningText.text = $"Gamepad needed to be connected : {playerNumber - minimumPlayers}";
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

    public void SetPlayerNumberInNonRequiredControllerGame(int i) {
        playerNumber = i;
        playersWanted?.Invoke(playerNumber);
        areEnoughGamepadConnected= true;

    }

}
