using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))] // requiert ces deux objets et si on les a, empêche qu'on les supprime!!!

public class Monster : MonoBehaviour // script qui décrit le comportement d'un monstre lorsqu'il touche le héro
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("I'M GONNA CATCH YA!!!");
            LevelsManager.LooseLife(); // Nom du script suivi de la méthode!!!

        }
    }

}
