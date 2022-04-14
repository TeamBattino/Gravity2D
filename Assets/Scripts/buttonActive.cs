using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonActive : MonoBehaviour
{
    public buttonDetection[] buttonsOn;
    public bool allButtonOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buttonOnDetectionLoop()
    {
        bool currentAllButtonsOn = true;
        for (int i = 0; i < buttonsOn.Length; i++)
        {
            if (!buttonsOn[i].on)
            {
                
                currentAllButtonsOn = false;
                
            }
        }
        allButtonOn = currentAllButtonsOn;
    }
}
