using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField]
    private float speedBackground;
    private Vector2 startPos;
    private float widthBackgroud;


    void Start()
    {
        startPos = transform.position;
        widthBackgroud = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {
        if (transform.position.x < startPos.x - widthBackgroud)
        {
            transform.position = startPos;
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speedBackground, startPos.y);
        }
    }
}
