using UnityEngine;
using TMPro;

public class WinController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    void Start()
    {
        UIManager.UpdateText(scoreText, "SCORE: ", GameStats.Score);    
    }

    public void GoToTitle()
    {
        SceneController.ChangeScene("TitleScene");
    }
}
