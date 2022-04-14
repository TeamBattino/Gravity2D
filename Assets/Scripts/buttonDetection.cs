using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonDetection : MonoBehaviour
{
    public bool on = false;
    private PolygonCollider2D buttonColliderup;
    private PolygonCollider2D buttonColliderdown;
    public int ObjectCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        buttonColliderup = GetComponents<PolygonCollider2D>()[0];
        buttonColliderdown = GetComponents<PolygonCollider2D>()[1];

    }

    // Update is called once per frame
    void Update()
    {
        if(ObjectCount > 0)
        {
            on = true;
            StartCoroutine(ButtonDown());
        }
        else
        {
                on = false;
                StartCoroutine(ButtonUp());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.GetComponent<Collider2D>().isTrigger && collision.gameObject.tag != "Ground")
        {
            ObjectCount ++;
            on = true;
            StartCoroutine(ButtonDown());
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.GetComponents<Collider2D>()[0].isTrigger && collision.gameObject.tag != "Ground")
        {
            ObjectCount--;
            
        }
    }
    private IEnumerator ButtonUp()
    {
        yield return new WaitForSeconds(0.2f);
        buttonColliderup.enabled = true;
        buttonColliderdown.enabled = false;
        broadcastButtons();
    }
    private IEnumerator ButtonDown()
    {
        yield return new WaitForSeconds(0.2f);
        buttonColliderup.enabled = false;
        buttonColliderdown.enabled = true;
        broadcastButtons();
    }
    private void broadcastButtons()
    {
        buttonActive[] buttonsActive = FindObjectsOfType<buttonActive>();
        for(int I = 0; I < buttonsActive.Length; I++)
        {
            buttonsActive[I].buttonOnDetectionLoop();
        }
    }
}
