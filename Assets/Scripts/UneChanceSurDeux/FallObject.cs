using System.Collections;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    public float speed;
    public bool stopFall;

    public void Update()
    {
        if (ChanceGameManager.Instance.gameLauch)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Plateform")
        {
            Destroy(gameObject);
        }
    }
}