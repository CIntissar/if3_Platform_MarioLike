using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMonster : Monster {// il hérite de "Monster" le script

    public Vector2 speed = Vector2.zero;  // .zero = (0,0)
    public bool flipX; 
    private SpriteRenderer spriteR;

    public float hitRange = 0.1f; 
    
    Vector2 start;
    Vector2 direction;
        

    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    virtual protected void Update()
    {

        //orientation de l'objet
        if(speed.x < 0)
        {
            spriteR.flipX = true;
            start = (Vector2)transform.position + Vector2.left * 0.51f;
            direction = Vector2.left;

        }
        else if(speed.x > 0)
        {
            spriteR.flipX  = false;
            start = (Vector2)transform.position + Vector2.right * 0.51f;
            direction = Vector2.right;
        }

        

        Debug.DrawRay(start, direction * hitRange, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange); 

        if(hit.collider != null ) // si on touche!
        {
            speed.x *= -1;
        }

        //deplacement
        Vector2 deplacement = speed * Time.deltaTime;
        transform.position += (Vector3)deplacement; // casting / caster deplacement dans Vector3
    }
}
