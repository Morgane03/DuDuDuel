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
    [SerializeField] private List<GameObject> inputBoxP1;
    [SerializeField] private List<GameObject> inputBoxP2;
    [SerializeField] private List<GameObject> inputBoxP3;
    [SerializeField] private List<GameObject> inputBoxP4;

    [Header("UI InputText")]
    [SerializeField] private List<TMP_Text> boundInputTextP1;
    [SerializeField] private List<TMP_Text> boundInputTextP2;
    [SerializeField] private List<TMP_Text> boundInputTextP3;
    [SerializeField] private List<TMP_Text> boundInputTextP4;

    public List<InputActionRebindingExtensions.RebindingOperation> rebindingOperationP1;
    public List<InputActionRebindingExtensions.RebindingOperation> rebindingOperationP2;
    public List<InputActionRebindingExtensions.RebindingOperation> rebindingOperationP3;
    public List<InputActionRebindingExtensions.RebindingOperation> rebindingOperationP4;

    [SerializeField] private GameObject _rebindingDisplay;

    // Rebinding P1 keys
    public void StartRebindingP1(string str1/*, string str2, string str3*/)
    {
        Debug.Log("StartRebindingP1");
        
        boundInputTextP1[0] .text = str1;
        /*boundInputTextP1[1].text = str2;
        boundInputTextP1[2].text = str3;*/

        inputBoxP1[0].gameObject.transform.GetChild(1).gameObject.SetActive(false);
        _rebindingDisplay.SetActive(true);

        rebindingOperationP1[0] = _playerOneInput.actions[str1].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
    .       OnComplete(operation =>
             RebindComplete(_playerOneInput.actions[str1], 1))
            .Start();
        Debug.Log("StartRebindingP1");

        /*rebindingOperationP1[1] = _playerTwoInput.actions[str2].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerTwoInput.actions[str2], 2))
            .Start();

        rebindingOperationP1[2] = _playerThreeInput.actions[str3].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerThreeInput.actions[str3], 3))
            .Start();*/
    }

    public void StartRebindingP2(/*string str1, string str2,*/ string str3)
    {
        /*boundInputTextP1[0].text = str1;
        boundInputTextP1[1].text = str2;*/
        boundInputTextP1[2].text = str3;

       /* rebindingOperationP1[0] = _playerOneInput.actions[str1].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
    .OnComplete(operation =>
             RebindComplete(_playerOneInput.actions[str1], 1))
            .Start();

        rebindingOperationP1[1] = _playerTwoInput.actions[str2].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerTwoInput.actions[str2], 2))
            .Start();
       */
        rebindingOperationP1[2] = _playerThreeInput.actions[str3].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerThreeInput.actions[str3], 3))
            .Start();
    }

    public void StartRebindingP3(/*string str1, */ string str2/*, string str3*/)
    {
        //boundInputTextP1[0].text = str1;
        boundInputTextP1[1].text = str2;
        //boundInputTextP1[2].text = str3;

        /*rebindingOperationP1[0] = _playerOneInput.actions[str1].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
    .OnComplete(operation =>
             RebindComplete(_playerOneInput.actions[str1], 1))
            .Start();*/

        rebindingOperationP1[1] = _playerTwoInput.actions[str2].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerTwoInput.actions[str2], 2))
            .Start();

       /* rebindingOperationP1[2] = _playerThreeInput.actions[str3].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerThreeInput.actions[str3], 3))
            .Start();*/
    }
    /*
    public void StartRebindingP4(string str1, string str2, string str3)
    {
        boundInputTextP1[0].text = str1;
        boundInputTextP1[1].text = str2;
        boundInputTextP1[2].text = str3;

        rebindingOperationP1[0] = _playerOneInput.actions[str1].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
    .OnComplete(operation =>
             RebindComplete(_playerOneInput.actions[str1], 1))
            .Start();

        rebindingOperationP1[1] = _playerTwoInput.actions[str2].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerTwoInput.actions[str2], 2))
            .Start();

        rebindingOperationP1[2] = _playerThreeInput.actions[str3].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerThreeInput.actions[str3], 3))
            .Start();
    }*/


    public void RebindComplete(InputAction _inputAction, int i)
    {
        Debug.Log("RebindComplete");
        string boundKey = InputControlPath.ToHumanReadableString(
        _inputAction.bindings[0].effectivePath,
        InputControlPath.HumanReadableStringOptions.OmitDevice);

        _inputAction.Enable();

        rebindingOperationP1[0].Dispose();
        //rebindingOperationP2[i - 1].Dispose();
        //rebindingOperationP3[i - 1].Dispose();



        switch (i)
        {
            case 1:
                Debug.Log("case 1");
                boundInputTextP1[0].text = boundKey;
                /*boundInputTextP1[i].text = boundKey;
                boundInputTextP1[i + 1].text = boundKey;*/
                // Autres modifications pour P1 si nécessaire

                inputBoxP1[0].gameObject.transform.GetChild(1).gameObject.SetActive(true);
                _rebindingDisplay.SetActive(false);

                break;
            case 2:
                boundInputTextP2[i - 1].text = boundKey;
                boundInputTextP2[i].text = boundKey;
                boundInputTextP2[i + 1].text = boundKey;
                // Autres modifications pour P2 si nécessaire
                break;
            case 3:
                boundInputTextP3[i - 1].text = boundKey;
                boundInputTextP3[i].text = boundKey;
                boundInputTextP3[i + 1].text = boundKey;
                // Autres modifications pour P3 si nécessaire
                break;
            case 4:
                boundInputTextP4[i - 1].text = boundKey;
                boundInputTextP4[i].text = boundKey;
                boundInputTextP4[i + 1].text = boundKey;
                // Autres modifications pour P4 si nécessaire
                break;
        }
    }
}