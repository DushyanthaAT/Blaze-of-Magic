using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoM_CharacterController : MonoBehaviour
{
    public int speed = 5;
    public int Rspeed = 30;
    public GameObject character;
    private Animator animater;
    public static int taskNumber;
    private Vector3 jump;
    public float jumpforce;
    public float jumph;
    private Rigidbody rigidbody;
    private Vector3 lastPosition;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        jump = new Vector3(0f, jumph, 0f);


        animater = GetComponent<Animator>();
  
        
        if (taskNumber == 1)
        {
            transform.position = new Vector3(363.49f, 28.95f, 135.17f);

        }
        if (taskNumber == 2)
        {
            //transform.position = bom_TaskMenuScripts.checkPoint;
            transform.position = new Vector3(431.21f, 28.93f, 304.95f);

        }
        if (taskNumber == 3)
        {
            //transform.position = bom_TaskMenuScripts.checkPoint;
            transform.position = new Vector3(293.36f, 29.52f, 301.44f);

        }
    }

    // Update is called once per frame
    void Update()
    {
      
        
        MoveRotate();
        MoveForwardBackward();
        MoveJump();

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            animater.Play("LeftTurn");
           
        }

        if (Input.GetKey(KeyCode.LeftShift)&& Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            animater.Play("Run");
            speed = 15;
        }
        else
        {
            speed = 6;
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                
                animater.Play("Walk");
            }
        }



    }
    void MoveForwardBackward()
    {


        Vector3 vec_MoveForwardBackward = Vector3.zero;
        vec_MoveForwardBackward.z = Input.GetAxis("Vertical");
        Vector3 v = vec_MoveForwardBackward * speed * Time.deltaTime;
        transform.Translate(v);
    }
   
    void MoveRotate()
    {
        Vector3 vec_Rotate = Vector3.zero;
        vec_Rotate.y = Input.GetAxis("Mouse X");
        Vector3 v = vec_Rotate * Rspeed * Time.deltaTime;
        transform.Rotate(v);
    }
    void MoveJump()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& transform.position.y <= 30)
        {
            rigidbody.AddForce(jump * jumpforce, ForceMode.Impulse);
            animater.SetFloat("Run", 0f);
            animater.Play("Jump");

            


        }


        /* Vector3 vec_MoveJump = Vector3.zero;
         vec_MoveJump.y = Input.GetAxis("Jump");
         Vector3 v = vec_MoveJump * speed * Time.deltaTime;
         transform.Translate(v);*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Out of Bounds")
        {


            transform.position = new Vector3(227.56f, 29.43f, 134.83f); ;
            
        }

    }

}

