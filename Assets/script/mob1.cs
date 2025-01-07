using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob1 : MonoBehaviour
{
    public int degats = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHearts playerHearts = FindObjectOfType<PlayerHearts>();
            playerHearts.playerHearts -= degats;
        }
    }
}
