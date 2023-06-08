using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float smoothSpeed;

    private Vector3 targetPost, newPos;

    [SerializeField] public Vector3 minPos, maxPos;

    void LateUpdate()
    {
        if (transform.position != player.position)
        {
            targetPost = player.position;

            Vector3 camBoundaryPos = new Vector3(
                Mathf.Clamp(targetPost.x, minPos.x, maxPos.x),
                Mathf.Clamp(targetPost.y, minPos.y, maxPos.y),
                Mathf.Clamp(targetPost.z, minPos.z, maxPos.z)
            );

            newPos = Vector3.Lerp(transform.position, camBoundaryPos, smoothSpeed);
            transform.position = newPos;
        }
    }
}
