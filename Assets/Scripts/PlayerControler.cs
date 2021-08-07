using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public int direccion;
    public float moveSpeed;
    Vector2 InputValue;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        MovementInput();
    }

    private void FixedUpdate()
    {
        MovementAction();
    }

    void Movement_1()
    {
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            direccion = -1;
            rigidBody.velocity = new Vector2(direccion * moveSpeed, rigidBody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            direccion = 1;
            rigidBody.velocity = new Vector2(direccion * moveSpeed, rigidBody.velocity.y);
        }
    }

    void MovementInput()
    {
        InputValue = new Vector2(Input.GetAxisRaw("Horizontal")*moveSpeed, rigidBody.velocity.y);
    }

    void MovementAction()
    {
        rigidBody.velocity = InputValue;
    }
}
