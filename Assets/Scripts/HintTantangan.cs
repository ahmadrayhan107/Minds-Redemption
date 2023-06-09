using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HintTantangan : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadObstacle1()
    {
        SceneManager.LoadScene("Level-1-1");
    }
    public void LoadObstacle2()
    {
        SceneManager.LoadScene("Level-1-2");
    }
    public void LoadObstacle3()
    {
        SceneManager.LoadScene("Level-2-1");
    }
    public void LoadObstacle4()
    {
        SceneManager.LoadScene("Level-2-2");
    }
}
