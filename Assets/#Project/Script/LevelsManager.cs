using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsManager : MonoBehaviour
{
    public static LevelsManager instance = null; // variable statique pour s'instancier soit même, qu'on peut référencier directement ex: LevelsManager. ***
    public GameObject playerPrefab;
    public GameObject player;

    public static int lifes = 3;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;

            player = Instantiate(playerPrefab);
            DontDestroyOnLoad(player); //on devra passer un point de départ as a empty gameObject mais on doit pas placer le perso dans chaque level
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // système de singleton -> il ne peut y en avoir qu'un seul!!!

    public static void LooseLife()
    {   
        lifes--;

        if(lifes < 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // buildIndex -> Index de la scène en cours
            print(lifes);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
