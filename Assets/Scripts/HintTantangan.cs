using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HintTantangan : MonoBehaviour
{
    public void LoadObstacle1()
    {
        SceneManager.LoadScene("Level-1-1");
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }

    public void LoadObstacle2()
    {
        SceneManager.LoadScene("Level-1-2");
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }

    public void LoadObstacle3()
    {
        SceneManager.LoadScene("Level-2-1");
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }

    public void LoadObstacle4()
    {
        SceneManager.LoadScene("Level-2-2");
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }

    public void LoadObstacle5()
    {
        SceneManager.LoadScene("Level-2-3");
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }

    public void LoadObstacle6()
    {
        SceneManager.LoadScene("Level-3-1");
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }

    public void LoadObstacle7()
    {
        SceneManager.LoadScene("Level-3-2");
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }

    public void LoadObstacle8()
    {
        SceneManager.LoadScene("Level-3-3");
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }

    public void LoadObstacle9()
    {
        SceneManager.LoadScene("Level-3-4");
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }
}
