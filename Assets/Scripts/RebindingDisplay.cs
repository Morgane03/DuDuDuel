using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

// made using this : https://youtu.be/dUCcZrPhwSo?si=JYoy8TvSQdoeHMDj
public class RebindingDisplay : MonoBehaviour
{

    [Header("Player Inputs")]
    [SerializeField] private PlayerInput _playerOneInput;
    [SerializeField] private PlayerInput _playerTwoInput;
    [SerializeField] private PlayerInput _playerThreeInput;
    [SerializeField] private PlayerInput _playerFourInput;


    [Header("UI Renderer")]
    [SerializeField] private GameObject inputBoxP1;
    [SerializeField] private GameObject inputBoxP2;
    [SerializeField] private GameObject inputBoxP3;
    [SerializeField] private GameObject inputBoxP4;


    [SerializeField] private TMP_Text boundInputText;

    public InputActionRebindingExtensions.RebindingOperation rebindingOperation;

    // Rebinding P1 keys
    public void StartRebindingP1(string str) {

        inputBoxP1.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        inputBoxP1.gameObject.transform.GetChild(2).gameObject.SetActive(true);


        _playerOneInput.actions[str].Disable();

        rebindingOperation = _playerOneInput.actions[str].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("<Gamepad>/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerOneInput.actions[str]))
            .Start();
    }

    // Rebinding P2 keys
    public void StartRebindingP2(string str) {

        inputBoxP2.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        inputBoxP2.gameObject.transform.GetChild(2).gameObject.SetActive(true);

        _playerTwoInput.actions[str].Disable();

        rebindingOperation = _playerTwoInput.actions[str].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("<Gamepad>/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerTwoInput.actions[str]))
            .Start();
    }

    // Rebinding P3 keys
    public void StartRebindingP3(string str) {

        inputBoxP3.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        inputBoxP3.gameObject.transform.GetChild(2).gameObject.SetActive(true);

        _playerThreeInput.actions[str].Disable();

        rebindingOperation = _playerThreeInput.actions[str].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("<Gamepad>/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerThreeInput.actions[str]))
            .Start();
    }

    // Rebinding P4 keys
    public void StartRebindingP4(string str) {

        inputBoxP4.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        inputBoxP4.gameObject.transform.GetChild(2).gameObject.SetActive(true);

        _playerFourInput.actions[str].Disable();

        rebindingOperation = _playerFourInput.actions[str].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("<Gamepad>/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerFourInput.actions[str]))
            .Start();
    }


    public void RebindComplete(InputAction _inputAction) {
        int bindingIndex = _inputAction.GetBindingIndexForControl(_inputAction.controls[0]);

        boundInputText.text = InputControlPath.ToHumanReadableString(
            _inputAction.bindings[0].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);

        /* string path = _inputAction.bindings[0].overridePath;
        Debug.Log(path); */

        //_inputAction.ApplyBindingOverride(path, _inputAction.bindings[0].path);

        _inputAction.Enable();

        rebindingOperation.Dispose();



        inputBoxP1.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        inputBoxP1.gameObject.transform.GetChild(2).gameObject.SetActive(false);

        inputBoxP2.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        inputBoxP2.gameObject.transform.GetChild(2).gameObject.SetActive(false);

        inputBoxP3.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        inputBoxP3.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        
        inputBoxP4.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        inputBoxP4.gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }
}
