using UnityEngine;
using UnityEngine.AI;

public class MonsterEnemyAI : MonoBehaviour
{
    public Transform target;
   // public Transform muzzlePoint;

    public float chaseRange = 15f;
    public float attackRange = 3f;

    public float distanceToTarget=Mathf.Infinity;

    //public float bulletSpeed = 5.0f;

    private NavMeshAgent navMeshAgent;

    //public GameObject bulletPrefab;

    private Animator animater;

    public AudioSource zombiesounds;

    /*public Transform[] waypoints;
    public int patrolSpeed=3;
    private int waypointIndex;
    private float distance;*/

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animater = GetComponent<Animator>();

        /*waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);*/

    }

    
    private void Update()
    {
        //Enemy chase player
        distanceToTarget = Vector3.Distance(target.position,transform.position);

        if (distanceToTarget <= chaseRange)
        {
            //animater.SetTrigger("Attack");
            //animater.Play("mixamo_com");
            //animater.Play("walk");

            //zombiesounds.Play();
            navMeshAgent.SetDestination(target.position);
            


            //Invoke("EnemyShoot",1f);
        }
        if (distanceToTarget <= attackRange)
        {
            zombiesounds.Play();
            animater.SetTrigger("Attack");
            navMeshAgent.SetDestination(target.position);


            //Invoke("EnemyShoot",1f);
        }
        /*if (EnemyScript.dieing == true)
        {
            animater.Play("10-death_fall_backward");

            Destroy(this.gameObject, 2f);
        }*/

        
        

        /*
        //Enemy patrol
        distance=Vector3.Distance(transform.position, waypoints[waypointIndex].position);

        if (distance < 0.5f)
        {
            IncreaseIndex();
        }

        Patrol();
        */


        //navMeshAgent.SetDestination(target.position);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }

    /*private void EnemyShoot()
    {
        GameObject bullet=Instantiate(bulletPrefab, muzzlePoint.position, muzzlePoint.rotation);

        bullet.GetComponent<Rigidbody>().velocity = muzzlePoint.forward * bulletSpeed;

        Destroy(bullet.gameObject, 2f);

    }*/

    /*private void Patrol()
    {
        transform.Translate(Vector3.forward * patrolSpeed * Time.deltaTime);
    }
    private void IncreaseIndex()
    {
        waypointIndex++;

        if (waypointIndex>=waypoints.Length)
        {
            waypointIndex = 0;
        }

        transform.LookAt(waypoints[waypointIndex].position);
    }*/
}
