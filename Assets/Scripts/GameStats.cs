public class GameStats
{
    private static GameManager.GameState _currentGameState;
    private static int _lifes = 0;
    private static int _score = 0;
    private static int _highScore = 0;

    public static int InitLifes = 3;
    public static GameManager.GameState CurrentState
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
    public static int Lifes
    {
        get
        {
            return _lifes;
        }
        set
        {
            _lifes = value; 
        }
    }
    public static int Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
        }
    }
    public static int HighScore
    {
        get
        {
            return _highScore;
        }
        set
        {
            _highScore = value;
        }
    }
}
