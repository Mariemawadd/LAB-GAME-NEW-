using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float maxSpeed = 2f;
    public int damage = 1;
    public SpriteRenderer sr;

    private bool playerTouching = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void Flip()
    {
        sr.flipX = !sr.flipX;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (!playerTouching)
            {
                FindObjectOfType<PlayerStats>().TakeDamage(damage);
                playerTouching = true;
            }
        }
    
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerTouching = false;
        }
    }
}