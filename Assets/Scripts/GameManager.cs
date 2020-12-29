using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManagerInstance;
    public enum GameState { menu, inTheGame, lostLife ,gameOver, winTheGame };

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        gameManagerInstance = this;
    }

    public void InitGame()
    {
        UpdateLifes(GameStats.InitLifes);
        GameStats.Score = 0;
    }

    public void UpdateLifes(int newLifes)
    {
        GameStats.Lifes = newLifes;
    }

    public void UpdateState(GameState newState)
    {
        GameStats.CurrentState = newState;
    }

    public void UpdateScore(int newScore)
    {
        GameStats.Score += newScore;
    }

    public void UpdateHighScore(int newScore)
    {
        GameStats.HighScore = newScore;
    }

    public bool CheckIsHighScore()
    {
        if (GameStats.Score > GameStats.HighScore)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void GameOver()
    {
        UpdateState(GameState.gameOver);
        SceneController.ChangeScene("Game Over");
    }
}
