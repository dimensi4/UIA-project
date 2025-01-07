using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob : MonoBehaviour
{
    public float vitesse;
    public Transform joueur;

    void Update()
    {
        // Calculer la direction vers le joueur
        Vector2 direction = joueur.position - transform.position;

        // Normaliser la direction pour avoir une longueur de 1
        direction.Normalize();

        // Appliquer une force dans cette direction
        GetComponent<Rigidbody2D>().velocity = direction * vitesse;
    }
}
