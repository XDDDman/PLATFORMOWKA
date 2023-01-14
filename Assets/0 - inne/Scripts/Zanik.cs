using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zanik : MonoBehaviour
{
    public float time;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
            Invoke("Znikniecie", time);
    }


    void Znikniecie()
    {
        Destroy(gameObject);
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Odznikniecie()
    {
        Debug.Log("xd");
    }

}