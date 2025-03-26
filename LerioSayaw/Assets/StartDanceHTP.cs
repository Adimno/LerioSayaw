using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDanceHTP : MonoBehaviour
{
   public GameObject Steps;
    public GameObject TutorialWalls;
    public AudioSource music;


    // Start is called before the first frame update
    public void Tutorial()
    {
        Steps.SetActive(true);
        TutorialWalls.SetActive(true);
        music.Play();
    }

}
