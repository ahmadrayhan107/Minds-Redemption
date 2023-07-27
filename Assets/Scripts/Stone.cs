using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public Transform player;

    public GameObject stoneAttack;

    // public Sprite stone; // Asset Stone

    private bool isInteracted = false;

    public void startInteraction()
    {
        if (!isInteracted && player.position.x >= transform.position.x)
        {
            isInteracted = true;
            Destroy(this.gameObject);
            stoneAttack.transform.position = new Vector3(stoneAttack.transform.position.x, 3.2f, stoneAttack.transform.position.z);
            Rigidbody2D rb = stoneAttack.AddComponent<Rigidbody2D>();
            rb.mass = 0.1f;
        }
    }

    public void stopInteraction()
    {
        if (isInteracted)
        {
            isInteracted = false;
        }
    }

    // public void spawn(Sprite render)
    // {
    //     SpriteRenderer sr = GetComponent<SpriteRenderer>();
    //     sr.sprite = render;
    // }
}
