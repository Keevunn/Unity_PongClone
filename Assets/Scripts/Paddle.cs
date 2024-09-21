using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Attributes
    protected Rigidbody2D _rigidbody;
    public float speed = 10.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    
    public void ResetPosition()
    {
        _rigidbody.position *= (new Vector2(1, 0));
        _rigidbody.velocity = Vector3.zero;
    }

}
