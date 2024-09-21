using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    // Attributes
    public float bounceStrength;

    public void OnCollisionEnter2D(Collision2D other)
    {
        Ball ball = other.gameObject.GetComponent<Ball>();
        if (ball == null) return;

        Vector2 normal = other.GetContact(0).normal;
        ball.AddForce(-normal * bounceStrength);
    }
    
}
