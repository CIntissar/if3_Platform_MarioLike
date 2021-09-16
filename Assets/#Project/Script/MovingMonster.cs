using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovingMonster : Monster {// il hérite de "Monster" le script

    [Tooltip("Monster speed")] // permet d'expliquer certaine partie de l'interface pour ceux qui savent pas coder!

    public bool flipX; 
    public Vector2 speed = Vector2.zero;  // .zero = (0,0)
    private SpriteRenderer spriteR;

    public float hitRange = 0.1f; 
    
    Vector2 start;
    Vector2 direction;

    private Animator animator;        

    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    virtual protected void Update()
    {

        //orientation de l'objet
        if(speed.x < 0)
        {
            if(animator != null)
            {
                animator.SetBool("whenRight", false);
            }
            else
            {
                spriteR.flipX = true;
            }

            start = (Vector2)transform.position + Vector2.left * 0.51f;
            direction = Vector2.left;

        }
        else if(speed.x > 0)
        {
            if(animator != null)
            {
                animator.SetBool("whenRight", true);
            }
            else
            {
                spriteR.flipX = false;
            }

            start = (Vector2)transform.position + Vector2.right * 0.51f;
            direction = Vector2.right;
        }

        

        Debug.DrawRay(start, direction * hitRange, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange); 

        if(hit.collider != null && !hit.transform.CompareTag("Player")) // si on touche!
        {
            speed.x *= -1;
        }

        //deplacement
        Vector2 deplacement = speed * Time.deltaTime;
        transform.position += (Vector3)deplacement; // casting / caster deplacement dans Vector3
    }
}
