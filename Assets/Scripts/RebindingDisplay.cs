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


    [Header("UI InputBox")]
    [SerializeField] private GameObject inputBoxP1;
    [SerializeField] private GameObject inputBoxP2;
    [SerializeField] private GameObject inputBoxP3;
    [SerializeField] private GameObject inputBoxP4;

    [Header("UI InputText")]
    [SerializeField] private TMP_Text boundInputTextP1;
    [SerializeField] private TMP_Text boundInputTextP2;
    [SerializeField] private TMP_Text boundInputTextP3;
    [SerializeField] private TMP_Text boundInputTextP4;


    public InputActionRebindingExtensions.RebindingOperation rebindingOperation;

    // Rebinding keys
    public void StartRebinding(string str) {

        inputBoxP1.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        inputBoxP1.gameObject.transform.GetChild(2).gameObject.SetActive(true);


        _playerOneInput.actions[str].Disable();

        rebindingOperation = _playerOneInput.actions[str].PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("<Gamepad>/start")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation =>
                RebindComplete(_playerOneInput.actions[str], 1))
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
                RebindComplete(_playerTwoInput.actions[str], 2))
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
                RebindComplete(_playerThreeInput.actions[str], 3))
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
                RebindComplete(_playerFourInput.actions[str], 4))
            .Start();
    }


    public void RebindComplete(InputAction _inputAction, int i) {

        string boundKey = InputControlPath.ToHumanReadableString(
            _inputAction.bindings[0].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);


        _inputAction.Enable();

        rebindingOperation.Dispose();

        switch (i)
        {
            case 1:

                boundInputTextP1.text = boundKey;

                inputBoxP1.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                inputBoxP1.gameObject.transform.GetChild(2).gameObject.SetActive(false);
                break;
            case 2:

                boundInputTextP2.text = boundKey;

                inputBoxP2.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                inputBoxP2.gameObject.transform.GetChild(2).gameObject.SetActive(false);
                break;
            case 3:

                boundInputTextP3.text = boundKey;

                inputBoxP3.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                inputBoxP3.gameObject.transform.GetChild(2).gameObject.SetActive(false);
                break;
            case 4:

                boundInputTextP4.text = boundKey;

                inputBoxP4.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                inputBoxP4.gameObject.transform.GetChild(2).gameObject.SetActive(false);
                break;
        }
    }
}
