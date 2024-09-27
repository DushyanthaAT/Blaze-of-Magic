using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TaskMenu : MonoBehaviour
{
    public GameObject TaskMenu1;
    public GameObject PlayFirstButton;
    public Transform target;
    public float chaseRange = 15f;
    public float distanceToTarget = Mathf.Infinity;
    public GameObject PressF;


    void Start()
    {
        
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(PlayFirstButton);
    }

    void Update()
    {
        //transform.Rotate(0, 90 * Time.deltaTime, 0);

        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= chaseRange)
        {

            PressF.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                Time.timeScale = 0;
                PressF.SetActive(false);
                TaskMenu1.SetActive(true);
            }
        }
        else
        {
            PressF.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(PlayFirstButton);
        }
    }

    public void quit()
    {
        Time.timeScale = 1;
        TaskMenu1.SetActive(false);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

}
