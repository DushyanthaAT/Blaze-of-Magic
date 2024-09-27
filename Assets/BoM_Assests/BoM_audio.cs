using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoM_audio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip running;
    public AudioClip jumping;
    public AudioClip footstep;

    void footsound()
    {
        source.clip = footstep;
        source.Play();
    }
    void runsound()
    {
        source.clip = running;
        source.Play();
    }
    void jumpsound()
    {
        source.clip = jumping;
        source.Play();
    }
}
