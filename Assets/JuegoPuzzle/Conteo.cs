using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conteo : MonoBehaviour
{
    public int piezascunata;
    public int necesarias;
    public GameObject PantallaVic;
    public GameObject ajustes;
    bool X;
    public AudioSource As;
    void Start()
    {
        X= true;    
    }
    public void Empezar()
    {
        necesarias++;
    }

    public void Coantar() 
    {
        As.Play();
        piezascunata++;

        if(piezascunata == necesarias)
        {
          PantallaVic.SetActive(true);
        }
    
    
    }

    public void Ajustes()
    {
        if (X)
        {
            ajustes.SetActive(true);

            X = false;
        }
        else if (!X)
        {
            ajustes.SetActive(!true);

            X = !false;
        }
    }
}
