using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int number;
    public bool go = false;
    public void OnClick()
    {
        StartCoroutine(CounterNumber());
    }

    IEnumerator CounterNumber()
    {
        text.text = number.ToString();
        yield return new WaitForSeconds(1);
        number--;
        if (number != -1)
        {
            StartCoroutine(CounterNumber());
        }
        if (number == -1)
        {
            text.text = " ";
            go = true;
            StopCoroutine(CounterNumber());
        }
    }
}
