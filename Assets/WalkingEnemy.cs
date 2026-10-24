using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : EnemyController
{
    public Transform leftPoint;
    public Transform rightPoint;

    private Rigidbody2D rb;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        // Start moving right
        sr.flipX = false;
    }

    void FixedUpdate()
    {
        // Reached right wall: move left
        if (rightPoint != null &&
            transform.position.x >= rightPoint.position.x)
        {
            sr.flipX = true;
        }

        // Reached left wall: move right
        if (leftPoint != null &&
            transform.position.x <= leftPoint.position.x)
        {
            sr.flipX = false;
        }

        // Move enemy
        if (sr.flipX == true)
        {
            rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
        }
    }
}