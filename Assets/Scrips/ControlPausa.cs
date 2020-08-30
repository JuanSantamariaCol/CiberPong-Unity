using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlPausa : MonoBehaviour
{
    public GameObject MenuPausa;
    private bool MenuActivo = false;

    public void ReiniciarNivel(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Juego");

    }

    public void Menu(){
        Time.timeScale = 1f;
        var MusicaDestruir = GameObject.FindGameObjectWithTag("Musica");
        var PuntajesDestruir = GameObject.FindGameObjectWithTag("Puntajes");
        Destroy(MusicaDestruir);
        Destroy(PuntajesDestruir);
        SceneManager.LoadScene("Menu_Principal");

    }

    public void Renuar(){

        MenuActivo = false;
        MenuPausa.SetActive(false);
        Time.timeScale = 1f;
    }


    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.Escape)){

            MenuActivo = (!MenuActivo);
            MenuPausa.SetActive(MenuActivo);
            Time.timeScale = (MenuActivo) ? 0 : 1f;  //explicacion aca lo que hacemos es que ponemos un valor booleano diciendo si menu activo es true entonces time sera 0 si es falso entonces time sera 1
            //Optimizar lo de ariba

        }
    }
}
