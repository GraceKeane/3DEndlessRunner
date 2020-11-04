﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to detect if the player runs into a purple diamond

public class PDiamond : MonoBehaviour
{
    // Allowing the diamond to rotate for visual effect
    public float turnSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {
        // Check that the object we collided with is the player
        if (other.gameObject.name != "Player")
        {
            // Stop executing rest of the function if not player
            return;
        }

        // Add to the player's score

        // Destroy purple diamond that player just collided with 
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
