using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPress : MonoBehaviour
{

    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Time.timeScale = 1;
            button.SetActive(false);
            
        }
    }
}
