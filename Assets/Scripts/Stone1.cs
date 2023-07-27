using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone1 : MonoBehaviour
{
    public Transform player;

    public GameObject stoneAttack;

    public GameObject tarantula;

    public Sprite stone;

    private bool isInteracted = false;

    private bool tarantulaAtk = false;

    private void Update()
    {
        if (tarantulaAtk)
        {
            tarantula.transform.Translate(Vector2.left * 0.5f * Time.deltaTime);
        }
    }


    public void startInteraction()
    {
        if (!isInteracted && player.position.x >= transform.position.x && player.position.x <= 0.2f)
        {
            GetComponent<AnchorGameObject>().executeInUpdate = false;
            isInteracted = true;
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            sr.sprite = null;
            SpriteRenderer srAtk = stoneAttack.AddComponent<SpriteRenderer>();
            spawn(srAtk, stone);
            stoneAttack.transform.position = new Vector3(stoneAttack.transform.position.x, 3.2f, stoneAttack.transform.position.z);
            Rigidbody2D rb = stoneAttack.AddComponent<Rigidbody2D>();
            rb.mass = 0.1f;
            tarantulaAtk = true;
        }
    }

    public void stopInteraction()
    {
        if (isInteracted)
        {
            isInteracted = false;

        }
    }

    public void spawn(SpriteRenderer srAtk, Sprite render)
    {
        srAtk.sprite = render;
    }

    public void setTarantulaAtk(bool tarantulaAtk)
    {
        this.tarantulaAtk = tarantulaAtk;
    }

    public bool getTarantulaAtk()
    {
        return tarantulaAtk;
    }
}
