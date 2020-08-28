using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enfoque_Camara : MonoBehaviour
{
    public SpriteRenderer Imagen_Enfoque;
    // Start is called before the first frame update
    void Start()
    {

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float targetRatio = Imagen_Enfoque.bounds.size.x / Imagen_Enfoque.size.y;

        if (screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = Imagen_Enfoque.bounds.size.y / 2;
        }
        else
        {
            float diffetenceInSize = targetRatio / screenRatio;
            Camera.main.orthographicSize = Imagen_Enfoque.size.y / 2 * diffetenceInSize;
        }
    }


}
