using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseScreen : MonoBehaviour {

    public Transform canvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);

            Time.timeScale = 0;
        }
        else
        {
            canvas.gameObject.SetActive(false);

            Time.timeScale = 1;
        }
    }

    public void TitleScreen()
    {
        Debug.Log("test " + CarController.m_Rigidbody);
        CarController.m_Rigidbody = null;
        Debug.Log("test 2" + CarController.m_Rigidbody);
        SceneManager.LoadScene(0);
    }

}
