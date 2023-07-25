using UnityEngine;
using UnityEngine.Events;

public class PeluruBayanganController : MonoBehaviour
{
    public UnityEvent OnHitTarget = new UnityEvent();

    private Transform target;
    private float speed;

    public void SetTarget(Transform target, float speed)
    {
        this.target = target;
        this.speed = speed;
    }

    private void Update()
    {
        if (target != null)
        {
            Vector2 direction = target.position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Virus"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
