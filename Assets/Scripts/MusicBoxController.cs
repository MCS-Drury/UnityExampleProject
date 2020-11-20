using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxController : MonoBehaviour
{
    public AudioClip music;
    private bool isMusicPlaying;
    private bool inTrigger;
    public Canvas triggerCanvas;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = music;
        isMusicPlaying = false;
        inTrigger = false;
    }

    //Play sound whenever collision is detected 
    void OnTriggerEnter2D(Collider2D col)
    {
        inTrigger = true;
        triggerCanvas.enabled = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        inTrigger = false;
        triggerCanvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && inTrigger)
        {
            Debug.Log("here");
            if (!isMusicPlaying)
            {
                GetComponent<AudioSource>().Play();
                isMusicPlaying = true;
            }
            else
            {
                GetComponent<AudioSource>().Stop();
                isMusicPlaying = false;
            }
        }
    }
}
