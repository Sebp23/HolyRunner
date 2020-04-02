using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] rightSideObstaclePrefabs;
    public GameObject[] topSideObstaclePrefabs;
    private float spawnRangeZ;
    private float positiveSpawnRangeX;
    private float negativeSpawnRangeX;

    public float rightSideStartDelay = 2;
    public float topSideStartDelay = 10;
    public float spawnInterval = 1.5f;
    private float numberOfObstacles = 1;
    private CollisionTracker collisionTrackerScript;

    // Start is called before the first frame update
    void Start()
    {
        spawnRangeZ = GameObject.Find("ZBorder").transform.position.z;
        positiveSpawnRangeX = GameObject.Find("XBorder1").transform.position.x;
        negativeSpawnRangeX = GameObject.Find("XBorder2").transform.position.x;

        InvokeRepeating("SpawnObstaclesFromRight", rightSideStartDelay, spawnInterval);
        InvokeRepeating("SpawnObstaclesFromTop", topSideStartDelay, spawnInterval);

        collisionTrackerScript = GameObject.Find("Player").GetComponent<CollisionTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstaclesFromRight()
    {
        if (collisionTrackerScript.gameOver == false)
        {
            for (int i = 0; i < numberOfObstacles; i++)
            {
                Vector3 spawnPos = new Vector3(20, 0.5f, Random.Range(-spawnRangeZ, spawnRangeZ));

                int obstacleIndex = Random.Range(0, rightSideObstaclePrefabs.Length);
                Instantiate(rightSideObstaclePrefabs[obstacleIndex], spawnPos, rightSideObstaclePrefabs[obstacleIndex].transform.rotation);
            }
            
        }
    }

    private void SpawnObstaclesFromTop()
    {
        if (collisionTrackerScript.gameOver == false)
        {
            for (int i = 0; i < numberOfObstacles; i++)
            {
                Vector3 spawnPos = new Vector3(Random.Range(negativeSpawnRangeX, positiveSpawnRangeX), 0.5f, 8);

                int obstacleIndex = Random.Range(0, topSideObstaclePrefabs.Length);
                Instantiate(topSideObstaclePrefabs[obstacleIndex], spawnPos, topSideObstaclePrefabs[obstacleIndex].transform.rotation);
            }

        }
    }
}
