using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameControllerLevel : MonoBehaviour
{
    public Text highScore;
    public Slider musicSlider;
    void Awake()
    {
        
        AudioSource music = this.GetComponent<AudioSource>();
        musicSlider.value = music.volume;
        DontDestroyOnLoad(this.gameObject);

    }

    void Start()
    {
        highScore.text = "HighScore:" + ((int)PlayerPrefs.GetFloat("HighScore")).ToString();     
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("dot_1");
    }
    // Start is called before the first frame update

    public void ChangeVolume(float volume)
    {
        AudioSource music = this.GetComponent<AudioSource>();
        music.volume = volume;
    }
}
