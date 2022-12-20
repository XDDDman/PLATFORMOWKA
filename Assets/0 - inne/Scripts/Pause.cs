using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool pause = false;
    // Start is called before the first frame update
    public GameObject pauseMenuUI;
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
        pauseMenuUI.SetActive(true);    
        Time.timeScale = 0;
        pause = true;
        }
        else
        {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        pause = false;
        }
    }
   



    }
}



