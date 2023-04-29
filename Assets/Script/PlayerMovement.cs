using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private SpriteRenderer _sprite;
    Vector2 movement;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
        
    }
    private void Start()
    {
        transform.position = new Vector3(12, 8, 0);
    }
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        _animator.SetFloat("speed", movement.magnitude);

        if (movement.x < 0)
        {
            _sprite.flipX= true;
        }
        if (movement.x > 0)
        {
            _sprite.flipX = false;
        }
    }
    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + movement * speed* Time.fixedDeltaTime);
    }
}
