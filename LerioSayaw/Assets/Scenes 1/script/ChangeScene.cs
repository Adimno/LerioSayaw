using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // This method will load the scene by its name
    public void ChangeScene1(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Alternatively, you can load the scene by its build index
    public void ChangeSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
