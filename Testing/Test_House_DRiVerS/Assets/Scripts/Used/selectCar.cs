using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectCar : MonoBehaviour {

    public RawImage ravensImage;
    public RawImage dragonsImage;
    public RawImage SerptentsImage;
    public RawImage VikingsImage;

    public Canvas trackInfo;
    public Button goButton;
    public Button back;

	// Use this for initialization
	void Start () {
        goButton.interactable = false;
        trackInfo.enabled = false;

        ravensImage.enabled = false;
        dragonsImage.enabled = false;
        SerptentsImage.enabled = false;
        VikingsImage.enabled = false;

        back = back.GetComponent<Button>();
    }

    public void SelectRavens()
    {
        PlayerPrefs.SetString("car", "ravens");
        goButton.interactable = true;
        trackInfo.enabled = true;
        ravensImage.enabled = true;
        dragonsImage.enabled = false;
        SerptentsImage.enabled = false;
        VikingsImage.enabled = false;
    }

    public void SelectDragons()
    {
        PlayerPrefs.SetString("car", "dragons");
        goButton.interactable = true;
        trackInfo.enabled = true;
        dragonsImage.enabled = true;
        ravensImage.enabled = false;
        SerptentsImage.enabled = false;
        VikingsImage.enabled = false;
    }

    public void SelectSerpents()
    {
        PlayerPrefs.SetString("car", "serpents");
        goButton.interactable = true;
        trackInfo.enabled = true;
        SerptentsImage.enabled = true;
        ravensImage.enabled = false;
        dragonsImage.enabled = false;
        VikingsImage.enabled = false;
    }

    public void SelectVikings()
    {
        PlayerPrefs.SetString("car", "vikings");
        goButton.interactable = true;
        trackInfo.enabled = true;
        VikingsImage.enabled = true;
        ravensImage.enabled = false;
        dragonsImage.enabled = false;
        SerptentsImage.enabled = false;
    }

    public void Go()
    {
        SceneManager.LoadScene(5);
        SceneManager.UnloadSceneAsync(5);
        SceneManager.LoadScene(5);
    }

    public void BackSelectCar()
    {
        SceneManager.LoadScene(3);
    }

    public void Back()
    {
        SceneManager.LoadScene(2);
    }


}
