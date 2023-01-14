using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class Player_Death : MonoBehaviour
{

    public GameObject TeloportGoal;

    public GameObject Gracz;


    public Text scoreText;
    public int levelDeaths = 0;

    void Start()
    {
        scoreText.text = levelDeaths.ToString();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Instant death"))
        {
            Gracz.transform.position = TeloportGoal.transform.position;

            levelDeaths += 1;
            scoreText.text = levelDeaths.ToString();
        }
    }
}
