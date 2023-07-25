using UnityEngine;

public class VirusSpawner : MonoBehaviour
{
    public GameObject virusPrefab;
    public Transform[] spawnPoints;
    public float[] spawnIntervals;

    private float spawnTimer = 0f;
    private int spawnIndex = 0;
    private bool isSpawning = false;


    private void Start()
    {
        StartSpawning();
    }

    private void Update()
    {
        
        if (isSpawning)
        {
            spawnTimer += Time.deltaTime;

            if (spawnTimer >= spawnIntervals[spawnIndex])
            {
                SpawnVirus();
                spawnIndex++;

                if (spawnIndex >= spawnPoints.Length)
                {
                    spawnIndex = 0;
                }

                spawnTimer = 0f;
            }
        }
    }

    private void SpawnVirus()
    {
        Instantiate(virusPrefab, spawnPoints[spawnIndex].position, Quaternion.identity);
    }

    private void StartSpawning()
    {
        isSpawning = true;
        Invoke("StopSpawning", 7f);
    }

    private void StopSpawning()
    {
        isSpawning = false;
    }
}
