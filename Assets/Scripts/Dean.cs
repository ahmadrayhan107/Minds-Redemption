using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dean : MonoBehaviour
{

    private Rigidbody2D rigidBody;

    private Animator animator;

    [SerializeField] private float speed = 2f;

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

        rigidBody.velocity = new Vector2(inputX * speed, rigidBody.velocity.y);

        if (inputX != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(inputX), 1, 1);
        }

        animator.SetBool("IsRun", inputX != 0); 
    }
}
