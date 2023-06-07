using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterBayangan : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public float speed = 2;
    private bool hasJumped = false;
    private bool isGrounded = false;
    private Vector2 initialPosition;
    private Nyawa nyawa;
    private Animator animator;

     private AnchorGameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        nyawa = FindObjectOfType<Nyawa>();
        animator = GetComponent<Animator>();

        moveLeft = false;
        moveRight = false;
        gameObject = GetComponent<AnchorGameObject>();
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
        gameObject.executeInUpdate = false;
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
        gameObject.executeInUpdate = false;
    }

    public void PointerUpRight()
    {
        moveRight = false;
    }

    public void PointerDownAbove()
    {
        if (!hasJumped && isGrounded)
        {
            Quaternion rotation = transform.rotation;
            float jumpHeight = 3f;
            float jumpHorizontalSpeed = 5f;

            float jumpDirection = (rotation.eulerAngles.y == 0f) ? 1f : -1f;

            // Menetapkan kecepatan horizontal karakter
            horizontalMove = jumpDirection * jumpHorizontalSpeed;

            // Melompat ke atas dengan ketinggian 3
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);

            hasJumped = true;
            gameObject.executeInUpdate = false;
        }
    }

    public void PointerUpAbove()
    {
        // Tidak ada tindakan yang perlu dilakukan saat tombol di atas dilepas
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Constraint"))
        {
            hasJumped = false;
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Constraint"))
        {
            isGrounded = false;
        }
    }



    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        animator.SetBool("IsRun", moveLeft || moveRight);
        animator.SetBool("IsJump", hasJumped);
    }

    private void MovePlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
            transform.localScale = new Vector3(Mathf.Sign(horizontalMove), 1, 1);
        }
        else if (moveRight)
        {
            horizontalMove = speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            horizontalMove = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("lubang"))
        {
            RespawnCharacter();
            nyawa.KurangiNyawa(1);
        }
    }

    // private void DestroyCharacter()
    // {
    //     isDestroyed = true;
    //     Destroy(gameObject);
    //     RespawnCharacter();
    // }

    private void RespawnCharacter()
    {
        transform.position = initialPosition;

    }
}