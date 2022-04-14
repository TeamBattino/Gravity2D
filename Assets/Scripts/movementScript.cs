using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movementScript : MonoBehaviour
{
    public float playerSpeed = 2f;
   // public Rigidbody2D rb;
    Vector2 movement;
    private bool isSprinting = false;
    private bool stoppedSprinting = true;
    private Animator shell;
    void Start()
    {
       
        playerSpeed = 2f;
    }
    void Update()
    {
        //called once per rendered Frame, used for Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        isSprinting = Input.GetButtonDown("Sprint");
        stoppedSprinting = Input.GetButtonUp("Sprint");
        if (isSprinting)
        {
            playerSpeed = 3f;
        }
        if (stoppedSprinting)
        {
            playerSpeed = 2f;
        }
 
        
    }
    void FixedUpdate()
    {
        //called 50 times a second, used for physics
       // rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
    }
}