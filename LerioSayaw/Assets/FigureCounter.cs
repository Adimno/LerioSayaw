using UnityEngine;
using TMPro;

public class FigureCounter : MonoBehaviour
{
    public TextMeshProUGUI displayText; // Assign a UI Text element in the Inspector
    
    public GameObject player;
    public GameObject[] steps; // Assign in order: step1, step52, step106, step142, step178, step215

    private string[] wallMessages =
    {
        "Figure 1: LIBAD",
        "Figure 2: KUNDAY",
        "Figure 3: KATOK",
        "Figure 4: STEP SWING/KAMAYAN",
        "Figure 5: KAWIT",
        "Figure 6: LABAS PASOK",
    };

    private int currentStep = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            for (int i = 0; i < steps.Length; i++)
            {
                if (gameObject == steps[i])
                {
                    currentStep = i + 1; // Track progress (1-based index)
                    displayText.text = wallMessages[i];
                    Debug.Log("Player reached step " + currentStep);
                    FindObjectOfType<FigureTracker>().UpdateProgress(); // Call progress update
                    break;
                }
            }
        }
    }
}
