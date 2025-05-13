using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : MonoBehaviour
{
    public GameObject[] LugarDeInstancia;

    public GameObject[] ObjetosCorrectos;

    public GameObject PadreObjtos;

    public GameObject[] ObjetosAleatorios;

    public GameObject[] ObjetosAlmacenados;

    public bool[] Ocupado;

    public int cuentas;

    int conteo;

    int ConteoInterno;
    void Start()
    {
        ObjetosAlmacenados = new GameObject[ObjetosAleatorios.Length];
        cuentas = 0;
    }

    public void EmpezarJuego()
    {
        //Pongo los bools necesacios para cada lugar de instancia
        Ocupado = new bool[LugarDeInstancia.Length];

        //Cuanto el listado de objetos correctos para saber cuanto pasos hay que hacer
        conteo = ObjetosCorrectos.Length;

        Xogo();
    }

    public void Xogo()
    {
        if (conteo >= 1)
        {
            for(int i = 0; i < Ocupado.Length; i++) 
            {
             Ocupado[i] = false;
            
            }
            int LAle = Random.Range(0, LugarDeInstancia.Length);

            Instantiate(ObjetosCorrectos[conteo - 1].AddComponent<Orden>(), LugarDeInstancia[LAle].transform.position, Quaternion.identity);

            Ocupado[LAle] = true;

            for (int i = 0; i < Ocupado.Length; i++)
            {
                if (Ocupado[i] == false)
                {

                    do {

                        ConteoInterno = Random.Range(0, ObjetosAleatorios.Length);

                    } while (ObjetosAleatorios[ConteoInterno]==null);

                   ObjetosAlmacenados[cuentas] = Instantiate(ObjetosAleatorios[ConteoInterno], LugarDeInstancia[i].transform.position,Quaternion.identity);

                    ObjetosAleatorios[ConteoInterno] = null;

                    Ocupado[i] = true;

                    cuentas++;
                }
            }
        }
        else if (conteo <= 0) 
        { 
        
        
        }
    }

    public void Correcto()
    {
        int i;
        i = 0;
        do
        {
            Destroy(ObjetosAlmacenados[i]);
            i++;
        } while (i < ObjetosAlmacenados.Length);
        
        conteo--;
        Xogo();
    }
    void Update()
    {
        
    }
}
