using UnityEngine;
using UnityEngine.Events;

public class TanganController : MonoBehaviour
{
    public GameObject peluruPrefabBewarna;
    public GameObject peluruPrefabBayangan;
    public Transform karakterBewarna;
    public Transform karakterBayangan;
    public float peluruSpeed = 5f;


    public void DestroyNearestViruses()
    {
        GameObject nearestVirusBayangan = FindNearestVirusBayangan();
        GameObject nearestVirusBewarna = FindNearestVirusBewarna();

        if (nearestVirusBayangan != null)
        {
            Destroy(nearestVirusBayangan);
        }

        if (nearestVirusBewarna != null)
        {
            Destroy(nearestVirusBewarna);
        }
    }

    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootPeluru();
        }
    }

    public void ShootPeluru()
    {
        GameObject nearestVirusBewarna = FindNearestVirusBewarna();
        GameObject nearestVirusBayangan = FindNearestVirusBayangan();

        if (nearestVirusBewarna != null || nearestVirusBayangan != null)
        {
            //bewarna
            GameObject peluruBewarna = Instantiate(peluruPrefabBewarna, karakterBewarna.position, Quaternion.identity);
            PeluruBewarnaController peluruBewarnaController = peluruBewarna.GetComponent<PeluruBewarnaController>();
            peluruBewarnaController.SetTarget(nearestVirusBewarna.transform, peluruSpeed);

            //bayangan
            GameObject peluruBayangan = Instantiate(peluruPrefabBayangan, karakterBayangan.position, Quaternion.identity);
            PeluruBayanganController peluruBayanganController = peluruBayangan.GetComponent<PeluruBayanganController>();
            peluruBayanganController.SetTarget(nearestVirusBayangan.transform, peluruSpeed);
        }
    }

    public GameObject FindNearestVirusBayangan()
    {
        GameObject nearestVirus = null;
        float nearestDistance = Mathf.Infinity;

        GameObject[] viruses = GameObject.FindGameObjectsWithTag("Virus");
        GameObject karakterBayangan = GameObject.FindGameObjectWithTag("Player1");

        foreach (GameObject virus in viruses)
        {
            float distanceToBayangan = Vector3.Distance(virus.transform.position, karakterBayangan.transform.position);

            if (distanceToBayangan < nearestDistance)
            {
                nearestDistance = distanceToBayangan;
                nearestVirus = virus;
            }
        }

        return nearestVirus;
    }

    public GameObject FindNearestVirusBewarna()
    {
        GameObject nearestVirus = null;
        float nearestDistance = Mathf.Infinity;

        GameObject[] viruses = GameObject.FindGameObjectsWithTag("Virus");
        GameObject karakterBewarna = GameObject.FindGameObjectWithTag("Player2");

        foreach (GameObject virus in viruses)
        {
            float distanceToBewarna = Vector3.Distance(virus.transform.position, karakterBewarna.transform.position);

            if (distanceToBewarna < nearestDistance)
            {
                nearestDistance = distanceToBewarna;
                nearestVirus = virus;
            }
        }

        return nearestVirus;
    }
}
