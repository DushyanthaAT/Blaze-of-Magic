using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monsterfinalplace : MonoBehaviour
{
    public Transform target;
    public float chaseRange = 2f;
    public float distanceToTarget = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= chaseRange)
        {
            SceneManager.LoadScene("MonsterResults");
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
