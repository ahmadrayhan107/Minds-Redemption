using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void LoadRestartScene()
    {
        SceneManager.LoadScene("Level-1-1");
    }
}
