using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left_Arrow : MonoBehaviour
{
    [SerializeField] public Sprite spriteA;
    [SerializeField] public Sprite spriteB;
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().sprite = spriteA;
        }
        if (Input.GetKeyUp (KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().sprite = spriteB;
        }
    }
}
