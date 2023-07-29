using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public Transform player;

    public Sprite lampOn;

    public GameObject tarantula;

    private bool isInteracted = false;

    private int count = 0;

    public void startInteraction()
    {
        if (!isInteracted && player.transform.position.x >= transform.position.x)
        {
            isInteracted = true;
            if (count == 0)
            {
                Vector3 scale = transform.localScale;
                scale = scale / 0.19f * 0.25f;
                transform.localScale = scale;
                count++;
            }
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            sr.sprite = null;
            tarantula.SetActive(false);
            Spawn(sr, lampOn);
        }
    }

    public void stopInteraction()
    {
        if (isInteracted)
        {
            isInteracted = false;
        }
    }

    private void Spawn(SpriteRenderer sr, Sprite render)
    {
        sr.sprite = render;
    }
}
