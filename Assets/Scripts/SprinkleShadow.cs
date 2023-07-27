using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinkleShadow : MonoBehaviour
{
    public Transform player;

    public GameObject tree;

    public Sprite seed;

    public Sprite growSeed;

    public Sprite growTree;

    public GameObject smoke;

    private bool isInteraction = false;
    private int count = 1;

    public void startInteraction()
    {
        if (!isInteraction && player.transform.position.x >= transform.position.x)
        {
            if (count == 1)
            {
                Vector3 scale = tree.transform.localScale;
                scale = scale * 0.02f;
                tree.transform.localScale = scale;
                SpriteRenderer sr = tree.AddComponent<SpriteRenderer>();
                Spawn(sr, seed);
                Transform smokeChild = smoke.transform.GetChild(0);
                Destroy(smokeChild.gameObject);
            }
            else if (count == 2)
            {
                tree.transform.position = new Vector3(tree.transform.position.x, tree.transform.position.y + 0.03f, tree.transform.position.z);
                Vector3 scale = tree.transform.localScale;
                scale = scale / 0.02f * 0.03f;
                tree.transform.localScale = scale;
                SpriteRenderer sr = tree.GetComponent<SpriteRenderer>();
                sr.sprite = null;
                Spawn(sr, growSeed);
                Transform smokeChild = smoke.transform.GetChild(1);
                Destroy(smokeChild.gameObject);
            }
            else if (count == 3)
            {
                tree.transform.position = new Vector3(tree.transform.position.x, tree.transform.position.y + 0.30f, tree.transform.position.z);
                Vector3 scale = tree.transform.localScale;
                scale = scale / 0.03f * 0.08f;
                tree.transform.localScale = scale;
                SpriteRenderer sr = tree.GetComponent<SpriteRenderer>();
                sr.sprite = null;
                Spawn(sr, growTree);
                Destroy(smoke.gameObject);
            }

            isInteraction = true;
            count++;
        }
    }

    public void stopInteraction()
    {
        if (isInteraction)
        {
            isInteraction = false;
        }
    }

    private void Spawn(SpriteRenderer sr, Sprite render)
    {
        sr.sprite = render;
    }
}
