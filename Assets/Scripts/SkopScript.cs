using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkopScript : MonoBehaviour
{
    public Transform player;
    public float interactionDistance = 2f; // Jarak maksimum antara karakter dan objek skop

    public GameObject objectToInActivate2; // Objek yang akan menghilang
    public GameObject objectToActivate;
    public GameObject objectToActivate2;
    public GameObject objectToInActivate;
    
    private bool isObjectActive = false;
    private bool isInteracting = false;
    private bool isPlayerNearby = false; // Menandakan apakah karakter berada di dekat objek skop

    public void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        isPlayerNearby = distanceToPlayer <= interactionDistance;

        isObjectActive = !isObjectActive;
    }

    public void StartInteraction()
    {
        if (isPlayerNearby && !isInteracting)
        {
            isInteracting = true;
            objectToInActivate2.SetActive(false);
            objectToActivate.SetActive(true);
            objectToActivate2.SetActive(true);
            objectToInActivate.SetActive(false);
        }
    }

     public void StopInteraction()
    {
        if (isInteracting)
        {
            isInteracting = false;
        }
    }
}
