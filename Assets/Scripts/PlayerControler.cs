using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D rigidBody;


    [Header("Movement Properties")]
    public int direccion;
    public float moveSpeed;

    [Header("Jump Properties")]
    public float jumpForce;
    public bool jumpInputOn;

    [Header("Ground Check Properties")]
    public Transform groundCheckPoint;
    public float radius;
    public LayerMask whatIsGround;
    public bool isGrounded;

    [Header("Doble Jump Properties")]
    public bool doubleJump=true;

    [Header("Animations")]
    public Animator animator;

    Vector2 InputValue;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        doubleJump = true;
        direccion = 1;
        FlipSprite();
    }

    
    void Update()
    {
        MovementInput();

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            jumpInputOn = true;
        }
    }

    private void FixedUpdate()
    {
        MovementAction();

        GroundCheck();

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
            //animator.SetBool("IsMoving", true);
        }
        else if (InputValue.x < 0)
        {
            direccion = -1;
            FlipSprite();
            //animator.SetBool("IsMoving", true);
        }
        //else
        //{
        //    //animator.SetBool("IsMoving", false);
        //}

        animator.SetBool("IsMoving", InputValue.x != 0 ? true : false);
    }

    void MovementAction()
    {
        rigidBody.velocity = InputValue;
    }
    #endregion

    #region Jump

    void GroundCheck()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, radius, whatIsGround);
        animator.SetBool("InNotInGround", !isGrounded);


        if (isGrounded)
        {
            doubleJump = true;
        }
    }

    void Jump()
    {
        if (isGrounded)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
        }
        else if (doubleJump)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
            animator.SetBool("InNotInGround", true);
            doubleJump = false;
        }
        
    }

    #endregion
    void FlipSprite()
    {
        transform.eulerAngles = new Vector3(0, direccion == 1 ? 180f : 0, 0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0);
        Gizmos.DrawSphere(groundCheckPoint.position, radius);
    }
}
