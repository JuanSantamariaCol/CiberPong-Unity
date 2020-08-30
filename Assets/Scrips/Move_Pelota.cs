using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Pelota : MonoBehaviour
{
    public float VelIni = 120f;
    public float Num1,Num2;
    public Rigidbody2D Pelota;


    // Start is called before the first frame update
    void Start()
    {

        //para que la pelota salga a una direccion aleatoria aleatorio 
        Num1 = Random.Range(-1, 1);
        Num2 = Random.Range(-1, 1);
        if (Num2 == 0)
        {
            Num2 = 1;
        }
        if (Num1 == 0)
        {
            Num1 = 1;
        }
        
        //Fin aleatorio
        Pelota = GetComponent<Rigidbody2D>();
        Pelota.AddForce(new Vector3(-VelIni*Num2, VelIni*Num1));
    }



}
