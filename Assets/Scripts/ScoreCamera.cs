using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCamera : MonoBehaviour
{
    //failure gallery
    //public Vector3 scorePos = new Vector3(0, 1, 0.25f);
    //public Vector3 ViewportToWorldPoint(Vector3 scorepos);

    //Vector3 scorePos = new Vector3(0, 1, 0.25f);
    //transform.position = GetComponent<Camera>(ViewportToWorldPoint(scorePos));

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Camera.main.ViewportToWorldPoint(new Vector3(5, 0f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
