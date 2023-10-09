using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    public float speed;

    private int randomPosition;
    public GameObject positionLeft;
    public GameObject positionRight;

    public void Start()
    {
        RandomPosition();
    }
    public void Update()
    {
        if (GameManager.Instance.gameLauched)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
    public void RandomPosition()
    {
        randomPosition = Random.Range(0, 50);

        if (randomPosition % 2 == 0) // nombre pair
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
        GameManager.Instance.gameLauched = false;
        GameManager.Instance.ChanceGameResult();
    }
}