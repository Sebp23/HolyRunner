using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //determines the position of the score on the HUD
        transform.position = Camera.main.ViewportToWorldPoint(new Vector3(5, 0f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
