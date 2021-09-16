using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class portalTriggered : MonoBehaviour
{    
    public void Menu(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("MenuScene");
        }
    }

    public void LevelOne(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("LevelOneScene");
        }
    }
    
    public void LevelTwo(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("LevelTwoScene");
        }
    }

    public void LevelThree(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("LevelThreeScene");
        }
    }

    public void Exit(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            Application.Quit();
        }
    }

}
