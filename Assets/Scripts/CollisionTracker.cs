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
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            playerAudio.PlayOneShot(explosionSound, 1.0f);

            gameOver = true;
            Debug.Log("Game Over!");

            Invoke("GameOver", gameOverTimer);
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene("GameOver");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("GameOver"));
    }
}
