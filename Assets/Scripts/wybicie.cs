using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wybicie : MonoBehaviour
{
    public float Wybity;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Wybicie"))
            rb.AddForce(new Vector2(rb.velocity.x, Wybity));
    }
}