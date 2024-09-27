using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsteropendoor : MonoBehaviour
{
    public GameObject opendoors;
    public GameObject explo;
    public GameObject explo2;
    public GameObject explo3;
    public GameObject dust;
    public GameObject fire1;
    public GameObject fire2;
    public GameObject fire3;
    public GameObject earth;
    public GameObject objectivetext;
    public GameObject objectivetext2;
    public Transform target;

    public AudioSource zombiesounds;
    public AudioSource doorbreaking;

    public float chaseRange = 10f;
    public float distanceToTarget = Mathf.Infinity;
    int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 90 * Time.deltaTime, 0);
        opendoors.gameObject.SetActive(false);

        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= chaseRange)
        {
           // opendoors.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.F))
            {
               //opendoors.gameObject.SetActive(false);
                Destroy(this.gameObject,1.2f);
                zombiesounds.Play();
                doorbreaking.Play();
                //Destroy(gameObject);

                 
                /*explo.gameObject.SetActive(true);
                explo2.gameObject.SetActive(true);
                explo3.gameObject.SetActive(true);
                dust.gameObject.SetActive(true);
               
                fire1.gameObject.SetActive(true);
                fire2.gameObject.SetActive(true);
                fire3.gameObject.SetActive(true);
                earth.gameObject.SetActive(true);
                
                Destroy(opendoors.gameObject);*/
                objectivetext.SetActive(false);
                objectivetext2.SetActive(true);

                //explo.gameObject.SetActive(false);


            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
