using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class runCrash : MonoBehaviour
{
    public GameObject stone;
    public AudioSource collectSound;
    //int no = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            collectSound.Play();

            other.GetComponent<runcharacter>().points++;
            Destroy(gameObject);
        }
    }
}
