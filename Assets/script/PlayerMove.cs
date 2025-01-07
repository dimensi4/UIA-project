using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public Rigidbody2D rb;
    public float Vitesse = 5f;
    Vector2 mouvement;
    public Animator animator;

    void Update()
    {
        mouvement.x = Input.GetAxisRaw ("Horizontal");
        mouvement.y = Input.GetAxisRaw ("Vertical");

        animator.SetFloat("Horizontal", mouvement.x);
        animator.SetFloat("Speed",mouvement.magnitude);

        rb.MovePosition(rb.position + Time.deltaTime * Vitesse * mouvement);
    }
}
