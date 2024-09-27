using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class monsterEnemyScript : MonoBehaviour
{
    public float health = 25f;

    private Animator animater;

    public static bool dieing = false;

    

    

    private void start()
    {
        animater = GetComponent<Animator>();
    }

    public void TakeDamage(float damageAmount)
    {
        //health = health - damageAmount;
        health -= damageAmount;

        if (health <= 0f)
        {
            health = 0f;

            Die();
        }
        if (health == 0f)
        {
            monsterplayer.die_count++;
        }
    }

    private void Die()
    {
        
        Destroy(this.gameObject, 0.5f);
        //dieing = true;
        

        //animater.SetTrigger("Die");
        //Destroy(this.gameObject,3f);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
