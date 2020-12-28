using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class UIManager : MonoBehaviour
{
    public static UIManager uIManagerInstance;
    public TextMeshProUGUI lifeText, scoreText, highScoreText;
    public GameObject playAgainBtn;

    void Awake()
    {
        uIManagerInstance = this;    
    }

    /// <summary>
    /// Update ui lifeText value
    /// </summary>
    /// <param name="lifes"></param>
    public void UpdateLifes(int lifes)
    {
       lifeText.text = "LIFE: " + lifes;
    }

    /// <summary>
    /// Update ui scoreText value
    /// </summary>
    /// <param name="score"></param>
    public void UpdateScore(int score)
    {
        scoreText.text = "SCORE: " + score;
    }

    /// <summary>
    /// Update ui highScoreText value
    /// </summary>
    /// <param name="newScore"></param>
    public void UpdateHighScore(int newScore)
    {
        highScoreText.text = "HIGH SCORE: " + newScore;
    }

    /// <summary>
    /// When click at btn change the scene
    /// </summary>
    /// <param name="newScene"></param>
    public void ChangeScene (string newScene)
    {
        SceneManager.LoadScene(newScene);
    }

    /// <summary>
    /// Quit game at click
    /// </summary>
    public void QuitGameFromTitle()
    {
        Application.Quit();
    }

    /// <summary>
    /// Show target btn
    /// </summary>
    /// <param name="onButton"></param>
    public void EnableButton(GameObject onButton)
    {
        onButton.SetActive(true);
    }

    /// <summary>
    /// Hide target btn
    /// </summary>
    /// <param name="offButton"></param>
    public void HideButton(GameObject offButton)
    {
        offButton.SetActive(false);
    }
}
