using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    public bool isOpen = false;

    public Sprite doorOpen;
    public Sprite doorClose;

    public UnityEvent whenEnter;

    private void Start() 
    {
        if(isOpen)
        {
            GetComponent<SpriteRenderer>().sprite = doorOpen;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = doorClose;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player") && isOpen)
        {
            whenEnter?.Invoke();
        }
    }

    public void Unlock()
    {
        isOpen = true;
        GetComponent<SpriteRenderer>().sprite = doorOpen;
    }

}
