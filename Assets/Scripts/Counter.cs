using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Counteur : MonoBehaviour
{
    public FallObject fallObject;
    public TextMeshProUGUI text;
    private int number;
    void Start()
    {
        number = 10;
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
            fallObject.Fall();
            StopCoroutine(CounterNumber());
        }
    }
}
