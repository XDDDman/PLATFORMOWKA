using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class destylacja : MonoBehaviour
{

    public GameObject destylacjaMenuUI;
    public GameObject destylacjaBarUI;
    public GameObject dym;

    public bool aktiv;


    public pieniadze pieniadze;

    public slimowanie slimowanie;

    public fillment fillment;

    public odnowienie odnowienie;


    bool GITslime;
    bool GITmoney;



    public Text destilesText;
    public int destiles = 0;


    public bool isWorking = false;


    public bool wykrytoGracza;

    private bool pasek = true;


    // Start is called before the first frame update
    void Start()
    {
        destylacjaMenuUI.SetActive(false);
        destylacjaBarUI.SetActive(false);

        dym.SetActive(false);

        destilesText.text = destiles.ToString() + " destiles";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r") && aktiv == true)
        {
            pieniadze.test();
            slimowanie.test();
            Debug.Log("testy wys³ane");

            if (GITslime == true && GITmoney == true && isWorking == false)
            {
                pieniadze.zakupyMoney();
                slimowanie.zakupySlime();
                Debug.Log("komendy pobrania wys³ane");

                fillment.start();

                dym.SetActive(true);
            }
        }

        if (counter == 0 && aktiv == false && pasek == false)
        {
            destylacjaBarUI.SetActive(false);
            //dym.SetActive(false);
        }


        if (destiles > 0)
        {
            odnowienie.wystarczy();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            destylacjaMenuUI.SetActive(true);
            destylacjaBarUI.SetActive(true);
            aktiv = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            destylacjaMenuUI.SetActive(false);
            destylacjaBarUI.SetActive(false);
            aktiv = false;
            //dym.SetActive(true);
        }
        if (isWorking == true)
        {
            destylacjaBarUI.SetActive(true);
            //dym.SetActive(true);
        }
    }


    public void slimeGIT()
    {
        GITslime = true;
        Debug.Log("otrzymano potwierdzenie slimów");
    }
    public void moneyGIT()
    {
        GITmoney = true;
        Debug.Log("otrzymano potwierdzenie pieniêdzy");
    }

    public void StopMoney()
    {
        GITmoney = false;
    }
    public void StopSlime()
    {
        GITslime = false;
    }







    public void wydanieDestylów()
    {
        destiles += 1;
        destilesText.text = destiles.ToString() + " destiles";


        pasek = false;
        dym.SetActive(false);
    }


    public void Dziala()
    {
        isWorking = true;
        pasek = true;
    }

    public void konczySie()
    {
        isWorking = false;
    }

    private int counter = 0;
    void OnTriggerEnter(Collider other)
    {
        counter++;
    }
    void OnTriggerExit(Collider other)
    {
        counter--;
    }


    public void platnosc()
    {
        destiles = destiles - 1;
        destilesText.text = destiles.ToString() + " destiles";
    }
}