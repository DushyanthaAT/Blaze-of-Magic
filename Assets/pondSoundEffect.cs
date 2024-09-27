using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pondSoundEffect : MonoBehaviour
{
    public Transform target;
    public float distanceToTarget = Mathf.Infinity;
    public float chaseRange = 120f;
    public AudioSource watersounds;

    void update()
    {

        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= chaseRange)
        {
            watersounds.Play();
        }



    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
       
    }

}
