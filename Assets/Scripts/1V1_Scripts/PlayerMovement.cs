using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        // Input for First Player :

            if (Input.GetKey(KeyCode.Z)) {

                Player.transform.position += new Vector3(0, 0, Time.deltaTime * speed);
            }

            if (Input.GetKey(KeyCode.S)) {

                Player.transform.position += new Vector3(0, 0, -(Time.deltaTime * speed));
            }

            if (Input.GetKey(KeyCode.Q)) {

                Player.transform.position += new Vector3(-(Time.deltaTime * speed), 0, 0);
            }

            if (Input.GetKey(KeyCode.D)) {

                Player.transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
            }


        // Input for Second Player :

            if (Input.GetKey(KeyCode.UpArrow)) {

                Player.transform.position += new Vector3(0, 0, Time.deltaTime * speed);
            }

            if (Input.GetKey(KeyCode.DownArrow)) {

                Player.transform.position += new Vector3(0, 0, -(Time.deltaTime * speed));
            }

            if (Input.GetKey(KeyCode.LeftArrow)) {

                Player.transform.position += new Vector3(-(Time.deltaTime * speed), 0, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow)) {

                Player.transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
            }
    }
}
