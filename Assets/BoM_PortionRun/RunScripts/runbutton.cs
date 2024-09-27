using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class runbutton : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("run");
    }

    public void exitGame()
    {
        SceneManager.LoadScene("BoM_Map");
    }
}
