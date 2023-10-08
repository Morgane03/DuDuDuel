using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [Header("Bullet Caracteristics")]
    public int bulletSpeed = 3;

    public void Start() {

        // Define bullet trajectory 
        this.GetComponent<Rigidbody2D>().velocity = this.transform.right * bulletSpeed;
    }


    void OnCollisionEnter2D(Collision2D collision) {

         Destroy(gameObject);

    }
}