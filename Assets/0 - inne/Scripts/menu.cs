using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class menu : MonoBehaviour
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

    public void actionMenu()
    {
        SceneManager.LoadScene("Menu 0");
        
        Player_Death.GeneralReset();
        Player_Death.Reset();

        levelTiming.Reset();
        GeneralTiming.Reset();

        goToNextLevel.Reset();
    }
}
