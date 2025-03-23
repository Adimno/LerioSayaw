using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class LerionPerformanceManager : MonoBehaviour
{
    public Button startButton;  
    public Button startButton2;  
    public TextMeshProUGUI resultText;
    public GameObject womanObject;
    public GameObject manObject;

    private float timer = 0f;
    private float maxTime = 307f;
    private List<float> triggerPoints;
    private bool[] hasTriggered;
    private bool isTimerRunning = false;

    void Start()
    {
        triggerPoints = new List<float>
        {
            50f,  
            85f,   
            125f,   
            169f,
            210f,
            256f
        };

        hasTriggered = new bool[triggerPoints.Count];
        for (int i = 0; i < hasTriggered.Length; i++)
        {
            hasTriggered[i] = false;
        }

        if (startButton != null)
        {
            startButton.onClick.AddListener(StartTimer);
        }
        else
        {
            Debug.LogError("Start button reference is missing! Please assign it in the Inspector.");
        }

        if (startButton2 != null)
        {
            startButton2.onClick.AddListener(StartTimer);
        }
        else
        {
            Debug.LogError("Start button 2 reference is missing! Please assign it in the Inspector.");
        }

        if (resultText == null)
        {
            Debug.LogError("TextMeshPro text reference is missing! Please assign it in the Inspector.");
        }
        else
        {
            resultText.text = "Choose to begin!";
        }
    }

    public void StartTimer()
    {
        if (!isTimerRunning)
        {
            isTimerRunning = true;
            timer = 0f;

            for (int i = 0; i < hasTriggered.Length; i++)
            {
                hasTriggered[i] = false;
            }

            if (resultText != null)
            {
                resultText.text = "...";
            }

            Debug.Log("Performance Timer Started - Will run for " + maxTime + " seconds");

            if (startButton != null)
            {
                startButton.interactable = false;
            }
            if (startButton2 != null)
            {
                startButton2.interactable = false;
            }
        }
    }

    void Update()
    {

        if (!isTimerRunning) return;

        timer += Time.deltaTime;

        if (timer >= maxTime)
        {
            Debug.Log("Performance Timer Complete!");
            isTimerRunning = false;

            if (resultText != null)
            {
                resultText.text = "Complete!";
            }

            if (startButton != null)
            {
                startButton.interactable = true;
            }
            if (startButton2 != null)
            {
                startButton2.interactable = true;
            }
            return;
        }

        CheckTriggerPoints();
    }

    private void CheckTriggerPoints()
    {
        for (int i = 0; i < triggerPoints.Count; i++)
        {

            if (timer >= triggerPoints[i] && !hasTriggered[i])
            {

                hasTriggered[i] = true;

                bool isCorrect = Random.Range(0f, 1f) <= 0.6f;
                int figureNumber = i + 1;

                if (isCorrect)
                {
                    if (!womanObject.activeSelf)
                    {
                        string prefKey = "woman_lerion_figure" + figureNumber;
                        PlayerPrefs.SetString(prefKey, "correct");
                        PlayerPrefs.Save();


                        if (resultText != null)
                        {
                            resultText.text = "CORRECT - Figure " + figureNumber;
                            resultText.color = Color.green;
                        }

                        Debug.Log("Timer: " + FormatTime(timer) + " - correct (Saved to " + prefKey + ")");
                    }

                    if (!manObject.activeSelf)
                    {
                        string prefKey = "man_lerion_figure" + figureNumber;
                        PlayerPrefs.SetString(prefKey, "correct");
                        PlayerPrefs.Save();


                        if (resultText != null)
                        {
                            resultText.text = "CORRECT - Figure " + figureNumber;
                            resultText.color = Color.green;
                        }

                        Debug.Log("Timer: " + FormatTime(timer) + " - correct (Saved to " + prefKey + ")");
                    }
                }
                else
                {

                    if (resultText != null)
                    {
                        resultText.text = "WRONG";
                        resultText.color = Color.red;
                    }

                    Debug.Log("Timer: " + FormatTime(timer) + " - wrong (Not saved)");
                }

                StartCoroutine(ClearResultTextAfterDelay(2f));
            }
        }
    }

    private IEnumerator ClearResultTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (isTimerRunning && resultText != null)
        {
            resultText.text = "...";
            resultText.color = Color.white;
        }
    }

    private string FormatTime(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds / 60f);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60f);
        return string.Format("{0}:{1:00}", minutes, seconds);
    }
}