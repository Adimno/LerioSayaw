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
    private bool[] previousState;
    //private string lastState = "";

    void Start()
    {
        previousState = (bool[])boolArray.Clone();
    }

    void Update()
    {
        if (HasArrayChanged())
        {
            CheckAllTrue();
            Array.Copy(boolArray, previousState, boolArray.Length);
        }
    }

    bool HasArrayChanged()
    {
        for (int i = 0; i < boolArray.Length; i++)
        {
            if (boolArray[i] != previousState[i])
                return true;
        }
        return false;
    }

    void CheckAllTrue()
    {
        bool allTrue = Array.TrueForAll(boolArray, element => element);
        bool atLeastOneTrue = Array.Exists(boolArray, element => element);

        if (allTrue && !hasTriggered)
        {
            Debug.Log("NICE");
            points.IncrementPoints(1);
            perfectAudio.Play();

            // Activate "Perfect" UI
            perfect.SetActive(true);
            great.SetActive(false);
            miss.SetActive(false);

            hasTriggered = true; // Prevent future triggers
            //lastState = "perfect";

            // Start coroutine to disable after 1 second
            StartCoroutine(DisablePerfectAfterDelay(1f));
        }
    }

    IEnumerator DisablePerfectAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        perfect.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == wrongDetector)
        {
            if (Array.Exists(boolArray, element => element == false))
            {
                counter.Increment();
                //indicator.ShowWrong();
            }
            else
            {
                counter.Reset();
                //indicator.ShowPerfect();
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
