using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_X : MonoBehaviour
{
    public Botones botonIzquierda;
    public Botones botonDerecha;
    public float VelocidadMovi = 25f;
    private float Velocidad = 0f;

    public float BordeDerecho = 118f;
    public float BordeIzquierdo = 106.74f;
    private float Posicion;
    public bool LimiteDe, LimiteIz = true;



    // Start is called before the first frame update




    private void Update()
    {
        //INICIO LIMITES
        //definir limites de la plataforma
        Vector2 PosPlataforma = GetComponent<Transform>().position;
        Posicion = PosPlataforma[0];

        //Esta dentro del limite derecho 
        if (Posicion > BordeDerecho)
        {
            LimiteDe = false;
        }
        else
            LimiteDe = true;


        //Esta dentro del limite izquierdo 

        if (Posicion < BordeIzquierdo)
        {
            LimiteIz = false;
        }
        else
            LimiteIz = true;



        //FIN LIMITES 

        // INICIO MOVIMIENTO 
        /// <summary>
        /// movimiento del jugador scrip espera un activador que viene del scrip boton y 
        /// al cumplir el condicional empieza el movimiento 
        
        
        if (botonIzquierda.Activado & LimiteIz)
        {
            Velocidad = -VelocidadMovi * Time.deltaTime;
            transform.Translate(Velocidad, 0, 0);
        }

        if (botonDerecha.Activado & LimiteDe)
        {
            Velocidad = VelocidadMovi * Time.deltaTime;
            transform.Translate(Velocidad, 0, 0);
        }
        //FIN MOVIMIENTO 
       
    }


}
