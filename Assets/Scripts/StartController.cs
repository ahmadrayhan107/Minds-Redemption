using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    // Metode yang dipanggil ketika tombol Start di klik
    public void OnStartButtonClicked()
    {
        // Mengambil nilai dari local storage dengan key "level"
        int levelValue = PlayerPrefs.GetInt("level", 1);

        // Menjalankan metode LoadScene berdasarkan nilai levelValue
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
                break;
        }
    }
}
