using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsteropendoor2 : MonoBehaviour
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
    public Transform target;
    public GameObject objectivetext2;
    public GameObject objectivetext3;

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
            //opendoors.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.F))
            {

                //Destroy(gameObject);
                doorbreaking.Play();
                //Destroy(opendoors.gameObject);
                Destroy(this.gameObject, 1.2f);

                //opendoors.gameObject.SetActive(false);
                /*explo.gameObject.SetActive(true);
                explo2.gameObject.SetActive(true);
                explo3.gameObject.SetActive(true);
                dust.gameObject.SetActive(true);
                //Destroy(this.gameObject, 1.2f);
                fire1.gameObject.SetActive(true);
                fire2.gameObject.SetActive(true);
                fire3.gameObject.SetActive(true);
                earth.gameObject.SetActive(true);*/
                objectivetext2.SetActive(false);
                objectivetext3.SetActive(true);


                //Destroy(opendoors.gameObject);

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
