using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    // Attributes
    private Vector2 _direction;
    
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        } 
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }
    
    // FixedUpdate is for physics
    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude > 0)
        {
            _rigidbody.AddForce(_direction * speed);
        }
    }
}
