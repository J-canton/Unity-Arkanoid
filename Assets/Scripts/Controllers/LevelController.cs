using UnityEngine;
using TMPro;

public class LevelController : MonoBehaviour
{
    private int _totalBlocks = 0;

    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lifeText;
    public GameObject panelBtns;
    

    void Start()
    {
        InitLevel();
        InitTotalBlocksInGame();
    }

    void Update()
    {
        if (!LooseLevel())
        {
            if (GameStats.CurrentState != GameManager.GameState.lostLife)
            {
                UIManager.UpdateText(scoreText, "SCORE", GameStats.Score);
                UIManager.UpdateText(lifeText, "LIFES", GameStats.Lifes);
            }
            else
            {
                UIManager.EnableElement(panelBtns);
            }
        }
        else if (WinLevel())
        {

        }
        else
        {
            GameManager.gameManagerInstance.GameOver();
        }
    }


    void InitLevel()
    {
        UIManager.UpdateText(highScoreText, "HIGH SCORE", GameStats.HighScore);
        UIManager.UpdateText(scoreText, "SCORE", GameStats.Score);
        UIManager.UpdateText(lifeText, "LIFES", GameStats.Lifes);
    }

    public void ReinitializeLevel()
    {   
        BallController.InitBallPosition();
        BallController.ShowBall();
        PlayerController.InitPositionPlayer();
        UIManager.HideElement(panelBtns);
        GameManager.gameManagerInstance.UpdateState(GameManager.GameState.inTheGame);
    }

    /// <summary>
    /// Count total blocks of this scene
    /// </summary>
    void InitTotalBlocksInGame()
    {
        _totalBlocks = GameObject.FindGameObjectsWithTag("Block").Length;
    }

    /// <summary>
    /// Check if is lifes equals to 0
    /// </summary>
    /// <returns></returns>
    bool LooseLevel()
    {
        if (GameStats.Lifes == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool WinLevel()
    {
        if (_totalBlocks == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
