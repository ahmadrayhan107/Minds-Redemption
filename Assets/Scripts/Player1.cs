using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) {
            rb.velocity = Vector2.left * speed;
        }

        if(Input.GetKey(KeyCode.RightArrow)) {
            rb.velocity = Vector2.right * speed;
        }
    }
}
