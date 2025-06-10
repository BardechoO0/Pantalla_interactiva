using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscogerActividades : MonoBehaviour
{
    [SerializeField] JuegoActividadesRemake JAR;
    int w;

    public bool PrimeraVez;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Comprebo si es la primra vez que pasan po aquí
        if (!PrimeraVez)
        {
            // Aquí comparo  los gameobjecto de el colisionador y el colisionado para saber que tengo que hacer
            if (this.gameObject.tag == "Act1" && collision.gameObject.tag == "Player")
            {
                w = 0;

                JAR.IrAActividad(w);

            }
            else if (this.gameObject.tag == "Act2" && collision.gameObject.tag == "Player")
            {
                w = 1;

                JAR.IrAActividad(w);

            }
            else if (this.gameObject.tag == "Act3" && collision.gameObject.tag == "Player")
            {
                w = 2;

                JAR.IrAActividad(w);

            }
            else if (this.gameObject.tag == "Act4" && collision.gameObject.tag == "Player")
            {
                w = 3;

                JAR.IrAActividad(w);

            }
            else if (this.gameObject.tag == "Act5" && collision.gameObject.tag == "Player")
            {
                w = 4;

                JAR.IrAActividad(w);

            }
            else if (this.gameObject.tag == "Act6" && collision.gameObject.tag == "Player")
            {
                w = 5;

                JAR.IrAActividad(w);

            }

            PrimeraVez = true;

            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        //Comprebo si es la primra vez que pasan po aquí
        if (!PrimeraVez)
        { 
            // Aquí comparo  los gameobjecto de el colisionador y el colisionado para saber que tengo que hacer
            if (this.gameObject.tag == "Act1" && collision.gameObject.tag == "Player")
            {
                 w = 0;

                 JAR.IrAActividad(w);

            }
            else if (this.gameObject.tag == "Act2" && collision.gameObject.tag == "Player")
            {
                w = 1;

                JAR.IrAActividad(w);

            }
            else if (this.gameObject.tag == "Act3" && collision.gameObject.tag == "Player")
            {
                w = 2;

                JAR.IrAActividad(w);

            }
            else if (this.gameObject.tag == "Act4" && collision.gameObject.tag == "Player")
            {
                w = 3;

                JAR.IrAActividad(w);

            }
            else if (this.gameObject.tag == "Act5" && collision.gameObject.tag == "Player")
            {
                w = 4;

                JAR.IrAActividad(w);

            }
            else if (this.gameObject.tag == "Act6" && collision.gameObject.tag == "Player")
            {
                w = 5;

                JAR.IrAActividad(w);

            }

            PrimeraVez = true;
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
