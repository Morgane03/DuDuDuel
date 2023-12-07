using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


// made using this : https://www.youtube.com/watch?v=qXbjyzBlduY&t=799s
public class RaceRebindingDisplay : MonoBehaviour
{
    [Header("Player Inputs")]
    [SerializeField] private PlayerInput _playerOneInput;
    [SerializeField] private PlayerInput _playerTwoInput;
    [SerializeField] private PlayerInput _playerThreeInput;
    [SerializeField] private PlayerInput _playerFourInput;

    [Header("UI InputBox")]
    public List<GameObject> inputBoxes;

    [Header("UI InputText")]
    public List<TMP_Text> boundInputTexts;

    public InputActionRebindingExtensions.RebindingOperation rebindingOperation;

    // Rebinding P1 keys
      
}