using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalPoints : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private double points = 0;
    public int pointsMultiplier = 1; // Default multiplier is 1x
    public GameObject Steps, GameOver;
    public GameObject GameOverImage, YouWinImage;

    void Update()
    {
        // Update the TextMeshPro text with points value
        textMeshPro.text = "Score: " + points + " pts";
    }

    // Property to get the points value
    public double Points
    {
        get { return points; }
    }

    // Function to increment points by a specified value
    public void IncrementPoints(double incrementValue)
    {
        points += incrementValue * pointsMultiplier; // Apply multiplier
    }

    // Function to decrement points by a specified value
    public void DecrementPoints(double decrementValue)
    {
        points -= decrementValue;
        if (points < 0)
        {
            points = 0;
            Steps.SetActive(false);
            GameOver.SetActive(true);
            GameOverImage.SetActive(true);
            YouWinImage.SetActive(false);
        }
    }
}
