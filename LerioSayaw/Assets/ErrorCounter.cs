using UnityEngine;

public class ErrorCounter : MonoBehaviour
{
    public int counter { get; private set; }
    public GameObject ResultCanvas;
    public GameObject Steps;
    public AudioSource GameOver;
    public TotalPoints points;

    public void Increment()
    {
        counter++;
        if (counter == 5)
        {
            points.DecrementPoints(2);
        }
        else if (counter == 10)
        {
            if (!GameOver.isPlaying) // Check if the sound isn't already playing
            {
                GameOver.Play();
            }
            
            ResultCanvas.SetActive(true);
            Steps.SetActive(false);
        }
    }


    public void Reset()
    {
        counter = 0;
    }
}
