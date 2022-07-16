using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField]
    private Renderer renderer1;
    [SerializeField]
    private float speed;

    private Material material;
    private Vector2 offsetMaterial;

    void Start()
    {
        material = renderer1.material;
        offsetMaterial = material.GetTextureOffset("_MainTex");
    }

   
    void Update()
    {
        offsetMaterial.y -= speed * Time.deltaTime;
        material.SetTextureOffset("_MainTex",offsetMaterial);
    }
}
