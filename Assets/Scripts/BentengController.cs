using UnityEngine;
using UnityEngine.UI;

public class BentengController : MonoBehaviour
{
    public int maxNyawa = 3;
    public Image[] nyawaImages;
    public Sprite[] nyawaSprites;

    private int currentNyawa = 3;

    private void Start()
    {
        UpdateNyawaImages();
        Debug.Log("Jumlah nyawa benteng saat ini: " + currentNyawa);
    }

    public void KurangiNyawa(int jumlah)
    {
        currentNyawa -= jumlah;
        UpdateNyawaImages();
        Debug.Log("Nyawa berkurang. Jumlah nyawa benteng saat ini: " + currentNyawa);

        if (currentNyawa <= 0)
        {
            DestroyBenteng();
        }
    }

    public void TambahNyawa(int jumlah)
    {
        currentNyawa += jumlah;

        // Pastikan jumlah nyawa tidak melebihi maxNyawa
        currentNyawa = Mathf.Clamp(currentNyawa, 0, maxNyawa);

        UpdateNyawaImages();
        Debug.Log("Nyawa bertambah. Jumlah nyawa benteng saat ini: " + currentNyawa);
    }

    private void UpdateNyawaImages()
    {
        for (int i = 0; i < nyawaImages.Length; i++)
        {
            if (i < currentNyawa)
            {
                // Cetak nama sprite yang sedang digunakan
                Debug.Log("Sprite yang sedang digunakan untuk nyawa benteng " + (i + 1) + ": " + nyawaSprites[i].name);

                // Ganti gambar nyawa benteng sesuai dengan nyawa saat ini
                nyawaImages[i].sprite = nyawaSprites[i];
            }
            else
            {
                // Gambar nyawa kosong
                nyawaImages[i].sprite = nyawaSprites[nyawaSprites.Length - 1];
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Virus"))
        {
            KurangiNyawa(1);
        }
    }

    private void DestroyBenteng()
    {
        // Hapus game object benteng
        Destroy(gameObject);
    }
}
