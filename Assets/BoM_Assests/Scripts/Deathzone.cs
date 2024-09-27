using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    public Transform spawnPoint;
    //public AudioClip portalSound;
    public AudioSource audioSource;
    void OnTriggerEnter(Collider other)
    {
        //audioSource.PlayOneShot(portalSound);
        other.gameObject.transform.position = spawnPoint.position;
       
           // if (other.tag == "Portal")
           // {
                audioSource.Play();
          //  }
        
    }
  
}
