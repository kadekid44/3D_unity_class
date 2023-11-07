using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoprefabs; // Array to store UFO ships
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);
        int ufoIndex = Random.Range(0, ufoprefabs.Length);
        Instantiate(ufoprefabs[ufoIndex],spawnPos, ufoprefabs[ufoIndex].transform.rotation); 
    }
}
