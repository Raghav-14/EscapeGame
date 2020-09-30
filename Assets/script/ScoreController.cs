using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;

    private float score = 0.0f;

    private bool isDeath = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDeath)
            return;
        score += Time.deltaTime * 3.0f;
        scoreText.text = ((int)score).ToString();
    }

    public void OnDeath()
    {
        isDeath = true;
        PlayerPrefs.SetFloat("HighScore", score);
    }
}
