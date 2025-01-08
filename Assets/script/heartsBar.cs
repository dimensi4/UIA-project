using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heartsBar : MonoBehaviour
{
    public GameObject trois;
    public GameObject troisD;
    public GameObject deux;
    public GameObject deuxD;
    public GameObject un;
    public GameObject unD;
    public GameObject zero;

    private PlayerHearts playerHearts; // Declare as private


    private void Update()
    {
        PlayerHearts playerHearts = FindObjectOfType<PlayerHearts>();

        if (playerHearts.playerHearts >= 6)
        {
            trois.SetActive(true);
        }
        else
        {
            trois.SetActive(false);
        }

        if (playerHearts.playerHearts == 5)
        {
            troisD.SetActive(true);
        }
        else
        {
            troisD.SetActive(false);
        }

        if (playerHearts.playerHearts == 4)
        {
            deux.SetActive(true);
        }
        else
        {
            deux.SetActive(false);
        }

        if (playerHearts.playerHearts == 3)
        {
            deuxD.SetActive(true);
        }
        else
        {
            deuxD.SetActive(false);
        }

        if(playerHearts.playerHearts == 2)
        {
            un.SetActive(true);
        }
        else
        {
            un.SetActive(false);
        }

        if (playerHearts.playerHearts == 1)
        {
            unD.SetActive(true);
        }
        else
        {
            unD.SetActive(false);
        }

        if (playerHearts.playerHearts <= 0)
        {
            zero.SetActive(true);
        }
        else
        {
            zero.SetActive(false);
        }
    }
}
