using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void LoadNextScene()
    {
        // Mengambil nilai dari local storage dengan key "level"
        int levelValue = PlayerPrefs.GetInt("level", 1);

        // Menjalankan metode LoadSceneByLevel berdasarkan nilai levelValue
        LoadSceneByLevel(levelValue);
    }

    // Metode untuk memuat scene berdasarkan nilai levelValue
    public void LoadSceneByLevel(int levelValue)
    {
        switch (levelValue)
        {
            case 1:
                SceneManager.LoadScene("UnlockLvl1");
                break;
            case 2:
                SceneManager.LoadScene("UnlockLvl2");
                break;
            case 3:
                SceneManager.LoadScene("UnlockLvl3");
                break;
            default:
                SceneManager.LoadScene("StageMenu");
                break;
        }
    }
}
