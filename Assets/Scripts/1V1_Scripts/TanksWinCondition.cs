using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanksWinCondition : MonoBehaviour
{
    [Header("Tank Alive")]
    public bool isAlive = true;


    void Update() {
        if (!this.isAlive) {
            // Announce that the other player has won
            Debug.Log("other Player has won");

            this.gameObject.SetActive(false);
            GameManager.Instance.gameLauched = false;
            GameManager.Instance.TankDuelResults();
        }

    }

    public void OnCollisionEnter2D(Collision2D collision) {

        if(collision.gameObject.tag == "Bullet") {

            this.isAlive = false;
            Destroy(collision.gameObject);
        }
    }
}
