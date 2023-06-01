using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageDissappear : MonoBehaviour
{
    public Image image;

    public void Start()
    {
        // Menjalankan coroutine untuk mengontrol tampilan gambar
        StartCoroutine(HideImageAfterDelay(3f));
    }

    public System.Collections.IEnumerator HideImageAfterDelay(float delay)
    {
        // Menunggu selama 'delay' detik
        yield return new WaitForSeconds(delay);

        // Menyembunyikan gambar
        image.enabled = false;
    }
}
