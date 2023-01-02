using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pieniadze : MonoBehaviour
{
    

    public Text scoreText;
    public int score = 0;


    public destylacja destylacja;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoreMoney()
    {
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
    }

    public void test()
    {
        if (score > 2)
        {
            destylacja.moneyGIT();
            Debug.Log("wystarczy pieniêdzy");
        }
        else
        {
            Debug.Log("nie wystarczy pieniêdzy");
        }
    }

    public void zakupyMoney()
    {
        score -= 3;
        scoreText.text = score.ToString() + " POINTS";
        Debug.Log("pobrano pieni¹dze");
        destylacja.StopMoney();
    }
}
