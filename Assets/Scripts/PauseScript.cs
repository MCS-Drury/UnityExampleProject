using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public Canvas pauseCanvas;
    private bool paused;

    private void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if(paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
        pauseCanvas.enabled = true;
        paused = true;
    }

    private void Resume()
    {
        Time.timeScale = 1;
        pauseCanvas.enabled = false;
        paused = false;
    }
}
