using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonGolf : MonoBehaviour
{
    public GameObject bg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bg.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
    public void ResetScene()
    {
        SceneManager.LoadScene("GolfCourt");
    }
    public void NextButton()
    {
        SceneManager.LoadScene("BoM_Map");
    }
}
