using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;
    public enum GameState { menu, inTheGame, lostLife ,gameOver, winTheGame };

    private int _initLifes = 3;
    private int _totalScore = 0;
    private int _highScore = 0;
    private int _totalBlocks = 0;

    public GameObject ball;
    public GameState _currentGameState;

    public int Lifes
    {
        get
        {
            return _initLifes;
        }
        set
        {
            _initLifes = value;
        }
    }
    public int Score
    {
        get
        {
            return _totalScore;
        }
        set
        {
            _totalScore = value;
        }
    }
    public GameState CurrentState
    {
        get
        {
            return _currentGameState;
        }
        set
        {
            _currentGameState = value;
        }

    }


    void Awake()
    {
        sharedInstance = this;
    }

    void Start()
    {
        InitLifes();
        InitScore();
        InitTotalBlocksInGame();
        InitLevel();
    }

    ///<summary>
    ///Set de _currentState to GameState.inTheGame
    /// </summary>
    void InitLevel()
    {
        CurrentState = GameState.inTheGame;
        PlayerController.InitPlayerPosition();
        BallController.InitBallPosition();
        BallController.ShowBall();
    }

    ///<SUMARY>
    /// Starts lifes at the start of the level
    /// </SUMARY>
    void InitLifes()
    {
        Debug.Log(Lifes);
        UIManager.uIManagerInstance.UpdateLifes(Lifes);
    }

    /// <summary>
    /// Update UI Lifes and add lifes;
    /// </summary>
    /// <param name="value"></param>
    public void UpdateLifes(int value)
    {
        Lifes -= value;
        if (Lifes > 0)
        {
            UIManager.uIManagerInstance.UpdateLifes(Lifes);
        }
        else
        {
            CurrentState = GameState.gameOver;
            UIManager.uIManagerInstance.ChangeScene("Game Over");
        }

    }

    ///<SUMARY>
    /// Starts score at the start of the level
    /// </SUMARY>
    void InitScore()
    {
        UIManager.uIManagerInstance.UpdateScore(Score);
    }

    /// <summary>
    /// Update UI score and add blockValue to the _totalScore
    /// </summary>
    /// <param name="value"></param>
    public void UpdateScore(int value)
    {
        Score += value;
        UIManager.uIManagerInstance.UpdateScore(Score);
    }

    /// <summary>
    /// Count total blocks of this scene
    /// </summary>
    void InitTotalBlocksInGame()
    {
        _totalBlocks = GameObject.FindGameObjectsWithTag("Block").Length;
    }

    public void StartGame()
    {
        InitLevel();
        UIManager.uIManagerInstance.HideButton(UIManager.uIManagerInstance.playAgainBtn);

    }
}
