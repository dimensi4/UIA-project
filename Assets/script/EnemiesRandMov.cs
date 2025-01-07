using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesRandMov : MonoBehaviour
{
    public float vitesse;
    public float intervalleChangementDirection;
    private float tempsDepuisDernierChangement;

    void Update()
    {
        tempsDepuisDernierChangement += Time.deltaTime;

        if (tempsDepuisDernierChangement >= intervalleChangementDirection)
        {
            // G�n�rer une direction al�atoire
            Vector2 direction = Random.insideUnitCircle;

            // Appliquer une force dans cette direction
            GetComponent<Rigidbody2D>().velocity = direction * vitesse;

            tempsDepuisDernierChangement = 0;
        }
    }
}
