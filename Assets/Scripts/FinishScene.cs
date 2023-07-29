using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScene : MonoBehaviour
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
             int currentLevel = PlayerPrefs.GetInt("level", 1);

             if (currentLevel != 3)
            {
                PlayerPrefs.SetInt("level", 2);
            }
            // Load scene "Finished"
            SceneManager.LoadScene("Finished");
        }
    }
}
