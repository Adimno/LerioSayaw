using UnityEngine;
using TMPro;

public class FigureTrackerCarinosa : MonoBehaviour
{
    public static int figureCount = 0; // Tracks how many times the script is called (Global)
    public TextMeshProUGUI progressText; // Assign a UI Text element in Inspector
    private int totalFigures = 8; // Total number of steps

    // Update Progress - This is now a global update method
    public static void UpdateProgress()
    {
        figureCount++;
        // Update progress text from the global variable
        if (Instance != null && Instance.progressText != null)
        {
            Instance.progressText.text = figureCount + "/" + Instance.totalFigures;
        }
        Debug.Log("Figure called: " + figureCount + "/" + Instance.totalFigures);
    }

    // Singleton pattern to ensure you only have one instance
    private static FigureTrackerCarinosa Instance;

    private void Awake()
    {
        Instance = this; // Ensure this instance is accessible globally
    }
}
