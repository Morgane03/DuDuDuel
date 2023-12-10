using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leaderboard : MonoBehaviour
{
    public string sceneName;

    public TextMeshProUGUI scorePlayerOne;
    public TextMeshProUGUI scorePlayerTwo;
    public TextMeshProUGUI scorePlayerThree;
    public TextMeshProUGUI scorePlayerFour;

    public TextMeshProUGUI scoreEachGame;

    void Update() {
        if(SceneManager.GetActiveScene().name == "MainMenu") {

            scorePlayerOne.text = PlayerPrefs.GetInt("ScorePlayerOne") + " Pts";
            scorePlayerTwo.text = PlayerPrefs.GetInt("ScorePlayerTwo") + " Pts";
            scorePlayerThree.text = PlayerPrefs.GetInt("ScorePlayerThree") + " Pts";
            scorePlayerFour.text = PlayerPrefs.GetInt("ScorePlayerFour") + " Pts";
        }

        if(SceneManager.GetActiveScene().name == sceneName) {

            SetEachGameLeaderboard(sceneName);
        }
        
    }

    public void SetEachGameLeaderboard(string str) {
        switch (str) {
            case "TankPinata":

                scoreEachGame.text = PlayerPrefs.GetInt("TankGameBestScore").ToString();
                break;
            case "Chance":


                break;
            case "Course":


                break;
        }

    }
}
