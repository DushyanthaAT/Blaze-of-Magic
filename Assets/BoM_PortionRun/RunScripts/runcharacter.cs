using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class runcharacter : MonoBehaviour
{
    public float speed = 10.5f;
    public float rotatespeed = 10000f;
   
    public float jumpVelocity= 50f;

    public float jumpforce;
    public float jumph;
    private Vector3 jump;

    public float downAccel = 0.75f;

    private Rigidbody rigidbody;
    private Animator animater;
    private Vector3 velocity;

    private int jumpInput = 0;
    //private bool onGroung = false;

    public int points;
    public GameObject ScoreText;

    public int maxHealth = 100;
    public int currentHealth;

    public bool isGrounded;

    


    private CharacterController controller;
    
    void Start()
    {
        //characterController = GetComponent<CharacterController>();
        rigidbody = GetComponent<Rigidbody>();
        animater = GetComponent<Animator>();
        velocity = Vector3.zero;

        jump = new Vector3(0f, jumph, 0f);

        isGrounded = true;



    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0,-rotatespeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, rotatespeed * Time.deltaTime, 0);
        }
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpInput = 1;
        }
        Jump();*/

        
            if (Input.GetKeyDown(KeyCode.Space) && transform.position.y<=2)
            {
                rigidbody.AddForce(jump * jumpforce, ForceMode.Impulse);
                animater.SetTrigger("Jump");
                //animater.SetTrigger("Jumping");
                isGrounded = false;
            }
        

        Debug.Log("Scores :" + points);
        ScoreText.GetComponent<Text>().text = "Score : " + points + " / 20"  ;

        // healthbar.SetHealth(currentHealth);

        if (GetComponent<runPlayerHealth>().health==0)
        {
            runfinalGameScore.sendscore = points;
            SceneManager.LoadScene("RunGameOver");

        }

        if (transform.position.y < -3  )
        {
            runfinalGameScore.sendscore = points;
            SceneManager.LoadScene("RunGameOver");

        }
        if (transform.position.z >= 1423)
        {
            runfinalGameScore.sendscore = points;
            SceneManager.LoadScene("RunGameOver");
        }


    }

    public void OnCollsionEnter(Collision other)
    {
        if (other.gameObject.tag == "floor")
        {
            isGrounded = true;
        }
        
    }

    
    void Jump()
    {
        /*if (jumpInput == 1) {
            velocity.y = jumpVelocity;
            animater.SetTrigger("Jump");
        }/*else if(jumpInput == 0)
        {
            velocity.y = 0;
        }*//*
        else
        {
            velocity.y = 0;
            //velocity.y = downAccel;
        }*/
        
        jumpInput = 0;
        
    }

   /* void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }*/

   /* private void onControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Obstacle")
        {
            print("Noooooo");
            PlayerManager.gameOver = true;
        }
    }*/



    /*void OnColisionEnter(Collider obj)
    {
        if (obj.gameObject.tag == "enemy")
        {
            //collectSound.Play();
            //ScoreText.GetComponent<ScoreText>().text="Score : " +
            TakeDamage(20);
            //Destroy(gameObject);
            
        }
    }
    void OnColisionEnter(Collider obj)
    {
        if (obj.name == "enemy1")
        {
            //collectSound.Play();
            //ScoreText.GetComponent<ScoreText>().text="Score : " +
            TakeDamage(20);
            //Destroy(gameObject);
            
        }
    }*/
    




    /* void MoveLeftRight()
     {
         Vector3 vec_left = Vector3.zero;
         vec_left = Input.GetAxis("Horizontal");
         Vector3 v = vec_left * speed * Time.deltaTime;
         transform.Translate(v);
     }*/
}
