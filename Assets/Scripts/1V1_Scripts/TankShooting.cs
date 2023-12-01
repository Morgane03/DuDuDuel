using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankShooting : MonoBehaviour, AllPlayerControl.IPlayerActions
{
    public GameObject bullet;
    public Transform shootArea;

    /* private void Start()
    {
        AllPlayerControl controls = new AllPlayerControl();

        controls.Enable();
        controls.Player.Enable();
        controls.Player.FireBulletP1.Enable();
        controls.Player.FireBulletP1.performed += OnFireBulletP1;
    } */

    public void OnMove(InputAction.CallbackContext context) { /* Does nothing */ }
    public void OnLook(InputAction.CallbackContext context) { /* Does nothing */ }

    public void OnFireBulletP1(InputAction.CallbackContext context) {
        if (TankGameManager.Instance.isGameStarted) { 
            GameObject bulletGameObject = Instantiate(bullet, shootArea.position, shootArea.rotation);
            bulletGameObject.GetComponent<BulletBehaviour>().SetShooter(this);
        }

    }

    public void OnFireBulletP2(InputAction.CallbackContext context) {
        if (TankGameManager.Instance.isGameStarted)
        {
            GameObject bulletGameObjectP2 = Instantiate(bullet, shootArea.position, shootArea.rotation);
            bulletGameObjectP2.GetComponent<BulletBehaviour>().SetShooter(this);
        }

    }

    public void OnFireBulletP3(InputAction.CallbackContext context) {
        if (TankGameManager.Instance.isGameStarted)
        {
            GameObject bulletGameObjectP3 = Instantiate(bullet, shootArea.position, shootArea.rotation);
            bulletGameObjectP3.GetComponent<BulletBehaviour>().SetShooter(this);
        }

    }

    public void OnFireBulletP4(InputAction.CallbackContext context) {
        if (TankGameManager.Instance.isGameStarted)
        {
            GameObject bulletGameObjectP4 = Instantiate(bullet, shootArea.position, shootArea.rotation);
            bulletGameObjectP4.GetComponent<BulletBehaviour>().SetShooter(this);
        }
        
    }
}
