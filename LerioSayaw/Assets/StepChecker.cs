using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StepChecker : MonoBehaviour
{
    public bool[] boolArray = new bool[3] { false, false, false };
    public TotalPoints points;
    public AudioSource perfectAudio, greatAudio, missAudio;
    public GameObject wrongDetector;
    private bool hasTriggered = false; // Ensures actions run only once
    public GameObject perfect, great, miss;
    public ErrorCounter error;
    public CorrectCounter correct;
    //public GameObject Player;

    void Update()
    {
        CheckAllTrue();
    }


    void CheckAllTrue()
    {
        // Check if all values in boolArray are true
        bool allTrue = true;
        foreach (bool value in boolArray)
        {
            if (!value)
            {
                allTrue = false;
                break;
            }
        }

        // If all values are true and hasTriggered is false, execute the actions
        if (allTrue && !hasTriggered)
        {
            Debug.Log("NICE");


            hasTriggered = true; // Set the flag to true to prevent future triggers
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == wrongDetector)
        {
            bool allTrue = Array.TrueForAll(boolArray, element => element);
            bool anyTrue = Array.Exists(boolArray, element => element); // Checks if at least one is true

            if (allTrue)
            {
                error.Reset();
                points.IncrementPoints(2);
                perfectAudio.Play();
                perfect.SetActive(true);
                great.SetActive(false);
                miss.SetActive(false);
                correct.Increment();
            }
            else if (anyTrue) // As long as there's a true, show "great"
            {
                error.Reset();
                points.IncrementPoints(1);
                perfect.SetActive(false);
                great.SetActive(true);
                miss.SetActive(false);
                greatAudio.Play();
                correct.Increment();
            }
            else // If none are true, show "miss"
            {
                error.Increment();
                perfect.SetActive(false);
                great.SetActive(false);
                miss.SetActive(true);
                missAudio.Play();
                correct.Reset();
            }
        }
    }



    public void SetIndexTrue(int index)
    {
        if (index >= 0 && index < boolArray.Length)
        {
            boolArray[index] = true;
        }
    }
}
