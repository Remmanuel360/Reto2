
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espada : MonoBehaviour
{
    private SpriteRenderer playerSpriteRenderer;
    private BoxCollider2D collider2D;
    
    public Animator animator;
    public GameObject espadaParent;
    void Start()
    {
       playerSpriteRenderer = transform.root.GetComponent<SpriteRenderer>();
        collider2D = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
            {
            animator.Play("ataque");
            collider2D.enabled = true;
            Invoke("Desabilitar", 0.5f);

        }

        if (playerSpriteRenderer.flipX == true)
        {
            espadaParent.transform.rotation = Quaternion.Euler(0,0,0);
        }



    }

    private void Desabilitar()
    {

        collider2D.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemigo"))
        {
 
        }

    }

}
