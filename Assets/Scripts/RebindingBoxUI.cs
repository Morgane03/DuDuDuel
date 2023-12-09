using UnityEngine;

public class RebindingBoxUI : MonoBehaviour
{
    // Player number this rebinding box belongs to 
    public int rebindingBoxPlayerNumber = 0;

    public void Start() {
        DeviceManager.Instance.playersWanted += Notify;

    }

    public void Notify(int playerWanted) {
        if(DeviceManager.Instance.playerNumber >= rebindingBoxPlayerNumber) {
            this.gameObject.SetActive(true);
        }
        else {
            this.gameObject.SetActive(false);
        }
    }
}
