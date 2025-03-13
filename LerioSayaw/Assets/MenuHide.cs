using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHide : MonoBehaviour
{
    public GameObject ShowCanvas;
    public GameObject MainMenu;


    void Start()
    {
        ShowCanvas.SetActive(false);
    }


    public void ShowNextCanvas()
    {
        if (ShowCanvas != null)
        {
            MainMenu.SetActive(false);
            ShowCanvas.SetActive(true);
        }
    }

    
    public void MainCanvas()
    {
        if (MainMenu != null)
        {
            MainMenu.SetActive(true);
            ShowCanvas.SetActive(false);
        }
    }
}
