using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript2 : MonoBehaviour
{
    public Transform player;
    public float interactionDistance = 2f; // Jarak maksimum antara karakter dan objek skop

    public GameObject objectToActivate1;
    public GameObject objectToActivate2;
    public GameObject objectToActivate3;
    public GameObject Puzzle;
    public GameObject objectToInActivate;


    private bool isInteracting = false;
    private bool isPlayerNearby = false; // Menandakan apakah karakter berada di dekat objek skop

    public void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        isPlayerNearby = distanceToPlayer <= interactionDistance;
    }

    public void StartInteraction()
    {
        if (isPlayerNearby && !isInteracting)
        {
            isInteracting = true;
            objectToInActivate.SetActive(false);
            Puzzle.SetActive(true);
            // Memanggil fungsi untuk munculnya objek setelah beberapa detik
            Invoke("ActivateObjectA", 2f);
            Invoke("ActivateObjectB", 5f);
            Invoke("ActivateObjectC", 9f);
        }
    }

    private void ActivateObjectA()
    {
        objectToActivate1.SetActive(true);
    }

    private void ActivateObjectB()
    {
        objectToActivate2.SetActive(true);
    }

    private void ActivateObjectC()
    {
        objectToActivate3.SetActive(true);
    }

    public void StopInteraction()
    {
        if (isInteracting)
        {
            isInteracting = false;
        }
    }
}
