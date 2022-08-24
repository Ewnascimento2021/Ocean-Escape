using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public bool isPressed;
    [SerializeField]
    private HUDController hc;

  

    private void OnTriggerStay2D(Collider2D other)
    {
        if (isPressed)
        {
            isPressed = false;
            hc.ScoreUp();
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
}

