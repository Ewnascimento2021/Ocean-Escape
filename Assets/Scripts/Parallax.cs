using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public GameObject cameraPlayer;
    private float lenght;
    private float starPos;
    public float speedParallax;
    void Start()
    {
        starPos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    
    void Update()
    {
        float temp = (cameraPlayer.transform.position.x * (1 - speedParallax));
        float dist = (cameraPlayer.transform.position.x * speedParallax);

        transform.position = new Vector3(starPos + dist, transform.position.y, transform.position.z);

        if (temp> starPos + lenght)
        {
            starPos += lenght;
        }
        else if (temp < starPos - lenght)
        {
            starPos -= lenght;
        }
    }
}
