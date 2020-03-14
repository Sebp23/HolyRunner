using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{
    //[SerializeField]
    public float speed = 15;
    public float addedSpeed;
    private float speedIncreaseStartDelay = 5f;
    private float speedIncreaseInterval = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpeedIncrease", speedIncreaseStartDelay, speedIncreaseInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpeedIncrease()
    {
        addedSpeed = 5f;
        speed += addedSpeed;

        Debug.Log($"Speed increased: {speed}");
    }
}
