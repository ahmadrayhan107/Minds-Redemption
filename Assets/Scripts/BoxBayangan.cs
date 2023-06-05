using UnityEngine;
using UnityEngine.UI;

public class BoxBayangan : MonoBehaviour
{
    public Transform player;
    public float interactionDistance = 2f;
    public float boxMoveDistance = 10f;

    private bool isPlayerNearby = false;
    private bool isInteracting = false;
    private Vector2 initialBoxPosition;

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
            initialBoxPosition = transform.position;
        }
    }

    public void StopInteraction()
    {
        if (isInteracting)
        {
            isInteracting = false;
        }
    }

    public void FixedUpdate()
    {
        if (isInteracting)
        {
            MoveBox();
        }
    }

    public void MoveBox()
    {
        Vector2 targetPosition = initialBoxPosition + (Vector2.right * boxMoveDistance);
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.fixedDeltaTime * 5f);

        float distanceToTarget = Vector2.Distance(transform.position, targetPosition);
        if (distanceToTarget <= 0.1f)
        {
            isInteracting = false;
        }
    }
}
