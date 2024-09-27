using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterGunScript : MonoBehaviour
{
    public Camera fpCamera;

    public GameObject hitEffect;

    public float range = 100f;
    public float damage = 5f;
    public float impactForce = 250f;

    public GameObject blood;

    public AudioSource wondsound;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }

    private void Shoot()
    {
        wondsound.Play();
        RaycastHit hitInfo;
        if(Physics.Raycast(fpCamera.transform.position, fpCamera.transform.forward, out hitInfo, range))
        {
            print("I hit" + hitInfo.transform.name);
            monsterEnemyScript enemyScript = hitInfo.transform.GetComponent<monsterEnemyScript>();
            if(enemyScript != null)
            {
                blood.gameObject.SetActive(true);
                enemyScript.TakeDamage(damage);
                //blood.gameObject.SetActive(false);

            }
        }

        GameObject impact=Instantiate(hitEffect, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
        Destroy(impact.gameObject, 1f);
    }
}
