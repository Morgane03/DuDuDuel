using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    public Counter counter;

    public float speed;
    private int randomPosition;
    public GameObject positionLeft;
    public GameObject positionRight;
    public bool win;

    public void Start()
    {
        RandomPosition();
    }
    public void Update()
    {
        if (counter.go == true)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
    
    public void RandomPosition()
    {
        randomPosition = Random.Range(0, 50);

        if(randomPosition %2 == 0) //nombre paire
        {
            gameObject.transform.position = positionLeft.transform.position;
        }
        else
        {
            gameObject.transform.position = positionRight.transform.position;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        counter.go = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlayerOne" && other.tag == "PlayerTwo" && win == false)
        {
            Debug.Log("No winner");
            win = true;
        }

        if(other.tag == "PlayerOne" && win == false)
        {
            Debug.Log("Player 2 win");
            win = true;
        }

        if (other.tag == "PlayerTwo" && win == false)
        {
            Debug.Log("Player 1 win");
            win = true;
        }
    }
}