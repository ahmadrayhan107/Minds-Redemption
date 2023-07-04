using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    public GameObject character1;
    public GameObject character2;
    public Transform cameraTransform;
    public float cameraShiftAmount = 5f;

    private bool character1ReachedFinish = false;
    private bool character2ReachedFinish = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == character1)
        {
            character1ReachedFinish = true;
        }
        else if (other.gameObject == character2)
        {
            character2ReachedFinish = true;
        }

        if (character1ReachedFinish && character2ReachedFinish)
        {
            ShiftCamera();
            MoveCharacters();
        }
    }

    private void ShiftCamera()
    {
        Vector3 cameraPosition = cameraTransform.position;
        cameraPosition.x += cameraShiftAmount;
        cameraTransform.position = cameraPosition;
    }

    private void MoveCharacters()
    {
        Vector3 character1Position = character1.transform.position;
        character1Position.x += cameraShiftAmount;
        character1.transform.position = character1Position;

        Vector3 character2Position = character2.transform.position;
        character2Position.x += cameraShiftAmount;
        character2.transform.position = character2Position;
    }
}
