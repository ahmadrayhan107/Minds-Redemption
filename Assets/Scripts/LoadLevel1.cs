using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : MonoBehaviour
{
    public void LoadAnimation()
    {
        SceneManager.LoadScene("AnimasiOpening");
    }

    public void LoadObstacle1()
    {
        SceneManager.LoadScene("HintTantangan1");
    }

    public void LoadObstacle2()
    {
        SceneManager.LoadScene("HintTantangan2");
    }

}
