using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


// made using this : https://www.youtube.com/watch?v=qXbjyzBlduY&t=799s
public class RaceRebindingDisplay : MonoBehaviour
{
    [Header("Player Inputs")]
    [SerializeField] private PlayerInput _playerInput;

    [Header("UI InputBox")]
    [SerializeField] private GameObject inputBox1;
    [SerializeField] private GameObject inputBox2;
    [SerializeField] private GameObject inputBox3;


    [Header("UI InputText")]
    [SerializeField] private TMP_Text boundInputText1;
    [SerializeField] private TMP_Text boundInputText2;
    [SerializeField] private TMP_Text boundInputText3;

    public InputActionRebindingExtensions.RebindingOperation rebindingOperation1;
    public InputActionRebindingExtensions.RebindingOperation rebindingOperation2;
    public InputActionRebindingExtensions.RebindingOperation rebindingOperation3;

    [SerializeField] private GameObject _rebindingDisplay;

    // Rebinding P1 keys
    public void StartRebindingP1(string str1)
    {
        Debug.Log("StartRebindingP1");
        
        boundInputText1.text = str1;


        inputBox1.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        _rebindingDisplay.SetActive(true);

        /*rebindingOperation1 = _playerInput.actions[str1].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
    .       OnComplete(operation =>
             RebindComplete(_playerInput.actions[str1], 1))
            .Start();*/
        Debug.Log("StartRebindingP1");

    }

    public void StartRebindingP2(string str3)
    {

        boundInputText2.text = str3;

        rebindingOperation2 = _playerInput.actions[str3].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerInput.actions[str3], 3))
            .Start();
    }

    public void StartRebindingP3( string str2)
    {
        boundInputText3.text = str2;
;

        rebindingOperation3 = _playerInput.actions[str2].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerInput.actions[str2], 2))
            .Start();
    }
 

    public void RebindComplete(InputAction _inputAction, int i)
    {
        Debug.Log("RebindComplete");
        string boundKey = InputControlPath.ToHumanReadableString(
        _inputAction.bindings[0].effectivePath,
        InputControlPath.HumanReadableStringOptions.OmitDevice);

        _inputAction.Enable();

        rebindingOperation1.Dispose();
        rebindingOperation2.Dispose();
        rebindingOperation3.Dispose();




        switch (i)
        {
            case 1:
                Debug.Log("case 1");
                boundInputText1.text = boundKey;

                inputBox1.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                _rebindingDisplay.SetActive(false);

                break;
            case 2:
                boundInputText2.text = boundKey;

                inputBox2.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                _rebindingDisplay.SetActive(false);

                break;
            case 3:
                boundInputText3.text = boundKey;

                inputBox3.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                _rebindingDisplay.SetActive(false);

                break;
        }
    }
}