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

    public float rightSideStartDelay = 4;
    public float topSideStartDelay = 25;
    public float spawnInterval = 1.5f;
    private float numberOfObstacles = 1;
    private CollisionTracker collisionTrackerScript;

    // Start is called before the first frame update
    void Start()
    {
        //set the spawn range on the Z axis based on the z position of the ZBorder object
        spawnRangeZ = GameObject.Find("ZBorder").transform.position.z;
        
        //set the positive spawn range on the X axis based on the x position of the XBorder1 object
        positiveSpawnRangeX = GameObject.Find("XBorder1").transform.position.x;
        //set the negative spawn range on the X axis based on the x position of the XBorder1 object
        negativeSpawnRangeX = GameObject.Find("XBorder2").transform.position.x;

        //execute the SpawnObstaclesFromRight() method after 2 seconds and then repeat the method every 1.5 seconds
        InvokeRepeating("SpawnObstaclesFromRight", rightSideStartDelay, spawnInterval);
        //execute the SpawnObstaclesFromTop() method after 25 seconds and then repeat the method every 1.5 seconds
        InvokeRepeating("SpawnObstaclesFromTop", topSideStartDelay, spawnInterval);

        //find the collision tracker script from the Player object so we can access that scripts methods from this script
        collisionTrackerScript = GameObject.Find("Player").GetComponent<CollisionTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //method that spawns obstacles from the right
    private void SpawnObstaclesFromRight()
    {
        //make sure that game isn't over. If it is, then the obstacles will stop spawning
        if (collisionTrackerScript.gameOver == false)
        {
            //create a loop to spawn the obstacles
            for (int i = 0; i < numberOfObstacles; i++)
            {
                //variable to determine where the obstacle will spawn
                Vector3 spawnPos = new Vector3(20, 0.5f, Random.Range(-spawnRangeZ, spawnRangeZ));

                //determine which obstacle prefab will spawn
                int obstacleIndex = Random.Range(0, rightSideObstaclePrefabs.Length);

                //spawn the obstacle
                Instantiate(rightSideObstaclePrefabs[obstacleIndex], spawnPos, rightSideObstaclePrefabs[obstacleIndex].transform.rotation);
            }
            
        }
    }

    //method that spawns obstacles from the top
    private void SpawnObstaclesFromTop()
    {
        //make sure that game isn't over. If it is, then the obstacles will stop spawning
        if (collisionTrackerScript.gameOver == false)
        {
            //create a loop to spawn the obstacles
            for (int i = 0; i < numberOfObstacles; i++)
            {
                //variable to determine where the obstacle will spawn
                Vector3 spawnPos = new Vector3(Random.Range(negativeSpawnRangeX, positiveSpawnRangeX), 0.5f, 8);

                //determine which obstacle prefab will spawn
                int obstacleIndex = Random.Range(0, topSideObstaclePrefabs.Length);

                //spawn the obstacle
                Instantiate(topSideObstaclePrefabs[obstacleIndex], spawnPos, topSideObstaclePrefabs[obstacleIndex].transform.rotation);
            }

        }
    }
}
