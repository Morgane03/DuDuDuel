using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("GameManger is null");
            }
            return _instance;

        }
    }

    public int generalScorePlayerOne = 0;
    public int generalScorePlayerTwo = 0;
    public int generalScorePlayerThree = 0;
    public int generalScorePlayerFour = 0;

    void Awake()
    {
        // DontDestroyOnLoad(this);
        _instance = this;
    }

    public bool gameLauched;


    public void WinnerOfAGame(int whichPlayer) {
        switch (whichPlayer) {
            case 1: // Cas Joueur 1 gagne la partie

                generalScorePlayerOne++;
                break;
            case 2: // Cas Joueur 2 gagne la partie

                generalScorePlayerTwo++;
                break;
            case 3: // Cas Joueur 3 gagne la partie

                generalScorePlayerThree++;
                break;
            case 4: // Cas Joueur 4 gagne la partie

                generalScorePlayerFour++;
                break;
        }
    }
}
