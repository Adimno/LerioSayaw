using UnityEngine;

public class SpeedController : MonoBehaviour
{
    public float speed = 1.0f; // Default speed value

    // Getter and Setter for the speed variable
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }
}
