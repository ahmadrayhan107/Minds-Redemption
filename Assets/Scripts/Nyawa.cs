using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nyawa : MonoBehaviour
{
    public NyawaUi nyawaUI;
     public GameOver gameOver;
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
            SceneManager.LoadScene("GameOver");
        }
    }
}
