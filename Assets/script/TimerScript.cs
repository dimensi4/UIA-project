using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    private float timeElapsed;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        TimeSpan t = TimeSpan.FromSeconds(timeElapsed);
        uiText.text = string.Format("{0:D2}:{1:D2}:{2:D3}", t.Minutes, t.Seconds, t.Milliseconds);

        if (t.Minutes == 0 && t.Seconds == 0 && t.Milliseconds == 0)
        {
            Time.timeScale = 1;
        }
    }
}