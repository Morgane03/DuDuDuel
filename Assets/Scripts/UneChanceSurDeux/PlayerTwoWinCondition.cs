using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerTwoWinCondition : MonoBehaviour
{
    public bool win;
    public TextMeshProUGUI textWin;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Tank" && win == false)
        {
            textWin.text = "Player 1 win";
            win = true;
        }
    }
}