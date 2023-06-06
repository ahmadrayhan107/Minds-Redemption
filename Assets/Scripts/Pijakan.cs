using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pijakan : MonoBehaviour
{
    public GameObject stick;
    public float stickMovementAmount = 0.5f;

    private Vector3 originalStickPosition;
    private int jumpCount;
    private bool isCharacterOnPijakan;

    private void Start()
    {
        originalStickPosition = stick.transform.position;
        jumpCount = 0;
        isCharacterOnPijakan = false;
    }

    private void Update()
    {
        if (isCharacterOnPijakan && jumpCount > 0)
        {
            MoveStick(jumpCount);
        }
    }

    private void MoveStick(int count)
    {
        float movement = stickMovementAmount * count;
        Vector3 targetPosition = originalStickPosition + stick.transform.right * movement;
        stick.transform.position = targetPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isCharacterOnPijakan = true;
            jumpCount++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            jumpCount--;
            if (jumpCount <= 0)
            {
                isCharacterOnPijakan = false;
            }
        }
    }
}
