using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class fillment : MonoBehaviour
{
    private const float MAXkonwertowanie = 100f;
    public float konwertowanie = 0;
    private Image barLevel;

    public float czas;

    public destylacja destylacja;

    public float licznik;



    // Start is called before the first frame update
    void Start()
    {
        barLevel = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        barLevel.fillAmount = konwertowanie / MAXkonwertowanie;

        if (konwertowanie == 100)
        {
            destylacja.wydanieDestylów();
            konwertowanie = 0;
            Invoke("zerowanie", 1);
        }
    }

    public void start()
    {
        destylacja.Dziala();
        Invoke("dodanie", czas);
    }

    public void dodanie()
    {
        if (licznik < 100)
        {
            konwertowanie += 1;
            licznik += 1;
            start();
        }
    }

    public void zerowanie()
    {
        licznik = 0;
        destylacja.konczySie();
    }
}
