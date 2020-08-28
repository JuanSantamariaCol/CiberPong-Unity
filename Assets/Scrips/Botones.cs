using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Botones : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool Activado;


    public void OnPointerDown(PointerEventData datos)
    {
        Activado = true;
    }

    public void OnPointerUp(PointerEventData datos)
    {
        Activado = false;
    }
}

