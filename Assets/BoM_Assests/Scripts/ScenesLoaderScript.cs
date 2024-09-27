using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesLoaderScript : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadPauseMenu();

        }
    }

    public void LoadPauseMenu()
    {
        SceneManager.LoadScene("pauseMenu");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
