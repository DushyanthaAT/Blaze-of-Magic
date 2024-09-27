using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class runfinalGameScore : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public Text winText;
    public Text passfail;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject victory;
    public GameObject defaet;
    public static int sendscore;
    public AudioSource victorysong;
    // Start is called before the first frame update
    void Start()
    {
        //myText.text = "OKK";
        //myText.text =sendscore;
        victorysong.Play();
        myText.text = "High Score: "+sendscore.ToString();
        if (sendscore >= 18)
        {
            image1.SetActive(true);
            image2.SetActive(true);
            image3.SetActive(true);
            victory.SetActive(true);
            defaet.SetActive(false);
            
        }
        else if(sendscore >= 16)
        {
            image1.SetActive(true);
            image2.SetActive(true);
            victory.SetActive(true);
            defaet.SetActive(false);

        }
        else if(sendscore >= 14)
        {
            image1.SetActive(true);
            victory.SetActive(true);
            defaet.SetActive(false);

        }
        else
        {
            winText.text = "Game Over";
            passfail.text = "You Lose the Game";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
