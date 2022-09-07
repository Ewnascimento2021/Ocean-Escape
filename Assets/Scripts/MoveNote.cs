using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNote : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isInside;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isInside = false;
    }

    private void Update()
    {
        if (isInside && Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.sequenceHits++;
            HUDController.Instance.ScoreUp();
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(new Vector2(transform.position.x - NoteManager.Instance.speed, transform.position.y));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isInside = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isInside = false;
    }
}
