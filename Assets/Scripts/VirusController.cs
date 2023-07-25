using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusController : MonoBehaviour
{
    public float moveSpeed = 2f;

    private void Update()
    {
        MoveVirusLeft();
    }

    private void MoveVirusLeft()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1") || collision.CompareTag("Player2") || collision.CompareTag("Peluru") || collision.CompareTag("Benteng"))
        {
            Destroy(gameObject);
        }
    }
}
