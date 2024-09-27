using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Monsterplayerhealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 100;
    public Slider slider;
    public Text text;
    public AudioSource zombiesounds;
    public static int finalpoints;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        text.text = "Health : " + health;
        MonsterScores.sendscore = finalpoints;

        if (health == 0)
        {
            
            SceneManager.LoadScene("MonsterResults");

        }
    }
    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Enemy")
        {
            zombiesounds.Play();
            health = health - 5;
            //hitSound.Play();

        }
    }
    
 }
