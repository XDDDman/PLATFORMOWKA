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

    public bool doubleJumpingEnable = false;
    

    public GameObject pauseMenuUI;

    public GameObject doubleJumpParticle;


    public bool isActive;

    public int czas = 1;


    public bool isStorm;
    public float tempo = 1.00f;

    public float tajm = 1;


    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        doubleJumpParticle.SetActive(false);
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
                    doubleJumpingEnable = false;
                    doubleJumpParticle.SetActive(true);
                    Invoke("stop", tajm);
                }
            }

        }


        



        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause == false)
            {
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0;
                pause = true;
                Debug.Log("Pauza");
            }
            else
            {
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1;
                pause = false;
            }
        }


        if (isStorm == true)
        {
            transform.position += new Vector3(tempo/-200, 0, 0);
        }

    }

    void stop()
    {
        doubleJumpParticle.SetActive(false);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Ground+"))
        {
            isJumping = false;
        }

        if (other.gameObject.CompareTag("Wybicie+") && isActive == false)
        {
            isJumping = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Ground+"))
        {
            isJumping = true;
            doubleJumping = false;
        }
        if (other.gameObject.CompareTag("Wybicie") || other.gameObject.CompareTag("Wybicie+"))
        {
            doubleJumping = true;
        }

        if (other.gameObject.CompareTag("Wybicie+") && isActive == false)
        {
            isJumping = true;
            doubleJumping = false;
        }
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("double jump activator"))
        {
            doubleJumpingEnable = true;
        }
    }


    public void wyszedl()
    {
        isActive = true;
    }

    
}