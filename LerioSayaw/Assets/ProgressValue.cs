using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProgressValue : MonoBehaviour
{
    public TaskPercentage progress;
    public TextMeshProUGUI textMeshPro;

    void Update()
    {
        // Update the TextMeshPro text with points value
        textMeshPro.text = Mathf.RoundToInt(progress.TaskPercentageValue) + "%";
    }
}
