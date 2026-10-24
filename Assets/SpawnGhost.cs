using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhost : MonoBehaviour
{
    // The Ghost prefab to spawn
    public Transform enemy;

    // The location where the Ghost appears
    public Transform spawnPoint;

    void RespawnEnemy()
    {
        Instantiate(enemy, spawnPoint.transform.position,
                    spawnPoint.transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            RespawnEnemy();
        }
    }
}