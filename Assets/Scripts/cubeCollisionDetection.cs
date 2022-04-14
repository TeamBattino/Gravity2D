using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCollisionDetection : MonoBehaviour
{
    public bool contact = true;
    public GameObject cubeCatcher;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject != cubeCatcher) { 
        contact = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        contact = false;
    }
}
