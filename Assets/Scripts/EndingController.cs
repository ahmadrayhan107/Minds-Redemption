using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndingController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private bool isVideoFinished = false;

    private void Start()
    {
        // Mendengarkan event saat video selesai diputar
        videoPlayer.loopPointReached += VideoFinished;
    }

    private void VideoFinished(VideoPlayer vp)
    {
        // Fungsi ini akan dipanggil saat video selesai diputar
        isVideoFinished = true;
    }

    private void Update()
    {
        if (isVideoFinished && !videoPlayer.isPlaying)
        {
            // Load scene berikutnya setelah video selesai diputar
            SceneManager.LoadScene("Finished3");
        }
    }
}
