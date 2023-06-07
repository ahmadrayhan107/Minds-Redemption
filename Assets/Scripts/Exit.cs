using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void ClickExit()
    {
        // Pemanggilan fungsi kembali ke main menu jika tombol "No" ditekan
        SceneManager.LoadScene("ExitMenu"); 
    }
}
