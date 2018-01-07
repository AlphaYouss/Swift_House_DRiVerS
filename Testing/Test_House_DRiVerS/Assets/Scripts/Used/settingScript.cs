using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class settingScript : MonoBehaviour {

    public Canvas resolutionCanvas;
    public Canvas audioCanvas;
    public Button back;
    public Button audio;
    public Button audioBack;
    public bool fullScreen;

    // Use this for initialization
    void Start () {
        back = back.GetComponent<Button>();
        audio = audio.GetComponent<Button>();
        audioBack = audioBack.GetComponent<Button>();
        audioCanvas = audioCanvas.GetComponent<Canvas>();
        resolutionCanvas = resolutionCanvas.GetComponent<Canvas>();

        resolutionCanvas.enabled = false;
        audioCanvas.enabled = false;
        fullScreen = Screen.fullScreen;
    }

    public void Resolution()
    {
        resolutionCanvas.enabled = true;
        audioCanvas.enabled = false;
    }

    public void ChangeResolutionFullHD()
    {
        Screen.SetResolution(1920, 1080, fullScreen);
    }

    public void ChangeResolution1600()
    {
        Screen.SetResolution(1600, 900, fullScreen);
    }

    public void ChangeResolutionNotHDAtAll()
    {
        Screen.SetResolution(1366, 768, fullScreen);
    }

    public void ChangeResolutionHD()
    {
        Screen.SetResolution(1280, 720, fullScreen);
    }

    public void FullSCreen()
    {
        fullScreen = !fullScreen;
        if (fullScreen)
            Screen.SetResolution(Screen.width, Screen.height, true);
        else
            Screen.SetResolution(Screen.width, Screen.height, false);
    }
   


    public void Audio()
    {
        resolutionCanvas.enabled = false;
        audioCanvas.enabled = true;
    }

    public void BackToResolution()
    {
        SceneManager.LoadScene(4);
    }

	public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
