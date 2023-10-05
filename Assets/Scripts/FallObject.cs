using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 direction;
    public void Fall()
    {
        Vector2 mouvement = new Vector2(speed.x * direction.x, speed.y * direction.y);
        mouvement *= Time.deltaTime;
        gameObject.transform.Translate(mouvement);
    }
}