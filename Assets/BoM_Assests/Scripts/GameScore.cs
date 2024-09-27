using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    public Text myText;
    public Text winText;
    public Text passfail;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public static int sendscore;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //myText.text = "OKK";
        //myText.text =sendscore;
        //myText.text = "Score: " + sendscore.ToString() + " / 20";
        if (sendscore <= 20)
        {
            image1.SetActive(true);
            image2.SetActive(true);
            image3.SetActive(true);
            audioSource.Play();

        }
        else if (sendscore >= 20 && sendscore <= 30)
        {
            image1.SetActive(true);
            image2.SetActive(true);
            audioSource.Play();

        }
        else if (sendscore >= 31 && sendscore <= 50)
        {
            image1.SetActive(true);
            audioSource.Play();
        }
        else
        {
            image4.SetActive(true);
            winText.text = "GameOver";
        }
    }
}