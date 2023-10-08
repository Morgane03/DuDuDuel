using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanksWinCondition : MonoBehaviour
{
    [Header("Tank Alive")]
    public bool isAlive = true;


    public void TankDestroyed() {
        // Announce that the other player has won
        Debug.Log("other Player has won");

        GameManager.Instance.TankDuelResults();
        this.gameObject.SetActive(false);
    }
    public void OnCollisionEnter2D(Collision2D collision) {

        if(collision.gameObject.tag == "Bullet") {

            this.isAlive = false;
            Destroy(collision.gameObject);
            TankDestroyed();
        }
    }
}