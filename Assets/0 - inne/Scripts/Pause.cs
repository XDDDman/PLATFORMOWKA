using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool pause = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
       
       
       
        if (Input.GetKeyDown(KeyCode.Escape))
    {
        if (pause == false)
        {
        Time.timeScale = 0;
        pause = true;
        }
        else
        {
        Time.timeScale = 1;
        pause = false;
        }
    }
   



    }
}



