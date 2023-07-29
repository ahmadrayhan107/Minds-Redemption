using UnityEngine;
using UnityEngine.EventSystems;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;

    private bool isPaused = false;

    private void Start()
    {
        // Sembunyikan menu pause saat game dimulai
        pauseMenu.SetActive(false);
    }

    public void OnPointerDownPause()
    {
        TogglePause();
    }

    public void OnPointerDownResume()
    {
        ResumeGame();
    }

    private void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            // Jika game dijeda, tampilkan menu pause dan hentikan waktu dalam game
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }
        else
        {
            // Jika game dilanjutkan, sembunyikan menu pause dan kembalikan waktu dalam game
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
        }
    }

    private void ResumeGame()
    {
        // Fungsi ini dipanggil saat pemain menekan tombol "Resume" di menu pause
        TogglePause();
    }

    // Tambahkan fungsi lain sesuai kebutuhan, misalnya untuk tombol "Quit", dsb.
}
