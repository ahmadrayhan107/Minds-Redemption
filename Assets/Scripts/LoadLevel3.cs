using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel3 : MonoBehaviour
{
<<<<<<< Updated upstream
    public void LoadObstacle1()
    {
        SceneManager.LoadScene("Level-3-1");
    }

=======
    public void LoadEnding()
    {
        SceneManager.LoadScene("AnimasiEnding");
    }
    public void LoadObstacle1()
    {
        SceneManager.LoadScene("HintTantangan6");
    }
>>>>>>> Stashed changes
    public void LoadObstacle2()
    {
        SceneManager.LoadScene("HintTantangan7");
    }

    public void LoadObstacle3()
    {
        SceneManager.LoadScene("HintTantangan8");
    }
    public void LoadObstacle4()
    {
        SceneManager.LoadScene("HintTantangan9");
    }

    public void LoadFinished()
    {
        SceneManager.LoadScene("Finished3");
    }

    public void LoadObstacle4()
    {
        SceneManager.LoadScene("Level-3-4");
    }
}
