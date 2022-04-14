using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attachToPlayer : MonoBehaviour
{
    private GameObject cube;
    public bool cubeGrabbable = false;
    private Vector2 cubePos;
    private Rigidbody2D rb;
    //public float stopSize;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        cube.GetComponent<TargetJoint2D>().target = transform.position;
        if (cubeGrabbable)
        {
            holding(cube);
            //GetComponent<BoxCollider2D>().isTrigger = false; //SuperGliched (Funny)
        }
      /*  else{
            GetComponent<BoxCollider2D>().isTrigger = true;    //SuperGliched (Funny)
        }*/
        cubePos = cube.transform.position;
    }
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "cube" && GetComponent<attachToPlayer>().enabled)
        {
            cube = collision.gameObject;
            cubeGrabbable = true; // still requires deactivation
            rb = cube.GetComponent<Rigidbody2D>();
            cube.GetComponent<TargetJoint2D>().enabled = true;  //WHY DOES THIS STILL ACTIVATE WHEN THIS SCRIPT IS TURNED OFF
        }
    }*/
  public GameObject getCube()
    {
        return cube;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "cube")
        {
            //cubeGrabbable = true;

            if (GetComponent<attachToPlayer>().enabled)
            {
                GetComponent<ParticleSystem>().startColor = new Color(0, 0.2395067f, 1, 0.3490196f);
                cube = collision.gameObject;
              rb = cube.GetComponent<Rigidbody2D>();
             cube.GetComponent<TargetJoint2D>().enabled = true; 
          }
             if (GetComponent<attachToPlayer>().enabled == false)
            {
             cube.GetComponent<TargetJoint2D>().enabled = false;
             cube = null;
                
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "cube" && collision.gameObject.GetComponent<cubeCollisionDetection>().contact)
        {
            GetComponent<ParticleSystem>().startColor = new Color(0, 0.2395067f, 1, 0.04313726f);
            cube.GetComponent<TargetJoint2D>().enabled = false;
            GetComponent<attachToPlayer>().enabled = false;
            cube = null;
        }
    }
    private void OnDisable()
    {
        killCube(cube);
    }
    public void killCube(GameObject cube)
    {
        GetComponent<ParticleSystem>().startColor = new Color(0, 0.2395067f, 1, 0.04313726f);
        cube.GetComponent<TargetJoint2D>().enabled = false;
        GetComponent<attachToPlayer>().enabled = false;
        cube = null;
    }
    void holding(GameObject cube)
    {
      /*  if(){
            cube.transform.position = cubePos;
            GetComponent<attachToPlayer>().enabled = false;
            }
        else{*/
            
       // }
      /* Vector2 cubePos = cube.transform.position;
        Vector2 catchPos = transform.position;
        Vector2 forceDirection = catchPos - cubePos;
        if (cubePos.x < catchPos.x+stopSize && cubePos.x > catchPos.x-stopSize && cubePos.y > catchPos.y-stopSize && cubePos.x < catchPos.x+stopSize)
        {
            cube.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        } 
        else
        {
            cube.GetComponent<Rigidbody2D>().velocity +=(forceDirection.normalized)*2f;
        }*/
        
    }
    /* private void OnTriggerExit2D(Collider2D collision)
    {
        //cube.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        //GetComponent<attachToPlayer>().enabled = false;
        cubeGrabbable = false;
        cube.GetComponent<TargetJoint2D>().enabled = false;
        cube = null;
        GetComponent<attachToPlayer>().enabled = false;

    }*/
}
