using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void IniciarJuego(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void salir()
    {
        Application.Quit();
        Debug.Log("Has Salido del Juego");
    }
}
   
