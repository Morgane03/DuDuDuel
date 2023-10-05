using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBehaviour : MonoBehaviour
{
    // Tanks attributes
    [Header("Tanks Attributes")]
    public float tankSpeed = 5f;

    
    [Header("---GameObjects---")]
    public GameObject playerOne;
    public GameObject playerTwo;

    public GameObject bullet;

    // Shooting areas for Tanks
    [Header("Shooting Areas")]
    public Transform firstPlayerShootingArea;
    public Transform secondPlayerShootingArea;


    // Update is called once per frame
    void Update()
    {
        // Input for moving First Player's tank :
        //// Rajouter un If pour l'état du jeu 
            if (Input.GetKey(KeyCode.S))
        {

            playerOne.transform.position += new Vector3(0, -(Time.deltaTime * tankSpeed), 0);
            }

            if (Input.GetKey(KeyCode.W)) {

                playerOne.transform.position += new Vector3(0, Time.deltaTime * tankSpeed, 0);
            }

            if (Input.GetKeyDown(KeyCode.D)) {

                PlayerOneShot();
            }

        // Input for moving Second Player's Tank :

            if (Input.GetKey(KeyCode.DownArrow)) {

                playerTwo.transform.position += new Vector3(0, -(Time.deltaTime * tankSpeed), 0);
            }

            if (Input.GetKey(KeyCode.UpArrow)) {

                playerTwo.transform.position += new Vector3(0, Time.deltaTime * tankSpeed, 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow)) {

                PlayerTwoShot();
            }
    }

    // Methods used to make Tanks shoot depending of which player
    public void PlayerOneShot() {

        Instantiate(bullet, firstPlayerShootingArea.position, firstPlayerShootingArea.rotation);
    }

    public void PlayerTwoShot() {

        Instantiate(bullet, secondPlayerShootingArea.position, secondPlayerShootingArea.rotation);
    }
}
