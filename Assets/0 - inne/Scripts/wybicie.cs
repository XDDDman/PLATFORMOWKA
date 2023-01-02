using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wybicie : MonoBehaviour
{
    public float Wybity;

    public float WybityPlus;

    public bool mozeWybic;


    public PlayerMovement PlayerMovement;

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
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Wybicie"))
            rb.AddForce(new Vector2(rb.velocity.x, Wybity));

        if (col.collider.CompareTag("Wybicie+") && mozeWybic == true)
            rb.AddForce(new Vector2(rb.velocity.x, WybityPlus));
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.collider.CompareTag("Wybicie+"))
        {
            mozeWybic = true;
            PlayerMovement.wyszedl();
        }
    }
}