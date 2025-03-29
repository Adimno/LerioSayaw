using UnityEngine;

public class CorrectCounter : MonoBehaviour
{
    public int counter { get; private set; }
    public TotalPoints points;

    public void Increment()
    {
        counter++;
        if (counter == 5)
        {
            points.IncrementPoints(5);
            Reset();
        }
    }

    public void Reset()
    {
        counter = 0;
    }
}
