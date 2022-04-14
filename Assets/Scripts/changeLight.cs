using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLight : MonoBehaviour
{
    
    public bool allButtonOn = false;
    public Sprite green;
    public Sprite red;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        allButtonOn = GetComponent<buttonActive>().allButtonOn;
        if (allButtonOn)
        {
            this.GetComponent<SpriteRenderer>().sprite = green;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = red;
        }
    }
}
