using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Menu : MonoBehaviour
{
    
    public void StartGame()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        
        Application.Quit();
    }
    
    
    
}
