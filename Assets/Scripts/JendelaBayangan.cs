using UnityEngine;
using UnityEngine.UI;

public class JendelaBayangan : MonoBehaviour
{
    public Transform player;
    public float interactionDistance; // Jarak maksimum antara karakter dan objek saklar

    public GameObject objectToDisappear; // Objek yang akan menghilang
    public GameObject objectToDisappear2; // Objek yang akan menghilang
    public GameObject objectToDisappear3; // Objek yang akan menghilang

    
    private bool isInteracting = false;
    private bool isPlayerNearby = false; // Menandakan apakah karakter berada di dekat objek saklar

    // Otomatis Memperkuat Daya Lompat
    private KarakterBewarna jumpForce;

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
            objectToDisappear2.SetActive(false);
            objectToDisappear3.SetActive(false);
            jumpForce = FindObjectOfType<KarakterBewarna>();
            jumpForce.jumpHeight = -5f;
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
