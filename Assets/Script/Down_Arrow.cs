using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down_Arrow : MonoBehaviour
{
    [SerializeField] public Sprite spriteA;
    [SerializeField] public Sprite spriteB;
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<SpriteRenderer>().sprite = spriteA;
        }
        if (Input.GetKeyUp (KeyCode.DownArrow))
        {
            GetComponent<SpriteRenderer>().sprite = spriteB;
        }
    }
}
