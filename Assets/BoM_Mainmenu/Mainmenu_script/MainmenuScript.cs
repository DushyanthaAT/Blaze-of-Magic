using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainmenuScript : MonoBehaviour
{

    public GameObject frame1;
    public GameObject frame2;


    void Update()
    {
        if (Input.anyKeyDown && frame1.activeInHierarchy)
        {
            frame1.SetActive(false);
            frame2.SetActive(true);
        }
    }

    public void newGame()
    {
        SceneManager.LoadScene("BoM_Map");
    } 
    public void quit()
    {
        Application.Quit();
    }

}
