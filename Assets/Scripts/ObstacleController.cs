using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public bool isFromRightSide;
    public bool isFromTopSide;

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
        if (isFromRightSide)
        {
            GoFromRight();
        }
        if (isFromTopSide)
        {
            GoFromTop();
        }
    }

    public void GoFromRight()
    {
        if (collisionTrackerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * increaseSpeedScript.speed);
        }
    }
    
    public void GoFromTop()
    {
        if (collisionTrackerScript.gameOver == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * increaseSpeedScript.speed);
        }
    }
}
