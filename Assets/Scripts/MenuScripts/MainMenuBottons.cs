using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
using UnityEngine.SceneManagement;
public class MainMenuBottons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToGym()
    {
        SceneManager.LoadScene("Gimnasio");
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("se cierra el juego");
    }
}
