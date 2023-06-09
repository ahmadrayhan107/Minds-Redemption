using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour
{
    public void LoadObstacle1()
    {
        SceneManager.LoadScene("HintTantangan3");
    }

    public void LoadObstacle2()
    {
        SceneManager.LoadScene("HintTantangan4");
    }
}
