using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    public void Fall()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}