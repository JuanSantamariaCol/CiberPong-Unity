using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Y : MonoBehaviour
{
    //recibir boleanos de el scrip del boton 
    public Botones botonIzquierda;
    public Botones botonDerecha;
    public float VelocidadMovi = 25f;
    private float Velocidad = 0f;
    //definir limites de movimiento plataforma
    public float BordeDerecho = 70.45f;
    public float BordeIzquierdo = 66f;
    private float Posicion;
    public bool LimiteDe, LimiteIz = true;

    //Prueba De Plataforma
    public GameObject Bola;
    public float PosX_Bola;



    // Start is called before the first frame update
    void Start()
    {




    }



    private void Update()
    {
        //INICIO LIMITES
        //definir limites de la plataforma
        Vector2 PosPlataforma = GetComponent<Transform>().position;
        Posicion = PosPlataforma[1];

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
        /// </summary>

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

        /*PRUEBA
        Vector2 Pos_bola = GetComponent<Transform>().position;
        PosX_Bola = Pos_bola[1];
        Debug.Log(PosX_Bola);
        transform.position = new Vector3 (, PosX_Bola,0);
       */
    }

}
