using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTimer : MonoBehaviour
{
    private float timer = 0.0f;
    public Text scoreTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AddSecond();
    }

    private void AddSecond()
    {
        timer += Time.deltaTime;
        int score = Mathf.RoundToInt(timer);
        scoreTime.text = ($"Score: {score.ToString()}");
    }
}
