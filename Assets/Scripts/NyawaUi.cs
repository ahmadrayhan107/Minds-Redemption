using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NyawaUi : MonoBehaviour
{
    public Image darahImage;

    public Sprite mental_bar_1;
    public Sprite mental_bar_3;
    public Sprite mental_bar_6;
    public Sprite mental_bar_9;

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
                darahImage.sprite = mental_bar_1;
                break;
            case 2:
                darahImage.sprite = mental_bar_3;
                break;
            case 1:
                darahImage.sprite = mental_bar_6;
                break;
            case 0:
                darahImage.sprite = mental_bar_9;
                break;
            default:
                Debug.LogError("Jumlah nyawa tidak valid");
                break;
        }
    }
}
