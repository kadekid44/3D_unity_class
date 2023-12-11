using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameObject Pointsprefabs; // Array to store UFO ships
    private float spawnRangeX = 27f;
    private float spawnPosZ = 0f;
    private float startDelay = 2;
    private float spawnInterval = 10.5f;
    void Start()
    {
        InvokeRepeating("SpawnPoints", startDelay, spawnInterval);
    }
    void SpawnPoints()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);
       
        Instantiate(Pointsprefabs,spawnPos, Pointsprefabs.transform.rotation); 
    }
}
