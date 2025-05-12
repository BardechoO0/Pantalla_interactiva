using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class SimonDice : MonoBehaviour
{
    private BaseEventData BED;

    [SerializeField] Botones_menu Bt;

    public GameObject[] Juego;

    public GameObject Menu;
    public GameObject Pantalla_Victoria;
    
    public Button triangulo_enemigos;
    public Button cuadrado_enemigos;
    public Button circulo_enemigos;
    public Button X_enemigos;

    public Button triangulo_aliados;
    public Button cuadrado_aliados;
    public Button circulo_aliados;
    public Button X_aliados;

    public int longitudDelJuego;
    public int cuantoLeQueda;

    public int botonSelecinado;
    public int[] listaDeNumerosEnemigos;
    public int[] listaDeNumerosAlidaos;

    public int conteo1;
    public int conteo2;

    public GameObject[] memoria_enemigos;
    public GameObject[] memoria_aliados;
    public GameObject[] objetosDeMemoria;

    public GameObject[] objetos_memoria_enemigos;
    public GameObject[] objetos_memoria_aliados;

    public bool EstaBien;

    public int Tempo;
    public GameObject objeto_Varra_tiempo;
    public Slider Varra_tiempo;
    public Sprite[] reloj = new Sprite[4];
    public GameObject imagen_Varra_tiempo;

    public GameObject panel_enemigo;
    public GameObject panel_aliados;

    public AudioSource Error;
    public AudioSource Acierto;

    int fail;

    public int Tiempo_botnes;
    void Start()
    {

        print("https://packaged-media.redd.it/fdhasfw8udfe1/pb/m2-res_1280p.mp4?m=DASHPlaylist.mpd&v=1&e=1746021600&s=e11b5b68ec0f0e202075d97fab89ab2669d297ec");
    }

    public void Empezar_2()
    {
        Tempo = Convert.ToInt32(Bt.Tempo.text.ToString());
        longitudDelJuego = Convert.ToInt32(Bt.Objetos.text.ToString());
        Tiempo_botnes = Convert.ToInt32(Bt.Tiempo_botones.text.ToString());

        Menu.SetActive(false);

        for(int x = 0; x <= Juego.Length-1; x++)
        {
            print("baka,baka,baka");
            Juego[x].SetActive(true);
        }

        triangulo_aliados.interactable = false;
        cuadrado_aliados.interactable = false;
        circulo_aliados.interactable = false;
        X_aliados.interactable = false;

        cuantoLeQueda = longitudDelJuego;

        conteo1 = -1;
        conteo2 = -1;

        listaDeNumerosEnemigos = new int[longitudDelJuego];
        listaDeNumerosAlidaos = new int[longitudDelJuego];

        objetos_memoria_aliados = new GameObject[longitudDelJuego];
        objetos_memoria_enemigos = new GameObject[longitudDelJuego];

        Simon();


        Varra_tiempo.maxValue = Tempo;
        Varra_tiempo.value = Tempo;
        imagen_Varra_tiempo.GetComponent<Image>().sprite = reloj[0];

        panel_enemigo.SetActive(false);
        panel_aliados.SetActive(true);

        objeto_Varra_tiempo.SetActive(false);
    }

    public void Simon()
    {
        //Instantiate(objetosDeMemoria[0], memoria_enemigos[conteo].gameObject.transform.position, Quaternion.identity);
         

        if (cuantoLeQueda > 0) 
        {
            StartCoroutine(Conteo());
            listaDeNumerosEnemigos[conteo1] = botonSelecinado;
            objetos_memoria_enemigos[conteo1] = Instantiate(objetosDeMemoria[botonSelecinado-1], memoria_enemigos[conteo1].gameObject.transform.position, Quaternion.identity);
        }
        else
        {
            objeto_Varra_tiempo.SetActive(true);
            StartCoroutine(tiempo(Tempo));
            print("Porque te tatuansti");
        }

        
    }
    IEnumerator tiempo(int t)
    {
        yield return new WaitForSeconds(1);


        //Esto no tiene sentido y se puede ahorar pasos pero me hizo bastante gracia y se queda así

        t = Tempo;
        t--;
        Varra_tiempo.value = t;

        imagen_Varra_tiempo.GetComponent<Image>().sprite = reloj[UnityEngine.Random.Range(1,4)];

        Tempo = t;

        if (Tempo <= 0)
        {
            Empezar(); 
            panel_aliados.SetActive(false);
            panel_enemigo.SetActive(true);
            objeto_Varra_tiempo.SetActive(false);
        }
        else
        {
            

            StartCoroutine(tiempo(Tempo));
        }

    }
    IEnumerator Conteo()
    {
      
        botonSelecinado = UnityEngine.Random.Range(1, 5);
        
        conteo1++;
      

        if (botonSelecinado == 1) 
        {
            triangulo_enemigos.OnSubmit(BED);
        }
        else if (botonSelecinado == 2) 
        {
            cuadrado_enemigos.OnSubmit(BED);
        }
        else if (botonSelecinado == 3) 
        {
            circulo_enemigos.OnSubmit(BED);
        }
        else if (botonSelecinado == 4 ) 
        {
            X_enemigos.OnSubmit(BED);
        }
        else 
        {
            print("Ella me dice ola y yo le digo godbye");
        }
        
        yield return new WaitForSeconds(Tiempo_botnes);

        cuantoLeQueda--;
        Simon();
    }


    public void Empezar() 
    {
        triangulo_aliados.interactable = true;
        cuadrado_aliados.interactable = true;
        circulo_aliados.interactable = true;
        X_aliados.interactable = true;

        triangulo_enemigos.interactable = false;
        cuadrado_enemigos.interactable = false;
        circulo_enemigos.interactable = false;
        X_enemigos.interactable = false;


    }

    public void checker()
    {
        for (int i = 0; i <= conteo2; i++) 
        {
            if (listaDeNumerosAlidaos[i] == listaDeNumerosEnemigos[i])
            {
                print("Teto>>>>>>>Miku");
            }
            else
            {
                if (EstaBien)
                {
                    fail = i;
                }
                EstaBien = false;
            }

        }

        if (EstaBien)
        {
            Debug.Log("El print esta bien basado");

            for (int x = 0; x <= Juego.Length - 1; x++)
            {
                print("Gyro, Gyro, Gyro Zeppeli");
                Juego[x].SetActive(false);
            }

            for (int i = 0; i <= listaDeNumerosAlidaos.Length - 1; i++)
            {
                listaDeNumerosAlidaos[i] = 0;
                Destroy(objetos_memoria_aliados[i]);
                Destroy(objetos_memoria_enemigos[i]);
                
                Bt.ajustes.SetActive(false);
            }



            Pantalla_Victoria.SetActive(true);

        }
        else if (!EstaBien)
        {
            Fallo();
        }
    }
    
    public void Fallo()
    {
        conteo2 -= (listaDeNumerosAlidaos.Length - fail);

        for(int i = fail;i <= listaDeNumerosAlidaos.Length-1; i++)
        {
            print("Miku, Miku, You can call me Miku");
            listaDeNumerosAlidaos[i] = 0;
            Destroy(objetos_memoria_aliados[i]);
        }
        EstaBien = true;
    }
    public void triangulo()
    {
        conteo2++;
        listaDeNumerosAlidaos[conteo2] = 1;
        objetos_memoria_aliados[conteo2] = Instantiate(objetosDeMemoria[0], memoria_aliados[conteo2].gameObject.transform.position, Quaternion.identity);

        if (listaDeNumerosAlidaos[conteo2] == listaDeNumerosEnemigos[conteo2]) 
        {
            Acierto.Play();
        }else if (listaDeNumerosAlidaos[conteo2] != listaDeNumerosEnemigos[conteo2])
        {
            Error.Play();   
        }
       
        if (conteo2 == conteo1)
        {
            checker();
            print("Y allá en el tambo todo el mundo me decía ¡Ya te vas a mejorar!");
        }
    }

    public void cuadrado()
    {
        conteo2++;
        listaDeNumerosAlidaos[conteo2] = 2;
        objetos_memoria_aliados[conteo2] = Instantiate(objetosDeMemoria[1], memoria_aliados[conteo2].gameObject.transform.position, Quaternion.identity);
       
        if (listaDeNumerosAlidaos[conteo2] == listaDeNumerosEnemigos[conteo2])
        {
            Acierto.Play();
        }
        else if (listaDeNumerosAlidaos[conteo2] != listaDeNumerosEnemigos[conteo2])
        {
            Error.Play();
        }
        
        if (conteo2 == conteo1)
        {
            checker();
            print("Y en la familia todo el mundo me decía ¡Ya te vas a mejorar!");
        }
    }

    public void circulo() 
    {
        conteo2++;
        listaDeNumerosAlidaos[conteo2] = 3;
        objetos_memoria_aliados[conteo2] = Instantiate(objetosDeMemoria[2], memoria_aliados[conteo2].gameObject.transform.position, Quaternion.identity);
       
        if (listaDeNumerosAlidaos[conteo2] == listaDeNumerosEnemigos[conteo2])
        {
            Acierto.Play();
        }
        else if (listaDeNumerosAlidaos[conteo2] != listaDeNumerosEnemigos[conteo2])
        {
            Error.Play();
        }

        if (conteo2 == conteo1)
        {
            checker();
            print("Ya perdí la paciencia en la lobotomía ¡Ya te vas a mejorar!");
        }
    }

    public void X()
    {
        conteo2++;
        listaDeNumerosAlidaos[conteo2] = 4;
        objetos_memoria_aliados[conteo2] = Instantiate(objetosDeMemoria[3], memoria_aliados[conteo2].gameObject.transform.position, Quaternion.identity);

        if (listaDeNumerosAlidaos[conteo2] == listaDeNumerosEnemigos[conteo2])
        {
            Acierto.Play();
        }
        else if (listaDeNumerosAlidaos[conteo2] != listaDeNumerosEnemigos[conteo2])
        {
            Error.Play();
        }

        if (conteo2 == conteo1)
        {
            checker();
            print("Perdí mi mano izquierda y me duele todavía ¡Ya te vas a mejorar!");
        }
    }
    void Update()
    {
        
    }
}
