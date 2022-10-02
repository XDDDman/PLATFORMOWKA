using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public int Speed;
    Vector2 targetPos;
    public Transform posA, posB;

    
    // Start is called before the first frame update
    void Start()
    {
        targetPos= posB.position;
    }

    // Update is called once per frame
    void Update()
    {
     if(Vector2.Distance(transform.position,posA.position) < 1f) targetPos = posB.position;

     if(Vector2.Distance(transform.position, posB.position) < 1f) targetPos = posA.position;


     transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(posA.position, posB.position);
    }
}
    

