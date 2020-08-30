using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    public GameObject Music;

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(Music);
    }
}
