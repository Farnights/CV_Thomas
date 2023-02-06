using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right_Arrow : MonoBehaviour
{
    [SerializeField] public Sprite spriteA;
    [SerializeField] public Sprite spriteB;
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().sprite = spriteA;
        }
        if (Input.GetKeyUp (KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().sprite = spriteB;
        }
    }
}
