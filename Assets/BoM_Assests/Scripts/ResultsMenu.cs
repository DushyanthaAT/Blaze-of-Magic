using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResultsMenu : MonoBehaviour

{

    public GameObject NextFirstButton;
    // Start is called before the first frame update
    void Start()
    {

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(NextFirstButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
