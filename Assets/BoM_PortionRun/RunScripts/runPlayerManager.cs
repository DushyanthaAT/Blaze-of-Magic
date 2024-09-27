using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runPlayerManager : MonoBehaviour
{

    public static bool gameOver;
    public GameObject gameOverPanel;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
