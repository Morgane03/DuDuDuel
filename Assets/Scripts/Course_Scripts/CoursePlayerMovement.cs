using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoursePlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject firstPlayer;
    [SerializeField] GameObject secondPlayer;
    public float speed;
    public float jumpHeight;
    float horizontal;
    private Vector2 movement;

    //public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * horizontal);
        }

        if(Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * horizontal);
        }
    }
}
