using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralTiming : MonoBehaviour
{
    static public float timeValue = 0;

    public Text GeneralTimeText;

    void Start()
    {
        GeneralTimeText.text = timeValue.ToString();
    }

    void Update()
    {
        timeValue += Time.deltaTime;

        float minutes = Mathf.FloorToInt(timeValue / 60);
        float seconds = Mathf.FloorToInt(timeValue % 60);
        GeneralTimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}