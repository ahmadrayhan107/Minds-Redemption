using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasedTuntutan : MonoBehaviour
{
    public Transform player;
    public float interactionDistance = 1f; // Jarak maksimum antara karakter dan objek skop
    private Nyawa nyawa;


    public GameObject objectToActivate;
    public GameObject objectToActivate2;
    public GameObject objectToActivate3;
    public GameObject objectToInActivate;

    private bool isInteracting = false;
    private bool isPlayerNearby = false; // Menandakan apakah karakter berada di dekat objek skop

    void Start()
    {
        nyawa = FindObjectOfType<Nyawa>();
    }

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
            nyawa.KurangiNyawa(1);
            objectToInActivate.SetActive(false);
            // Memanggil fungsi untuk munculnya objek setelah beberapa detik
            Invoke("ActivateObjectA", 1f);
            Invoke("ActivateObjectB", 3f);
            Invoke("ActivateObjectC", 6f);
        }
    }

    private void ActivateObjectA()
    {
        objectToActivate.SetActive(true);
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
