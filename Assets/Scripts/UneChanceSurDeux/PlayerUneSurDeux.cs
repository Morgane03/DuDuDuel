using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUneSurDeux : MonoBehaviour
{
    public float speed;
    public GameObject player1;
    public GameObject player2;

    void Update()
    {
        if (GameManager.Instance.gameLauched)
        {
            //player1
            if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.A))
            {
                player1.transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                player1.transform.Translate(Vector3.right * Time.deltaTime * speed);
            }

            //player2
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                player2.transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                player2.transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
        }
    }
}
