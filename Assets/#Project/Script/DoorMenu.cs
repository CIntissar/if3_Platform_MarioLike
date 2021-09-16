using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorMenu : MonoBehaviour
{
    public UnityEvent whenEnter;

    private void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.CompareTag("Player"))
            {
                whenEnter?.Invoke();
            }
        }
}
