using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxController : MonoBehaviour
{
    public AudioClip music;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = music;
    }

    //Play sound whenever collision is detected 
    void OnCollisionEnter()
    {
        GetComponent<AudioSource>().Play();
    }
}
