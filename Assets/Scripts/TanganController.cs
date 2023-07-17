using UnityEngine;

public class TanganController : MonoBehaviour
{
    public GameObject[] holes;
    private int currentHoleIndex = 0;

    public void DisappearVirus()
    {
        if (currentHoleIndex < holes.Length)
        {
            holes[currentHoleIndex].SetActive(false);
            currentHoleIndex++;
        }
    }
}
