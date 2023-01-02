using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawntest : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 origin = Vector3.zero;
    public float radius = 10;
    void Start()
    {
        // Finds a position in a sphere with a radius of 10 units.
        Vector3 randomPosition = origin + Random.insideUnitSphere * radius;
        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }
}
