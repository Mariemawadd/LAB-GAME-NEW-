using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GhostEnemy : EnemyController
{
    // Ghosts can pass through walls, so override the superclass trigger.
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
            Flip();
        }
    }
}
