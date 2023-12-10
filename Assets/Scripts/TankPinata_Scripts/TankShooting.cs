using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankShooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootArea;

    public int bulletShot = 0;
    public int maxBullet = 5;

    public void OnFireBullet(InputAction.CallbackContext context) {
        if (TankGameManager.Instance.isGameStarted && bulletShot < maxBullet) { 
            GameObject bulletGameObject = Instantiate(bullet, shootArea.position, shootArea.rotation);
            bulletGameObject.GetComponent<BulletBehaviour>().SetShooter(this);

            bulletShot++;
            ReloadBullet();
        }
    }


    public void ReloadBullet() {
        StartCoroutine(ReloadingBullet());
    }

    public IEnumerator ReloadingBullet()
    {
        yield return new WaitForSeconds(3);
        if (bulletShot > 0) {

            bulletShot--;
            StartCoroutine(ReloadingBullet());
        }
        if (bulletShot == 0) {
            StopCoroutine(ReloadingBullet());
        }
    }
    
}
