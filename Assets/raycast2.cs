using UnityEngine;

public class raycast2 : MonoBehaviour
{
    // Float a rigidbody object a set distance above a surface.
    public float speed = 5;
    int moveDirection = 1;

    Rigidbody2D rb2D;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Cast a ray straight down.
        RaycastHit2D hit = Physics2D.Raycast(transform.position+ Vector3.right*moveDirection, -Vector2.up);
        Debug.Log(hit.collider.gameObject.name);

        // If it hits something...
        if (hit.collider == null)
        {
            moveDirection *= -1;
        }

        transform.Translate(new Vector3(moveDirection * speed*Time.deltaTime, 0, 0));
    }
}