using UnityEngine;

public class VirusBewarnaController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public GameObject[] holes;
    private int currentHoleIndex = 0;

    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player2"))
        {
            // Menghilangkan objek yang bergerak
            gameObject.SetActive(false);
        }
    }


}
