using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    [SerializeField] private Vector3 newCamPos, newPlayerPos;
    CamController camControl;
    CameraViewportHandler cam;

    // Start is called before the first frame update
    void Start()
    {
        camControl = Camera.main.GetComponent<CamController>();
        cam = CameraViewportHandler.Instance.GetComponent<CameraViewportHandler>();
    }

    public void OnTriggerEnter2D(Collider2D other) {
        cam.executeInUpdate = false;
        if (other.CompareTag("Player")) {
            
            camControl.minPos += newCamPos;
            camControl.maxPos += newCamPos;
            
            other.transform.position += newPlayerPos;
        }
    }
}
