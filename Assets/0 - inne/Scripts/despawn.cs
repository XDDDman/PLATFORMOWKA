using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("despawning", 1.0f/10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void despawning()
    {
        Destroy(gameObject);
    }
}
