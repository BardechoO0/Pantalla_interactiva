using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuegoActividadesRemake : MonoBehaviour
{
    //las zonas son los lugares donde estan las actividades generales en cambi en los lugaes estan las actividades más específicas.
    //Zona = Cocina, Salon, Taller...
    //Lugares = Pasta de dientes, Ensalada, Fregar...

    //Actividas > Lugar > Actividad

    public GameObject[] Zonas;
    public GameObject[] Lugares;

    // Las actividades posibles en cada lugar
    public GameObject[] Actividades;

    //  Conica    Salon     Social      Bano    Habitacion      Taller
    //     0        1          2          3          4             5

    int x;
    int y;
    void Start()
    {
        //Confirmo que al iniciar el juego que todo este como debe estar
        for (int i = 0; i < Zonas.Length; i++)
        {
            Zonas[i].SetActive(true);
            Lugares[i].SetActive(false);
        }
            
            
    }

    public void IrALugar(int Lugar)
    {
        x = Lugar;
        print(x);
        
        
        Lugares[x].SetActive(true);


        Actividades = new GameObject[Lugares[x].transform.childCount];
        //Cojo a los hijos del Lugar selecionado para saber las actividades que hay que dar para la seleción
        for (int i = 0; i < Lugares[x].transform.childCount; i++)
        {
            print(i);
            Actividades[i] = Lugares[x].transform.GetChild(i).gameObject;
        }

        //Indico el Lugar que se ha escogido
        for (int i = 0; i < Zonas.Length; i++)
        {
            Zonas[i].SetActive(false);
        }
        //la zona no pude volver a selecionarse
        Zonas[Lugar].SetActive(true);
        Zonas[Lugar].GetComponent<SpriteRenderer>().enabled = false;
        Zonas[Lugar].GetComponent<Lugares>().enabled = false;
        Zonas[Lugar].GetComponent<BoxCollider2D>().enabled = false;
    }

    public void IrAActividad(int Act)
    {
     y = Act;

        
        for (int i = 0; i < Actividades.Length; i++)
        {
            Actividades[i].SetActive(false);
        }

        Actividades[Act].SetActive(true);
        Actividades[Act].GetComponent<Juego>().EmpezarJuego();

       
    }


    void Update()
    {
        
    }
}
