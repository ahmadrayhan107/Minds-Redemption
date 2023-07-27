using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public GameObject[] puzzlePieces; // Daftar objek potongan puzzle
    public GameObject Loveurself; // Objek A yang akan diaktifkan jika terdapat 4 potongan puzzle yang diaktifkan

    private void Update()
    {
        // Fungsi untuk memeriksa apakah 4 potongan puzzle telah diaktifkan (active)
        bool allPuzzlePiecesActivated = CheckAllPuzzlePiecesActivated();

        // Jika terdeteksi 4 potongan puzzle telah diaktifkan (active), maka aktifkan objek A
        if (allPuzzlePiecesActivated)
        {
            Loveurself.SetActive(true);
        }
    }

    private bool CheckAllPuzzlePiecesActivated()
    {
        // Hitung berapa banyak potongan puzzle dalam keadaan active
        int activatedPuzzleCount = 0;

        // Loop melalui daftar potongan puzzle dan periksa apakah masing-masing potongan dalam keadaan active
        foreach (GameObject puzzlePiece in puzzlePieces)
        {
            if (puzzlePiece.activeSelf)
            {
                activatedPuzzleCount++;
            }
        }

        // Jika jumlah potongan puzzle dalam keadaan active adalah 4, return true; jika tidak, return false
        return activatedPuzzleCount == 4;
    }
}
