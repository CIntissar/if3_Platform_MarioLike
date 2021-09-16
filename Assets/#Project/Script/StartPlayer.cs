using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        LevelsManager levelsManager = LevelsManager.instance; 
        // il va chercher une instance unique et comme il y en a qu'un seul, il ne peut pas se tromper
        GameObject player = levelsManager.player;
        player.transform.position = transform.position;
        
    }
}

