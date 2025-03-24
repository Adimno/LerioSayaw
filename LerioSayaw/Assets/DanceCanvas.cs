using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DanceCanvas : MonoBehaviour
{
    public GameObject welcome, characterSelection;

    // Start is called before the first frame update
    void Start()
    {
        welcome.SetActive(true);
        characterSelection.SetActive(false);
    }

    public void welcomeShow()
    {
        welcome.SetActive(true);
    }

    public void characterSelectionShow()
    {
        characterSelection.SetActive(true);
        welcome.SetActive(false);
    }

    public void MoveToMain_Menu()
    {
        // Reset attempts and navigate to the main menu
        StartCoroutine(LoadScene("MainMenu"));
    }

    public void TryAgainLerio()
    {
        // Reload the current scene for retrying
        StartCoroutine(LoadScene("Lerion_Scene"));
    }

    private IEnumerator LoadScene(string sceneName)
    {
        // Asynchronously load the specified scene
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
