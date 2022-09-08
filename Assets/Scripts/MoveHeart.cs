using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHeart : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(new Vector2(transform.position.x - NoteManager.Instance.speed, transform.position.y));
    }
}
