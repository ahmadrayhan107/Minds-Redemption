using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    public void LoadHomeScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadHomeScene2()
    {
        SceneManager.LoadScene("MainMenu2");
    }
}
