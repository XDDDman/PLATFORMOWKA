using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zanik : MonoBehaviour
{

    public int time;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
            Invoke("Znikniecie", time);
    }


    void Znikniecie()
    {
        Destroy(gameObject);
    }
}