using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotKey : MonoBehaviour
{
    private SpriteRenderer spriteR;


    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
