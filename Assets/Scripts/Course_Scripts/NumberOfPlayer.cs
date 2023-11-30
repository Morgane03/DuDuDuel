using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NumberOfPlayer : MonoBehaviour
{
    public SplitScreen splitScreen;

    public void OnButtonClick(int nbPlayer)
    {
        splitScreen.DisplayPlayer(nbPlayer);
        splitScreen.DisplayCamera(nbPlayer);
    }
}
