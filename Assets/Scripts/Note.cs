using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    private float noteSpeed;
    public bool noteEnabled;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position = new Vector2(transform.position.x -1 * Time.deltaTime * noteSpeed, transform.position.y);

        if (noteEnabled && Input.GetButtonDown("Touch"))
        {
            Destroy(gameObject);
        }
    }
}
