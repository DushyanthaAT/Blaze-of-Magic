using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class runCollectScript : MonoBehaviour
{
    public GameObject ScoreText;
    public AudioSource collectSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,90 * Time.deltaTime, 0);
        //ScoreText.GetComponent<Text>().text = "Score : " + GetComponent<caractercntrol>().points;
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
