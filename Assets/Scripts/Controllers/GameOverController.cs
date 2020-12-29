using UnityEngine;
using TMPro;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        GetComponent<AudioSource>().Play();

        if (GameManager.gameManagerInstance.CheckIsHighScore())
        {
            GameManager.gameManagerInstance.UpdateHighScore(GameStats.Score);
            PrintHighScore(GameStats.HighScore);
        }
        else
        {
            PrintHighScore(GameStats.HighScore);
        }
        UIManager.UpdateText(scoreText, "SCORE: ", GameStats.Score);
    }


    void PrintHighScore(int score)
    {
        UIManager.UpdateText(highScoreText, "HIGH SCORE: ", score);
    }

    public void GoTitle()
    {
        SceneController.ChangeScene("TitleScene");
    }
}
