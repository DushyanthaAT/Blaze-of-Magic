using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playbutton : MonoBehaviour
{
    public GameObject playBottonx;
    public void playbuttonx()
    {
        playBottonx.SetActive(false);
        Time.timeScale = 1;

    }
}
