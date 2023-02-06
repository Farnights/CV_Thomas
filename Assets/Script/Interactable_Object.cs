using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interactable_Object : MonoBehaviour
{
    [SerializeField] public bool _isInRange;
    [SerializeField] private GameObject _interactable;
    [SerializeField] private Animator _animator;
    [SerializeField] private bool _isTrigger;
    [SerializeField] private GameObject _fade;
    [SerializeField] private GameObject _glove;

    private void Start()
    {
        _isTrigger = false;

        _animator = _fade.GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            _isInRange = true;
            _glove.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _isInRange = false;
            _glove.SetActive(true);
        }
    }
    
    private void Update()
    {
        if (_isInRange == true && Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("Fade", true);
            _isTrigger = true;
        }

        if (_isInRange == false)
        {
            _animator.SetBool("Fade", false);
            _isTrigger = false;
        }
    }
}
