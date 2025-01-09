using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float dashSpeed = 10f;
    public float dashDuration = 0.2f;
    public float dashCooldown = 1f;

    private Vector2 movement;
    private Animator animator;
    private bool isDashing = false;
    private float dashStartTime;
    private float lastDashTime;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.magnitude);

        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastDashTime > dashCooldown)
        {
            isDashing = true;
            dashStartTime = Time.time;
            lastDashTime = Time.time;
        }

        if (isDashing)
        {
            if (Time.time - dashStartTime < dashDuration)
            {
                rb.velocity = movement * dashSpeed;
            }
            else
            {
                isDashing = false;
                rb.velocity = movement * speed;
            }
        }
        else
        {
            rb.velocity = movement * speed;
        }
    }
}