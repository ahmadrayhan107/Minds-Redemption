using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene("level-1"); // Ganti "Level1" dengan nama scene level 1 yang sesuai
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene"); // Ganti "MainMenu" dengan nama scene menu utama yang sesuai
    }
}
