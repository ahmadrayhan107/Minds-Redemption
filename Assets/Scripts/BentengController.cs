using UnityEngine;
using UnityEngine.UI;

public class BentengController : MonoBehaviour
{
    public int maxNyawa = 5;
    public Image[] nyawaImages;
    public Sprite[] nyawaSprites;

    private int currentNyawa = 5;

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
                nyawaImages[i].sprite = nyawaSprites[0]; // Gambar nyawa penuh
            }
            else
            {
                nyawaImages[i].sprite = nyawaSprites[1]; // Gambar nyawa kosong
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
        Destroy(gameObject);
    }
}
