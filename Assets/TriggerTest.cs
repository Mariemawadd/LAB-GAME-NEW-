using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TRIGGER TEST SCRIPT IS RUNNING");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("TRIGGER ENTERED BY: " + other.name);
    }
}
