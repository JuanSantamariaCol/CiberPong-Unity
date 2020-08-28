using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;


public class Datos_Puntajes : MonoBehaviour
{
    //Anuncios
    private InterstitialAd interstitialAd;
    [SerializeField] private string appID = "";
    [SerializeField] private string interstitialID = "";
    //

    public GameObject DatosPuntos;

    public bool RondaTerminada = false;
    public bool Boton = false;
    public int Num_Rondas;
    public int Puntos_J1;
    public int Puntos_J2;
    public int Puntos_J3;
    public int Puntos_J4;

    // Start is called before the first frame update
    void Start()
    {
        PedirInterstitial();
    }

    private void PedirInterstitial() //funcion para pedir el anuncio a los servidores
    {
        interstitialAd = new InterstitialAd(interstitialID);
        AdRequest pedir = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(pedir);
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(DatosPuntos);


        if ((RondaTerminada) && (Boton) && (Num_Rondas < 5))
        {
            RondaTerminada = false;
            Boton = false;
            interstitialAd.Show();      //mostrar anuncio 
            interstitialAd.Destroy();   //destruir anuncio
            PedirInterstitial();        //pedir otro anuncio 
            SceneManager.LoadScene("Juego"); //Pasar ronda

        }

        if (Num_Rondas == 5 && Boton)
        {
            Num_Rondas++;
            SceneManager.LoadScene("TablaDePuntajes");
            
        }
    }



}
