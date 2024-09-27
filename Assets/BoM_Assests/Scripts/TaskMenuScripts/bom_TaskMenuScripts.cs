using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class bom_TaskMenuScripts : MonoBehaviour
{
    [SerializeField] private GameObject TaskMenu;
    public GameObject PlayFirstButton;
    public Transform target;
    public float chaseRange = 18f;
    public float distanceToTarget = Mathf.Infinity;
    public GameObject PressF;
    public static Vector2 checkPoint;

    void Start()
    {

        
    }

    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= chaseRange)
        {
            PressF.SetActive(true);

            checkPoint = transform.position;

            if (Input.GetKeyDown(KeyCode.F))
            {
                Time.timeScale = 0;
                PressF.SetActive(false);
                TaskMenu.SetActive(true);
            }
        }
        else
        {
            PressF.SetActive(false);
        }

        

        if (TaskMenu.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
        
    }

    public void quit()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        TaskMenu.SetActive(false);

    }
    public void play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MonsterTask");

    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
