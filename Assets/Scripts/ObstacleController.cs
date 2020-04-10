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
        //find the collision tracker script from the Player object so we can access that scripts methods from this script
        collisionTrackerScript = GameObject.Find("Player").GetComponent<CollisionTracker>();

        //find the IncreaseSpeed script from the IncreaseObstacleSpeed object so we can access that script's methods from this script
        increaseSpeedScript = GameObject.Find("IncreaseObstacleSpeed").GetComponent<IncreaseSpeed>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //check to see if the obstacle is coming from the right
        if (isFromRightSide)
        {
            //execute the GoFromRight() method
            GoFromRight();
        }
        //check to see if the obstacle is coming from the top
        if (isFromTopSide)
        {
            //execute the GoFromTop() method
            GoFromTop();
        }
    }

    public void GoFromRight()
    {
        //make sure the game isn't over. If it is, then the obstacles will stop moving
        if (collisionTrackerScript.gameOver == false)
        {
            //make the obstacles move towards the left
            transform.Translate(Vector3.left * Time.deltaTime * increaseSpeedScript.speed);
        }
    }
    
    public void GoFromTop()
    {
        //make sure the game isn't over. If it is, then the obstacles will stop moving
        if (collisionTrackerScript.gameOver == false)
        {
            //make the obstacles move downwards
            transform.Translate(Vector3.back * Time.deltaTime * increaseSpeedScript.speed);
        }
    }
}
