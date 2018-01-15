using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class finishButtons : MonoBehaviour {

   
	public void loadMainMenu(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void loadAnotherRace(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
