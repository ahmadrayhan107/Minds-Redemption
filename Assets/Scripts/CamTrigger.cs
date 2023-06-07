using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    [SerializeField] private Vector3 newCamPos, newPlayerPos;
    
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    CamController camControl;


    // Start is called before the first frame update
    void Start()
    {
        camControl = Camera.main.GetComponent<CamController>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (player1.transform.position.x > 1.6 && player2.transform.position.x > 1.6) {
            camControl.minPos += newCamPos;
            camControl.maxPos += newCamPos;
            
            other.transform.position += newPlayerPos;
        }
    }
}
