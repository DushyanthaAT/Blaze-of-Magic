﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterunlockcurser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnlockMouse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UnlockMouse()
    {
        //RigidbodyFirstPersonController
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
