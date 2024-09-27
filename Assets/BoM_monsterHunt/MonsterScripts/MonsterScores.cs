using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MonsterScores : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI myText;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject victory;
    public GameObject defeat;
    public static int sendscore;
    public AudioSource victorysong;
    void Start()
    {
        victorysong.Play();
        myText.text = "Score: " + sendscore.ToString();
        if (sendscore >= 29)
        {
            image1.SetActive(true);
            image2.SetActive(true);
            image3.SetActive(true);
            defeat.SetActive(false);
            victory.SetActive(true);
            

        }
        else if (sendscore >= 26)
        {
            image1.SetActive(true);
            image2.SetActive(true);
            defeat.SetActive(false);
            victory.SetActive(true);
            

        }
        else if (sendscore >= 22)
        {
            image1.SetActive(true);
            defeat.SetActive(false);
            victory.SetActive(true);

        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
