using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class play : MonoBehaviour
{
    public Player_Death Player_Death;

    public levelTiming levelTiming;
    public GeneralTiming GeneralTiming;

    public goToNextLevel goToNextLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void actionPlay()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Poziom 0 !");
        Debug.Log("play");
        Cursor.visible = false;

        Player_Death.GeneralReset();
        Player_Death.Reset();

        levelTiming.Reset();
        GeneralTiming.Reset();

        goToNextLevel.Reset();
    }
}
