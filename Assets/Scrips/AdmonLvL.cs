using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdmonLvL : MonoBehaviour
{
    // Tiempo Bola Asesina y Bool
    public float T_BolaAse = 15f;
    public bool P_BolaAse = false;
    //respawn de poderes 
    public GameObject PoderMultiBola;
    public GameObject PoderVelocidad;
    public GameObject PoderMatadora;
    public GameObject PoderEscogido;
    public float T_RespawnBuff = 1;
    public int RadioCirculo = 20; // Mejorar Esto Cambiar a Rectangulo


    // Update is called once per frame
    void Update()
    {
        
       
        //PODER Bola Asesina
        if (P_BolaAse == true)
        {
            T_BolaAse -= Time.deltaTime;
 
        }

        if (T_BolaAse < 0)
        {
            P_BolaAse = false;
            T_BolaAse = 10f;
        }

        T_RespawnBuff -= Time.deltaTime;
        
        if (T_RespawnBuff < 0)
        {
            T_RespawnBuff = 10;
            RespawnBuff(true);

        }
        
    }

    void RespawnBuff(bool Activador)
    {
        if (Activador == true)
        {
            var Num_Aleatorio = Random.RandomRange(1, 4);
            if (Num_Aleatorio == 1)
            {
                PoderEscogido = PoderMatadora;
            }
            if(Num_Aleatorio == 2)
            {
                PoderEscogido = PoderVelocidad;
            }
            if (Num_Aleatorio == 3)
            {
                PoderEscogido = PoderMultiBola;
            }

            var A_pointInCircle = Random.insideUnitCircle * RadioCirculo;
            Instantiate(PoderEscogido, A_pointInCircle, transform.rotation); // Hacer una lista de Objetos para no instanciarlos (Consume Mucho)

            Activador = false;
            

        }
    }



}
