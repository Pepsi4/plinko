using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader
{
    public void LoadScene(string sceneName)
    {
        Debug.Log($"Loading scene: {sceneName}");
        SceneManager.LoadScene(sceneName);
    }
}
