using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text myText;
    public static int sendscore;
    // Start is called before the first frame update
    void Start()
    {
        myText.text = sendscore.ToString();  
    }

  
}
