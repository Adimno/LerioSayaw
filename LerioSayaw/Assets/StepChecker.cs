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
    public ErrorCounter counter;
    private bool hasTriggered = false; // Ensures actions run only once
    public GameObject perfect, great, miss;

    void Start()
    {
        perfect.SetActive(false);
        great.SetActive(false);
        miss.SetActive(false);
    }

    //void Update()
    //{
    //    CheckStepStatus();
    //}

    //void CheckStepStatus()
    //{
    //    int trueCount = 0;
    //    int falseCount = 0;

    //    // Count true and false values
    //    foreach (bool value in boolArray)
    //    {
    //        if (value) trueCount++;
    //        else falseCount++;
    //    }

    //    if (trueCount == boolArray.Length && !hasTriggered)
    //    {
    //        // All true
    //        Debug.Log("NICE");
    //        points.IncrementPoints(1);
    //        perfectAudio.Play();
    //        hasTriggered = true;
    //    }
    //    else if (falseCount == boolArray.Length)
    //    {
    //        // All false
    //        hasTriggered = false; // Reset to allow triggering again
    //    }
    //    else
    //    {
    //        // At least one true but not all
    //        Debug.Log("At least one step is correct.");
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == wrongDetector)
        {
            int trueCount = 0;
            int falseCount = 0;

            foreach (bool value in boolArray)
            {
                if (value) trueCount++;
                else falseCount++;
            }

            if (falseCount == boolArray.Length)
            {
                // All false
                perfect.SetActive(false);
                great.SetActive(false);
                miss.SetActive(true);

                missAudio.Play();
                counter.Increment();
            }
            else if (trueCount == boolArray.Length)
            {
                // All true
                points.IncrementPoints(1);
                perfect.SetActive(true);
                great.SetActive(false);
                miss.SetActive(false);

                perfectAudio.Play();
                counter.Reset();
            }
            else
            {
                // At least one true
                perfect.SetActive(false);
                great.SetActive(true);
                miss.SetActive(false);

                greatAudio.Play();
                Debug.Log("Some steps are correct, but not all.");
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
