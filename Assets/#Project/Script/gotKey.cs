using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gotKey : MonoBehaviour
{
    public UnityEvent whenPickUp;


    private void OnTriggerEnter2D(Collider2D other) 
    {

        if(other.CompareTag("Player"))
        {
            whenPickUp?.Invoke();  //non nullité de l'event
            Destroy(gameObject);
        }
    }
}
