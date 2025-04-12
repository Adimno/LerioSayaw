using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
    public void MoveToMainMenu()
    {
        // Load the main menu scene asynchronously
        StartCoroutine(LoadScene("main_menu_stage"));
    }

    
    public void TryAgainLogic()
    {
             StartCoroutine(LoadScene("Tutorial"));
    }

    public void QuitApplication()
    {
        // Quit the application
        Application.Quit();
    }

    private IEnumerator LoadScene(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
