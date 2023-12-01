using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour, AllPlayerControl.IPlayerActions
{
    public int speed;
    private Vector3 _direction;
    private Vector3 _direction2;
    private Vector3 _direction3;
    private Vector3 _direction4;

    public GameObject playerOne;
    public GameObject playerTwo;
    public GameObject playerThree;
    public GameObject playerFour;
    public void Start()
    {
        playerOne.GetComponent<Rigidbody>();
        playerTwo.GetComponent<Rigidbody>();
        playerThree.GetComponent<Rigidbody>();
        playerFour.GetComponent<Rigidbody>();
    }

    public void OnFireBulletP1(InputAction.CallbackContext context){}
    public void OnLook(InputAction.CallbackContext context) {}

    public void OnMove(InputAction.CallbackContext context)
    {
        _direction = context.ReadValue<Vector2>();
    }

    public void OnMoveP2(InputAction.CallbackContext context)
    {
        _direction2 = context.ReadValue<Vector2>();
        playerTwo.GetComponent<Rigidbody>().velocity = _direction2 * (speed * Time.deltaTime);
    }

    public void OnMoveP3(InputAction.CallbackContext context)
    {
        _direction3 = context.ReadValue<Vector2>();
        playerThree.GetComponent<Rigidbody>().velocity = _direction3 * (speed * Time.deltaTime);
    }
    public void OnMoveP4(InputAction.CallbackContext context)
    {
        _direction4 = context.ReadValue<Vector2>();
        playerFour.GetComponent<Rigidbody>().velocity = _direction4 * (speed * Time.deltaTime);

    }

    public void Update()
    {
        playerOne.GetComponent<Rigidbody>().velocity = _direction * (speed * Time.deltaTime);

    }
}
