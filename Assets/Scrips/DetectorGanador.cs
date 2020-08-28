using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectorGanador : MonoBehaviour
{
    //Guardar Puntajes Y Numero de Rondas
    public GameObject GuardadorPtsRounds;
    public  Datos_Puntajes CentroDePuntos;  
    public bool SoloUnPunto = true;


    //Panel para anunciar el ganador
    public GameObject AnunciadorGanador;
    public GameObject Pelota;

    //Declarar Ganador
    public Text GanadorRonda;
    public Image GanadorRonda_image;
    public Sprite J1_Imagen;
    public Sprite J2_Imagen;
    public Sprite J3_Imagen;
    public Sprite J4_Imagen;

    // estado del jugador (Vivo o Muerto)
    public bool VidaJ1;
    public bool VidaJ2;
    public bool VidaJ3;
    public bool VidaJ4;
    // Objetos que envian el estado del jugador 
    public GameObject J1;
    public GameObject J2;
    public GameObject J3;
    public GameObject J4;



    // Start is called before the first frame update
    void Start()
    {
        //Buscar El Objeto De Puntajes 
        GuardadorPtsRounds = GameObject.Find("Puntajes");
        CentroDePuntos = GuardadorPtsRounds.GetComponent<Datos_Puntajes>();
        
    }

    // Update is called once per frame
    void Update()
    {

        VidaJ1 = J1.gameObject.GetComponent<Limites>().Jugador_Vivo;
        VidaJ2 = J2.gameObject.GetComponent<Limites>().Jugador_Vivo;
        VidaJ3 = J3.gameObject.GetComponent<Limites>().Jugador_Vivo;
        VidaJ4 = J4.gameObject.GetComponent<Limites>().Jugador_Vivo;

        if ((VidaJ2 == false) && (VidaJ3 == false) && (VidaJ4 == false) && (SoloUnPunto == true))
        {
            Pelota.SetActive(false);
            AnunciadorGanador.SetActive(true);
            GanadorRonda.text = "Jugador 1";
            GanadorRonda_image.sprite = J1_Imagen;
            //Guardar Punto Y Sumar Ronda
            CentroDePuntos.Puntos_J1++;
            CentroDePuntos.Num_Rondas++;
            CentroDePuntos.RondaTerminada = true;
            SoloUnPunto = false;
            
            
        }

        if ((VidaJ1 == false) && (VidaJ3 == false) && (VidaJ4 == false) && (SoloUnPunto == true))
        {
            Pelota.SetActive(false);
            AnunciadorGanador.SetActive(true);
            GanadorRonda.text = "Jugador 2";
            GanadorRonda_image.sprite = J2_Imagen;
            //Guardar Punto Y Sumar Ronda
            CentroDePuntos.Puntos_J2++;
            CentroDePuntos.Num_Rondas++;
            CentroDePuntos.RondaTerminada = true;
            SoloUnPunto = false;
        }
        if ((VidaJ1 == false) && (VidaJ2 == false) && (VidaJ4 == false) && (SoloUnPunto == true))
        {
            Pelota.SetActive(false);
            AnunciadorGanador.SetActive(true);
            GanadorRonda.text = "Jugador 3";
            GanadorRonda_image.sprite = J3_Imagen;
            //Guardar Punto Y Sumar Ronda
            CentroDePuntos.Puntos_J3++;
            CentroDePuntos.Num_Rondas++;
            CentroDePuntos.RondaTerminada = true;
            SoloUnPunto = false;
        }
        if ((VidaJ1 == false) && (VidaJ2 == false) && (VidaJ3 == false) && (SoloUnPunto == true))
        {
            Pelota.SetActive(false);
            AnunciadorGanador.SetActive(true);
            GanadorRonda.text = "Jugador 4";
            GanadorRonda_image.sprite = J4_Imagen;
            //Guardar Punto Y Sumar Ronda
            CentroDePuntos.Puntos_J4++;
            CentroDePuntos.Num_Rondas++;
            CentroDePuntos.RondaTerminada = true;
            SoloUnPunto = false;
        }



    }
    public void ActivacionBoton(bool Activacion)
    {
        CentroDePuntos.Boton = Activacion;
    }
}