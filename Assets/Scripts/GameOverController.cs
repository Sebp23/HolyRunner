using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public bool isPlayAgain;
    public bool isMainMenu;
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
        if (isPlayAgain)
        {
            //Load Prototype scene (main game scene) if "Play Again" is clicked
            SceneManager.LoadScene("Prototype");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Prototype"));
            Debug.Log("Scene Loaded!");
        }
        if (isCredits)
        {
            //load credits scene if "Credits" is clicked
            SceneManager.LoadScene("Credits");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Credits"));
            Debug.Log("Scene Loaded!");
        }
        if (isMainMenu)
        {
            //Load MainMenu scene if "Main Menu" is clicked
            SceneManager.LoadScene("MainMenu");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainMenu"));
            Debug.Log("Scene Loaded!");
        }
    }
}
