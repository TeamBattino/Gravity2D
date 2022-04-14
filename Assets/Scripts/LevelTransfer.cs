using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransfer : MonoBehaviour
{
    private buttonActive buttonActive;
    // Start is called before the first frame update
    void Start()
    {
        buttonActive = GetComponent<buttonActive>();
        GetComponent<Animator>().SetBool("Opening", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonActive.allButtonOn)
        {
            if (GetComponent<Animator>().GetBool("Opening") == false)
            {
                GetComponent<Animator>().SetBool("Opening", true);
                GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        else
        {
            if(GetComponent<Animator>().GetBool("Opening") == true) { 
            GetComponent<Animator>().SetBool("Opening", false);
            GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}
