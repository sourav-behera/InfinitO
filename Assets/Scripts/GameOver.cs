using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class GameOver : MonoBehaviour
{   
    public static GameOver gameover;
    
    public TextMeshProUGUI _scoreText;
    public TextMeshProUGUI _highscoreText;
   private void Start() {
       if (gameover == null) gameover = this;
       gameObject.SetActive(false);
   }
    public void Over(){
        gameObject.SetActive(true);
        Time.timeScale = 0;
        _scoreText.text = "SC: " + ScoreManager.scoreManager.score.ToString();
        _highscoreText.text = "HI : " + PlayerPrefs.GetInt("Highscore").ToString();


    }
    public void Restart(){
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
    public void Quit(){
        Application.Quit();
    }
    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

}
