using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour
{
    public bool isStart;
    public bool isMainMenu;

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
            //load the main game scene, "prototype" if the player clicks the "Start" button
            SceneManager.LoadScene("Prototype");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Prototype"));
            Debug.Log("Scene Loaded!");
        }
        if (isMainMenu)
        {
            //load the MainMenu scene if player clicks "Main Menu" button
            SceneManager.LoadScene("MainMenu");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainMenu"));
            Debug.Log("Scene Loaded!");
        }
    }
}
