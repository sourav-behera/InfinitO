using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseMenu; 
    private void Awake() {
        pauseMenu.SetActive(false);
    }
    

    public void Pause(){
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void Resume(){
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    public void Quit(){
        Application.Quit();
    }
    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
