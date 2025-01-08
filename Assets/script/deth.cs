using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deth : MonoBehaviour
{
    private PlayerHearts playerHearts;

    public GameObject dethWindow;

    public string restart;

    public string gomenu;

    public void RestartGame()
    {
        SceneManager.LoadScene(restart);
    }
    public void goToMenu()
    {
        SceneManager.LoadScene(gomenu);
    }

    void Update()
    {
        PlayerHearts playerHearts = FindObjectOfType<PlayerHearts>();

        if (playerHearts.playerHearts <= 0)
        {
            dethWindow.SetActive(true);
            Time.timeScale = 0;
        }
       
    }
}
