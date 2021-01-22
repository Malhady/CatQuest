using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Represents the player; contains movement
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    /// <summary>
    /// Movement speed
    /// </summary>
    public float speed;

    /// <summary>
    /// Jump speed
    /// </summary>
    public float jumpSpeed;

    /// <summary>
    /// Horizontal input value from keyboard/controller
    /// </summary>
    private float hInput;

    /// <summary>
    /// Vertical input value from keyboard/controller
    /// </summary>
    private float vInput;

    /// <summary>
    /// Player input for jumping
    /// </summary>
    private bool jump;


    /// <summary>
    /// cooldown for the Jumping ability
    /// </summary>
    private float jumpCooldown =0f ;

    /// <summary>
    /// Epsilon, used for controls stick input
    /// </summary>
    //private float eps = 0.0001f;

    /// <summary>
    /// Rigidbody 2D for game physics
    /// </summary>
    Rigidbody2D body;

    Animator bounce;
    private bool grab;
    /// <summary>
    /// Initializing sound effects
    /// </summary>
    [SerializeField] private AudioSource jumpSound;
        [SerializeField] private AudioSource pointSound;

    //[SerializeField] private AudioSource jumpReset;

    /// <summary>
    /// Initializing score tracker
    /// </summary>
    public ScoreTracker s;

    /// <summary>
    /// Gets instance of RigidBody2D from the player
    /// </summary>
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        bounce=GetComponent<Animator>();
        s = GameObject.Find("Score").GetComponent<ScoreTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && jumpCooldown <= 0)
        {
            jumpSound.Play();
            jumpCooldown = 0.76f;
            jump = true;
            
        }else if(Input.GetKeyDown(KeyCode.DownArrow)){
            grab=true;
        }

       
        if(jumpCooldown > 0){
            jumpCooldown -= Time.deltaTime;
            
               // jumpReset.Play();
            
        }

        if(hInput>0){
            bounce.SetBool("isRight",true);
            bounce.SetBool("isLeft",false);
            
        }else if(hInput<0){
            bounce.SetBool("isLeft",true);
            bounce.SetBool("isRight",false);
            
        }else{
            bounce.SetBool("isLeft",false);
            bounce.SetBool("isRight",false);
        }
        if(jump){
            bounce.SetBool("isJumping",true);
        }else{
            bounce.SetBool("isJumping",false);
        }
        if(grab){
            bounce.SetBool("isGrabbing",true);
        }else{
            bounce.SetBool("isGrabbing",false);
        }

    }

    /// <summary>
    /// Updates player movement speed + direction
    /// </summary>
    void FixedUpdate()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");

        if(jump)
        {
            body.velocity = new Vector2(hInput * speed, vInput * jumpSpeed);
            jump = false;
        }
        else if(grab){
            // down arrow pressed, grabbing cat
            body.velocity=new Vector2(0,0);
            grab=false;
        }
        else
        {
            body.velocity = new Vector2(hInput * speed, body.velocity.y);
        }

    }

    /// <summary>
    /// If the player reaches a goal, they get one point
    /// </summary>
    
    public void ScorePoint()
    {
            pointSound.Play();
            s.ScorePoint();
    }
  
    /// <summary>
    /// If the player hits the ground, they will be sent to the deathscreen
    /// </summary>
  void OnCollisionEnter2D(Collision2D coll)
         {
          if(coll.collider.tag == "Player"){
             SceneManager.LoadScene("Deathscene");
          }
         }
}
