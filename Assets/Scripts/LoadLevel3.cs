using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel3 : MonoBehaviour
{
    public void LoadObstacle1()
    {
        SceneManager.LoadScene("Level-3-1");
    }

    public void LoadObstacle2()
    {
        SceneManager.LoadScene("Level-3-2");
    }

    public void LoadObstacle3()
    {
        SceneManager.LoadScene("Level-3-3");
    }

    public void LoadObstacle4()
    {
        SceneManager.LoadScene("Level-3-4");
    }
}
