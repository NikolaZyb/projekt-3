using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool paused = false;
    public GameObject PMCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused == true)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }

    void Stop()
    {
        PMCanvas.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }
    public void Play()
    {
        PMCanvas.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }
}
