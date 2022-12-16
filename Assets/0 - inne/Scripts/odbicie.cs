using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odbicie : MonoBehaviour
{

    public float odbicieA;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Instant death"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, odbicieA));
        }
    }
}
