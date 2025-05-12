using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : MonoBehaviour
{
    public GameObject[] LugarDeInstancia;

    public GameObject[] ObjetosCorrectos;

    public GameObject PadreObjtos;
    public GameObject[] ObjetosAleatorios;

    public bool[] Ocupado;

    int conteo;

    int ConteoInterno;
    void Start()
    {
        
    }

    public void EmpezarJuego()
    {
        //Pongo los bools necesacios para cada lugar de instancia
        Ocupado = new bool[LugarDeInstancia.Length];

        //Cuentos todos los Objetos aleatorios que va ha ver
        ObjetosAleatorios = new GameObject[PadreObjtos.transform.childCount];

        conteo = ObjetosCorrectos.Length;

        //Setea todos los sprites aleatorios eliminiando los correctos
        for (int i = 0; i < PadreObjtos.transform.childCount; i++)
        {
            ObjetosAleatorios[i-1] = PadreObjtos.transform.GetChild(i-1).gameObject;

            for (int j = 0; ObjetosCorrectos.Length > j; j++) 
            {
                if (ObjetosCorrectos[j-1].GetComponent<Sprite>() == ObjetosAleatorios[i].GetComponent<Sprite>())
                {
                    ObjetosAleatorios[i - 1] = null;
                }
            }
        }
    }

    public void Xogo()
    {
        if (conteo >= 1)
        {
            int LAle = Random.Range(0, LugarDeInstancia.Length);

            Instantiate(ObjetosCorrectos[conteo - 1], LugarDeInstancia[LAle].transform);

            Ocupado[LAle] = true;

            for (int i = 0; i < Ocupado.Length; i++)
            {
                if (Ocupado[i] == false)
                {
                
                    ConteoInterno = Random.Range(0,ObjetosAleatorios.Length);

                    StartCoroutine(si(i));

                    Instantiate(ObjetosAleatorios[ConteoInterno], LugarDeInstancia[i].transform);

                    ObjetosAleatorios[ConteoInterno] = null;
                }
            }
        }
        else if (conteo <= 0) 
        { 
        
        
        }
    }

    IEnumerator si(int i)
    {
        if (ObjetosAleatorios[ConteoInterno].gameObject == null)
        {
            if (ObjetosAleatorios.Length - (4 * (i + 1)) >= ConteoInterno)
            {

                ConteoInterno -= 4 * (i + 1);

            }
            else if (ConteoInterno >= 4)
            {

                ConteoInterno += 4 * (i + 1);

            }
        }

        yield return null;

        if (ObjetosAleatorios[ConteoInterno]==null) 
        {
            StartCoroutine(si(i));
        }
        
    }
    void Update()
    {
        
    }
}
