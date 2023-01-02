using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odnowienie : MonoBehaviour
{
    public bool isAble;

    public bool isStanding;

    public zamiana zamiana;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            if (isAble == true && isStanding == true)
            {
                zamiana.zmienienie();
            }
        }
    }

    public void wystarczy()
    {
        isAble = true;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ground+"))
        {
            isStanding = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Ground+"))
        {
            isStanding = false;
        }
    }
}
