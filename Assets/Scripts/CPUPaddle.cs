using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUPaddle : Paddle
{
    // Attributes
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0)
        {
            if (ball.position.y > transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            } else if (ball.position.y < transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if (transform.position.y > 0)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            } else if (transform.position.y < 0)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            }
        }
    }
}
