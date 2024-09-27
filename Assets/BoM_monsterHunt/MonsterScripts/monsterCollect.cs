using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterCollect : MonoBehaviour
{

    public GameObject ScoreText;
    public AudioSource collectSound;
    public GameObject collecttext;
    public GameObject anima;

    public Transform target;
    public float chaseRange = 10f;
    public float distanceToTarget = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
        collecttext.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 90 * Time.deltaTime, 0);
        collecttext.gameObject.SetActive(false);

        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= chaseRange)
        {

            collecttext.gameObject.SetActive(true);
            Debug.Log("Ok");
            
            if (Input.GetKey(KeyCode.F))
            {
                collectSound.Play();
                monsterplayer.points++;
                Destroy(gameObject);
                collecttext.gameObject.SetActive(false);
                anima.gameObject.SetActive(false);
                
                
            }
        }
        else
        {
            //collecttext.gameObject.SetActive(false);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

    private void OnTriggerEnter(Collider other)
    {
       // collecttext.gameObject.SetActive(true);

        //Destroy(gameObject);
        /*if (other.gameObject.tag == "GamePlayer")
        {
            collectSound.Play();

            //other.GetComponent<caractercntrol>().points++;
            
        }*/
    }
}
