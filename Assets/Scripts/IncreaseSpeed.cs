using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{
    public float speed = 15;
    public float addedSpeed;
    private float speedIncreaseStartDelay = 5f;
    private float speedIncreaseInterval = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //execute the method SpeedIncrease() after 5 seconds, then repeat it every 5 seconds
        InvokeRepeating("SpeedIncrease", speedIncreaseStartDelay, speedIncreaseInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpeedIncrease()
    {
        //determine how much speed will be added to the total speed
        addedSpeed = 5f;
        //add 5 to the total speed
        speed += addedSpeed;

        Debug.Log($"Speed increased: {speed}");
    }
}
