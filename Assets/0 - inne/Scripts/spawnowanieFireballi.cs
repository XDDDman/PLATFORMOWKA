using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnowanieFireballi : MonoBehaviour
{
    public int timer = 0;
    public int timeWyrzucenia;

    public GameObject FireballToSpawn;

    public bool isOn = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isOn == true)
        {
            timer += 1;
        }
        

        if (timer == timeWyrzucenia)
        {
            timer = 0;
            Instantiate(FireballToSpawn, transform.position, transform.rotation);
        }
    }
}
