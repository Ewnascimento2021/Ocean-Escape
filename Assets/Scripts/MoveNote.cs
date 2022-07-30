using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNote : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    public float speed;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        rb.MovePosition(new Vector2(transform.position.x - speed , transform.position.y));
    }

}
