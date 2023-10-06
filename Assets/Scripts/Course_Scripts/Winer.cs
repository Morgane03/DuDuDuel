using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winer : MonoBehaviour
{

    public CoursePlayerMovement coursePlayerMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider playercollider)
    {
        if (coursePlayerMovement.firstPlayer = playercollider.gameObject)
        {
            Debug.Log("J1 Win");
        }
        /*
        if(coursePlayerMovement.secondPlayer = playercollider.gameObject)
        {
            Debug.Log("J2 Win");
        }*/
    }
}
