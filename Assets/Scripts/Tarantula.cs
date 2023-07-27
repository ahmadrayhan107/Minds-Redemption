using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarantula : MonoBehaviour
{
    public GameObject stone;

    public GameObject stone1;

    public Stone stoneCls;

    public Stone1 stoneCls1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            transform.position = new Vector3(1.25f, 0.87f, 0);
            if (stoneCls1.getTarantulaAtk())
            {
                stoneCls1.setTarantulaAtk(false);
                Destroy(stone1.gameObject);
            }

            if (stoneCls.getTarantulaAtk())
            {
                stoneCls.setTarantulaAtk(false);
                Destroy(stone.gameObject);
            }
        }
    }
}
