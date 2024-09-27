using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class runPlayerHealth : MonoBehaviour
{

    public int health;
    public Slider slider;
    public Text text;
    public AudioSource hitSound;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        text.text = "Health : " + health;
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Enemy")
        {
            health = health - 20;
            transform.Translate(50f * Time.deltaTime, 0, 0);
            hitSound.Play();

        }
        if (obj.gameObject.tag == "EnemyLeft")
        {
            health = health - 20;
            transform.Translate(50f * Time.deltaTime, 0, 0);
            hitSound.Play();

        }
        if (obj.gameObject.tag == "EnemyRight")
        {
            health = health - 20;
            transform.Translate(-50f * Time.deltaTime, 0, 0);
            hitSound.Play();

        }
    }
}
