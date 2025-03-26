using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceCanvasHTP : MonoBehaviour
{
    public GameObject welcome, LookCanvas, CongratsCanvas, GoodluckCanvas;

    // Start is called before the first frame update
    void Start()
    {
        welcome.SetActive(true);
        LookCanvas.SetActive(false);
        CongratsCanvas.SetActive(false);
        GoodluckCanvas.SetActive(false);
    }

    public void welcomeShow()
    {
        welcome.SetActive(true);
    }

    public void LookCanvasLogic()
    {
        LookCanvas.SetActive(true);
        welcome.SetActive(false);
    }

    public void DanceCanvasLogic()
    {
        LookCanvas.SetActive(false);
        welcome.SetActive(false);
        GoodluckCanvas.SetActive(true);
    }


    public void CongratsCanvasLogic()
    {
        LookCanvas.SetActive(false);
        welcome.SetActive(false);
        GoodluckCanvas.SetActive(false);
        CongratsCanvas.SetActive(true);
    }


}
