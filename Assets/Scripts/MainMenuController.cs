using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public bool isStart;
    public bool isQuit;
    public bool isCredits;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        if (isStart)
        {
            //Actual Game level is scene 1
            SceneManager.LoadScene(1);
            Debug.Log("Scene Loaded!");
        }
        if (isCredits)
        {
            //credits is scene 3
            SceneManager.LoadScene(3);
            Debug.Log("Scene Loaded!");
        }
        if (isQuit)
        {
            Application.Quit();
            Debug.Log("Scene Loaded!");
        }
    }
}
