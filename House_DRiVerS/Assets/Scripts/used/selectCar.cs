using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selectCar : MonoBehaviour {

    public RawImage image;
    public Button ravensButton;
    public Button dragonsButton;
    public Button serpentsButton;
    public Button vikingsButton;

    public Button back;

	// Use this for initialization
	void Start () {
        ravensButton = ravensButton.GetComponent<Button>();
        dragonsButton = dragonsButton.GetComponent<Button>();
        serpentsButton = serpentsButton.GetComponent<Button>();
        vikingsButton = vikingsButton.GetComponent<Button>();

        back = back.GetComponent<Button>();
    }

    public void SelectCar()
    {

    }

    public void Back()
    {
        SceneManager.LoadScene(1);
    }


}
