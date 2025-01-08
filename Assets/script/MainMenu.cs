using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad; 

    public GameObject settingsWindow;

    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void Credits()
    {
         settingsWindow.SetActive(true);  
    }

    public void CloseCredits()
    { 
        settingsWindow.SetActive(false); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
