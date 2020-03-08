using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public float speed = 10.0f;
    public float zRange;
    public float positiveXBorder;
    public float negativeXBorder;
    private CollisionTracker collisionTrackerScript;

    // Start is called before the first frame update
    void Start()
    {
        zRange = GameObject.Find("ZBorder").transform.position.z;
        positiveXBorder = GameObject.Find("XBorder1").transform.position.x;
        negativeXBorder = GameObject.Find("XBorder2").transform.position.x;
        collisionTrackerScript = GameObject.Find("Player").GetComponent<CollisionTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        if(collisionTrackerScript.gameOver == false)
        {
            //check to make sure player stays inbounds
            if (transform.position.z < -zRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
            }

            if (transform.position.z > zRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
            }

            if (transform.position.x < negativeXBorder)
            {
                transform.position = new Vector3(negativeXBorder, transform.position.y, transform.position.z);
            }

            if (transform.position.x > positiveXBorder)
            {
                transform.position = new Vector3(positiveXBorder, transform.position.y, transform.position.z);
            }

            //assign control to horizontalInput to move player up/down
            verticalInput = Input.GetAxis("Vertical");
            //assign control to the horizontalInput to move player left/right
            horizontalInput = Input.GetAxis("Horizontal");

            //move player up/down
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
            //move player left/right
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }

    }
}
