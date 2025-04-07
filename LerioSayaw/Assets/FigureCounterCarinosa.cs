using UnityEngine;
using TMPro;

public class FigureCounterCarinosa : MonoBehaviour
{
       public TextMeshProUGUI displayText; // Assign in the Inspector
    public GameObject player;
    public GameObject[] steps; // Assign step GameObjects here

    private string[] wallMessages =
    {
        "Figure 1: Three-step and Point ",
        "Figure 2: Touch Step",
        "Figure 3: Three-step Forward and Back to Back",
        "Figure 4: Hide and Seek with Fan",
        "Figure 5: Kneeling and Fanning",
        "Figure 6: Hide and Seek with Handkerchief",
        "Figure 7: Flirting with Handkerchief ",
        "Figure 8: Flirting",
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
