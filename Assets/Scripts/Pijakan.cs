using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pijakan : MonoBehaviour
{
    public GameObject stick;
    public float stickMovementAmount = 0.65f;
    public int maxJumpCount = 3;

    private Vector3 originalStickPosition;
    private bool isCharacterOnPijakan;
    private bool isStickMoved;
    private int jumpCount;

    private void Start()
    {
        originalStickPosition = stick.transform.position;
        isCharacterOnPijakan = false;
        isStickMoved = false;
        jumpCount = 0;
    }

    private void Update()
    {
        if (isCharacterOnPijakan && jumpCount < maxJumpCount)
        {
            if (!isStickMoved)
            {
                MoveStick();
                isStickMoved = true;
            }
        }
    }

    private void MoveStick()
    {
        float movement = stickMovementAmount;
        Vector3 targetPosition = originalStickPosition + stick.transform.up * (movement * (jumpCount + 1));
        stick.transform.position = targetPosition;

        Rigidbody2D stickRigidbody = stick.GetComponent<Rigidbody2D>();
        if (stickRigidbody != null)
        {
            stickRigidbody.isKinematic = false; // Mengaktifkan rigidbody agar stik jatuh
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            isCharacterOnPijakan = true;
            jumpCount++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            isCharacterOnPijakan = false;
        }
    }
}
