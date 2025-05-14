using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Juego : MonoBehaviour
{

    //Todo lo que se necesita para poder jugar.
    //Solo hace fata  si quieres añadir o mdificar uno nuevo.
    //El lugar de instacia los Objetos correcto a oren inverso del orden principal (en vez de 1-2-3-4 es 4-3-2-1).
    //Los objetos aleatorios que deben se el tamaño de LugarIntancia.Length*ObjetosCorrectos.Length.
    //Lo demas ya lo hace el scrip automático.
    public GameObject[] LugarDeInstancia;
    public GameObject[] ObjetosCorrectos;
    public GameObject[] ObjetosAleatorios;
    public GameObject[] ObjetosAlmacenados;

    public bool[] Ocupado;
    public int cuentas;
    int conteo;
    int ConteoInterno;

    //Pantalla de victoria
    public GameObject[] LugarDeInstanciaVic;
    public TextMeshProUGUI Recordatorio;
    public string Texto;
    void Start()
    {
        //Igualo la cantidad de objetos almacenados con la de los Objetos erroneos (ObjetosAleatorios)
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
            //Confirmar que todos los ocupados esten false para que no den ningun error.
            for(int i = 0; i < Ocupado.Length; i++) 
            {
             Ocupado[i] = false; 
            }

            //Instancio primro el Objeto correcto en un lugar de los posible aleatoriamente
            //Tambien, consigo el scprit de Orden para 
            //Y pongo que este en ocupado
            int LAle = Random.Range(0, LugarDeInstancia.Length);
            GameObject p =  Instantiate(ObjetosCorrectos[conteo - 1], LugarDeInstancia[LAle].transform.position, Quaternion.identity);
            p.GetComponent<Orden>().ElCorrecto = true;
            p.GetComponent<Orden>().enabled = true;
            p.GetComponent<AudioSource>().Play();
            Ocupado[LAle] = true;


            //Genero el resto de objetos erroneos
            for (int i = 0; i < Ocupado.Length; i++)
            {
                if (Ocupado[i] == false)
                {
                     //Compruebo que el objeto que genero no sea nulo
                    do {

                        ConteoInterno = Random.Range(0, ObjetosAleatorios.Length);

                    } while (ObjetosAleatorios[ConteoInterno]==null);

                    //Instancio los Objetos erroneos y los hago nulo para que no se vuelvan a repetir.
                    //Más pongo el lugar de intancia ocupoado para que no se vuelva a generar un  objeto en ese lugar.
                    //Y almeceno los objetos para luego poder destruirlo más comodamente.
                   ObjetosAlmacenados[cuentas] = Instantiate(ObjetosAleatorios[ConteoInterno], LugarDeInstancia[i].transform.position,Quaternion.identity);
                   ObjetosAleatorios[ConteoInterno] = null;
                   Ocupado[i] = true;
                   cuentas++;
                }
            }
        }
        else if (conteo <= 0) 
        { 
         for (int i = ObjetosCorrectos.Length; i>0;i--)
            {
                Instantiate(ObjetosCorrectos[i-1], LugarDeInstanciaVic[i-1].transform.position, Quaternion.identity);
            }
        
        }
    }

    public void Correcto()
    {
        //Destruir todos los objetos en la escena
        //Volver a comenzar la siguiete ronda
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
