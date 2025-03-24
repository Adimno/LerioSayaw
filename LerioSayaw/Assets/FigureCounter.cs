using UnityEngine;
using TMPro;

public class FigureCounter : MonoBehaviour
{
    public TextMeshProUGUI displayText; // Assign a UI Text element in the Inspector

    // Assign the player GameObject and step GameObjects in the Unity Inspector
    public GameObject player;
    public GameObject step1;
    public GameObject step52;
    public GameObject step106;
    public GameObject step142;
    public GameObject step178;
    // public GameObject step215;


    private string[] wallMessages =
    {
        "Figure 1: LIBAD",
        "Figure 2: KUNDAY",
        "Figure 3: KATOK",
        "Figure 4: STEP SWING/KAMAYAN",
        "Figure 5: KAWIT",
        "Figure 6: LABAS PASOK",
    };

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player) // Check if the colliding object is the assigned player
        {
            Debug.Log("Player collided with " + gameObject.name);

            if (gameObject == step1) displayText.text = wallMessages[0];
            else if (gameObject == step52) displayText.text = wallMessages[1];
            else if (gameObject == step106) displayText.text = wallMessages[2];
            else if (gameObject == step142) displayText.text = wallMessages[3];
            else if (gameObject == step178) displayText.text = wallMessages[4];
            // else if (gameObject == step215) displayText.text = wallMessages[5];
        }
    }


}
