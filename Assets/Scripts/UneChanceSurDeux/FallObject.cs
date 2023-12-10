using UnityEngine;

public class FallObject : MonoBehaviour
{
    public float speed;

    public void Update()
    {
        if (ChanceGameManager.Instance.gameLauch) //box fall 
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }

    public void OnTriggerEnter(Collider collision) //box disappear 
    {
        if (collision.tag == "Plateform")
        {
            Destroy(gameObject);
            ChanceGameManager.Instance.CountBoxFallen();
        }
    }
}