using UnityEngine;
using TMPro;

public class LevelController : MonoBehaviour
{
    private int _totalBlocks = 0;
    private Vector2 playerInitalPosition;
    private Vector2 ballInitialPosition;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lifeText;
    public GameObject panelBtns;
    public GameObject player;
    public GameObject ball;
    

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
                UIManager.UpdateText(scoreText, "SCORE: ", GameStats.Score);
                UIManager.UpdateText(lifeText, "LIFES: ", GameStats.Lifes);
            }
            else
            {
                UIManager.EnableElement(panelBtns);
            }
        }
        else if (IsWinnedLevel())
        {
            ChangeToWinScreen();
        }
        else
        {
            GameManager.gameManagerInstance.GameOver();
        }
    }

    /// <summary>
    /// Set UI element at display
    /// </summary>
    void InitLevel()
    {
        UIManager.UpdateText(highScoreText, "HIGH SCORE: ", GameStats.HighScore);
        UIManager.UpdateText(scoreText, "SCORE: ", GameStats.Score);
        UIManager.UpdateText(lifeText, "LIFES: ", GameStats.Lifes);
        GetInitPlayerPosition();
        GetInitBallPosition();
    }

    /// <summary>
    /// Reinitialize level elements
    /// </summary>
    public void ReinitializeLevel()
    {
        GameManager.gameManagerInstance.UpdateState(GameManager.GameState.inTheGame);
        Debug.Log(GameStats.CurrentState);
        UIManager.HideElement(panelBtns);
        player.transform.position = playerInitalPosition;
        ball.transform.position = ballInitialPosition;
        
    }

    /// <summary>
    /// Count total blocks of this scene
    /// </summary>
    void InitTotalBlocksInGame()
    {
        _totalBlocks = GameObject.FindGameObjectsWithTag("Block").Length;
    }

    /// <summary>
    /// Get player Vector2 initial position
    /// </summary>
    void GetInitPlayerPosition()
    {
        playerInitalPosition = player.transform.position;
    }

    /// <summary>
    /// Get ball Vector2 initial position
    /// </summary>
    void GetInitBallPosition()
    {
        ballInitialPosition = ball.transform.position;
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

    /// <summary>
    /// Check if player destroy all blocks
    /// </summary>
    /// <returns></returns>
    bool IsWinnedLevel()
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

    void ChangeToWinScreen()
    {
        GameManager.gameManagerInstance.UpdateState(GameManager.GameState.winTheGame);
        SceneController.ChangeScene("WinScene");
    }
}
