using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseHeart : MonoBehaviour
{
    public Transform player;
    public float interactionDistance = 0.1f; // Jarak maksimum antara karakter dan objek skop
    private Vector2 initialPosition;


    public GameObject objectToInActivate;
    private Nyawa nyawa;


    private bool isObjectActive = false;
    private bool isInteracting = false;
    private bool isPlayerNearby = false; // Menandakan apakah karakter berada di dekat objek skop

    void Start()
    {
        initialPosition = transform.position;
        nyawa = FindObjectOfType<Nyawa>();
    }

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
            RespawnCharacter();
            nyawa.KurangiNyawa(1);
            objectToInActivate.SetActive(false);
        }
    }

    /* public void StartInteraction()
    {
        if (isPlayerNearby && !isInteracting && !isObjectActive)
        {
            isInteracting = true;
            nyawa.KurangiNyawa(1);
            objectToInActivate.SetActive(false);
        }
    } */


     public void StopInteraction()
    {
        if (isInteracting)
        {
            isInteracting = false;
        }
    }

    private void RespawnCharacter()
    {
        transform.position = initialPosition;
    }
}
