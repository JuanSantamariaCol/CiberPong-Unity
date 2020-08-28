using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TablaPts_Reset : MonoBehaviour
{
    public GameObject GuardadorPuntos;
    public Datos_Puntajes PuntosAcomulados;
    public Text PuntosJ1;
    public Text PuntosJ2;
    public Text PuntosJ3;
    public Text PuntosJ4;

    // Start is called before the first frame update
    void Start()
    {
        GuardadorPuntos = GameObject.Find("Puntajes");
        PuntosAcomulados = GuardadorPuntos.GetComponent<Datos_Puntajes>();

    }

    // Update is called once per frame
    void Update()
    {
        PuntosJ1.text = (PuntosAcomulados.Puntos_J1).ToString();
        PuntosJ2.text = (PuntosAcomulados.Puntos_J2).ToString();
        PuntosJ3.text = (PuntosAcomulados.Puntos_J3).ToString();
        PuntosJ4.text = (PuntosAcomulados.Puntos_J4).ToString();


    }

    public void Reseteo(bool Activador)
    {
         
        if (Activador)
        {
            var ReseteoPuntaje = GameObject.Find("Puntajes");
            var ReseteoMusica = GameObject.Find("Musica");

            Destroy(ReseteoMusica);
            Destroy(ReseteoPuntaje);
            SceneManager.LoadScene("Menu_Principal");

        }

    }
}
