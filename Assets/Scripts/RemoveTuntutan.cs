using UnityEngine;

public class RemoveTuntutan : MonoBehaviour
{
    public GameObject Loveurself; // Objek yang akan diperiksa status aktivasinya
    public GameObject[] objectsToDeactivate; // Array yang berisi objek b, c, d, e, f, dan g yang akan dinonaktifkan jika objek A aktif

    private void Update()
    {
        // Jika objek A aktif (active), maka nonaktifkan objek b, c, d, e, f, dan g
        if (Loveurself.activeSelf)
        {
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(false);
            }
        }
    }
}
