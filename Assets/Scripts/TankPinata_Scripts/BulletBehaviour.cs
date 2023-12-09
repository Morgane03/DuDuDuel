using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [Header("Bullet Caracteristics")]
    public int bulletSpeed = 3;
    public int pointGivenOnHit = 1;

    public TankShooting tankShooting;

    public void Start() {

        // Defines bullet trajectory 
        this.GetComponent<Rigidbody2D>().velocity = this.transform.right * bulletSpeed;
    }


    void OnCollisionEnter2D(Collision2D collision) {
        if(TankGameManager.Instance.isGameStarted) {
            TankGameManager.Instance.GetPoint(pointGivenOnHit, tankShooting);
        }
        Destroy(gameObject);
    }

    public void SetShooter(TankShooting shooter) {
        tankShooting = shooter;
    }
}
