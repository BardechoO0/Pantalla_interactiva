using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{


    //JUEGO COLORES

    [SerializeField] public float Points;
    public static gameManager Instance;
    [SerializeField] public TextMeshProUGUI ColorTexto;
    [SerializeField] public int ColorPedido2;
    [SerializeField] public string ColorPedido;
    [SerializeField] public string[] Colores = new string[5];
    [SerializeField] public float Diferencia = 1f;
    [SerializeField] GameObject Azul;
    [SerializeField] GameObject Rojo;
    [SerializeField] GameObject Verde;
    [SerializeField] GameObject Amarillo;
    [SerializeField] GameObject Blanco;
    [SerializeField] public Image ColorSolicitado;
    [SerializeField] public int FormaPedida;
    [SerializeField] public GameObject BotonesRejugar;
    [SerializeField] public Vector2 VectorVerde;
    [SerializeField] public Vector2 VectorRojo;
    [SerializeField] public Vector2 VectorAmarillo;
    [SerializeField] public Vector2 VectorAzul;
    [SerializeField] public Vector2 VectorBlanco;
    [SerializeField] public float LimitesX;
    [SerializeField] public float LimitesY;
    [SerializeField] public GameObject VolverAlMenu;
    [SerializeField] public GameObject ContinuarJugando;
    //VIEJA X
    [SerializeField] public float PosicionVerdeX;
    [SerializeField] public float PosicionRojoX;
    [SerializeField] public float PosicionAzulX;
    [SerializeField] public float PosicionAmarilloX;
    [SerializeField] public float PosicionBlancoX;
    [SerializeField] public float[] PosicionesX = new float[5];
    //VIEJA Y
    [SerializeField] public float PosicionVerdeY;
    [SerializeField] public float PosicionRojoY;
    [SerializeField] public float PosicionAzulY;
    [SerializeField] public float PosicionAmarilloY;
    [SerializeField] public float PosicionBlancoY;
    [SerializeField] public float[] PosicionesY = new float[5];

    //NUEVA X
    [SerializeField] public float NuevaPosicionVerdeX;
    [SerializeField] public float NuevaPosicionRojoX;
    [SerializeField] public float NuevaPosicionAzulX;
    [SerializeField] public float NuevaPosicionAmarilloX;
    [SerializeField] public float NuevaPosicionBlancoX;
    //NUEVA Y
    [SerializeField] public float NuevaPosicionVerdeY;
    [SerializeField] public float NuevaPosicionRojoY;
    [SerializeField] public float NuevaPosicionAzulY;
    [SerializeField] public float NuevaPosicionAmarilloY;
    [SerializeField] public float NuevaPosicionBlancoY;
    //CHECKERS X
    [SerializeField] public bool TeleportCheckerVerdeX;
    [SerializeField] public bool TeleportCheckerRojoX;
    [SerializeField] public bool TeleportCheckerAzulX;
    [SerializeField] public bool TeleportCheckerAmarilloX;
    [SerializeField] public bool TeleportCheckerBlancoX;
    [SerializeField] public bool TeleportCheckerX;
    //CHECKERS Y
    [SerializeField] public bool TeleportCheckerVerdeY;
    [SerializeField] public bool TeleportCherckerRojoY;
    [SerializeField] public bool TeleportCheckerAzulY;
    [SerializeField] public bool TeleportCheckerAmarilloY;
    [SerializeField] public bool TeleportCheckerBlancoY;
    [SerializeField] public bool TeleportCheckerY;

    //JUEGO ORDENAR

    [SerializeField] GameObject[] ConjuntoObjetos = new GameObject[40];
    [SerializeField] public float SpawnX;
    [SerializeField] public float SpawnY;
    [SerializeField] public float[] ViejaX = new float[40];
    [SerializeField] public float[] ViejaY = new float[40];
    [SerializeField] public float MaxX;
    [SerializeField] public float MaxY;
    [SerializeField] public bool SpawnChecker;
    [SerializeField] public int z;
    [SerializeField] public int x;
    [SerializeField] public string HabitacionPedida;
    [SerializeField] public string HabitacionProvisional;
    [SerializeField] public string[] Habitaciones = new string[4];
    [SerializeField] public int ObjetosCocina;
    [SerializeField] public int ObjetosDormitorio;
    [SerializeField] public int ObjetosJuguetes;
    [SerializeField] public int ObjetosBaño;
    [SerializeField] public string[] AuxiliarHabitaciones = new string[5];
    [SerializeField] public bool CheckerHabitaciones;

    // Start is called before the first frame update

    //ANIMACIONABUELA

    
    [SerializeField] public GameObject[] ArrayAbuela;
    [SerializeField] public int NumeroAbuela = 1;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Hay más de un Game Manager en escena");
        }
    }

    private void Start()
    {
        ArrayAbuela[0].SetActive(false);
        ArrayAbuela[1].SetActive(true);
        ArrayAbuela[2].SetActive(false);
        ArrayAbuela[3].SetActive(false);
        

        Time.timeScale = 1;

        //JUEGO COLORES
        Colores[0] = "Azul";
        Colores[1] = "Rojo";
        Colores[2] = "Amarillo";
        Colores[3] = "Verde";
        Colores[4] = "Morado";

        VectorVerde = new Vector2(-2.72f, 3.3f);
        VectorRojo = new Vector2(3.28f, 3.3f);
        VectorAmarillo = new Vector2(0.28f, -3.7f);
        VectorAzul = new Vector2(-4.72f, 0.7f);
        VectorBlanco = new Vector2(5.28f, -0.7f);
        BotonesRejugar.SetActive(false);
        VolverAlMenu.SetActive(false);
        ContinuarJugando.SetActive(false);


        //JUEGO ORDENAR

        Habitaciones[0] = "Cocina";
        Habitaciones[1] = "Dormitorio";
        Habitaciones[2] = "Juguetes";
        Habitaciones[3] = "Baño";
        ViejaX[0] = 0f;
        ViejaY[0] = 0f;

        
        Time.timeScale = 0;
        PedirColor();
    }

    private void Update()
    {
        if (ColorPedido2 == 0)
        {
            ColorSolicitado.color = Color.red;
            ColorPedido = "Rojo";
        }
        else if (ColorPedido2 == 1)
        {
            ColorSolicitado.color = new Color (0, 0.3126089f , 0.9137255f, 1);
            ColorPedido = "Azul";
        }
        else if (ColorPedido2 == 2)
        {
            ColorSolicitado.color = new Color (0.104806f, 0.6037736f, 0.1689246f, 1);
            ColorPedido = "Verde";
        }
        else if (ColorPedido2 == 3)
        {
            ColorSolicitado.color = new Color (0.6314721f, 0, 1, 1);
            ColorPedido = "Morado";
        }
        else if (ColorPedido2 == 4)
        {
            ColorSolicitado.color = Color.yellow;
            ColorPedido = "Amarillo";
            
        }

        ColorTexto.text = "Dale al " + ColorPedido;


        if (Points == 20)
        {
            QuieresJugarAOtro();
        }

        /*if (FormaPedida == 0)
        {
            ColorSolicitado.color = Color.red;
            ColorPedido = "Rojo";
        }
        else if (FormaPedida == 1)
        {
            ColorSolicitado.color = Color.blue;
            ColorPedido = "Azul";
        }
        else if (ColorPedido2 == 2)
        {
            ColorSolicitado.color = Color.green;
            ColorPedido = "Verde";
        }
        else if (ColorPedido2 == 3)
        {
            ColorSolicitado.color = Color.white;
            ColorPedido = "Blanco";
        }
        else if (ColorPedido2 == 4)
        {
            ColorSolicitado.color = Color.yellow;
            ColorPedido = "Amarillo";
        }*/
    }
    public void SumarPuntos()
    {
        Points++;
        if (NumeroAbuela == 0)
        {
            ArrayAbuela[0].SetActive(true);
            ArrayAbuela[1].SetActive(false);
            ArrayAbuela[2].SetActive(false);
            ArrayAbuela[3].SetActive(false);
            NumeroAbuela++;
        }
        else if (NumeroAbuela == 1)
        {
            ArrayAbuela[0].SetActive(false);
            ArrayAbuela[1].SetActive(true);
            ArrayAbuela[2].SetActive(false);
            ArrayAbuela[3].SetActive(false);
            NumeroAbuela++;
        }
        else if (NumeroAbuela == 2)
        {
            ArrayAbuela[0].SetActive(false);
            ArrayAbuela[1].SetActive(false);
            ArrayAbuela[2].SetActive(true);
            ArrayAbuela[3].SetActive(false);
            NumeroAbuela++;
        }
        else if (NumeroAbuela == 3)
        {
            ArrayAbuela[0].SetActive(false);
            ArrayAbuela[1].SetActive(false);
            ArrayAbuela[2].SetActive(false);
            ArrayAbuela[3].SetActive(true);
            NumeroAbuela = 0;
        }
        
    }

    public void PedirColor()
    {
        ColorPedido2 =Random.Range(0, Colores.Length);

        
    }
    public void QuieresJugarAOtro()
    {
        
        BotonesRejugar.SetActive(true);
        Time.timeScale = 0;
        
    }
   
    public void TeleportVerde()
    {
        TeleportCheckerVerdeX = true;

        while (TeleportCheckerVerdeX == true) 
        {
            NuevaPosicionVerdeX = Random.Range(-6f, 8f);
            if ((NuevaPosicionVerdeX > PosicionVerdeX + Diferencia || NuevaPosicionVerdeX < PosicionVerdeX -Diferencia) 
                && (NuevaPosicionVerdeX > PosicionAmarilloX + Diferencia || NuevaPosicionVerdeX < PosicionAmarilloX -Diferencia) 
                && (NuevaPosicionVerdeX > PosicionAzulX + Diferencia || NuevaPosicionVerdeX < PosicionAzulX - Diferencia) 
                && (NuevaPosicionVerdeX > PosicionRojoX + Diferencia || NuevaPosicionVerdeX < PosicionRojoX - Diferencia) 
                && (NuevaPosicionVerdeX > PosicionBlancoX + Diferencia || NuevaPosicionVerdeX < PosicionBlancoX - Diferencia))
            {
                TeleportCheckerVerdeX = false;
            }
        }

        TeleportCheckerVerdeY = true;

        while (TeleportCheckerVerdeY == true)
        {
            NuevaPosicionVerdeY = Random.Range(-4f, 2f);
            if ((NuevaPosicionVerdeY > PosicionVerdeY + Diferencia || NuevaPosicionVerdeY < PosicionVerdeY - Diferencia) 
                && (NuevaPosicionVerdeY > PosicionAmarilloY + Diferencia || NuevaPosicionVerdeY < PosicionAmarilloY - Diferencia) 
                && (NuevaPosicionVerdeY > PosicionAzulY + Diferencia || NuevaPosicionVerdeY < PosicionAzulY - Diferencia) 
                && (NuevaPosicionVerdeY > PosicionRojoY + Diferencia || NuevaPosicionVerdeY < PosicionRojoY - Diferencia) 
                && (NuevaPosicionVerdeY > PosicionBlancoY + Diferencia || NuevaPosicionVerdeY < PosicionBlancoY - Diferencia))
            {
                TeleportCheckerVerdeY = false;
            }
        }

        PosicionVerdeX = NuevaPosicionVerdeX;
        PosicionVerdeY = NuevaPosicionVerdeY;

        
        Vector2 PosVerde = new Vector2(PosicionVerdeX, PosicionVerdeY);
        VectorVerde = PosVerde;
        Verde.transform.position = PosVerde;
        StartCoroutine(ParticulasDelayVerde());

    }

    public void TeleportAzul()
    {
        TeleportCheckerAzulX = true;

        while (TeleportCheckerAzulX == true)
        {
            NuevaPosicionAzulX = Random.Range(-6f, 8f);
            if (
                (NuevaPosicionAzulX > PosicionVerdeX + Diferencia || NuevaPosicionAzulX < PosicionVerdeX - Diferencia)
                && (NuevaPosicionAzulX > PosicionAmarilloX + Diferencia || NuevaPosicionAzulX < PosicionAmarilloX - Diferencia)
                && (NuevaPosicionAzulX > PosicionAzulX + Diferencia || NuevaPosicionAzulX < PosicionAzulX - Diferencia)
                && (NuevaPosicionAzulX > PosicionRojoX + Diferencia || NuevaPosicionAzulX < PosicionRojoX - Diferencia)
                && (NuevaPosicionAzulX > PosicionBlancoX + Diferencia || NuevaPosicionAzulX < PosicionBlancoX - Diferencia)
                )
            {
                TeleportCheckerAzulX = false;
            }
        }

        TeleportCheckerAzulY = true;

        while (TeleportCheckerAzulY == true)
        {
            NuevaPosicionAzulY = Random.Range(-4f, 2f);
            if (
                (NuevaPosicionAzulY > PosicionVerdeY + Diferencia || NuevaPosicionAzulY < PosicionVerdeY - Diferencia)
                && (NuevaPosicionAzulY > PosicionAmarilloY + Diferencia || NuevaPosicionAzulY < PosicionAmarilloY - Diferencia)
                && (NuevaPosicionAzulY > PosicionAzulY + Diferencia || NuevaPosicionAzulY < PosicionAzulY - Diferencia)
                && (NuevaPosicionAzulY > PosicionRojoY + Diferencia || NuevaPosicionAzulY < PosicionRojoY - Diferencia)
                && (NuevaPosicionAzulY > PosicionBlancoY + Diferencia || NuevaPosicionAzulY < PosicionBlancoY - Diferencia)
                )
            {
                TeleportCheckerAzulY = false;
            }
        }

        PosicionAzulX = NuevaPosicionAzulX;
        PosicionAzulY = NuevaPosicionAzulY;

        
        Vector2 PosAzul = new Vector2(PosicionAzulX, PosicionAzulY);
        VectorAzul = PosAzul;
        Azul.transform.position = PosAzul;
        
        StartCoroutine(ParticulasDelayAzul());
        


    }

    public void TeleportAmarillo()
    {
        TeleportCheckerAmarilloX = true;

        while (TeleportCheckerAmarilloX == true)
        {
            NuevaPosicionAmarilloX = Random.Range(-6f, 8f);
            if (
                (NuevaPosicionAmarilloX > PosicionVerdeX + Diferencia || NuevaPosicionAmarilloX < PosicionVerdeX - Diferencia)
                && (NuevaPosicionAmarilloX > PosicionAmarilloX + Diferencia || NuevaPosicionAmarilloX < PosicionAmarilloX - Diferencia)
                && (NuevaPosicionAmarilloX > PosicionAzulX + Diferencia || NuevaPosicionAmarilloX < PosicionAzulX - Diferencia)
                && (NuevaPosicionAmarilloX > PosicionRojoX + Diferencia || NuevaPosicionAmarilloX < PosicionRojoX - Diferencia)
                && (NuevaPosicionAmarilloX > PosicionBlancoX + Diferencia || NuevaPosicionAmarilloX < PosicionBlancoX - Diferencia)
                )
            {
                TeleportCheckerAmarilloX = false;
            }
        }

        TeleportCheckerAmarilloY = true;

        while (TeleportCheckerAmarilloY == true)
        {
            NuevaPosicionAmarilloY = Random.Range(-4f, 2f);
            if (
                (NuevaPosicionAmarilloY > PosicionVerdeY + Diferencia || NuevaPosicionAmarilloY < PosicionVerdeY - Diferencia)
                && (NuevaPosicionAmarilloY > PosicionAmarilloY + Diferencia || NuevaPosicionAmarilloY < PosicionAmarilloY - Diferencia)
                && (NuevaPosicionAmarilloY > PosicionAzulY + Diferencia || NuevaPosicionAmarilloY < PosicionAzulY - Diferencia)
                && (NuevaPosicionAmarilloY > PosicionRojoY + Diferencia || NuevaPosicionAmarilloY < PosicionRojoY - Diferencia)
                && (NuevaPosicionAmarilloY > PosicionBlancoY + Diferencia || NuevaPosicionAmarilloY < PosicionBlancoY - Diferencia)
                )
            {
                TeleportCheckerAmarilloY = false;
            }
        }

        PosicionAmarilloX = NuevaPosicionAmarilloX;
        PosicionAmarilloY = NuevaPosicionAmarilloY;

        
        Vector2 PosAmarillo = new Vector2(PosicionAmarilloX, PosicionAmarilloY);
        VectorAmarillo = PosAmarillo;
        Amarillo.transform.position = PosAmarillo;
        StartCoroutine(ParticulasDelayAmarillo());

    }

    public void TeleportRojo()
    {
        TeleportCheckerRojoX = true;

        while (TeleportCheckerRojoX == true)
        {
            NuevaPosicionRojoX = Random.Range(-6f, 8f);
            if (
                (NuevaPosicionRojoX > PosicionVerdeX + Diferencia || NuevaPosicionRojoX < PosicionVerdeX - Diferencia)
                && (NuevaPosicionRojoX > PosicionAmarilloX + Diferencia || NuevaPosicionRojoX < PosicionAmarilloX - Diferencia)
                && (NuevaPosicionRojoX > PosicionAzulX + Diferencia || NuevaPosicionRojoX < PosicionAzulX - Diferencia)
                && (NuevaPosicionRojoX > PosicionRojoX + Diferencia || NuevaPosicionRojoX < PosicionRojoX - Diferencia)
                && (NuevaPosicionRojoX > PosicionBlancoX + Diferencia || NuevaPosicionRojoX < PosicionBlancoX - Diferencia)
                )
            {
                TeleportCheckerRojoX = false;
            }
        }

        TeleportCherckerRojoY = true;

        while (TeleportCherckerRojoY == true)
        {
            NuevaPosicionRojoY = Random.Range(-4f, 2f);
            if (
                (NuevaPosicionRojoY > PosicionVerdeY + Diferencia || NuevaPosicionRojoY < PosicionVerdeY - Diferencia)
                && (NuevaPosicionRojoY > PosicionAmarilloY + Diferencia || NuevaPosicionRojoY < PosicionAmarilloY - Diferencia)
                && (NuevaPosicionRojoY > PosicionAzulY + Diferencia || NuevaPosicionRojoY < PosicionAzulY - Diferencia)
                && (NuevaPosicionRojoY > PosicionRojoY + Diferencia || NuevaPosicionRojoY < PosicionRojoY - Diferencia)
                && (NuevaPosicionRojoY > PosicionBlancoY + Diferencia || NuevaPosicionRojoY < PosicionBlancoY - Diferencia)
                )
            {
                TeleportCherckerRojoY = false;
            }
        }

        PosicionRojoX = NuevaPosicionRojoX;
        PosicionRojoY = NuevaPosicionRojoY;

        
        Vector2 PosRojo = new Vector2(PosicionRojoX, PosicionRojoY);
        VectorRojo = PosRojo;
        Rojo.transform.position = PosRojo;
        StartCoroutine(ParticulasDelayRojo());

    }
    public void TeleportBlanco()
    {
        TeleportCheckerBlancoX = true;

        while (TeleportCheckerBlancoX == true)
        {
            NuevaPosicionBlancoX = Random.Range(-6f, 8f);
            if (
                (NuevaPosicionBlancoX > PosicionVerdeX + Diferencia || NuevaPosicionBlancoX < PosicionVerdeX - Diferencia)
                && (NuevaPosicionBlancoX > PosicionAmarilloX + Diferencia || NuevaPosicionBlancoX < PosicionAmarilloX - Diferencia)
                && (NuevaPosicionBlancoX > PosicionAzulX + Diferencia || NuevaPosicionBlancoX < PosicionAzulX - Diferencia)
                && (NuevaPosicionBlancoX > PosicionRojoX + Diferencia || NuevaPosicionBlancoX < PosicionRojoX - Diferencia)
                && (NuevaPosicionBlancoX > PosicionBlancoX + Diferencia || NuevaPosicionBlancoX < PosicionBlancoX - Diferencia)
                )
            {
                TeleportCheckerBlancoX = false;
            }
        }

        TeleportCheckerBlancoY = true;

        while (TeleportCheckerBlancoY == true)
        {
            NuevaPosicionBlancoY = Random.Range(-4f, 2f);
            if (
                (NuevaPosicionBlancoY > PosicionVerdeY + Diferencia || NuevaPosicionBlancoY < PosicionVerdeY - Diferencia)
                && (NuevaPosicionBlancoY > PosicionAmarilloY + Diferencia || NuevaPosicionBlancoY < PosicionAmarilloY - Diferencia)
                && (NuevaPosicionBlancoY > PosicionAzulY + Diferencia || NuevaPosicionBlancoY < PosicionAzulY - Diferencia)
                && (NuevaPosicionBlancoY > PosicionRojoY + Diferencia || NuevaPosicionBlancoY < PosicionRojoY -     Diferencia)
                && (NuevaPosicionBlancoY > PosicionBlancoY + Diferencia || NuevaPosicionBlancoY < PosicionBlancoY - Diferencia)
                )
            {
                TeleportCheckerBlancoY = false;
            }
        }

        PosicionBlancoX = NuevaPosicionBlancoX;
        PosicionBlancoY = NuevaPosicionBlancoY;

        
        Vector2 PosBlanco = new Vector2(PosicionBlancoX, PosicionBlancoY);
        VectorBlanco = PosBlanco;
        Blanco.transform.position = PosBlanco;
        StartCoroutine(ParticulasDelayBlanco());

    }


    public void InicioCocina()
    {

        if (ObjetosCocina == 10 && ObjetosBaño == 10 && ObjetosDormitorio == 10 && ObjetosJuguetes == 10)
        {
            Debug.Log("JuegoTerminado");
        }
        else if (ObjetosCocina == 10 && ObjetosBaño == 10 && ObjetosDormitorio == 10)
        {
            HabitacionPedida = "Juguetes";
        }
        else if (ObjetosCocina == 10 && ObjetosBaño == 10)
        {
            HabitacionPedida = "Dormitorio";
        }
        else if (ObjetosCocina == 10)
        {
            HabitacionPedida = "Baño";
        }
    }
    public void SpawnObjetos()
    {
        for (int i = 0; i < 40; i++)
        {
            SpawnChecker = true;

            while(SpawnChecker == true)
            {
                SpawnX = Random.Range(-8f, 8f);
                SpawnY = Random.Range(-4f, 4f);
                

                for (int j = 0;  j <= i;)
                {
                    if ( i == 0)
                    {
                        Vector2 PosSpawn1 = new Vector2(SpawnX, SpawnY);
                        Instantiate(ConjuntoObjetos[0], PosSpawn1, Quaternion.identity);
                        j = 43;
                        z = j;
                    }

                    else if 
                    (
                   (SpawnX < ViejaX[j] + Diferencia && SpawnX > ViejaX[j] - Diferencia) && (SpawnY < ViejaY[j] + Diferencia && SpawnY > ViejaY[j] - Diferencia)
                    )
                    {
                        j = 42;
                        z = j;
                        

                    }
                    else
                    {
                        z = j;
                        j++;
                        
                    }
                }

                if ( z == 42)
                {
                    SpawnChecker = true;
                }
                else
                {
                    SpawnChecker = false;
                }
            }

            Vector2 PosSpawn = new Vector2(SpawnX, SpawnY);

            ViejaX[i] = SpawnX;
            ViejaY[i] = SpawnY;

            if ( i > 0)
            {
                Instantiate(ConjuntoObjetos[i], PosSpawn, Quaternion.identity);
            }
            

        }
    }

    IEnumerator ParticulasDelayAzul()
    {
        SpawnParticulas.ReferenciaParticulas.PlayParticulasAzul();
        yield return new WaitForSeconds(1f);
        SpawnParticulas.ReferenciaParticulas.StopParticulasAzul();
        SpawnParticulas.ReferenciaParticulas.ParticulasAzul.transform.position = Azul.transform.position;
    }
    IEnumerator ParticulasDelayAmarillo()
    {
        SpawnParticulas.ReferenciaParticulas.PlayParticulasAmarillo();
        yield return new WaitForSeconds(1f);
        SpawnParticulas.ReferenciaParticulas.StopParticulasAmarillo();
        SpawnParticulas.ReferenciaParticulas.ParticulasAmarillo.transform.position = Amarillo.transform.position;
    }
    IEnumerator ParticulasDelayBlanco()
    {
        SpawnParticulas.ReferenciaParticulas.PlayParticulasBlanco();
        yield return new WaitForSeconds(1f);
        SpawnParticulas.ReferenciaParticulas.StopParticulasBlanco();
        SpawnParticulas.ReferenciaParticulas.ParticulasBlanco.transform.position = Blanco.transform.position;
    }
    IEnumerator ParticulasDelayVerde()
    {
        SpawnParticulas.ReferenciaParticulas.PlayParticulasVerde();
        yield return new WaitForSeconds(1f);
        SpawnParticulas.ReferenciaParticulas.StopParticulasVerde();
        SpawnParticulas.ReferenciaParticulas.ParticulasVerde.transform.position = Verde.transform.position;
    }
    IEnumerator ParticulasDelayRojo()
    {
        SpawnParticulas.ReferenciaParticulas.PlayParticulasRojo();
        yield return new WaitForSeconds(1f);
        SpawnParticulas.ReferenciaParticulas.StopParticulasRojo();
        SpawnParticulas.ReferenciaParticulas.ParticulasRojo.transform.position = Rojo.transform.position;
    }
    public void Engranaje()
    { 
        Time.timeScale = 0;
        VolverAlMenu.SetActive(true);
        ContinuarJugando.SetActive(true);
    }
    public void Continuar()
    {
        Time.timeScale = 1;
        VolverAlMenu.SetActive(false);
        ContinuarJugando.SetActive(false);
    }
}
