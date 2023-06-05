using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitConfirmation : MonoBehaviour
{
    public void ExitGame()
    {
        // Tampilkan dialog konfirmasi exit di sini (misalnya menggunakan UI atau dialog pop-up)

        // Pemanggilan fungsi keluar jika tombol "Yes" ditekan
        Application.Quit();
    }

    public void CancelExit()
    {
        // Pemanggilan fungsi kembali ke main menu jika tombol "No" ditekan
        SceneManager.LoadScene("MainMenuScene"); 
    }
}
