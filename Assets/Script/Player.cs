using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private GameObject _player;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _animator;
    
    private Vector2 movement;
    private void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        _animator.SetFloat("Horizontal", movement.x);
        _animator.SetFloat("Vertical", movement.y);
        _animator.SetFloat("Speed", movement.sqrMagnitude);
        
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            _player.transform.position += Vector3.up * _speed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _player.transform.position += Vector3.down * _speed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _player.transform.position += Vector3.right * _speed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _player.transform.position += Vector3.left * _speed * Time.deltaTime;
        }*/
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + movement * _speed * Time.fixedDeltaTime);
    }
}
