using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    // Update is called once per frame
    void Update()
    {
        
    }
}
