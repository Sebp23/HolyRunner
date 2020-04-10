using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffscreen : MonoBehaviour
{
    private float playBound;

    // Start is called before the first frame update
    void Start()
    {
        //playBound equals the x position of the object DestroyObstacleBorder
        playBound = GameObject.Find("DestroyObstacleBorder").transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < playBound)
        {
            //destroy the obstacle once it is off screen
            Destroy(gameObject);
        }
    }
}
