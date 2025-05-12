using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lugares : MonoBehaviour
{
    //Este Scrip se encanga de saber a la zona que va la ardilla
    [SerializeField] JuegoActividadesRemake JAR;
    int w;


    private void OnCollisionEnter(Collision collision)
    {
        // Aquí comparo  los gameobjecto de el colisionador y el colisionado para saber que tengo que hacer
        if (this.gameObject.tag == "Cocina" && collision.gameObject.tag == "Player")
        {
            w = 0;

            JAR.IrALugar(w);

        }else if (this.gameObject.tag == "Salon" && collision.gameObject.tag == "Player")
        {
            w = 1;

            JAR.IrALugar(w);

        }
        else if (this.gameObject.tag == "Social" && collision.gameObject.tag == "Player")
        {
            w = 2;

            JAR.IrALugar(w);

        }
        else if (this.gameObject.tag == "Bano" && collision.gameObject.tag == "Player")
        {
            w = 3;

            JAR.IrALugar(w);

        }
        else if (this.gameObject.tag == "Habitacion" && collision.gameObject.tag == "Player")
        {
            w = 4;

            JAR.IrALugar(w);

        }
        else if (this.gameObject.tag == "Taller" && collision.gameObject.tag == "Player")
        {
            w = 5;

            JAR.IrALugar(w);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
