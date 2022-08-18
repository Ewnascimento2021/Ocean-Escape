using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public bool isPressed;
    private GameManager gm;

    private void Start()
    {
        gm = GetComponent<GameManager>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (isPressed)
        {
            isPressed = false;
            gm.ScoreUp();
            Destroy(other.gameObject);
        }
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isPressed = true;
        }
    }
    //private void FixedUpdate()
    //{
    //    if (Input.GetButtonDown("Jump"))
    //    { 
    //        isPressed = true;
    //    }
    //    else
    //    {
    //        isPressed = false;
    //    }
    //}
}

