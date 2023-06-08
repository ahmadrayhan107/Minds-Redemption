using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nyawa : MonoBehaviour
{
    public NyawaUi nyawaUI;
    private int nyawa;

    private void Start()
    {
        nyawa = 3;
        nyawaUI.UpdateDarahUi(nyawa);
        Debug.Log("Jumlah nyawa saat ini: " + nyawa);
    }

    public void KurangiNyawa(int jumlah)
    {
        nyawa -= jumlah;
        nyawaUI.UpdateDarahUi(nyawa);
        Debug.Log("Nyawa berkurang. Jumlah nyawa saat ini: " + nyawa);
        if (nyawa <= 0)
        {
            Debug.Log("Game Over");

            // Tambahkan logika game over di sini
            if (SceneManager.GetSceneByName("Level-1-1").isLoaded)
            {
                SceneManager.LoadScene("GameOver");
            }
            else if (SceneManager.GetSceneByName("Level-1-2").isLoaded)
            {
                SceneManager.LoadScene("GameOver1");
            }
            else if (SceneManager.GetSceneByName("level-2-1").isLoaded)
            {
                SceneManager.LoadScene("GameOver2");
            }
            else if (SceneManager.GetSceneByName("level-2-2").isLoaded)
            {
                SceneManager.LoadScene("GameOver3");
            }
        }
    }
}
