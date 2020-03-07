﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    private float spawnRangeZ = 4.4f;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private CollisionTracker collisionTrackerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, spawnInterval);

        collisionTrackerScript = GameObject.Find("Player").GetComponent<CollisionTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        if (collisionTrackerScript.gameOver == false)
        {
            Vector3 spawnPos = new Vector3(20, 0.5f, Random.Range(-spawnRangeZ, spawnRangeZ));

            int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
        }
    }
}
