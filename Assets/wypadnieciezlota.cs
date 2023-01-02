 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wypadnieciezlota : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("wykryto");
        if (col.CompareTag("pikaks"))
        {
            Destroy(gameObject);
            Debug.Log("Uderzono");
        }
    }
}
