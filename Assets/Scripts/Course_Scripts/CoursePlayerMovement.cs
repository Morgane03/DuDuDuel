using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoursePlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject firstPlayer;
    [SerializeField] GameObject secondPlayer;
    public float speed;
    public float jumpHeight;
    public Transform firstPlayerTransform;
    public Transform secondPlayerTransform;

    // Update is called once per frame
    void Update()
    {
        // first player movement
        if (Input.GetKey(KeyCode.D))
        {
            firstPlayerTransform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.Q))
        {
            firstPlayerTransform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
        if(Input.GetKey(KeyCode.Z))
        {
            firstPlayerTransform.Translate(Vector3.up * Time.deltaTime * jumpHeight);
        }

        //second player movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            secondPlayerTransform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            secondPlayerTransform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            secondPlayerTransform.Translate(Vector3.up * Time.deltaTime * jumpHeight);
        }
    }
}
