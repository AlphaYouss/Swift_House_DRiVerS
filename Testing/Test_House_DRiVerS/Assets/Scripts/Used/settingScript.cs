using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SettingScript : MonoBehaviour {

    public Canvas ControlsCanvas;
    public Canvas resolutionCanvas;
    public Canvas audioCanvas;
    public Button back;

    public RawImage keyboardWASD;
    public RawImage keyboardArrows;

    public Dropdown dropdownKeyCon;
    public Dropdown holdsKey;
    public Dropdown holdsCont;
    public bool fullScreen;

    // Use this for initialization
    void Start () {
        back = back.GetComponent<Button>();
        ControlsCanvas = ControlsCanvas.GetComponent<Canvas>();
        audioCanvas = audioCanvas.GetComponent<Canvas>();
        resolutionCanvas = resolutionCanvas.GetComponent<Canvas>();

        keyboardArrows = keyboardArrows.GetComponent<RawImage>();
        keyboardWASD = keyboardWASD.GetComponent<RawImage>();

        dropdownKeyCon = dropdownKeyCon.GetComponent<Dropdown>();
        holdsKey = holdsKey.GetComponent<Dropdown>();
        holdsCont = holdsCont.GetComponent<Dropdown>();

        holdsCont.enabled = false;
        holdsCont.enabled = false;

        keyboardWASD.enabled = true;
        keyboardArrows.enabled = false;

        ControlsCanvas.enabled = false;
        ControlsCanvas.enabled = false;
        resolutionCanvas.enabled = false;
        audioCanvas.enabled = false;
        audioCanvas.enabled = false;
        fullScreen = Screen.fullScreen;
    }



    public void Changecontkey()
    {
        switch (dropdownKeyCon.value)
        {
            case 0:
                holdsCont.Show();
                holdsKey.Hide();
                break;
            case 1:
                holdsCont.Hide();
                holdsKey.Show();
                break;
        }
    }

    public void HoldsCont()
    {
        switch (holdsCont.value)
        {
            case 0:
                Debug.Log("grip");
                break;
            case 1:
                Debug.Log("claw");
                break;
        }
    }

    public void HoldsKey()
    {
        switch (holdsKey.value)
        {
            case 0:
                keyboardWASD.enabled = true;
                keyboardArrows.enabled = false;
                break;
            case 1:
                keyboardArrows.enabled = true;
                keyboardWASD.enabled = false;
                break;
        }
    }



    public void Resolution()
    {
        resolutionCanvas.enabled = true;
        ControlsCanvas.enabled = false;
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
   
    public void Controls()
    {
        resolutionCanvas.enabled = false;
        audioCanvas.enabled = false;
        ControlsCanvas.enabled = true;
    }

    public void Audio()
    {
        resolutionCanvas.enabled = false;
        ControlsCanvas.enabled = false;
        audioCanvas.enabled = true;
    }

    public void BackToResolution()
    {
        SceneManager.LoadScene(1);
    }

	public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayAudio()
    {
        AudioListener.volume = 1f;
    }

    public void MuteAudio()
    {
        AudioListener.volume = 0f;
    }

    public void ChangeAudio(float newValue)
    {
        AudioListener.volume = newValue;
    }
}
