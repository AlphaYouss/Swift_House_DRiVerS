using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class LoadScript : MonoBehaviour
{

    public RawImage image;
    public float timeLeft = 5;


    // Use this for initialization
    void Start()
    {
        image = image.GetComponent<RawImage>();
    }

    int temp = 1;

    // Update is called once per frame
    void Update()
    {
        image.transform.Rotate(Vector3.back, temp * Time.deltaTime);
        if (temp != 5000)
        {
            temp++;
        }
        if (temp == 500)
        {
            SceneManager.LoadScene(5);
        }
    }
}
