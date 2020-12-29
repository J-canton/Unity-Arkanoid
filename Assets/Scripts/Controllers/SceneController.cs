using UnityEngine.SceneManagement;

public class SceneController
{
    /// <summary>
    /// Change to target scene
    /// </summary>
    /// <param name="newScene"></param>
    public static void ChangeScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }
}
