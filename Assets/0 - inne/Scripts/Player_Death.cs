using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class Player_Death : MonoBehaviour
{



    public Text LevelDeathsText;
    public static int levelDeaths = 0;

    public Text GeneralDeathsText;
    public static int GeneralDeaths = 0;




    void Start()
    {
        LevelDeathsText.text = levelDeaths.ToString();
        GeneralDeathsText.text = GeneralDeaths.ToString();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Instant death"))
        {
            
            levelDeaths += 1;
            LevelDeathsText.text = levelDeaths.ToString();

            GeneralDeaths += 1;
            GeneralDeathsText.text = GeneralDeaths.ToString();

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (col.CompareTag("stopTimerowi"))
        {
            GeneralDeathsText.text = GeneralDeaths.ToString() + "  razy";
        }
    }

    public void Reset()
    {
        levelDeaths = 0;
    }

    public void GeneralReset()
    {
        GeneralDeaths = 0;
    }
}