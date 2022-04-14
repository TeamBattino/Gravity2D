using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onGround : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Ground")
        {
            player.GetComponent<PlayerMovement>().onGround = true;
            player.GetComponent<Rigidbody2D>().drag = 6;
           }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Ground")
        {
            player.GetComponent<PlayerMovement>().onGround = false;
            player.GetComponent<Rigidbody2D>().drag = 0.2f;
         }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Ground")
        {
            player.GetComponent<PlayerMovement>().onGround = true;
            player.GetComponent<Rigidbody2D>().drag = 6;
        }
    } 
    
}
