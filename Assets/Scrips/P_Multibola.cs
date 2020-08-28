using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Multibola : MonoBehaviour
{
    public GameObject Prefab_Clonar;
    public int Num_Bolas = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D Objeto)
    {
        if (Objeto.gameObject.CompareTag("Pelota"))
        {
            
            Clonar_Bola();
            Destroy(gameObject);
        }

    }

    void Clonar_Bola()
    {

        while (Num_Bolas > 0)
        {
            Instantiate(Prefab_Clonar, transform.position, transform.rotation);
            Num_Bolas--;
            
        }

        return;

    }
}
