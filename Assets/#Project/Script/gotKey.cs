using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gotKey : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Key"))
        {
            Destroy(other.gameObject);
        }
    }
}
