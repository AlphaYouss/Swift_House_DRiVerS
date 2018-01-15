using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    public Camera MainCamera;
    public Camera RightCamera;
    public Camera LeftCamera;
    public Camera BumperCamera;

    void Start()
    {
        MainCamera = MainCamera.GetComponent<Camera>();
        RightCamera = RightCamera.GetComponent<Camera>();
        LeftCamera = LeftCamera.GetComponent<Camera>();
        BumperCamera = BumperCamera.GetComponent<Camera>();

        MainCamera.enabled = true;
        RightCamera.enabled = false;
        LeftCamera.enabled = false;
        BumperCamera.enabled = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            MainCamera.enabled = true;
            RightCamera.enabled = false;
            LeftCamera.enabled = false;
            BumperCamera.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            MainCamera.enabled = false;
            RightCamera.enabled = true;
            LeftCamera.enabled = false;
            BumperCamera.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            MainCamera.enabled = false;
            RightCamera.enabled = false;
            LeftCamera.enabled = true;
            BumperCamera.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            MainCamera.enabled = false;
            RightCamera.enabled = false;
            LeftCamera.enabled = false;
            BumperCamera.enabled = true;
        }
    }
}
