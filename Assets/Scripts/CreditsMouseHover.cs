﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMouseHover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //set material to white on start
        GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        //set material to red when mouse enters box collider
        GetComponent<Renderer>().material.color = Color.red;
    }

    void OnMouseExit()
    {
        //set material back to white when mouse leave box collider
        GetComponent<Renderer>().material.color = Color.white;
    }
}
