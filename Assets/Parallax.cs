using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed = 1f;
    Renderer back;
    void Start()
    {
        back = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0,speed * Time.deltaTime);

        back.material.mainTextureOffset += offset;
    }
}
