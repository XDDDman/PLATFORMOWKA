using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class slimowanie : MonoBehaviour
{
    public Text kulkiText;
    public int kulki = 0;





    public destylacja destylacja;

    void Start()
    {
        int kulki = 0;
        kulkiText.text = kulki.ToString() + " slimes";


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("kulecka"))
        {
            kulki += 1;
            kulkiText.text = kulki.ToString() + " slimes";
        }
    }

    public void test()
    {
        if (kulki > 0)
        {
            destylacja.slimeGIT();
            Debug.Log("wystarczy slimów");
        }
        else
        {
            Debug.Log("nie wystarczy slimów");
        }
    }

    
    public void zakupySlime()
    {
        kulki -= 1;
        kulkiText.text = kulki.ToString() + " slimes";
        Debug.Log("pobrano slimy");
        destylacja.StopSlime();
    }

}