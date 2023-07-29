using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
using UnityEngine.SceneManagement;

public class FinishScene3 : MonoBehaviour
{
   private bool player1Touched = false;

    private bool player2Touched = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            player1Touched = true;
        }
        else if (other.CompareTag("Player2"))
        {
            player2Touched = true;
        }

        CheckPlayerStatus();
    }

    public void CheckPlayerStatus()
    {
        if (player1Touched && player2Touched)
        {
            // Ubah nilai level menjadi 2 di local storage (PlayerPrefs)
            PlayerPrefs.SetInt("level", 3);

            SceneManager.LoadScene("AnimasiEnding");
        }
    }
}
