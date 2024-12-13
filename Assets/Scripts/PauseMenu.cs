using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public bool PauseGame;
    public GameObject pauseMenu;

    [SerializeField] private AudioSource audioButton;
    
    

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale=1f;
        PauseGame = false;
        audioButton.Play();
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
        audioButton.Play();
    }

    public void LoadMenu()
    {
        audioButton.Play();
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        audioButton.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
        Time.timeScale = 1f;
    }

    public void Continue()
    {
        audioButton.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
