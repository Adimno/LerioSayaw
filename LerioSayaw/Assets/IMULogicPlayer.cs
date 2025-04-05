using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMULogicPlayer : MonoBehaviour
{
    // icons
    public GameObject cameraHead;
    public GameObject lookupicon;
    public GameObject lookdownicon;
    public GameObject lookrighticon;
    public GameObject looklefticon;
    public GameObject tiltlefticon;
    public GameObject tiltrighticon;

    public DanceCanvasHTP danceCanvasHTP;

    // monitors
    public GameObject monitorLookUpDown;
    public GameObject monitorLookLeftRight;
    public GameObject monitorTiltLeftRight;

    // flag to prevent multiple triggers
    private bool allMonitorsCompleted = false;

    void Start()
    {
        // deactivate all icons
        lookupicon.SetActive(false);
        lookdownicon.SetActive(false);
        lookrighticon.SetActive(false);
        looklefticon.SetActive(false);
        tiltlefticon.SetActive(false);
        tiltrighticon.SetActive(false);

        // deactivate all monitors
        monitorLookUpDown.SetActive(false);
        monitorLookLeftRight.SetActive(false);
        monitorTiltLeftRight.SetActive(false);
    }

    void Update()
    {
        float xRotation = cameraHead.transform.rotation.eulerAngles.x;
        float yRotation = cameraHead.transform.rotation.eulerAngles.y;
        float zRotation = cameraHead.transform.rotation.eulerAngles.z;

        // PITCH
        if (xRotation >= 300f && xRotation <= 320f && !lookupicon.activeSelf)
        {
            lookupicon.SetActive(true);
        }
        else if (xRotation >= 60f && xRotation <= 75f && !lookdownicon.activeSelf)
        {
            lookdownicon.SetActive(true);
        }

        // YAW
        else if (yRotation >= 100f && yRotation <= 110f && !lookrighticon.activeSelf)
        {
            lookrighticon.SetActive(true);
        }
        else if (yRotation >= 250f && yRotation <= 260f && !looklefticon.activeSelf)
        {
            looklefticon.SetActive(true);
        }

        // ROLL
        else if (zRotation >= 70f && zRotation <= 80f && !tiltlefticon.activeSelf)
        {
            tiltlefticon.SetActive(true);
        }
        else if (zRotation >= 270f && zRotation <= 300f && !tiltrighticon.activeSelf)
        {
            tiltrighticon.SetActive(true);
        }

        // === Monitor Logic ===
        if (lookupicon.activeSelf && lookdownicon.activeSelf && !monitorLookUpDown.activeSelf)
        {
            monitorLookUpDown.SetActive(true);
        }

        if (looklefticon.activeSelf && lookrighticon.activeSelf && !monitorLookLeftRight.activeSelf)
        {
            monitorLookLeftRight.SetActive(true);
        }

        if (tiltlefticon.activeSelf && tiltrighticon.activeSelf && !monitorTiltLeftRight.activeSelf)
        {
            monitorTiltLeftRight.SetActive(true);
        }

        // === Completion Check ===
        if (!allMonitorsCompleted &&
            monitorLookUpDown.activeSelf &&
            monitorLookLeftRight.activeSelf &&
            monitorTiltLeftRight.activeSelf)
        {
            OnAllMonitorsCompleted();
            allMonitorsCompleted = true;
        }
    }

    void OnAllMonitorsCompleted()
    {
        Debug.Log("✅ All monitor tasks completed!");
        danceCanvasHTP.LookCanvasLogic();
    }
}
