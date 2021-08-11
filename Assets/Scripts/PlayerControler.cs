using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D rigidBody;


    [Header("Movement Properties")]
    public int direccion;
    public float moveSpeed;

    [Header("Jump Properties")]
    public float jumpForce;
    public bool jumpInputOn;

    public Vector2 InputValue;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        direccion = 1;
        FlipSprite();
    }

    
    void Update()
    {
        MovementInput();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpInputOn = true;
        }
    }

    private void FixedUpdate()
    {
        MovementAction();

        if (jumpInputOn)
        {
            Jump();
            jumpInputOn = false;
        }
    }

    #region Movement
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

        if (InputValue.x > 0)
        {
            direccion = 1;
            FlipSprite();
        }
        else if (InputValue.x < 0)
        {
            direccion = -1;
            FlipSprite();
        }
        //else
        //{
        //    direccion = 0;
        //}
    }

    void MovementAction()
    {
        rigidBody.velocity = InputValue;
    }
    #endregion

    #region Jump

    void Jump()
    {
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
    }

    #endregion
    void FlipSprite()
    {
        transform.eulerAngles = new Vector3(0, direccion == 1 ? 180f : 0, 0);
    }
}
