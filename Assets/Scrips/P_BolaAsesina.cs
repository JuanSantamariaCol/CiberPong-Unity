using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_BolaAsesina : MonoBehaviour
{
    public AdmonLvL Administrador;
    private GameObject BuscarAdmon;
    // Start is called before the first frame update
    void Start()
    {
         BuscarAdmon= GameObject.Find("AdmonLvL");
        Administrador = BuscarAdmon.GetComponent<AdmonLvL>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pelota"))
        {
            Debug.Log("Activacion Poder");
            Administrador.P_BolaAse = true;
            Debug.Log(Administrador.P_BolaAse);
            Destroy(gameObject);
        }
    }
}
