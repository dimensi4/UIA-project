using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAllSounds : MonoBehaviour
{
    public bool mutee = false;
    public GameObject mutWindow;
    public GameObject enmutWindow;

    public void muteAllSounds()
    {
        // Trouver tous les objets avec un AudioSource
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();

        // Couper le son de tous les AudioSource
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.mute = true;
            mutee = true;
        }

        if (mutee = true)
        {
            mutWindow.SetActive(true);
        }
        else
        {
            mutWindow.SetActive(false);
        }

        if (mutee = false)
        {
            enmutWindow.SetActive(true);
        }
        else
        {
            enmutWindow.SetActive(false);
        }
    }
}
