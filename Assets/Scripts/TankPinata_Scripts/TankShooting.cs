using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankShooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootArea;


    public void OnFireBullet(InputAction.CallbackContext context) {
        if (TankGameManager.Instance.isGameStarted && this.gameObject.activeSelf) { 
            GameObject bulletGameObject = Instantiate(bullet, shootArea.position, shootArea.rotation);
            bulletGameObject.GetComponent<BulletBehaviour>().SetShooter(this);

        }
    }
}
