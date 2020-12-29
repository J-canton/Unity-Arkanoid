using UnityEngine;

public class TitleController : MonoBehaviour
{
    void Start()
    {
        GameManager.gameManagerInstance.UpdateState(GameManager.GameState.menu);    
    }

    /// <summary>
    ///  Change currentGameState and change de scene
    /// </summary>
    /// <param name="nextScene"></param>
    public void StartGame(string nextScene)
    {
        GameManager.gameManagerInstance.InitGame();
        GameManager.gameManagerInstance.UpdateState(GameManager.GameState.inTheGame);
        SceneController.ChangeScene(nextScene);
    }

    /// <summary>
    /// Quit game at click
    /// </summary>
    public void QuitGameFromTitle()
    {
        Application.Quit();
    }
}
