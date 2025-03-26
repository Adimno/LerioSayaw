using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsCheckerTutorial : MonoBehaviour
{
        public bool[] boolArray = new bool[3] { false, false, false };

    public AudioSource perfectAudio, greatAudio, missAudio;
    public GameObject wrongDetector;
    private bool hasTriggered = false; // Ensures actions run only once
    public GameObject perfect, great, miss;

    void Start()
    {
        perfect.SetActive(false);
        great.SetActive(false);
        miss.SetActive(false);
    }

 
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
            }
            else if (trueCount == boolArray.Length)
            {
                // All true
                perfect.SetActive(true);
                great.SetActive(false);
                miss.SetActive(false);

                perfectAudio.Play();
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
