using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerTwoWinCondition : MonoBehaviour
{
    public bool secondDie;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Tank")
        {
            secondDie = true;
        }
    }
}
