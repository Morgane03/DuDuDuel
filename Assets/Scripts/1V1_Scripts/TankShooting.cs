using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TankShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootArea;

    // Update is called once per frame
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)) {
            GameObject bulletGameObject = Instantiate(bullet, shootArea.position, shootArea.rotation);
            bulletGameObject.GetComponent<BulletBehaviour>().SetShooter(this);
        }
    }
}
