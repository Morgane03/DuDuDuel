using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    public Counter counter;

    public float speed;
    public void Update()
    {
        if (counter.go == true)
        {
            //gameObject.GetComponent<Rigidbody>().useGravity = true;
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        counter.go = false;
    }
}