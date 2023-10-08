using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerOneWinCondition : MonoBehaviour
{
    public bool firstDie;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Tank")
        {
            firstDie = true;
        }
    }
}
