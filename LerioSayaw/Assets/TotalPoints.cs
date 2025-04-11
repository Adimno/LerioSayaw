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
    private string music;
    public GameObject gold, silver, bronze;
    public AudioSource GameoverSound;
    public AudioSource music1, music2;
    private void Awake()
    {
        // Fetch the stored music value once in Awake or Start
        music = PlayerPrefs.GetString("music");
    }

    void Update()
    {
        // Update the TextMeshPro text with points value
        textMeshPro.text = "Score: " + points + " pts";

        if (music == "Lerion")
        {
            if (StartDance.GetGender() == "Male")
            {
                if(points >= 0 && points <= 300)
                {
                    gold.SetActive(false);
                    silver.SetActive(false);
                    bronze.SetActive(true);
                } else if(points >= 301 && points <= 500)
                {
                    gold.SetActive(false);
                    silver.SetActive(true);
                    bronze.SetActive(false);
                } else if (points >= 501 && points <= 617)
                {
                    gold.SetActive(true);
                    silver.SetActive(false);
                    bronze.SetActive(false);
                }

            }
            else if (StartDance.GetGender() == "Female")
            {
                if (points >= 0 && points <= 400)
                {
                    gold.SetActive(false);
                    silver.SetActive(false);
                    bronze.SetActive(true);
                }
                else if (points >= 401 && points <= 650)
                {
                    gold.SetActive(false);
                    silver.SetActive(true);
                    bronze.SetActive(false);
                }
                else if (points >= 651 && points <= 825)
                {
                    gold.SetActive(true);
                    silver.SetActive(false);
                    bronze.SetActive(false);
                }
            }

        }

        if (music == "Carinosa")
        {
            if (StartDance.GetGender() == "Male")
            {
                if (points >= 0 && points <= 140)
                {
                    gold.SetActive(false);
                    silver.SetActive(false);
                    bronze.SetActive(true);
                }
                else if (points >= 141 && points <= 240)
                {
                    gold.SetActive(false);
                    silver.SetActive(true);
                    bronze.SetActive(false);
                }
                else if (points >= 241 && points <= 315)
                {
                    gold.SetActive(true);
                    silver.SetActive(false);
                    bronze.SetActive(false);
                }
            }
            else if (StartDance.GetGender() == "Female")
            {
                if (points >= 0 && points <= 140)
                {
                    gold.SetActive(false);
                    silver.SetActive(false);
                    bronze.SetActive(true);
                }
                else if (points >= 141 && points <= 230)
                {
                    gold.SetActive(false);
                    silver.SetActive(true);
                    bronze.SetActive(false);
                }
                else if (points >= 231 && points <= 304)
                {
                    gold.SetActive(true);
                    silver.SetActive(false);
                    bronze.SetActive(false);
                }
            }

        }
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
            music1.Stop();
            music2.Stop();
            GameoverSound.Play();
            Steps.SetActive(false);
            GameOver.SetActive(true);
            GameOverImage.SetActive(true);
            YouWinImage.SetActive(false);
        }
    }
}
