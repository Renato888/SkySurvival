using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectores : MonoBehaviour
{
    public float speed;
    int localBase = 1;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward, speed);
            transform.localScale = Vector2.one * (localBase + speed);
            speed += .1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = Vector2.one * (localBase - speed);
            speed -= .1f;
            transform.Rotate(Vector3.forward, -speed);
        }
    }
}
