using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public string levelToLoad;
    public string LoadMenu;

    public void Return()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void Menu()
    {
        SceneManager.LoadScene(LoadMenu);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
