using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class portalTriggered : MonoBehaviour
{    
    
    public void LevelTwo(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("LevelTwoScene");
        }
    }


}
