using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 followDirection = mousePos - transform.position;
        float directionAngle = Vector2.SignedAngle(Vector2.right, followDirection);
        transform.eulerAngles = new Vector3(0, 0, directionAngle);

    }
}
