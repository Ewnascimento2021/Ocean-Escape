using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    private bool isKeyPressed;
    private int Live;
    void Start()
    {
        Live = 3;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isKeyPressed = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (isKeyPressed)
        {
            Destroy(other.gameObject);
            Live += 1;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (!isKeyPressed)
        {
            Live -= 1;
        }
    }
}
