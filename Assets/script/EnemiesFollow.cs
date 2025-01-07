using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        GameObject player = GameObject.Find("Chill-guy");

        if (player != null)
        {
            // Calcul de la direction vers le joueur
            Vector3 direction = player.transform.position - transform.position;

            // Normalisation du vecteur direction pour obtenir une direction unitaire
            direction.Normalize();

            // Déplacement de l'ennemi
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}

