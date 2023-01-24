using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niszczenieOziemie : MonoBehaviour
{
    public GameObject objectToSpawn;

    //float pozycja1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pozycja1 = transform.position.y - 1;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ground") || col.CompareTag("Wybicie"))
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
