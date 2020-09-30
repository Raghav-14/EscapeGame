using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour { 

     public static UiManager instance;

     public GameObject tapText;
    public GameObject titlePanel;
    public GameObject gameOverPanel;


    void Awake()
    {
        if (instance == null) // if once hasn't been created yet
            instance = this; // makes sure there is only once instance, set to this (first) one
    }
    // Start is called before the first frame update
    public void GameStart()
    {
        
        

            tapText.SetActive(false);
            titlePanel.GetComponent<Animator>().Play("panelUp");

    }

    public void GameOver()
    {
        //score.text = PlayerPrefs.GetInt("score").ToString();
        //highScore2.text = PlayerPrefs.GetInt("highScore").ToString();
        gameOverPanel.SetActive(true);
    }

    public void Reset()
    {
        SceneManager.LoadScene(0); // can pass name of scene or index of scene in build settings
    }

}
