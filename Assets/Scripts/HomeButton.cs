using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    public void LoadHomeScene()
    {
        SceneManager.LoadScene("MainMenu");
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }
}
