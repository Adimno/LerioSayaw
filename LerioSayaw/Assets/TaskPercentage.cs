using UnityEngine;
using UnityEngine.UI;

public class TaskPercentage : MonoBehaviour
{
    public Slider progressSlider; // Reference to the UI Slider
    private float taskPercentage = 0;

    void Start()
    {
        UpdateSlider(); // Ensure the slider is set at the correct value initially
    }

    public float TaskPercentageValue
    {
        get { return taskPercentage; }
    }

    public void IncrementTaskPercentage(float incrementValue)
    {
        taskPercentage += incrementValue;
        taskPercentage = Mathf.Clamp(taskPercentage, 0, 100); // Keep within 0-100%
        UpdateSlider(); // Immediately update the slider value
    }

    private void UpdateSlider()
    {
        if (progressSlider != null)
        {
            progressSlider.value = taskPercentage / 100f; // Normalize to 0-1 range for the slider
        }
        else
        {
            Debug.LogWarning("Progress Slider is not assigned in the Inspector!");
        }
    }
}
