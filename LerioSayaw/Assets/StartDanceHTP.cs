using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDanceHTP : MonoBehaviour
{
   public GameObject Steps;
    public GameObject ParentGameObject;
   public GameObject Male;

   public GameObject Female;
    public AudioSource music;


    // Start is called before the first frame update
    public void Tutorial()
    {
        Steps.SetActive(true);
        ParentGameObject.SetActive(true);
        music.Play();
    }

      public void MaleFunction()
    {
        Steps.SetActive(true);
        Male.SetActive(true);
        ParentGameObject.SetActive(true);
        music.Play();
    }

    
      public void FemaleFunction()
    {
        Steps.SetActive(true);
        Female.SetActive(true);
        ParentGameObject.SetActive(true);
        music.Play();
    }


}
