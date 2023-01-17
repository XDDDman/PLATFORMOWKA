using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class goToNextLevel : MonoBehaviour
{
    public Player_Death Player_Death;

    public levelTiming levelTiming;

    public Text levelNumText;
    public static int levelNum;

    void Start()
    {
        levelNumText.text = levelNum.ToString() + "/20";
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            Player_Death.Reset();

            levelTiming.Reset();

            levelNum += 1;
            levelNumText.text = levelNum.ToString() + "/20";
        }
    }

    public void Reset()
    {
        levelNum = 0;
        levelNumText.text = levelNum.ToString() + "/20";
    }
}