using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralTiming : MonoBehaviour
{
    static public float timeValue = 0;

    public bool isCounting = true;

    public Text GeneralTimeText;

    void Start()
    {
        GeneralTimeText.text = timeValue.ToString();
    }

    void Update()
    {
        if (isCounting == true)
        {
            timeValue += Time.deltaTime;
        }

        float minutes = Mathf.FloorToInt(timeValue / 60);
        float seconds = Mathf.FloorToInt(timeValue % 60);
        GeneralTimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("stopTimerowi"))
        {
            isCounting = false;
            Cursor.visible = true;
        }
    }

    public void Reset()
    {
        timeValue = 0;
    }
}