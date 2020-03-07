using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float speed = 10.0f;
    public float zRange = 4.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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

        //assign control to horizontalInput to move player left/right
        verticalInput = Input.GetAxis("Vertical");

        //move player up/up
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

    }
}
