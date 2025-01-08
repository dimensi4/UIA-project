using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob1 : MonoBehaviour
{
    public int degats = 1;
    PlayerHearts playerHearts;
    private void Start()
    {
        playerHearts = FindObjectOfType<PlayerHearts>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!playerHearts.isTuch)
            {
                playerHearts.isTuch = true;
                playerHearts.playerHearts -= degats;
                StartCoroutine(tuch());
            }
        }
    }


    IEnumerator tuch()
    {
        yield return new WaitForSeconds(3f);
        playerHearts.isTuch = false;
    }
}
