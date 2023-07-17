using UnityEngine;

public class VirusBayanganController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public GameObject[] holes;
    public GameObject bunker;
    public int maxVirusCount = 10;
    public float respawnDelay = 0.3f;
    private int currentHoleIndex = 0;


    private int activeVirusCount = 0;
    private int infectedBunkerCount = 0;
    private int remainingLives = 3;
    private bool isGameRunning = false;

    private void Start()
    {
        StartGame();
    }

    private void Update()
    {
        if (isGameRunning)
        {
            MoveVirus();
        }
    }

    private void StartGame()
    {
        isGameRunning = true;
        activeVirusCount = 0;
        infectedBunkerCount = 0;
        remainingLives = 3;

        InvokeRepeating("SpawnVirus", 0f, respawnDelay);
    }

    private void MoveVirus()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            remainingLives--;
            Debug.Log("Life reduced! Remaining lives: " + remainingLives);

            if (remainingLives <= 0)
            {
                EndGame();
            }
        }
        else if (collision.CompareTag("Bunker"))
        {
            infectedBunkerCount++;
            remainingLives--;
            Debug.Log("Bunker infected! Life reduced! Remaining lives: " + remainingLives);

            if (remainingLives <= 0)
            {
                EndGame();
            }
        }
    }

    private void EndGame()
    {
        isGameRunning = false;
        Debug.Log("Game Over! You lost.");
    }

    public void DestroyVirus()
    {
        activeVirusCount--;
    }

    private void SpawnVirus()
    {
        if (activeVirusCount < maxVirusCount)
        {
            if (currentHoleIndex >= holes.Length)
            {
                currentHoleIndex = 0;
            }

            GameObject newVirus = Instantiate(gameObject, holes[currentHoleIndex].transform.position, Quaternion.identity);
            currentHoleIndex++;
            activeVirusCount++;

            VirusBayanganController virusController = newVirus.GetComponent<VirusBayanganController>();
            virusController.SetBunker(bunker);
        }
    }

    public void SetBunker(GameObject targetBunker)
    {
        bunker = targetBunker;
    }
}
