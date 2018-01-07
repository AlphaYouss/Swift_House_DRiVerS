using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControls : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;

    void Start()
    {
        cam1 = cam1.GetComponent<Camera>();
        cam2 = cam2.GetComponent<Camera>();
        cam3 = cam3.GetComponent<Camera>();
        cam4 = cam4.GetComponent<Camera>();

        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            cam1.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            cam1.enabled = false;
            cam2.enabled = true;
            cam3.enabled = false;
            cam4.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = true;
            cam4.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = true;
        }
    }
}
