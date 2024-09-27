using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monsterplayer : MonoBehaviour
{
    public static int points;
    public static int die_count;

    public GameObject ScoreText;
    public GameObject diecounting;


    public AudioSource zombiesounds;

    // Start is called before the first frame update
    void Start()
    {

        BoM_CharacterController.taskNumber = 1;
        if (transform.position.z <= 115 && transform.position.z>=-25)
        {
            zombiesounds.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Monsterplayerhealth.finalpoints = points;
        ScoreText.GetComponent<Text>().text = points.ToString();
        diecounting.GetComponent<Text>().text = die_count.ToString();
    }
}
