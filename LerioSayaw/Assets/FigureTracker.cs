using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FigureTracker : MonoBehaviour
{
    public static int figureCount = 0; // Tracks how many times the script is called
    public TextMeshProUGUI progressText; // Assign a UI Text element in Inspector
    private int totalFigures = 6; // Total number of steps

    public void UpdateProgress()
    {
        figureCount++;
        progressText.text = figureCount + "/" + totalFigures;
        Debug.Log("Figure called: " + figureCount + "/" + totalFigures);
    }
}
