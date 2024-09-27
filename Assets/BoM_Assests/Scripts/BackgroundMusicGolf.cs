using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicGolf : MonoBehaviour
{
    public AudioSource backgroundAudio;
    void Start()
    {
        backgroundAudio.Play();
    }

}
