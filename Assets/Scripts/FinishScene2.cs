using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
using UnityEngine.SceneManagement;

public class FinishScene2 : MonoBehaviour
{
<<<<<<< Updated upstream
    private bool player1Touched = false;
=======
   private bool player1Touched = false;
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
=======
            // Ubah nilai level menjadi 2 di local storage (PlayerPrefs)
            PlayerPrefs.SetInt("level", 3);

>>>>>>> Stashed changes
            SceneManager.LoadScene("Finished2");
        }
    }
}
