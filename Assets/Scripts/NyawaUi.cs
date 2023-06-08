using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NyawaUi : MonoBehaviour
{
    public Image darahImage;

    public Sprite health_bar_0;
    public Sprite health_bar_1;
    public Sprite health_bar_2;
    public Sprite health_bar_3;

    private void Start()
    {
        // Set gambar awal
        UpdateDarahUi(3);
    }

    public void UpdateDarahUi(int jumlahNyawa)
    {
        switch (jumlahNyawa)
        {
            case 3:
                darahImage.sprite = health_bar_0;
                break;
            case 2:
                darahImage.sprite = health_bar_1;
                break;
            case 1:
                darahImage.sprite = health_bar_2;
                break;
            case 0:
                darahImage.sprite = health_bar_3;
                break;
            default:
                Debug.LogError("Jumlah nyawa tidak valid");
                break;
        }
    }
}
