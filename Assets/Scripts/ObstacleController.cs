using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private CollisionTracker collisionTrackerScript;
    private IncreaseSpeed increaseSpeedScript;

    // Start is called before the first frame update
    void Start()
    {
        collisionTrackerScript = GameObject.Find("Player").GetComponent<CollisionTracker>();
        increaseSpeedScript = GameObject.Find("IncreaseObstacleSpeed").GetComponent<IncreaseSpeed>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Go();
    }

    public void Go()
    {
        if (collisionTrackerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * increaseSpeedScript.speed);
        }
    }
}
