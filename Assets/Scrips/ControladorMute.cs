using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMute : MonoBehaviour
{
    public GameObject ReproductorSonido;
    public bool ActivadoSonido = true;

    // Start is called before the first frame update
    void Start()
    {
        ReproductorSonido = GameObject.Find("Musica"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Mute (string Activador)
    {
        if (ActivadoSonido == true && Activador == "Toque")
        {

            ActivadoSonido = false;
            ReproductorSonido.SetActive(ActivadoSonido);

        }

        else{
            ActivadoSonido = true;
            ReproductorSonido.SetActive(ActivadoSonido);
        }

        
            
    }
}

