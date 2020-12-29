using UnityEngine;
using TMPro;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        GetComponent<AudioSource>().Play();
        UIManager.UpdateText(highScoreText, "HIGH SCORE: ", GameStats.HighScore);
        UIManager.UpdateText(scoreText, "SCORE: ", GameStats.Score);
    }

    private void OnDestroy()
    {
        if (GameManager.gameManagerInstance.CheckIsHighScore())
        {
            GameManager.gameManagerInstance.UpdateHighScore(GameStats.Score);
            PrintHighScore(GameStats.HighScore);
        }
        else
        {
            PrintHighScore(GameStats.HighScore);
        }
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
