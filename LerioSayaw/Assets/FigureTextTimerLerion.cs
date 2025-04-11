using UnityEngine;
using UnityEngine.UI;

public class FigureTextTimerLerion : MonoBehaviour
{
    public Text figureText;

    private float timer = 0f;

    private (float time, string text)[] figureSteps = new (float, string)[]
    {
        (1f, "Figure 1 - Libad"),
        (43f, "Figure 2 - Kunday"),
        (86f, "Figure 3 - Katok"),
        (130f, "Figure 4 - Step Swing / Kamayan"),
        (169f, "Figure 5 - Kawit"),
        (211f, "Figure 6 - Labas Pasok")
    };

    private int currentIndex = 0;

    void Start()
    {
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
