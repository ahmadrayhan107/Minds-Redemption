using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneAttack : MonoBehaviour
{
    void Start()
    {
        GetComponent<AnchorGameObject>().executeInUpdate = false;   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("lubang"))
        {
            gameObject.SetActive(false);
        }
    }
}
