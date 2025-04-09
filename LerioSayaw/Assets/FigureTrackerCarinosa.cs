using UnityEngine;
using TMPro;
public class FigureTrackerCarinosa : MonoBehaviour
{
       public static int figureCount = 0; // Tracks how many times the script is called
    public TextMeshProUGUI progressText; // Assign a UI Text element in Inspector
    private int totalFigures = 8; // Total number of steps

    public void UpdateProgress()
    {
        figureCount++;
        progressText.text = figureCount + "/" + totalFigures;
        Debug.Log("Figure called: " + figureCount + "/" + totalFigures);
    }
}
