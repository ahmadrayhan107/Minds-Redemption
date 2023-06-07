using UnityEngine;
using UnityEngine.UI;

public class SaklarBerwarna : MonoBehaviour
{
    public Transform player;
    public float interactionDistance = 2f; // Jarak maksimum antara karakter dan objek saklar

    public GameObject objectToDisappear; // Objek yang akan menghilang

    
    private bool isInteracting = false;
    private bool isPlayerNearby = false; // Menandakan apakah karakter berada di dekat objek saklar

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
            objectToDisappear.SetActive(false);
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
