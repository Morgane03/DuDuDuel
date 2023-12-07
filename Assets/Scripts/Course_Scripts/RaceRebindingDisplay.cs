using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


// made using this : https://www.youtube.com/watch?v=qXbjyzBlduY&t=799s
public class RaceRebindingDisplay : MonoBehaviour
{
    public InputActionRebindingExtensions.RebindingOperation rebindingOperation;

    public void RebindKeyboard(InputActionReference _ref)
    {
        InputAction _action = _ref.action;
        _action.Disable();
        rebindingOperation = _ref.action.PerformInteractiveRebinding(0)
            .WithControlsExcluding("Mouse")
            .WithControlsExcluding("Gamepad")
            .WithControlsExcluding("Touchpad")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation => RebindComplete(_action))
            .Start();
    }
    void RebindComplete(InputAction _action)
    {
        Debug.Log(rebindingOperation.action.bindings[0].effectivePath);
        _action.Enable();
        rebindingOperation.Dispose();
        Debug.Log(InputControlPath.ToHumanReadableString(_action.bindings[0].effectivePath, InputControlPath.HumanReadableStringOptions.OmitDevice));
    }
}