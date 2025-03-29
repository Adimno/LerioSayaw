using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotationMonitor : MonoBehaviour
{
    public GameObject cameraHead;
    public AudioSource audioSource;

     void Start(){
      this.enabled = false; // Disable this script
     }
    void Update()
    {
        float yRotation = cameraHead.transform.rotation.eulerAngles.y;

        // If looking backward (160° to 200°), play the audio and disable the script
        if (yRotation >= 160f && yRotation <= 200f)
        {
            Debug.Log("Player is looking backward!");
            audioSource.Play();
            this.enabled = false; // Disable this script
        }
    }
}
