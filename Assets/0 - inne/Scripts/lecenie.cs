using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lecenie : MonoBehaviour
{
    private Rigidbody2D rb;

    public int X;

    public int Y;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(X, Y);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
