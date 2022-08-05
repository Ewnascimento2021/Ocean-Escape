using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    private bool isKeyPressed;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isKeyPressed = true;
        }

       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isKeyPressed == true && other.CompareTag("Nota"))
        {
            {
                Destroy(other.gameObject);
                transform.localScale = new Vector2(3, 3);
                isKeyPressed = false;
            }
        }
    }
}
