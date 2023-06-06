using UnityEngine;
using UnityEngine.UI;

public class SaklarBayangan : MonoBehaviour
{
    public KeyCode interactionKey = KeyCode.E; // Tombol interaksi yang akan digunakan
    public float interactionDistance = 2f; // Jarak maksimum antara karakter dan objek saklar

    public GameObject objectToDisappear; // Objek yang akan menghilang
    public GameObject objectToDisappear2; // Objek yang akan menghilang

    public Transform player;
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
            objectToDisappear2.SetActive(false);
        }
    }

    private void Update()
    {
        // Menghitung jarak antara karakter dan objek saklar
        float distance = Vector2.Distance(player.transform.position, transform.position);

        // Periksa apakah karakter berada di dekat objek saklar
        if (distance <= interactionDistance)
        {
            isPlayerNearby = true;

            // Periksa apakah tombol interaksi ditekan
            if (Input.GetKeyDown(interactionKey))
            {
                // Menghilangkan objek yang ditentukan
                objectToDisappear.SetActive(false);
            }
        }
        else
        {
            isPlayerNearby = false;
        }
    }
}
