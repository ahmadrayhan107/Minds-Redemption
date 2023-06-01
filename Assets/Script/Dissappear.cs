using UnityEngine;
using UnityEngine.UI;

public class Disappear : MonoBehaviour
{
    public Image image;

    private void Start()
    {
        // Menjalankan coroutine untuk mengontrol tampilan gambar
        StartCoroutine(HideImageAfterDelay(10f));
    }

    private System.Collections.IEnumerator HideImageAfterDelay(float delay)
    {
        // Menunggu selama 'delay' detik
        yield return new WaitForSeconds(delay);

        // Menyembunyikan gambar
        image.enabled = false;
    }
}
