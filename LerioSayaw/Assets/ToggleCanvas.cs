using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCanvas : MonoBehaviour
{
    public GameObject Quitcanvas;
    private bool isActive = false;
    private bool isScriptActive = true;
    public SpeedController speed;
    public Canvas canvas;
    public AudioSource music;

    private void Start()
    {
        Quitcanvas.SetActive(false); // Start with the Maincanvas disabled 
        canvas.enabled = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!isScriptActive)
            return;

        if (OVRInput.GetDown(OVRInput.Button.Three)) // You can replace this with the Oculus button you want to use.
        {
            isActive = !isActive; // Toggle the isActive flag
            Quitcanvas.SetActive(isActive);

            if (isActive)
            {
                Debug.Log("Quitcanvas ON");
                speed.speed = 0f;
                music.Pause();
            }
            else
            {
                Debug.Log("Quitcanvas OFF");
                speed.speed = 1f;
                music.UnPause();
            }
        }

        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            canvas.enabled = !canvas.enabled;
            Debug.Log("Canvas toggled to: " + canvas.enabled);
        }
    }

    // Function to deactivate the script
    public void DeactivateScript()
    {
        isScriptActive = false;
    }

    public void OpenCanvasAgain()
    {
        canvas.enabled = true;
    }
}
