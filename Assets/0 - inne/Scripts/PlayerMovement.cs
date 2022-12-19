using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;

    public float jump;

    public bool isJumping;

    private Rigidbody2D rb;


    public bool pause = false;


    private bool doubleJumping;


    public bool doubleJumpingEnable;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");



        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && pause == false)
        {
            if (isJumping == false)
            {
                rb.AddForce(new Vector2(rb.velocity.x, jump));
            }
            else
            {
                if (pause == false && isJumping == true && doubleJumping == false && doubleJumpingEnable == true)
                {
                    rb.AddForce(new Vector2(rb.velocity.x, jump));
                    doubleJumping = true;
                }
            }
        }



        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause == false)
            {
                Time.timeScale = 0;
                pause = true;
                Debug.Log("Pauza");
            }
            else
            {
                Time.timeScale = 1;
                pause = false;
            }
        }


    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
            doubleJumping = false;
        }
        if (other.gameObject.CompareTag("Wybicie"))
        {
            doubleJumping = true;
        }
    }

}