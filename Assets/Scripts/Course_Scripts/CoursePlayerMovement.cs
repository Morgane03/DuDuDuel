using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CoursePlayerMovement : MonoBehaviour, AllPlayerControl.IPlayerActions
{
    public float speed;
    public Transform firstPlayerTransform;
    public Transform secondPlayerTransform;
    //public Transform thirdPlayerTransform;
    //public Transform fourthPlayerTransform;

    private Vector3 _direction;
    private Vector3 _direction2;
    private Vector3 _direction3;
    private Vector3 _direction4;
    private Vector3 _jumpDirection;

    public void OnLook(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _direction = context.ReadValue<Vector2>();
    }

    public void OnMoveP2(InputAction.CallbackContext context)
    {
        _direction2 = context.ReadValue<Vector2>();
    }
    /*
    public void OnMoveP3(InputAction.CallbackContext context)
    {
        _direction3 = context.ReadValue<Vector2>();
    }
    public void OnMoveP4(InputAction.CallbackContext context)
    {
        _direction4 = context.ReadValue<Vector2>();
    }
    */
    public void OnJump(InputAction.CallbackContext context)
    {
        _jumpDirection = context.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.gameLauched)
        {
            // first player movement
            firstPlayerTransform.Translate(_direction * (speed * Time.deltaTime));
            firstPlayerTransform.Translate(_jumpDirection * (speed * Time.deltaTime));

            //second player movement
            secondPlayerTransform.Translate(_direction2 * (speed * Time.deltaTime));
            secondPlayerTransform.Translate(_jumpDirection * (speed * Time.deltaTime));

            /*
            //third player movement
            thirdPlayerTransform.Translate(_direction3 * (speed * Time.deltaTime));

            //fourth player movement
            fourthPlayerTransform.Translate(_direction4 * (speed * Time.deltaTime));*/
        }
    }
}
