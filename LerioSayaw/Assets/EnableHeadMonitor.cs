using UnityEngine;

public class EnableHeadMonitor : MonoBehaviour
{
    public HeadRotationMonitor headRotationMonitor;

    private void OnTriggerEnter(Collider other)
    {
        headRotationMonitor.enabled = true;
        Debug.Log("HeadRotationMonitor reactivated by " + other.gameObject.name);
    }
}