using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pieniadze : MonoBehaviour
{
    

    public Text scoreText;
    public int score = 0;

   

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
}
