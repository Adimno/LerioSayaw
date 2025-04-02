using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLerion : MonoBehaviour
{
    public string music;
    // This method will load the scene by its name
    public void ChangeScene1(string sceneName)
    {
        PlayerPrefs.SetString("music", music);
        PlayerPrefs.Save();
        SceneManager.LoadScene(sceneName);
    }

    // Alternatively, you can load the scene by its build index
    public void ChangeSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
