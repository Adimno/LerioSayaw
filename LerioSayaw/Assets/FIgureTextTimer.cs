using UnityEngine;
using UnityEngine.UI;

public class FigureTextTimer : MonoBehaviour
{
    public Text figureText; // Assign your regular UI Text component here

    private float timer = 0f;

    private (float time, string text)[] figureSteps = new (float, string)[]
    {
        (1f, "Figure 1 - Three-step and Point"),
        (20f, "Figure 2 - Touch Step"),
        (33f, "Figure 3 - Three-step Forward and Back to Back"),
        (43f, "Figure 4 - Hide and Seek with Fan"),
        (54f, "Figure 5 - Kneeling and Fanning"),
        (74f, "Figure 6 - Hide and Seek with Handkerchief"),
        (94f, "Figure 7 - Flirting with Handkerchief"),
        (108f, "Figure 8 - Flirting")
    };

    private int currentIndex = 0;
    
    void Start(){
         figureText.gameObject.SetActive(false);
        this.enabled = false;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (currentIndex < figureSteps.Length && timer >= figureSteps[currentIndex].time)
        {
            figureText.text = figureSteps[currentIndex].text;
            currentIndex++;
        }
    }
}
