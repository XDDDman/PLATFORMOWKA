using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelTiming : MonoBehaviour
{
    static public float timeValue = 0;

    public Text levelTimeText;

    void Start()
    {
        levelTimeText.text = timeValue.ToString();
    }

    void Update()
    {
        timeValue += Time.deltaTime;

        float minutes = Mathf.FloorToInt(timeValue / 60);
        float seconds = Mathf.FloorToInt(timeValue % 60);
        levelTimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void Reset()
    {
        timeValue = 0;
    }
}
