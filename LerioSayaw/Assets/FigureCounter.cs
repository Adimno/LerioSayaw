using UnityEngine;
using TMPro;

public class FigureCounter : MonoBehaviour
{
    public TextMeshProUGUI displayText; // Assign in the Inspector
    public GameObject player;
    public GameObject[] steps; // Assign step GameObjects here

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
    private bool hasBeenTriggered = false; // <-- Prevent double-trigger

    private void OnTriggerEnter(Collider other)
    {
        if (hasBeenTriggered) return; // Avoid multiple triggers

        if (other.gameObject == player)
        {
            for (int i = 0; i < steps.Length; i++)
            {
                if (gameObject == steps[i])
                {
                    Debug.Log("Triggered by: " + gameObject.name);
                    currentStep = i + 1; // 1-based index
                    displayText.text = wallMessages[i];
                    Debug.Log("Player reached step " + currentStep);
                    FindObjectOfType<FigureTracker>().UpdateProgress();
                    hasBeenTriggered = true; // Mark this step as triggered
                    break;
                }
            }
        }
    }
}
