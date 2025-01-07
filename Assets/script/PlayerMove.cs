using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public Rigidbody2D rb;
    public float vitesse = 5f;
    Vector2 mouvement;
    public Animator animator;

    public float Vitesse { get => vitesse; set => vitesse = value; }

    void Update()
    {
        mouvement.x = Input.GetAxisRaw ("Horizontal");
        mouvement.y = Input.GetAxisRaw ("Vertical");

        animator.SetFloat("Horizontal", mouvement.x);
        animator.SetFloat("Speed",mouvement.magnitude);

        rb.MovePosition(rb.position + Vitesse * mouvement);
    }
}
