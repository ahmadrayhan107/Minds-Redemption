using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dean : MonoBehaviour
{

    private Rigidbody2D rigidBody;

    private Animator animator;

    [SerializeField] private Transform groundCheck;

    [SerializeField] private float groundCheckRadius = 0.05f;

    [SerializeField] private float speed = 2f;

    [SerializeField] private float jumpForce = 10f;

    [SerializeField] private LayerMask collisionMask;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var inputX = Input.GetAxisRaw("Horizontal");
        var jumpInput = Input.GetButton("Jump"); 

        rigidBody.velocity = new Vector2(inputX * speed, rigidBody.velocity.y);

        if(jumpInput && IsGrounded())
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
        }

        if (inputX != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(inputX), 1, 1);
        }

        animator.SetBool("IsJump", IsGrounded());
        animator.SetBool("IsRun", inputX != 0); 
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, collisionMask);
    }
}
