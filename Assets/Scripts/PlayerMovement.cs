using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    Rigidbody2D rb;
    public float speed = 3;
    public bool onGround = true;
    public GameObject cubeCatcher;
    private Animator shell;
    public float jumpForce = 4;
    private float deltaSpeed;
    public GameObject cubeCollider;
    // Start is called before the first frame update
    void Start()
    {
        shell = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreCollision(cubeCollider.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x < 0)
        {
            shell.SetBool("Running", true);
            shell.speed = rb.velocity.x * -1f * 0.2f;
        }
        if (rb.velocity.x > 0)
        {
            shell.SetBool("Running", true);
            shell.speed = rb.velocity.x * 0.2f;
            
        }
        if(rb.velocity.x == 0)
        {
            shell.SetBool("Running", false);
            shell.speed = 1f;
        }
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePos = Input.mousePosition;
        if (mousePos.x < Screen.width / 2)
        {
            GetComponent<SpriteRenderer>().flipX = true;
           // GetComponent<SpriteRenderer>().flipY = true;
        }
        if (mousePos.x > Screen.width / 2)
        {
            GetComponent<SpriteRenderer>().flipX = false;
          //  GetComponent<SpriteRenderer>().flipY = false;
        }
        Move();
        if (onGround)
        {
            rb.drag = 3f;
        }
    }
  /*  private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = true;
           // rb.drag = 3f;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = false;
            //rb.drag = 0.8f;
        }
    }*/
    void Move()
    {
        deltaSpeed = speed * Time.deltaTime * 100;
        if (Input.GetKey(KeyCode.D) && rb.velocity.x <= 10 && onGround)
        {
            rb.AddForce(Vector2.right * deltaSpeed);
        }
        if (Input.GetKey(KeyCode.A) && rb.velocity.x >= -10 && onGround)
        {
            rb.AddForce(Vector2.left * deltaSpeed);
        }
        if (Input.GetKey(KeyCode.D) && rb.velocity.x <= 10 && !onGround)
        {
            rb.AddForce(Vector2.right * deltaSpeed * 0.5f);
        }
        if (Input.GetKey(KeyCode.A) && rb.velocity.x >= -10 && !onGround)
        {
            rb.AddForce(Vector2.left * deltaSpeed*0.5f);
        }
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.AddForce(Vector2.up * 100 * jumpForce);
        }
        if (Input.GetKeyDown(KeyCode.E)){
            if (cubeCatcher.GetComponent<attachToPlayer>().enabled)
            {
                cubeCatcher.GetComponent<attachToPlayer>().enabled = false;
            }
            else if (!cubeCatcher.GetComponent<attachToPlayer>().enabled)
            {
                cubeCatcher.GetComponent<attachToPlayer>().enabled = true;
            }
        }
    }
    /*  private void OnCollisionEnter2D(Collision2D collision)
      {
          if (collision.gameObject.tag == "cube")
          {
              Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>(), true);
          }
      }*/
}
