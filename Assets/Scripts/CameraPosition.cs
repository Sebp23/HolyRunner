using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public float horizontalResolution = 1920;

    void OnGUI()
    {
        float currentAspect = (float)Screen.width / (float)Screen.height;
        Camera.main.orthographicSize = horizontalResolution / currentAspect / 200;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Screen.SetResolution(1920, 1080, true);
        //OnGUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
