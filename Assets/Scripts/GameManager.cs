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

    void Awake() {
        DontDestroyOnLoad(this);
        _instance = this;

        generalScorePlayerOne = PlayerPrefs.GetInt("ScorePlayerOne");
        generalScorePlayerTwo = PlayerPrefs.GetInt("ScorePlayerTwo");
        generalScorePlayerThree = PlayerPrefs.GetInt("ScorePlayerThree");
        generalScorePlayerFour = PlayerPrefs.GetInt("ScorePlayerFour");
    }


    public void WinnerOfAGame(int whichPlayer) {
        switch (whichPlayer) {
            case 1: // Case Player 1 win the Game.

                PlayerPrefs.GetInt("ScorePlayerOne", generalScorePlayerOne);
                PlayerPrefs.SetInt("ScorePlayerOne", generalScorePlayerOne++);

                Debug.Log(PlayerPrefs.GetInt("ScorePlayerOne"));
                break;
            case 2: // Case Player 2 win the Game.

                PlayerPrefs.GetInt("ScorePlayerTwo", generalScorePlayerTwo);
                PlayerPrefs.SetInt("ScorePlayerTwo", generalScorePlayerTwo++);
                break;
            case 3: // Case Player 3 win the Game. 

                PlayerPrefs.GetInt("ScorePlayerThree", generalScorePlayerThree);
                PlayerPrefs.SetInt("ScorePlayerThree", generalScorePlayerThree++);
                break;
            case 4: // Case Player 4 win the Game.

                PlayerPrefs.GetInt("ScorePlayerFour", generalScorePlayerFour);
                PlayerPrefs.SetInt("ScorePlayerFour", generalScorePlayerFour++);
                break;
        }
    }
}
