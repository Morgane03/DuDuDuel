using UnityEngine;

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
