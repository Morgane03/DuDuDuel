using System.Collections;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    public float speed;
    public bool stopFall;

    public void Update()
    {
        //if (GameManager.Instance.gameLauched)
        //{

        transform.Translate(Vector3.down * Time.deltaTime * speed);

        //}
    }

    public void OnTriggerEnter(Collider collision)
    {
        //GameManager.Instance.gameLauched = false;
        //GameManager.Instance.ChanceGameResult();
        if (collision.tag == "Plateform")
        {
           Destroy(gameObject);
        }

    }
}