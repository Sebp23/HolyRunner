using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTracker : MonoBehaviour
{
    public bool gameOver = false;
    public float gameOverTimer = 2;

    [SerializeField]
    public AudioClip explosionSound;

    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        //get the audio component
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //check to see if the object tagged "Obstacle" is hit by the player
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //play the explosion sound if the player hits an obstacle
            playerAudio.PlayOneShot(explosionSound, 1.0f);

            //set game over to true
            gameOver = true;
            Debug.Log("Game Over!");

            //execute the GameOver() method after 2 seconds (gameOverTimer value)
            Invoke("GameOver", gameOverTimer);
        }
    }

    private void GameOver()
    {
        //load the GameOver scene
        SceneManager.LoadScene("GameOver");
        //transition to the GameOver scene
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("GameOver"));
    }
}
