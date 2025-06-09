using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conteo : MonoBehaviour
{
    public int piezascunata;
    public int necesarias;

    public AudioSource As;
    void Start()
    {
        
    }
    public void empezar()
    {
        necesarias++;
    }

    public void coantar() 
    {
        As.Play();
        piezascunata++;

        if(piezascunata == necesarias)
        {
            print("Tus muertos");
        }
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
