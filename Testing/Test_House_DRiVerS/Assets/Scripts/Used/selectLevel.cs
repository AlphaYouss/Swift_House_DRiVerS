using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectLevel : MonoBehaviour {

    public Button GoButton;
    public Button generalTrack;
    public Button back;
    public Canvas infotrack;
    public Text text;
    public Color color;



    // Use this for initialization
    void Start () {
        back = back.GetComponent<Button>();
        generalTrack = generalTrack.GetComponent<Button>();
        infotrack = infotrack.GetComponent<Canvas>();
        GoButton = GoButton.GetComponent<Button>();

        infotrack.enabled = false;
        GoButton.interactable = false;
    }

    public void SelectMap()
    {
        infotrack.enabled = true;
        generalTrack.interactable = false;
        if (infotrack.enabled)
        {
            GoButton.interactable = true;
        }
    }

    public void Go()
    {
        SceneManager.LoadScene(5);
    }

    public void BackSelectMap()
    {
        SceneManager.LoadScene(1);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
