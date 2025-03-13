using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class SceneNavigator : MonoBehaviour
{

    public void MoveToLerionScene()
    {
  
            StartCoroutine(LoadScene("Lerion_Scene"));
 
 

    }

    public void MoveToCarinosaScene()
    {
        StartCoroutine(LoadScene("Carinosa_Scene"));
    }

    public void MoveToTutorial()
    {
        StartCoroutine(LoadScene("Tutorial"));
    }
     
     
    public void MoveToMenu()
    {
        StartCoroutine(LoadScene("MainMenu"));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadScene(string sceneName)
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        asyncLoad.allowSceneActivation = false; 


        asyncLoad.allowSceneActivation = true;

        while (!asyncLoad.isDone)
        {
            yield return null;
        }


    }
}
