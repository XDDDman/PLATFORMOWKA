using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zamiana : MonoBehaviour
{
    public GameObject objectToSpawn;

    public destylacja destylacja;


    public GameObject slimowaPlatformaUI;



    // Start is called before the first frame update
    void Start()
    {
        slimowaPlatformaUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void zmienienie()
    {
        destylacja.platnosc();
        Instantiate(objectToSpawn, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
        {
            slimowaPlatformaUI.SetActive(true);
            Debug.Log("wykryto");
        }
    }

    public void OnCollisionExit2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
        {
            slimowaPlatformaUI.SetActive(false);
            Debug.Log("przestano");
        }
    }
}
