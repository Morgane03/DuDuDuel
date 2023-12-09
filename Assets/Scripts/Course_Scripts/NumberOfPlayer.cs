using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Lets you tell the splitscrenn script the number of players
public class NumberOfPlayer : MonoBehaviour
{
    public SplitScreen splitScreen;

    // Allows to give the number of players to the splitscreen script
    public void OnButtonClick(int nbPlayer)
    {
        splitScreen.DisplayPlayer(nbPlayer);
        splitScreen.DisplayCamera(nbPlayer);
    }
}
