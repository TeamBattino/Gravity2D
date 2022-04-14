using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipGun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePos = Input.mousePosition;
        if(mousePos.x < Screen.width/2)
        {
            GetComponent<SpriteRenderer>().flipY = true;
        }
        if (mousePos.x > Screen.width/2)
        {
            GetComponent<SpriteRenderer>().flipY = false;
        }
    }
}