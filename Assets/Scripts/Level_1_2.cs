using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_1_2 : MonoBehaviour
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

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            player1Touched = false;
        }
        else if (other.CompareTag("Player2"))
        {
            player2Touched = false;
        }
    }

    private void CheckPlayerStatus()
    {
        if (player1Touched && player2Touched)
        {
            SceneManager.LoadScene("HintTantangan2");
            Debug.Log("berhasil");
        }
        else
        {
            Debug.Log("gagal");
        }
    }
}
