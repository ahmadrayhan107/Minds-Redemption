using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_1_2 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player2")) {
            SceneManager.LoadScene("Level-1-2");
        }
    }
}
