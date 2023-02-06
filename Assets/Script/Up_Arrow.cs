using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_Arrow : MonoBehaviour
{

    [SerializeField] public Sprite spriteA;
    [SerializeField] public Sprite spriteB;
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<SpriteRenderer>().sprite = spriteA;
        }
        if (Input.GetKeyUp (KeyCode.UpArrow))
        {
            GetComponent<SpriteRenderer>().sprite = spriteB;
        }
    }
}
