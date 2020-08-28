using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour
{
    // sonidos
    AudioSource Sonido_Muerte;
    public AudioClip SonidoMuerte;
    public AudioClip SonidoRebote;

    public AdmonLvL Administrador;
    public GameObject Plataforma;
    public bool Jugador_Vivo = true;
    // Start is called before the first frame update
    void Start()
    {
        Sonido_Muerte = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision )
    {
        if ((collision.gameObject.CompareTag("Pelota"))&& Administrador.P_BolaAse == false && Jugador_Vivo == true){
            Muerte();
        }

        if (collision.gameObject.CompareTag("Pelota")&& Jugador_Vivo && Administrador.P_BolaAse == false){
            Muerte();
        }


    }

    public void Muerte()
    {
        Sonido_Muerte.clip = SonidoMuerte;
        Sonido_Muerte.Play();
        Jugador_Vivo = false;
        Plataforma.SetActive(false);

    }

}
