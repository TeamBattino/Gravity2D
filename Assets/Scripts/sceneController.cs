using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Freeze();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Freeze()
    {
        Time.timeScale = 0;
    }
    public void UnFreeze()
    {
        Time.timeScale = 1;
    }
    public void NextLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
