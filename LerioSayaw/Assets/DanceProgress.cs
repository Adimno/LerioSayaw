using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceProgress : MonoBehaviour
{
    public GameObject player;
    public TaskPercentage percent;
    private string music;

    private bool hasCollided = false;

    private void Awake()
    {
        // Fetch the stored music value once in Awake or Start
        music = PlayerPrefs.GetString("music");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && (other.gameObject == player))
        {
            // progress for lerion music
            if (music == "Lerion")
            {
                if (StartDance.GetGender() == "Male")
                {
                    percent.IncrementTaskPercentage(0.5025f);
                }
                else if (StartDance.GetGender() == "Female")
                {
                    percent.IncrementTaskPercentage(0.3731f);
                }

            }

            if (music == "Carinosa")
            {
                if (StartDance.GetGender() == "Male")
                {
                    percent.IncrementTaskPercentage(1.0204f);
                }
                else if (StartDance.GetGender() == "Female")
                {
                    percent.IncrementTaskPercentage(1.06383f);
                }

            }

            hasCollided = true;
        }
    }
}
