using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poderes_Pelota : MonoBehaviour
{
    public int Velocidad_Impulso = 4;
    public Rigidbody2D Pelota;
    public GameObject BuscarAdmon;
    public AdmonLvL Administrador;

    //ANIMACIONES
    private Animator animaciones;

    //Sonidos
    AudioSource AudioPelota;
    public AudioClip Sonido_Rebote;
    public AudioClip Sonido_P_Ase;
    public AudioClip Sonido_P_Multi;
    public AudioClip Sonido_P_Veloci;


    void Start()
    {
        BuscarAdmon = GameObject.Find("AdmonLvL");
        Administrador = BuscarAdmon.GetComponent<AdmonLvL>();
        animaciones = GetComponent<Animator>();
        Pelota = GetComponent<Rigidbody2D>();
        AudioPelota = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Administrador.P_BolaAse == true)
        {
            animaciones.SetBool("Matadora", true);
            
        }
        else
            animaciones.SetBool("Matadora", false);



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Para que cuando bola asesina este activado se muera el jugador al tocarla

        if ((collision.gameObject.CompareTag("Player")) && Administrador.P_BolaAse == true)
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("P_Velocidad"))
        {
            Pelota.velocity = new Vector2(Velocidad_Impulso, Velocidad_Impulso);
            if (Velocidad_Impulso < 15) // Acomula la velocidad hasta llegar a un tope
            {
                Velocidad_Impulso += 1;
            }
            
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            AudioPelota.clip = Sonido_Rebote;
            AudioPelota.Play();
        }
        if (collision.gameObject.CompareTag("P_BolaAse"))
        {
            AudioPelota.clip = Sonido_P_Ase;
            AudioPelota.Play();
        }

        if (collision.gameObject.CompareTag("P_Multi"))
        {
            AudioPelota.clip = Sonido_P_Multi;
            AudioPelota.Play();
        }
        if (collision.gameObject.CompareTag("P_Velocidad"))
        {
            AudioPelota.clip = Sonido_P_Veloci;
            AudioPelota.Play();
        }
    }
}
