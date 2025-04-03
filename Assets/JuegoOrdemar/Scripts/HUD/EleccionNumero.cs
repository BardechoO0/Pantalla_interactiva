using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EleccionNumero : MonoBehaviour
{

    [SerializeField] public int NumeroDeObjetos;
    [SerializeField] public GameObject[] Objetos12 = new GameObject[12];
    [SerializeField] public GameObject[] Objetos20 = new GameObject[20];
    [SerializeField] public GameObject[] Objetos28 = new GameObject[28];
    [SerializeField] public GameObject[] Objetos40 = new GameObject[40];

   
    // Te quedaste aqu� payaso

    [SerializeField] public GameObject[] Objetos122 = new GameObject[12];
    [SerializeField] public GameObject[] Objetos202 = new GameObject[20];
    [SerializeField] public GameObject[] Objetos282 = new GameObject[28];
    [SerializeField] public GameObject[] Objetos402 = new GameObject[40];
    [SerializeField] public GameObject Imagenes12;
    [SerializeField] public GameObject Imagenes20;
    [SerializeField] public GameObject Imagenes28;
    [SerializeField] public GameObject Imagenes40;
    [SerializeField] public GameObject BotonJugar;
    [SerializeField] public bool CheckerBotonJugar;
    [SerializeField] public GameObject BotonesNumeroObjetos;
    [SerializeField] public Button Color12;
    [SerializeField] public Button Color20;
    [SerializeField] public Button Color28;
    [SerializeField] public Button Color40;
    [SerializeField] public int Cocina12;
    [SerializeField] public int Cocina20;
    [SerializeField] public int Cocina28;
    [SerializeField] public int Cocina40;
    [SerializeField] public int Dormitorio12;
    [SerializeField] public int Dormitorio20;
    [SerializeField] public int Dormitorio28;
    [SerializeField] public int Dormitorio40;
    [SerializeField] public int Ba�o12;
    [SerializeField] public int Ba�o20;
    [SerializeField] public int Ba�o28;
    [SerializeField] public int Ba�o40;
    [SerializeField] public int Juguetes12;
    [SerializeField] public int Juguetes20;
    [SerializeField] public int Juguetes28;
    [SerializeField] public int Juguetes40;
    [SerializeField] public bool CheckerImagenes12;
    [SerializeField] public bool CheckerImagenes20;
    [SerializeField] public bool CheckerImagenes28;
    [SerializeField] public bool CheckerImagenes40;
    [SerializeField] public int z;
    [SerializeField] public int x;
    [SerializeField] public GameObject CocinaPadre;
    [SerializeField] public GameObject Ba�oPadre;
    [SerializeField] public GameObject DormitorioPadre;
    [SerializeField] public GameObject JuguetesPadre;
    [SerializeField] public GameObject VolverAlMenu;
    [SerializeField] public GameObject ContinuarJugando;
    [SerializeField] public GameObject MarcosRecogidosCocina;
    [SerializeField] public GameObject MarcosRecogidosBa�o;
    [SerializeField] public GameObject MarcosRecogidosJuguetes;
    [SerializeField] public GameObject MarcosRecogidosDormitorio;
    //POSICIONES 0-9 COCINA, 10-19 DORMITORIO, 20-29 BA�O, 30-39 JUGUETES
    [SerializeField] public GameObject[] ConjuntoObjetos = new GameObject[40];
    [SerializeField] public int[] ObjetoAnterior = new int[40];
    public List<int> numbersToChooseFrom = new List<int>(); // Lista de n�meros posibles
    private List<int> chosenNumbers = new List<int>(); // Lista de n�meros ya elegidos
    int randomNumber;
    // Start is called before the first frame update

    

    //NUEVAS VARIABLES CAMBIO DE DISE�O

    [SerializeField] public int NumeroDeHabitaciones;
    [SerializeField] public bool OpcionCocina;
    [SerializeField] public bool OpcionBa�o;
    [SerializeField] public bool OpcionDormitorio;
    [SerializeField] public bool OpcionJuguetes;
    [SerializeField] public GameObject MarcaCocina;
    [SerializeField] public GameObject MarcaBa�o;
    [SerializeField] public GameObject MarcaDormitorio;
    [SerializeField] public GameObject MarcaJuguetes;
    [SerializeField] public GameObject Habitacion1;
    [SerializeField] public GameObject Checkers;
    [SerializeField] public GameObject Bordes1Habitacion;
    [SerializeField] public GameObject Bordes2Habitaciones;
    [SerializeField] public GameObject Bordes34Habitaciones;
    [SerializeField] public GameObject PasarAlSiguiente;
    [SerializeField] public GameObject Ticks;
    [SerializeField] public GameObject Ajustes;
    [SerializeField] public GameObject Ajustes1Habitacion;
    [SerializeField] public GameObject BordeAjustes1;
    [SerializeField] public GameObject[] Habitacion2 = new GameObject[2];
    [SerializeField] public GameObject[] Habitaciones34 = new GameObject[4];
    public List<GameObject> ListaAuxiliar = new List<GameObject>();
    public List<GameObject> ListaAuxiliarTexto = new List<GameObject>();
    [SerializeField] public GameObject CocinaTexto;
    [SerializeField] public GameObject Ba�oTexto;
    [SerializeField] public GameObject DormitorioTexto;
    [SerializeField] public GameObject JuguetesTexto;
    [SerializeField] public GameObject SpawnTexto1;
    [SerializeField] public GameObject SpawnTexto21;
    [SerializeField] public GameObject SpawnTexto22;
    int Comodin = 0;
    int Comodin2 = 0;
    int Velocidad = 0;
    [SerializeField] public GameObject[] Objetos121 = new GameObject[12];
    [SerializeField] public GameObject[] Objetos201 = new GameObject[20];
    [SerializeField] public GameObject[] Objetos281 = new GameObject[28];
    [SerializeField] public GameObject[] Objetos401 = new GameObject[40];
    [SerializeField] public GameObject CortinaIzquierda;
    [SerializeField] public GameObject CortinaDerecha;
    [SerializeField] public GameObject Ganaste;

    



    
        public bool CocinaHab1Pos1Num = false;
        public bool Ba�oHab1Pos1Num = false;
        public bool DormitorioHab1Pos1Num = false;
        public bool JuguetesHab1Pos1Num = false;
        public bool CocinaHab2Pos1Num = false;
        public bool CocinaHab2Pos2Num = false;
        public bool Ba�oHab2Pos1Num = false;
        public bool Ba�oHab2Pos2Num = false;
        public bool DormitorioHab2Pos1Num = false;
        public bool DormitorioHab2Pos2Num = false;
        public bool JuguetesHab2Pos1Num = false;
        public bool JuguetesHab2Pos2Num = false;
        public bool CocinaHab34Pos2Num = false;
        public bool Ba�oHab34Pos1Num = false;
        public bool DormitorioHab34Pos4Num = false;
        public bool JuguetesHab34Pos3Num = false;


    [SerializeField] public int ObjetosAcertados;
    [SerializeField] public int PuntosNecesarios;


    public static EleccionNumero ReferenciaEleccionNumero;

    public void Awake()
    {
        if (ReferenciaEleccionNumero ==  null)
        {
            ReferenciaEleccionNumero = this;
        }
    }

    void Start()
    {
        Time.timeScale = 1;
        Ganaste.SetActive(false);
        VolverAlMenu.SetActive(false);
        ContinuarJugando.SetActive(false);
        for (int i = 0; i <= 39; i++)
        {
            numbersToChooseFrom.Add(i);
        }
        BotonJugar.SetActive(false);
        CheckerBotonJugar = false;
        Imagenes20.SetActive(false);
        Imagenes40.SetActive(false);
        Imagenes12.SetActive(false);
        Imagenes28.SetActive(false);
        DormitorioPadre.SetActive(false);
        CocinaPadre.SetActive(false);
        Ba�oPadre.SetActive(false);
        JuguetesPadre.SetActive(false);
        MarcaCocina.SetActive(false);
        MarcaBa�o.SetActive(false);
        MarcaDormitorio.SetActive(false);
        MarcaJuguetes.SetActive(false);
        BotonesNumeroObjetos.SetActive(false);
        OpcionBa�o = false;
        OpcionDormitorio = false;
        OpcionJuguetes = false;
        OpcionCocina = false;
    }
    // Update is called once per frame
    void Update()
    {
        
        Vector2 Izq = new Vector2(-1f, 0f) * Velocidad * Time.deltaTime;
        CortinaIzquierda.transform.Translate(Izq);
        Vector2 Der = new Vector2(1f, 0f) * Velocidad * Time.deltaTime;
        CortinaDerecha.transform.Translate(Der);
        if (CortinaIzquierda.transform.position.x < -11.25f)
        {
            Velocidad = 0;
        }


        if (PuntosNecesarios == ObjetosAcertados && PuntosNecesarios > 1)
        {
            Ganaste.SetActive(true);


        }
    }
    public void Seleccion12()
    {
        NumeroDeObjetos = 12;
        Color12.image.color = Color.gray;
        Color20.image.color = Color.white;
        Color28.image.color = Color.white;
        Color40.image.color = Color.white;

        if (CheckerBotonJugar == false)
        {
            BotonJugar.SetActive(true);
            CheckerBotonJugar = true;
        }
    }
    public void Seleccion20()
    {
        NumeroDeObjetos = 20;
        Color20.image.color = Color.gray;
        Color12.image.color = Color.white;
        Color28.image.color = Color.white;
        Color40.image.color = Color.white;

        if (CheckerBotonJugar == false)
        {
            BotonJugar.SetActive(true);
            CheckerBotonJugar = true;
        }
    }
    public void Seleccion28()
    {
        NumeroDeObjetos = 28;
        Color28.image.color = Color.gray;
        Color12.image.color = Color.white;
        Color20.image.color = Color.white;
        Color40.image.color = Color.white;

        if (CheckerBotonJugar == false)
        {
            BotonJugar.SetActive(true);
            CheckerBotonJugar = true;
        }
    }
    public void Seleccion40()
    {
        NumeroDeObjetos = 40;
        Color40.image.color = Color.gray;
        Color12.image.color = Color.white;
        Color20.image.color = Color.white;
        Color28.image.color = Color.white;

        if (CheckerBotonJugar == false)
        {
            BotonJugar.SetActive(true);
            CheckerBotonJugar = true;
        }
    }
    public void SeleccionCocina()
    {
        if (OpcionCocina == false)
        {
            NumeroDeHabitaciones++;
            MarcaCocina.SetActive(true);
            OpcionCocina = true;
            ListaAuxiliar.Add(CocinaPadre);
            ListaAuxiliarTexto.Add(CocinaTexto);
        }
        else
        {
            NumeroDeHabitaciones--;
            MarcaCocina.SetActive(false);
            OpcionCocina = false;
            ListaAuxiliar.Remove(CocinaPadre);
            ListaAuxiliarTexto.Remove(CocinaTexto);
        }
    }
    public void SeleccionBa�o()
    {
        if (OpcionBa�o == false)
        {
            NumeroDeHabitaciones++;
            MarcaBa�o.SetActive(true);
            OpcionBa�o = true;
            ListaAuxiliar.Add(Ba�oPadre);
            ListaAuxiliarTexto.Add(Ba�oTexto);
        }
        else
        {
            NumeroDeHabitaciones--;
            MarcaBa�o.SetActive(false);
            OpcionBa�o = false;
            ListaAuxiliar.Remove(Ba�oPadre);
            ListaAuxiliarTexto.Remove(Ba�oTexto);
        }
    }
    public void SeleccionDormitorio()
    {
        if (OpcionDormitorio == false)
        {
            NumeroDeHabitaciones++;
            MarcaDormitorio.SetActive(true);
            OpcionDormitorio = true;
            ListaAuxiliar.Add(DormitorioPadre);
            ListaAuxiliarTexto.Add(DormitorioTexto);
        }
        else
        {
            NumeroDeHabitaciones--;
            MarcaDormitorio.SetActive(false);
            OpcionDormitorio = false;
            ListaAuxiliar.Remove(DormitorioPadre);
            ListaAuxiliarTexto.Remove(DormitorioTexto);
        }
    }
    public void SeleccionJuguetes()
    {
        if (OpcionJuguetes == false)
        {
            NumeroDeHabitaciones++;
            MarcaJuguetes.SetActive(true);
            OpcionJuguetes = true;
            ListaAuxiliar.Add(JuguetesPadre);
            ListaAuxiliarTexto.Add(JuguetesTexto);
        }
        else
        {
            NumeroDeHabitaciones--;
            MarcaJuguetes.SetActive(false);
            OpcionJuguetes = false;
            ListaAuxiliar.Remove(JuguetesPadre);
            ListaAuxiliarTexto.Remove(JuguetesTexto);
        }
    }
    public void siguiente()
    {
        if (NumeroDeHabitaciones > 0)
        {
            Ticks.SetActive(false);
            Checkers.SetActive(false);
            BotonesNumeroObjetos.SetActive(true);
            PasarAlSiguiente.SetActive(false);
            Checkers.SetActive(false);
        }
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
    public void RemoverDeLista()
    {
        numbersToChooseFrom.Remove(0 + Comodin);
        numbersToChooseFrom.Remove(1 + Comodin);
        numbersToChooseFrom.Remove(2 + Comodin);
        numbersToChooseFrom.Remove(3 + Comodin);
        numbersToChooseFrom.Remove(4 + Comodin);
        numbersToChooseFrom.Remove(5 + Comodin);
        numbersToChooseFrom.Remove(6 + Comodin);
        numbersToChooseFrom.Remove(7 + Comodin);
        numbersToChooseFrom.Remove(8 + Comodin);
        numbersToChooseFrom.Remove(9 + Comodin);
    }

    public void PickRandomNumber2()
    {
        
            Velocidad = 2;
            
        
        
        // UNA HABITACION
        if (NumeroDeHabitaciones == 1)
        {
            
            BordeAjustes1.SetActive(true);
            Ajustes1Habitacion.SetActive(true);
            Bordes1Habitacion.SetActive(true);
            Habitacion1.SetActive(true);
            SpawnTexto1.SetActive(true);
            if (OpcionCocina == true)
            {
                Comodin = 0;
                CocinaTexto.SetActive(true);
                CocinaPadre.SetActive(true);
                CocinaPadre.transform.position = Habitacion1.transform.position;
                CocinaTexto.transform.position = SpawnTexto1.transform.position;
                CocinaHab1Pos1Num = true;
                Habitacion1.SetActive(false);
                SpawnTexto1.SetActive(false);
                
            }
            else if (OpcionBa�o == true)
            {
                Comodin = 20;
                Ba�oTexto.SetActive(true);
                Ba�oPadre.SetActive(true);
                Ba�oPadre.transform.position = Habitacion1.transform.position;
                Ba�oTexto.transform.position = SpawnTexto1.transform.position;
                Ba�oHab1Pos1Num = true;
                Habitacion1.SetActive(false);
                SpawnTexto1.SetActive(false);

            }
            else if (OpcionDormitorio == true)
            {
                Comodin = 10;
                DormitorioTexto.SetActive(true);
                DormitorioPadre.SetActive(true);
                DormitorioPadre.transform.position = Habitacion1.transform.position;
                DormitorioTexto.transform.position = SpawnTexto1.transform.position;
                DormitorioHab1Pos1Num = true;
                Habitacion1.SetActive(false);
                SpawnTexto1.SetActive(false);

            }
            else if (OpcionJuguetes == true)
            {
                Comodin = 30;
                JuguetesTexto.SetActive(true);
                JuguetesPadre.SetActive(true);
                JuguetesPadre.transform.position = Habitacion1.transform.position;
                JuguetesTexto.transform.position = SpawnTexto1.transform.position;
                JuguetesHab1Pos1Num = true;
                Habitacion1.SetActive(false);
                SpawnTexto1.SetActive(false);

            }
            List<GameObject> list = new List<GameObject>();
            if (NumeroDeObjetos == 12)
            {
                PuntosNecesarios = 6;
                CuentaBa�o.ReferenciaCuentaBa�o.RecogidosHab1[6].SetActive(false);
                CuentaBa�o.ReferenciaCuentaBa�o.RecogidosHab1[7].SetActive(false);
                CuentaBa�o.ReferenciaCuentaBa�o.RecogidosHab1[8].SetActive(false);
                CuentaBa�o.ReferenciaCuentaBa�o.RecogidosHab1[9].SetActive(false);

                for (int i = 0; i < NumeroDeObjetos; i++)
                {
                    list.Add(Objetos121[i]);
                }
            }
            else if (NumeroDeObjetos == 20)
            {

                PuntosNecesarios = 10;
                for (int i = 0; i < NumeroDeObjetos; i++)
                {
                    list.Add(Objetos201[i]);
                }
            }
            else if (NumeroDeObjetos == 28)
            {
                PuntosNecesarios = 10;
                for (int i = 0; i < NumeroDeObjetos; i++)
                {
                    list.Add(Objetos281[i]);
                }
            }
            else if (NumeroDeObjetos == 40)
            {
                PuntosNecesarios= 10;
                for (int i = 0; i < NumeroDeObjetos; i++)
                {
                    list.Add(Objetos401[i]);
                }
            }


            if (NumeroDeObjetos == 12 || NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();

                for (int i = Comodin; i < Comodin + (NumeroDeObjetos / 2); i++)
                {
                    lista.Add(ConjuntoObjetos[i]);

                }

                RemoverDeLista();

                for (int i = Comodin; i < Comodin + (NumeroDeObjetos / 2); i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < NumeroDeObjetos; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], list[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    
                }
            }

            else if (NumeroDeObjetos == 28)
            {
                CuentaBa�o.ReferenciaCuentaBa�o.RecogidosHab1[9].SetActive(false);

                List<GameObject> lista = new List<GameObject>();
                for (int i = Comodin; i < 9 + Comodin; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                RemoverDeLista();

                for (int i = 0; i < 19; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], list[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos281[i].SetActive(false);

                }
            }
            else if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0 + Comodin; i < 10 + Comodin; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                RemoverDeLista();

                for (int i = 0; i < 30; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], list[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos401[i].SetActive(false);
                }
            }
            
        }

        // DOS HABITACIONES
        if (NumeroDeHabitaciones == 2)
        {
            Ajustes.SetActive(true);
            Bordes2Habitaciones.SetActive(true);
            Habitacion2[0].SetActive(true);
            Habitacion2[1].SetActive(true);
            SpawnTexto21.SetActive(true);
            SpawnTexto22.SetActive(true);
            ListaAuxiliar[0].gameObject.SetActive(true);
            ListaAuxiliar[1].gameObject.SetActive(true);
            ListaAuxiliar[0].transform.position = Habitacion2[0].transform.position;
            ListaAuxiliar[1].transform.position = Habitacion2[1].transform.position;
            ListaAuxiliarTexto[0].gameObject.SetActive(true);
            ListaAuxiliarTexto[1].gameObject.SetActive(true);
            ListaAuxiliarTexto[0].transform.position = SpawnTexto21.transform.position;
            ListaAuxiliarTexto[1].transform.position = SpawnTexto22.transform.position;
            Habitacion2[0].SetActive(false);
            Habitacion2[1].SetActive(false);
            SpawnTexto21.SetActive(false);
            SpawnTexto22.SetActive(false);

            if (OpcionCocina && OpcionBa�o)
            {

                Comodin = 0;
                Comodin2 = 20;
                CocinaTexto.SetActive(true);
                CocinaPadre.SetActive(true);
                Ba�oTexto.SetActive(true);
                Ba�oPadre.SetActive(true);
                CocinaPadre.transform.position = Habitacion2[0].transform.position;
                CocinaTexto.transform.position = SpawnTexto21.transform.position;
                Ba�oPadre.transform.position= Habitacion2[1].transform.position;
                Ba�oTexto.transform.position = SpawnTexto22.transform.position;
                Habitacion2[0].SetActive(false);
                SpawnTexto21.SetActive(false);
                Habitacion2[1].SetActive(false);
                SpawnTexto22.SetActive(false);
                CocinaHab2Pos1Num = true;
                Ba�oHab2Pos2Num = true;

            }

            else if (OpcionCocina && OpcionDormitorio)
            {

                Comodin = 0;
                Comodin2 = 10;
                CocinaTexto.SetActive(true);
                CocinaPadre.SetActive(true);
                DormitorioTexto.SetActive(true);
                DormitorioPadre.SetActive(true);
                CocinaPadre.transform.position = Habitacion2[0].transform.position;
                CocinaTexto.transform.position = SpawnTexto21.transform.position;
                DormitorioPadre.transform.position = Habitacion2[1].transform.position;
                DormitorioTexto.transform.position = SpawnTexto22.transform.position;
                Habitacion2[0].SetActive(false);
                SpawnTexto21.SetActive(false);
                Habitacion2[1].SetActive(false);
                SpawnTexto22.SetActive(false);
                CocinaHab2Pos1Num = true;
                DormitorioHab2Pos2Num = true;

            }
            else if (OpcionCocina && OpcionJuguetes)
            {
                Comodin = 0;
                Comodin2 = 30;
                CocinaTexto.SetActive(true);
                CocinaPadre.SetActive(true);
                JuguetesTexto.SetActive(true);
                JuguetesPadre.SetActive(true);
                CocinaPadre.transform.position = Habitacion2[0].transform.position;
                CocinaTexto.transform.position = SpawnTexto21.transform.position;
                JuguetesPadre.transform.position = Habitacion2[1].transform.position;
                JuguetesTexto.transform.position = SpawnTexto22.transform.position;
                Habitacion2[0].SetActive(false);
                SpawnTexto21.SetActive(false);
                Habitacion2[1].SetActive(false);
                SpawnTexto22.SetActive(false);
                CocinaHab2Pos1Num = true;
                JuguetesHab2Pos2Num = true;
            }
            else if (OpcionBa�o && OpcionDormitorio)
            {
                Comodin = 20;
                Comodin2 = 10;
                Ba�oTexto.SetActive(true);
                Ba�oPadre.SetActive(true);
                DormitorioTexto.SetActive(true);
                DormitorioPadre.SetActive(true);
                Ba�oPadre.transform.position = Habitacion2[0].transform.position;
                Ba�oTexto.transform.position = SpawnTexto21.transform.position;
                DormitorioPadre.transform.position = Habitacion2[1].transform.position;
                DormitorioTexto.transform.position = SpawnTexto22.transform.position;
                Habitacion2[0].SetActive(false);
                SpawnTexto21.SetActive(false);
                Habitacion2[1].SetActive(false);
                SpawnTexto22.SetActive(false);
                Ba�oHab2Pos1Num = true;
                DormitorioHab2Pos2Num = true;
            }
            else if (OpcionBa�o && OpcionJuguetes)
            {
                Comodin = 20;
                Comodin2 = 30;
                Ba�oTexto.SetActive(true);
                Ba�oPadre.SetActive(true);
                JuguetesTexto.SetActive(true);
                JuguetesPadre.SetActive(true);
                Ba�oPadre.transform.position = Habitacion2[0].transform.position;
                Ba�oTexto.transform.position = SpawnTexto21.transform.position;
                JuguetesPadre.transform.position = Habitacion2[1].transform.position;
                JuguetesTexto.transform.position = SpawnTexto22.transform.position;
                Habitacion2[0].SetActive(false);
                SpawnTexto21.SetActive(false);
                Habitacion2[1].SetActive(false);
                SpawnTexto22.SetActive(false);
                Ba�oHab2Pos1Num = true;
                JuguetesHab2Pos2Num = true;
            }
            else if (OpcionDormitorio && OpcionJuguetes)
            {
                Comodin = 10;
                Comodin2 = 30;
                DormitorioTexto.SetActive(true);
                DormitorioPadre.SetActive(true);
                JuguetesTexto.SetActive(true);
                JuguetesPadre.SetActive(true);
                DormitorioPadre.transform.position = Habitacion2[0].transform.position;
                DormitorioTexto.transform.position = SpawnTexto21.transform.position;
                JuguetesPadre.transform.position = Habitacion2[1].transform.position;
                JuguetesTexto.transform.position = SpawnTexto22.transform.position;
                Habitacion2[0].SetActive(false);
                SpawnTexto21.SetActive(false);
                Habitacion2[1].SetActive(false);
                SpawnTexto22.SetActive(false);
                DormitorioHab2Pos1Num = true;
                JuguetesHab2Pos2Num = true;
            }
            if (NumeroDeObjetos == 12)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0 + Comodin; i < 4 + Comodin; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }
                 // convierte esto en una funcion payaso


                numbersToChooseFrom.Remove(0 + Comodin);
                numbersToChooseFrom.Remove(1 + Comodin);
                numbersToChooseFrom.Remove(2 + Comodin);
                numbersToChooseFrom.Remove(3 + Comodin);
                numbersToChooseFrom.Remove(4 + Comodin);
                numbersToChooseFrom.Remove(5 + Comodin);
                numbersToChooseFrom.Remove(6 + Comodin);
                numbersToChooseFrom.Remove(7 + Comodin);
                numbersToChooseFrom.Remove(8 + Comodin);
                numbersToChooseFrom.Remove(9 + Comodin);

                for (int i = 0 + Comodin2; i < 4 + Comodin2; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0 + Comodin2);
                numbersToChooseFrom.Remove(1 + Comodin2);
                numbersToChooseFrom.Remove(2 + Comodin2);
                numbersToChooseFrom.Remove(3 + Comodin2);
                numbersToChooseFrom.Remove(4 + Comodin2);
                numbersToChooseFrom.Remove(5 + Comodin2);
                numbersToChooseFrom.Remove(6 + Comodin2);
                numbersToChooseFrom.Remove(7 + Comodin2);
                numbersToChooseFrom.Remove(8 + Comodin2);
                numbersToChooseFrom.Remove(9 + Comodin2);

                for (int i = 0; i < 4; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos122[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos122[i].SetActive(false);
                }
                PuntosNecesarios = 8;
            }
            if (NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0 + Comodin; i < 7 + Comodin; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0 + Comodin);
                numbersToChooseFrom.Remove(1 + Comodin);
                numbersToChooseFrom.Remove(2 + Comodin);
                numbersToChooseFrom.Remove(3 + Comodin);
                numbersToChooseFrom.Remove(4 + Comodin);
                numbersToChooseFrom.Remove(5 + Comodin);
                numbersToChooseFrom.Remove(6 + Comodin);
                numbersToChooseFrom.Remove(7 + Comodin);
                numbersToChooseFrom.Remove(8 + Comodin);
                numbersToChooseFrom.Remove(9 + Comodin);

                for (int i = 0 + Comodin2; i < 7 + Comodin2; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0 + Comodin2);
                numbersToChooseFrom.Remove(1 + Comodin2);
                numbersToChooseFrom.Remove(2 + Comodin2);
                numbersToChooseFrom.Remove(3 + Comodin2);
                numbersToChooseFrom.Remove(4 + Comodin2);
                numbersToChooseFrom.Remove(5 + Comodin2);
                numbersToChooseFrom.Remove(6 + Comodin2);
                numbersToChooseFrom.Remove(7 + Comodin2);
                numbersToChooseFrom.Remove(8 + Comodin2);
                numbersToChooseFrom.Remove(9 + Comodin2);

                for (int i = 0; i < 6; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos202[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos202[i].SetActive(false);
                }
                PuntosNecesarios = 14;
            }
            if (NumeroDeObjetos == 28)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0 + Comodin; i < 9 + Comodin; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0 + Comodin);
                numbersToChooseFrom.Remove(1 + Comodin);
                numbersToChooseFrom.Remove(2 + Comodin);
                numbersToChooseFrom.Remove(3 + Comodin);
                numbersToChooseFrom.Remove(4 + Comodin);
                numbersToChooseFrom.Remove(5 + Comodin);
                numbersToChooseFrom.Remove(6 + Comodin);
                numbersToChooseFrom.Remove(7 + Comodin);
                numbersToChooseFrom.Remove(8 + Comodin);
                numbersToChooseFrom.Remove(9 + Comodin);

                for (int i = 0 + Comodin2; i < 9 + Comodin2; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0 + Comodin2);
                numbersToChooseFrom.Remove(1 + Comodin2);
                numbersToChooseFrom.Remove(2 + Comodin2);
                numbersToChooseFrom.Remove(3 + Comodin2);
                numbersToChooseFrom.Remove(4 + Comodin2);
                numbersToChooseFrom.Remove(5 + Comodin2);
                numbersToChooseFrom.Remove(6 + Comodin2);
                numbersToChooseFrom.Remove(7 + Comodin2);
                numbersToChooseFrom.Remove(8 + Comodin2);
                numbersToChooseFrom.Remove(9 + Comodin2);

                for (int i = 0; i < 10; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos282[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos282[i].SetActive(false);
                }
                PuntosNecesarios = 18;
            }
            if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0 + Comodin; i < 10 + Comodin; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0 + Comodin);
                numbersToChooseFrom.Remove(1 + Comodin);
                numbersToChooseFrom.Remove(2 + Comodin);
                numbersToChooseFrom.Remove(3 + Comodin);
                numbersToChooseFrom.Remove(4 + Comodin);
                numbersToChooseFrom.Remove(5 + Comodin);
                numbersToChooseFrom.Remove(6 + Comodin);
                numbersToChooseFrom.Remove(7 + Comodin);
                numbersToChooseFrom.Remove(8 + Comodin);
                numbersToChooseFrom.Remove(9 + Comodin);

                for (int i = 0 + Comodin2; i < 10 + Comodin2; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0 + Comodin2);
                numbersToChooseFrom.Remove(1 + Comodin2);
                numbersToChooseFrom.Remove(2 + Comodin2);
                numbersToChooseFrom.Remove(3 + Comodin2);
                numbersToChooseFrom.Remove(4 + Comodin2);
                numbersToChooseFrom.Remove(5 + Comodin2);
                numbersToChooseFrom.Remove(6 + Comodin2);
                numbersToChooseFrom.Remove(7 + Comodin2);
                numbersToChooseFrom.Remove(8 + Comodin2);
                numbersToChooseFrom.Remove(9 + Comodin2);

                for (int i = 0; i < 20; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos402[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos402[i].SetActive(false);
                }
                PuntosNecesarios = 20;
            }
        }
        // TRES HABITACIONES
        if (NumeroDeHabitaciones >= 3)
        {
            Ajustes.SetActive(true);
            Bordes34Habitaciones.SetActive(true);
            if (NumeroDeHabitaciones == 3)
            {
                Habitaciones34[0].SetActive(true);
                Habitaciones34[1].SetActive(true);
                Habitaciones34[2].SetActive(true);
                Habitaciones34[3].SetActive(true);

                if (OpcionCocina == false)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        MarcosRecogidosCocina.SetActive(false);

                    }
                    Ba�oPadre.SetActive(true);
                    DormitorioPadre.SetActive(true);
                    JuguetesPadre.SetActive(true);
                    Ba�oPadre.transform.position = Habitaciones34[0].transform.position;
                    JuguetesPadre.transform.position = Habitaciones34[2].transform.position;
                    DormitorioPadre.transform.position = Habitaciones34[3].transform.position;
                    Habitaciones34[0].SetActive(false);
                    Habitaciones34[1].SetActive(false);
                    Habitaciones34[2].SetActive(false);
                    Habitaciones34[3].SetActive(false);
                    Ba�oHab34Pos1Num = true;
                    JuguetesHab34Pos3Num = true;
                    DormitorioHab34Pos4Num = true;



                }
                else if (OpcionBa�o == false)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        MarcosRecogidosBa�o.SetActive(false);

                    }
                    CocinaPadre.SetActive(true);
                    DormitorioPadre.SetActive(true);
                    JuguetesPadre.SetActive(true);
                    CocinaPadre.transform.position = Habitaciones34[1].transform.position;
                    JuguetesPadre.transform.position = Habitaciones34[2].transform.position;
                    DormitorioPadre.transform.position = Habitaciones34[3].transform.position;
                    Habitaciones34[0].SetActive(false);
                    Habitaciones34[1].SetActive(false);
                    Habitaciones34[2].SetActive(false);
                    Habitaciones34[3].SetActive(false);
                    CocinaHab34Pos2Num = true;
                    JuguetesHab34Pos3Num = true;
                    DormitorioHab34Pos4Num = true;



                }
                else if (OpcionDormitorio == false)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        MarcosRecogidosDormitorio.SetActive(false);

                    }
                    Ba�oPadre.SetActive(true);
                    CocinaPadre.SetActive(true);
                    JuguetesPadre.SetActive(true);
                    Ba�oPadre.transform.position = Habitaciones34[0].transform.position;
                    CocinaPadre.transform.position = Habitaciones34[1].transform.position;
                    JuguetesPadre.transform.position = Habitaciones34[2].transform.position;
                    Habitaciones34[0].SetActive(false);
                    Habitaciones34[1].SetActive(false);
                    Habitaciones34[2].SetActive(false);
                    Habitaciones34[3].SetActive(false);
                    Ba�oHab34Pos1Num = true;
                    CocinaHab34Pos2Num = true;
                    JuguetesHab34Pos3Num = true;


                }
                else if (OpcionJuguetes == false)
                {

                    MarcosRecogidosJuguetes.SetActive(false);

                    Ba�oPadre.SetActive(true);
                    CocinaPadre.SetActive(true);
                    DormitorioPadre.SetActive(true);
                    Ba�oPadre.transform.position = Habitaciones34[0].transform.position;
                    CocinaPadre.transform.position = Habitaciones34[1].transform.position;
                    DormitorioPadre.transform.position = Habitaciones34[3].transform.position;
                    Habitaciones34[0].SetActive(false);
                    Habitaciones34[1].SetActive(false);
                    Habitaciones34[2].SetActive(false);
                    Habitaciones34[3].SetActive(false);
                    Ba�oHab34Pos1Num = true;
                    CocinaHab34Pos2Num = true;
                    DormitorioHab34Pos4Num = true;

                }
            }

            if (NumeroDeHabitaciones == 4)
            {
                Bordes34Habitaciones.SetActive(true);
                DormitorioPadre.SetActive(true);
                CocinaPadre.SetActive(true);
                Ba�oPadre.SetActive(true);
                JuguetesPadre.SetActive(true);
                CocinaPadre.transform.position = Habitaciones34[1].transform.position;
                Ba�oPadre.transform.position = Habitaciones34[0].transform.position;
                JuguetesPadre.transform.position = Habitaciones34[2].transform.position;
                DormitorioPadre.transform.position = Habitaciones34[3].transform.position;
                Habitaciones34[0].SetActive(false);
                Habitaciones34[1].SetActive(false);
                Habitaciones34[2].SetActive(false);
                Habitaciones34[3].SetActive(false);
                Ba�oHab34Pos1Num = true;
                CocinaHab34Pos2Num = true;
                JuguetesHab34Pos3Num = true;
                DormitorioHab34Pos4Num = true;

            }
            if (NumeroDeObjetos == 12)
            {
                Imagenes12.SetActive(true);
                for (int i = 0; i < 12; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {
                        // Genera un �ndice aleatorio dentro del rango de la lista de n�meros posibles
                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        // Obtiene el n�mero correspondiente al �ndice aleatorio
                        randomNumber = numbersToChooseFrom[randomIndex];

                        // Procesa el n�mero elegido (en este caso, solo lo imprime)
                        Debug.Log("N�mero elegido: " + randomNumber);

                        // Agrega el n�mero a la lista de n�meros elegidos
                        chosenNumbers.Add(randomNumber);

                        // Remueve el n�mero elegido de la lista de n�meros posibles
                        numbersToChooseFrom.RemoveAt(randomIndex);

                        if (randomNumber >= 0 && randomNumber <= 9)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Cocina";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                            Objetos12[i].SetActive(false);
                            Cocina12++;

                            if (Cocina12 == 3)
                            {
                                numbersToChooseFrom.Remove(0);
                                numbersToChooseFrom.Remove(1);
                                numbersToChooseFrom.Remove(2);
                                numbersToChooseFrom.Remove(3);
                                numbersToChooseFrom.Remove(4);
                                numbersToChooseFrom.Remove(5);
                                numbersToChooseFrom.Remove(6);
                                numbersToChooseFrom.Remove(7);
                                numbersToChooseFrom.Remove(8);
                                numbersToChooseFrom.Remove(9);

                            }
                        }
                        else if (randomNumber >= 10 && randomNumber <= 19)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                            Objetos12[i].SetActive(false);
                            Dormitorio12++;

                            if (Dormitorio12 == 3)
                            {
                                numbersToChooseFrom.Remove(10);
                                numbersToChooseFrom.Remove(11);
                                numbersToChooseFrom.Remove(12);
                                numbersToChooseFrom.Remove(13);
                                numbersToChooseFrom.Remove(14);
                                numbersToChooseFrom.Remove(15);
                                numbersToChooseFrom.Remove(16);
                                numbersToChooseFrom.Remove(17);
                                numbersToChooseFrom.Remove(18);
                                numbersToChooseFrom.Remove(19);

                            }
                        }
                        else if (randomNumber >= 20 && randomNumber <= 29)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Ba�o";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                            Objetos12[i].SetActive(false);
                            Ba�o12++;

                            if (Ba�o12 == 3)
                            {
                                numbersToChooseFrom.Remove(20);
                                numbersToChooseFrom.Remove(21);
                                numbersToChooseFrom.Remove(22);
                                numbersToChooseFrom.Remove(23);
                                numbersToChooseFrom.Remove(24);
                                numbersToChooseFrom.Remove(25);
                                numbersToChooseFrom.Remove(26);
                                numbersToChooseFrom.Remove(27);
                                numbersToChooseFrom.Remove(28);
                                numbersToChooseFrom.Remove(29);

                            }
                        }
                        else if (randomNumber >= 30 && randomNumber <= 39)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Juguetes";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                            Objetos12[i].SetActive(false);
                            Juguetes12++;

                            if (Juguetes12 == 3)
                            {
                                numbersToChooseFrom.Remove(30);
                                numbersToChooseFrom.Remove(31);
                                numbersToChooseFrom.Remove(32);
                                numbersToChooseFrom.Remove(33);
                                numbersToChooseFrom.Remove(34);
                                numbersToChooseFrom.Remove(35);
                                numbersToChooseFrom.Remove(36);
                                numbersToChooseFrom.Remove(37);
                                numbersToChooseFrom.Remove(38);
                                numbersToChooseFrom.Remove(39);

                            }
                        }
                    }
                }
                if (NumeroDeHabitaciones == 4)
                {
                    PuntosNecesarios = 12;
                }else if (NumeroDeHabitaciones == 3)
                {
                    PuntosNecesarios = 9;
                }
            }


            else if (NumeroDeObjetos == 20)
            {
                Imagenes20.SetActive(true);
                for (int i = 0; i < 20; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {
                        
                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        
                        randomNumber = numbersToChooseFrom[randomIndex];

                        
                        Debug.Log("N�mero elegido: " + randomNumber);

                       
                        chosenNumbers.Add(randomNumber);

                       
                        numbersToChooseFrom.RemoveAt(randomIndex);

                        if (randomNumber >= 0 && randomNumber <= 9)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Cocina";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                            Objetos20[i].SetActive(false);
                            Cocina20++;

                            if (Cocina20 == 5)
                            {
                                numbersToChooseFrom.Remove(0);
                                numbersToChooseFrom.Remove(1);
                                numbersToChooseFrom.Remove(2);
                                numbersToChooseFrom.Remove(3);
                                numbersToChooseFrom.Remove(4);
                                numbersToChooseFrom.Remove(5);
                                numbersToChooseFrom.Remove(6);
                                numbersToChooseFrom.Remove(7);
                                numbersToChooseFrom.Remove(8);
                                numbersToChooseFrom.Remove(9);
                            }
                        }
                        else if (randomNumber >= 10 && randomNumber <= 19)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                            Objetos20[i].SetActive(false);
                            Dormitorio20++;

                            if (Dormitorio20 == 5)
                            {
                                numbersToChooseFrom.Remove(10);
                                numbersToChooseFrom.Remove(11);
                                numbersToChooseFrom.Remove(12);
                                numbersToChooseFrom.Remove(13);
                                numbersToChooseFrom.Remove(14);
                                numbersToChooseFrom.Remove(15);
                                numbersToChooseFrom.Remove(16);
                                numbersToChooseFrom.Remove(17);
                                numbersToChooseFrom.Remove(18);
                                numbersToChooseFrom.Remove(19);
                            }
                        }
                        else if (randomNumber >= 20 && randomNumber <= 29)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Ba�o";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                            Objetos20[i].SetActive(false);
                            Ba�o20++;

                            if (Ba�o20 == 5)
                            {
                                numbersToChooseFrom.Remove(20);
                                numbersToChooseFrom.Remove(21);
                                numbersToChooseFrom.Remove(22);
                                numbersToChooseFrom.Remove(23);
                                numbersToChooseFrom.Remove(24);
                                numbersToChooseFrom.Remove(25);
                                numbersToChooseFrom.Remove(26);
                                numbersToChooseFrom.Remove(27);
                                numbersToChooseFrom.Remove(28);
                                numbersToChooseFrom.Remove(29);
                            }
                        }
                        else if (randomNumber >= 30 && randomNumber <= 39)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Juguetes";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                            Objetos20[i].SetActive(false);
                            Juguetes20++;

                            if (Juguetes20 == 5)
                            {
                                numbersToChooseFrom.Remove(30);
                                numbersToChooseFrom.Remove(31);
                                numbersToChooseFrom.Remove(32);
                                numbersToChooseFrom.Remove(33);
                                numbersToChooseFrom.Remove(34);
                                numbersToChooseFrom.Remove(35);
                                numbersToChooseFrom.Remove(36);
                                numbersToChooseFrom.Remove(37);
                                numbersToChooseFrom.Remove(38);
                                numbersToChooseFrom.Remove(39);
                            }
                        }
                    }
                }
                if (NumeroDeHabitaciones == 4)
                {
                    PuntosNecesarios = 20;
                }else if(NumeroDeHabitaciones == 3) {
                    PuntosNecesarios = 15;
                }
            }

            else if (NumeroDeObjetos == 28)
            {
                Imagenes28.SetActive(true);
                for (int i = 0; i < 28; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {
                        
                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                    
                        randomNumber = numbersToChooseFrom[randomIndex];

                     
                        Debug.Log("N�mero elegido: " + randomNumber);

                
                        chosenNumbers.Add(randomNumber);

                     
                        numbersToChooseFrom.RemoveAt(randomIndex);

                        if (randomNumber >= 0 && randomNumber <= 9)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Cocina";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                            Objetos28[i].SetActive(false);
                            Cocina28++;

                            if (Cocina28 == 7)
                            {
                                numbersToChooseFrom.Remove(0);
                                numbersToChooseFrom.Remove(1);
                                numbersToChooseFrom.Remove(2);
                                numbersToChooseFrom.Remove(3);
                                numbersToChooseFrom.Remove(4);
                                numbersToChooseFrom.Remove(5);
                                numbersToChooseFrom.Remove(6);
                                numbersToChooseFrom.Remove(7);
                                numbersToChooseFrom.Remove(8);
                                numbersToChooseFrom.Remove(9);
                            }
                        }
                        else if (randomNumber >= 10 && randomNumber <= 19)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                            Objetos28[i].SetActive(false);
                            Dormitorio28++;

                            if (Dormitorio28 == 7)
                            {
                                numbersToChooseFrom.Remove(10);
                                numbersToChooseFrom.Remove(11);
                                numbersToChooseFrom.Remove(12);
                                numbersToChooseFrom.Remove(13);
                                numbersToChooseFrom.Remove(14);
                                numbersToChooseFrom.Remove(15);
                                numbersToChooseFrom.Remove(16);
                                numbersToChooseFrom.Remove(17);
                                numbersToChooseFrom.Remove(18);
                                numbersToChooseFrom.Remove(19);
                            }
                        }
                        else if (randomNumber >= 20 && randomNumber <= 29)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Ba�o";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                            Objetos28[i].SetActive(false);
                            Ba�o28++;

                            if (Ba�o28 == 7)
                            {
                                numbersToChooseFrom.Remove(20);
                                numbersToChooseFrom.Remove(21);
                                numbersToChooseFrom.Remove(22);
                                numbersToChooseFrom.Remove(23);
                                numbersToChooseFrom.Remove(24);
                                numbersToChooseFrom.Remove(25);
                                numbersToChooseFrom.Remove(26);
                                numbersToChooseFrom.Remove(27);
                                numbersToChooseFrom.Remove(28);
                                numbersToChooseFrom.Remove(29);
                            }
                        }
                        else if (randomNumber >= 30 && randomNumber <= 39)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Juguetes";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                            Objetos28[i].SetActive(false);
                            Juguetes28++;

                            if (Juguetes28 == 7)
                            {
                                numbersToChooseFrom.Remove(30);
                                numbersToChooseFrom.Remove(31);
                                numbersToChooseFrom.Remove(32);
                                numbersToChooseFrom.Remove(33);
                                numbersToChooseFrom.Remove(34);
                                numbersToChooseFrom.Remove(35);
                                numbersToChooseFrom.Remove(36);
                                numbersToChooseFrom.Remove(37);
                                numbersToChooseFrom.Remove(38);
                                numbersToChooseFrom.Remove(39);
                            }
                        }
                    }
                }
                if (NumeroDeHabitaciones == 4)
                {
                    PuntosNecesarios = 28;
                }else if (NumeroDeHabitaciones == 3){
                    PuntosNecesarios = (28/4)*3;
                }
            }

            else if (NumeroDeObjetos == 40)
            {
                Imagenes40.SetActive(true);
                for (int i = 0; i < 40; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {
                       
                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                       
                        randomNumber = numbersToChooseFrom[randomIndex];

                       
                        Debug.Log("N�mero elegido: " + randomNumber);

                       
                        chosenNumbers.Add(randomNumber);

                       
                        numbersToChooseFrom.RemoveAt(randomIndex);


                        Instantiate(ConjuntoObjetos[randomNumber], Objetos40[i].transform.position, Quaternion.identity);
                        Objetos40[i].SetActive(false);

                        if (randomNumber >= 0 && randomNumber <= 9)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Cocina";
                        }
                        else if (randomNumber >= 10 && randomNumber <= 19)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                        }
                        else if (randomNumber >= 20 && randomNumber <= 29)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Ba�o";
                        }
                        else if (randomNumber >= 30 && randomNumber <= 39)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Juguetes";
                        }
                    }
                }
                if (NumeroDeHabitaciones == 4)
                {
                    PuntosNecesarios = 40;
                }else if (NumeroDeHabitaciones == 3){

                    PuntosNecesarios = 30;
                }
            }
            
        }

        BotonJugar.SetActive(false);
        BotonesNumeroObjetos.SetActive(false);
    }
}
/*public void PickRandomNumber()
{

    // UNA HABITACION
    if (NumeroDeHabitaciones == 1)
    {
        BordeAjustes1.SetActive(true);
        Ajustes1Habitacion.SetActive(true);
        Bordes1Habitacion.SetActive(true);
        Habitacion1.SetActive(true);
        SpawnTexto1.SetActive(true);
        if (OpcionCocina == true)
        {
            CocinaTexto.SetActive(true);
            CocinaPadre.SetActive(true);
            CocinaPadre.transform.position = Habitacion1.transform.position;
            CocinaTexto.transform.position = SpawnTexto1.transform.position;
            Habitacion1.SetActive(false);
            SpawnTexto1.SetActive(false);

            if (NumeroDeObjetos == 12)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 6; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 0; i < 6; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos121[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos121[i].SetActive(false);
                }
            }
            else if (NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 10; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 0; i < 10; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos201[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos201[i].SetActive(false);
                }
            }
            else if (NumeroDeObjetos == 28)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 9; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 0; i < 19; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos281[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos281[i].SetActive(false);

                }
            }
            else if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 10; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 0; i < 30; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos401[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos401[i].SetActive(false);
                }
            }
        }
        else if (OpcionBa�o == true)
        {
            Ba�oTexto.SetActive(true);
            Ba�oPadre.SetActive(true);
            Ba�oPadre.transform.position = Habitacion1.transform.position;
            Ba�oTexto.transform.position = SpawnTexto1.transform.position;
            Habitacion1.SetActive(false);
            SpawnTexto1.SetActive(false);
            if (NumeroDeObjetos == 12)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 16; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 0; i < 6; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos121[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos121[i].SetActive(false);
                }
            }
            else if (NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 20; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 0; i < 10; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos201[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos201[i].SetActive(false);
                }
            }
            else if (NumeroDeObjetos == 28)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 19; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 0; i < 19; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos281[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos281[i].SetActive(false);
                }
            }
            else if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 20; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 0; i < 30; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos401[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos401[i].SetActive(false);
                }
            }
        }
        else if (OpcionDormitorio == true)
        {
            DormitorioTexto.SetActive(true);
            DormitorioPadre.SetActive(true);
            DormitorioPadre.transform.position = Habitacion1.transform.position;
            DormitorioTexto.transform.position = SpawnTexto1.transform.position;
            Habitacion1.SetActive(false);
            SpawnTexto1.SetActive(false);
            if (NumeroDeObjetos == 12)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 20; i < 26; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 6; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos121[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos121[i].SetActive(false);
                }
            }
            else if (NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 20; i < 30; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 10; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos201[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos201[i].SetActive(false);

                }
            }
            else if (NumeroDeObjetos == 28)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 20; i < 29; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 19; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos281[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos281[i].SetActive(false);
                }
            }
            else if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 20; i < 30; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 30; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos401[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos401[i].SetActive(false);
                }
            }
        }
        else if (OpcionJuguetes == true)
        {
            JuguetesTexto.SetActive(true);
            JuguetesPadre.SetActive(true);
            JuguetesPadre.transform.position = Habitacion1.transform.position;
            JuguetesTexto.transform.position = SpawnTexto1.transform.position;
            Habitacion1.SetActive(false);
            SpawnTexto1.SetActive(false);
            if (NumeroDeObjetos == 12)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 30; i < 36; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 6; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos121[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos121[i].SetActive(false);
                }
            }
            else if (NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 30; i < 40; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 10; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos201[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos201[i].SetActive(false);
                }
            }
            else if (NumeroDeObjetos == 28)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 30; i < 39; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 19; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos281[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos281[i].SetActive(false);
                }
            }
            else if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 30; i < 40; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 30; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos401[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos401[i].SetActive(false);
                }
            }
        }
    }

    // DOS HABITACIONES
    if (NumeroDeHabitaciones == 2)
    {
        Ajustes.SetActive(true);
        Bordes2Habitaciones.SetActive(true);
        Habitacion2[0].SetActive(true);
        Habitacion2[1].SetActive(true);
        SpawnTexto21.SetActive(true);
        SpawnTexto22.SetActive(true);
        ListaAuxiliar[0].gameObject.SetActive(true);
        ListaAuxiliar[1].gameObject.SetActive(true);
        ListaAuxiliar[0].transform.position = Habitacion2[0].transform.position;
        ListaAuxiliar[1].transform.position = Habitacion2[1].transform.position;
        ListaAuxiliarTexto[0].gameObject.SetActive(true);
        ListaAuxiliarTexto[1].gameObject.SetActive(true);
        ListaAuxiliarTexto[0].transform.position = SpawnTexto21.transform.position;
        ListaAuxiliarTexto[1].transform.position = SpawnTexto22.transform.position;
        Habitacion2[0].SetActive(false);
        Habitacion2[1].SetActive(false);
        SpawnTexto21.SetActive(false);
        SpawnTexto22.SetActive(false);

        if (OpcionCocina && OpcionBa�o)
        {
            if (NumeroDeObjetos == 12)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 4; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 10; i < 14; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 0; i < 4; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos12[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos12[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 7; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 10; i < 17; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 0; i < 6; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos20[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos20[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 28)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 9; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 10; i < 19; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 0; i < 10; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos28[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos28[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 10; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 10; i < 20; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 0; i < 20; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos40[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos40[i].SetActive(false);
                }
            }
        }
        else if (OpcionCocina && OpcionDormitorio)
        {
            if (NumeroDeObjetos == 12)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 4; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 20; i < 24; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 4; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos20[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos20[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 7; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 20; i < 27; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 6; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos20[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos20[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 28)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 9; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 20; i < 29; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 10; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos28[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos28[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 10; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 20; i < 30; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 20; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos40[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos40[i].SetActive(false);
                }
            }
        }
        else if (OpcionCocina && OpcionJuguetes)
        {
            if (NumeroDeObjetos == 12)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 4; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 30; i < 34; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 4; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos12[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos12[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 7; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 30; i < 37; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 6; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos20[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos20[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 28)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 9; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 30; i < 39; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 10; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos28[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos28[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 0; i < 10; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(0);
                numbersToChooseFrom.Remove(1);
                numbersToChooseFrom.Remove(2);
                numbersToChooseFrom.Remove(3);
                numbersToChooseFrom.Remove(4);
                numbersToChooseFrom.Remove(5);
                numbersToChooseFrom.Remove(6);
                numbersToChooseFrom.Remove(7);
                numbersToChooseFrom.Remove(8);
                numbersToChooseFrom.Remove(9);

                for (int i = 30; i < 40; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 20; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos40[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos40[i].SetActive(false);
                }
            }
        }
        else if (OpcionBa�o && OpcionDormitorio)
        {
            if (NumeroDeObjetos == 12)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 14; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 20; i < 24; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 4; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos12[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos12[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 17; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 20; i < 27; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 6; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos20[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos20[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 28)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 19; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 20; i < 29; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 10; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos28[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos28[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 20; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 20; i < 30; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 0; i < 20; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos40[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos40[i].SetActive(false);
                }
            }
        }
        else if (OpcionBa�o && OpcionJuguetes)
        {
            if (NumeroDeObjetos == 12)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 14; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 30; i < 34; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 4; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos12[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos12[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 17; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 30; i < 37; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 6; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos20[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos20[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 28)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 19; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 30; i < 39; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 10; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos28[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos28[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 10; i < 20; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(10);
                numbersToChooseFrom.Remove(11);
                numbersToChooseFrom.Remove(12);
                numbersToChooseFrom.Remove(13);
                numbersToChooseFrom.Remove(14);
                numbersToChooseFrom.Remove(15);
                numbersToChooseFrom.Remove(16);
                numbersToChooseFrom.Remove(17);
                numbersToChooseFrom.Remove(18);
                numbersToChooseFrom.Remove(19);

                for (int i = 30; i < 40; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 20; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos40[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos40[i].SetActive(false);
                }
            }
        }
        else if (OpcionDormitorio && OpcionJuguetes)
        {
            if (NumeroDeObjetos == 12)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 20; i < 24; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 30; i < 34; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 4; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos12[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos12[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 20)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 20; i < 27; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 30; i < 37; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 6; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos20[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos20[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 28)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 20; i < 29; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 30; i < 39; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 10; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos28[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos28[i].SetActive(false);
                }
            }
            if (NumeroDeObjetos == 40)
            {
                List<GameObject> lista = new List<GameObject>();
                for (int i = 20; i < 30; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(20);
                numbersToChooseFrom.Remove(21);
                numbersToChooseFrom.Remove(22);
                numbersToChooseFrom.Remove(23);
                numbersToChooseFrom.Remove(24);
                numbersToChooseFrom.Remove(25);
                numbersToChooseFrom.Remove(26);
                numbersToChooseFrom.Remove(27);
                numbersToChooseFrom.Remove(28);
                numbersToChooseFrom.Remove(29);

                for (int i = 30; i < 40; i++)
                {
                    lista.Add(ConjuntoObjetos[i]);
                }

                numbersToChooseFrom.Remove(30);
                numbersToChooseFrom.Remove(31);
                numbersToChooseFrom.Remove(32);
                numbersToChooseFrom.Remove(33);
                numbersToChooseFrom.Remove(34);
                numbersToChooseFrom.Remove(35);
                numbersToChooseFrom.Remove(36);
                numbersToChooseFrom.Remove(37);
                numbersToChooseFrom.Remove(38);
                numbersToChooseFrom.Remove(39);

                for (int i = 0; i < 20; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        randomNumber = numbersToChooseFrom[randomIndex];

                        Debug.Log("N�mero elegido: " + randomNumber);

                        chosenNumbers.Add(randomNumber);

                        numbersToChooseFrom.RemoveAt(randomIndex);

                        lista.Add(ConjuntoObjetos[randomNumber]);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    int Numero = Random.Range(0, lista.Count);
                    Instantiate(lista[Numero], Objetos40[i].transform.position, Quaternion.identity);
                    lista.RemoveAt(Numero);
                    Objetos40[i].SetActive(false);
                }
            }
        }

    }
    // TRES HABITACIONES
    if (NumeroDeHabitaciones >= 3)
    {
        Ajustes.SetActive(true);
        Bordes34Habitaciones.SetActive(true);
        if (NumeroDeHabitaciones == 3)
        {
            Habitaciones34[0].SetActive(true);
            Habitaciones34[1].SetActive(true);
            Habitaciones34[2].SetActive(true);
            Habitaciones34[3].SetActive(true);

            if (OpcionCocina == false)
            {
                Ba�oPadre.SetActive(true);
                DormitorioPadre.SetActive(true);
                JuguetesPadre.SetActive(true);
                Ba�oPadre.transform.position = Habitaciones34[0].transform.position;
                JuguetesPadre.transform.position = Habitaciones34[2].transform.position;
                DormitorioPadre.transform.position = Habitaciones34[3].transform.position;
                Habitaciones34[0].SetActive(false);
                Habitaciones34[1].SetActive(false);
                Habitaciones34[2].SetActive(false);
                Habitaciones34[3].SetActive(false);



            }
            else if (OpcionBa�o == false)
            {
                CocinaPadre.SetActive(true);
                DormitorioPadre.SetActive(true);
                JuguetesPadre.SetActive(true);
                CocinaPadre.transform.position = Habitaciones34[1].transform.position;
                JuguetesPadre.transform.position = Habitaciones34[2].transform.position;
                DormitorioPadre.transform.position = Habitaciones34[3].transform.position;
                Habitaciones34[0].SetActive(false);
                Habitaciones34[1].SetActive(false);
                Habitaciones34[2].SetActive(false);
                Habitaciones34[3].SetActive(false);


            }
            else if (OpcionDormitorio == false)
            {
                Ba�oPadre.SetActive(true);
                CocinaPadre.SetActive(true);
                JuguetesPadre.SetActive(true);
                Ba�oPadre.transform.position = Habitaciones34[0].transform.position;
                CocinaPadre.transform.position = Habitaciones34[1].transform.position;
                JuguetesPadre.transform.position = Habitaciones34[2].transform.position;
                Habitaciones34[0].SetActive(false);
                Habitaciones34[1].SetActive(false);
                Habitaciones34[2].SetActive(false);
                Habitaciones34[3].SetActive(false);


            }
            else if (OpcionJuguetes == false)
            {
                Ba�oPadre.SetActive(true);
                CocinaPadre.SetActive(true);
                DormitorioPadre.SetActive(true);
                Ba�oPadre.transform.position = Habitaciones34[0].transform.position;
                CocinaPadre.transform.position = Habitaciones34[1].transform.position;
                DormitorioPadre.transform.position = Habitaciones34[3].transform.position;
                Habitaciones34[0].SetActive(false);
                Habitaciones34[1].SetActive(false);
                Habitaciones34[2].SetActive(false);
                Habitaciones34[3].SetActive(false);


            }



        }

        if (NumeroDeHabitaciones == 4)
        {
            Bordes34Habitaciones.SetActive(true);
            DormitorioPadre.SetActive(true);
            CocinaPadre.SetActive(true);
            Ba�oPadre.SetActive(true);
            JuguetesPadre.SetActive(true);
            CocinaPadre.transform.position = Habitaciones34[1].transform.position;
            Ba�oPadre.transform.position = Habitaciones34[0].transform.position;
            JuguetesPadre.transform.position = Habitaciones34[2].transform.position;
            DormitorioPadre.transform.position = Habitaciones34[3].transform.position;
            Habitaciones34[0].SetActive(false);
            Habitaciones34[1].SetActive(false);
            Habitaciones34[2].SetActive(false);
            Habitaciones34[3].SetActive(false);

        }
        if (NumeroDeObjetos == 12)
        {
            Imagenes12.SetActive(true);
            for (int i = 0; i < 12; i++)
            {
                if (numbersToChooseFrom.Count > 0)
                {
                    // Genera un �ndice aleatorio dentro del rango de la lista de n�meros posibles
                    int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                    // Obtiene el n�mero correspondiente al �ndice aleatorio
                    randomNumber = numbersToChooseFrom[randomIndex];

                    // Procesa el n�mero elegido (en este caso, solo lo imprime)
                    Debug.Log("N�mero elegido: " + randomNumber);

                    // Agrega el n�mero a la lista de n�meros elegidos
                    chosenNumbers.Add(randomNumber);

                    // Remueve el n�mero elegido de la lista de n�meros posibles
                    numbersToChooseFrom.RemoveAt(randomIndex);

                    if (randomNumber >= 0 && randomNumber <= 9)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Cocina";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                        Objetos12[i].SetActive(false);
                        Cocina12++;

                        if (Cocina12 == 3)
                        {
                            numbersToChooseFrom.Remove(0);
                            numbersToChooseFrom.Remove(1);
                            numbersToChooseFrom.Remove(2);
                            numbersToChooseFrom.Remove(3);
                            numbersToChooseFrom.Remove(4);
                            numbersToChooseFrom.Remove(5);
                            numbersToChooseFrom.Remove(6);
                            numbersToChooseFrom.Remove(7);
                            numbersToChooseFrom.Remove(8);
                            numbersToChooseFrom.Remove(9);

                        }
                    }
                    else if (randomNumber >= 10 && randomNumber <= 19)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                        Objetos12[i].SetActive(false);
                        Dormitorio12++;

                        if (Dormitorio12 == 3)
                        {
                            numbersToChooseFrom.Remove(10);
                            numbersToChooseFrom.Remove(11);
                            numbersToChooseFrom.Remove(12);
                            numbersToChooseFrom.Remove(13);
                            numbersToChooseFrom.Remove(14);
                            numbersToChooseFrom.Remove(15);
                            numbersToChooseFrom.Remove(16);
                            numbersToChooseFrom.Remove(17);
                            numbersToChooseFrom.Remove(18);
                            numbersToChooseFrom.Remove(19);

                        }
                    }
                    else if (randomNumber >= 20 && randomNumber <= 29)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Ba�o";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                        Objetos12[i].SetActive(false);
                        Ba�o12++;

                        if (Ba�o12 == 3)
                        {
                            numbersToChooseFrom.Remove(20);
                            numbersToChooseFrom.Remove(21);
                            numbersToChooseFrom.Remove(22);
                            numbersToChooseFrom.Remove(23);
                            numbersToChooseFrom.Remove(24);
                            numbersToChooseFrom.Remove(25);
                            numbersToChooseFrom.Remove(26);
                            numbersToChooseFrom.Remove(27);
                            numbersToChooseFrom.Remove(28);
                            numbersToChooseFrom.Remove(29);

                        }
                    }
                    else if (randomNumber >= 30 && randomNumber <= 39)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Juguetes";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                        Objetos12[i].SetActive(false);
                        Juguetes12++;

                        if (Juguetes12 == 3)
                        {
                            numbersToChooseFrom.Remove(30);
                            numbersToChooseFrom.Remove(31);
                            numbersToChooseFrom.Remove(32);
                            numbersToChooseFrom.Remove(33);
                            numbersToChooseFrom.Remove(34);
                            numbersToChooseFrom.Remove(35);
                            numbersToChooseFrom.Remove(36);
                            numbersToChooseFrom.Remove(37);
                            numbersToChooseFrom.Remove(38);
                            numbersToChooseFrom.Remove(39);

                        }
                    }
                }
            }
        }


        else if (NumeroDeObjetos == 20)
        {
            Imagenes20.SetActive(true);
            for (int i = 0; i < 20; i++)
            {
                if (numbersToChooseFrom.Count > 0)
                {
                    // Genera un �ndice aleatorio dentro del rango de la lista de n�meros posibles
                    int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                    // Obtiene el n�mero correspondiente al �ndice aleatorio
                    randomNumber = numbersToChooseFrom[randomIndex];

                    // Procesa el n�mero elegido (en este caso, solo lo imprime)
                    Debug.Log("N�mero elegido: " + randomNumber);

                    // Agrega el n�mero a la lista de n�meros elegidos
                    chosenNumbers.Add(randomNumber);

                    // Remueve el n�mero elegido de la lista de n�meros posibles
                    numbersToChooseFrom.RemoveAt(randomIndex);

                    if (randomNumber >= 0 && randomNumber <= 9)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Cocina";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                        Objetos20[i].SetActive(false);
                        Cocina20++;

                        if (Cocina20 == 5)
                        {
                            numbersToChooseFrom.Remove(0);
                            numbersToChooseFrom.Remove(1);
                            numbersToChooseFrom.Remove(2);
                            numbersToChooseFrom.Remove(3);
                            numbersToChooseFrom.Remove(4);
                            numbersToChooseFrom.Remove(5);
                            numbersToChooseFrom.Remove(6);
                            numbersToChooseFrom.Remove(7);
                            numbersToChooseFrom.Remove(8);
                            numbersToChooseFrom.Remove(9);
                        }
                    }
                    else if (randomNumber >= 10 && randomNumber <= 19)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                        Objetos20[i].SetActive(false);
                        Dormitorio20++;

                        if (Dormitorio20 == 5)
                        {
                            numbersToChooseFrom.Remove(10);
                            numbersToChooseFrom.Remove(11);
                            numbersToChooseFrom.Remove(12);
                            numbersToChooseFrom.Remove(13);
                            numbersToChooseFrom.Remove(14);
                            numbersToChooseFrom.Remove(15);
                            numbersToChooseFrom.Remove(16);
                            numbersToChooseFrom.Remove(17);
                            numbersToChooseFrom.Remove(18);
                            numbersToChooseFrom.Remove(19);
                        }
                    }
                    else if (randomNumber >= 20 && randomNumber <= 29)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Ba�o";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                        Objetos20[i].SetActive(false);
                        Ba�o20++;

                        if (Ba�o20 == 5)
                        {
                            numbersToChooseFrom.Remove(20);
                            numbersToChooseFrom.Remove(21);
                            numbersToChooseFrom.Remove(22);
                            numbersToChooseFrom.Remove(23);
                            numbersToChooseFrom.Remove(24);
                            numbersToChooseFrom.Remove(25);
                            numbersToChooseFrom.Remove(26);
                            numbersToChooseFrom.Remove(27);
                            numbersToChooseFrom.Remove(28);
                            numbersToChooseFrom.Remove(29);
                        }
                    }
                    else if (randomNumber >= 30 && randomNumber <= 39)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Juguetes";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                        Objetos20[i].SetActive(false);
                        Juguetes20++;

                        if (Juguetes20 == 5)
                        {
                            numbersToChooseFrom.Remove(30);
                            numbersToChooseFrom.Remove(31);
                            numbersToChooseFrom.Remove(32);
                            numbersToChooseFrom.Remove(33);
                            numbersToChooseFrom.Remove(34);
                            numbersToChooseFrom.Remove(35);
                            numbersToChooseFrom.Remove(36);
                            numbersToChooseFrom.Remove(37);
                            numbersToChooseFrom.Remove(38);
                            numbersToChooseFrom.Remove(39);
                        }
                    }
                }
            }
        }

        else if (NumeroDeObjetos == 28)
        {
            Imagenes28.SetActive(true);
            for (int i = 0; i < 28; i++)
            {
                if (numbersToChooseFrom.Count > 0)
                {
                    // Genera un �ndice aleatorio dentro del rango de la lista de n�meros posibles
                    int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                    // Obtiene el n�mero correspondiente al �ndice aleatorio
                    randomNumber = numbersToChooseFrom[randomIndex];

                    // Procesa el n�mero elegido (en este caso, solo lo imprime)
                    Debug.Log("N�mero elegido: " + randomNumber);

                    // Agrega el n�mero a la lista de n�meros elegidos
                    chosenNumbers.Add(randomNumber);

                    // Remueve el n�mero elegido de la lista de n�meros posibles
                    numbersToChooseFrom.RemoveAt(randomIndex);

                    if (randomNumber >= 0 && randomNumber <= 9)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Cocina";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                        Objetos28[i].SetActive(false);
                        Cocina28++;

                        if (Cocina28 == 7)
                        {
                            numbersToChooseFrom.Remove(0);
                            numbersToChooseFrom.Remove(1);
                            numbersToChooseFrom.Remove(2);
                            numbersToChooseFrom.Remove(3);
                            numbersToChooseFrom.Remove(4);
                            numbersToChooseFrom.Remove(5);
                            numbersToChooseFrom.Remove(6);
                            numbersToChooseFrom.Remove(7);
                            numbersToChooseFrom.Remove(8);
                            numbersToChooseFrom.Remove(9);
                        }
                    }
                    else if (randomNumber >= 10 && randomNumber <= 19)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                        Objetos28[i].SetActive(false);
                        Dormitorio28++;

                        if (Dormitorio28 == 7)
                        {
                            numbersToChooseFrom.Remove(10);
                            numbersToChooseFrom.Remove(11);
                            numbersToChooseFrom.Remove(12);
                            numbersToChooseFrom.Remove(13);
                            numbersToChooseFrom.Remove(14);
                            numbersToChooseFrom.Remove(15);
                            numbersToChooseFrom.Remove(16);
                            numbersToChooseFrom.Remove(17);
                            numbersToChooseFrom.Remove(18);
                            numbersToChooseFrom.Remove(19);
                        }
                    }
                    else if (randomNumber >= 20 && randomNumber <= 29)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Ba�o";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                        Objetos28[i].SetActive(false);
                        Ba�o28++;

                        if (Ba�o28 == 7)
                        {
                            numbersToChooseFrom.Remove(20);
                            numbersToChooseFrom.Remove(21);
                            numbersToChooseFrom.Remove(22);
                            numbersToChooseFrom.Remove(23);
                            numbersToChooseFrom.Remove(24);
                            numbersToChooseFrom.Remove(25);
                            numbersToChooseFrom.Remove(26);
                            numbersToChooseFrom.Remove(27);
                            numbersToChooseFrom.Remove(28);
                            numbersToChooseFrom.Remove(29);
                        }
                    }
                    else if (randomNumber >= 30 && randomNumber <= 39)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Juguetes";
                        Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                        Objetos28[i].SetActive(false);
                        Juguetes28++;

                        if (Juguetes28 == 7)
                        {
                            numbersToChooseFrom.Remove(30);
                            numbersToChooseFrom.Remove(31);
                            numbersToChooseFrom.Remove(32);
                            numbersToChooseFrom.Remove(33);
                            numbersToChooseFrom.Remove(34);
                            numbersToChooseFrom.Remove(35);
                            numbersToChooseFrom.Remove(36);
                            numbersToChooseFrom.Remove(37);
                            numbersToChooseFrom.Remove(38);
                            numbersToChooseFrom.Remove(39);
                        }
                    }
                }
            }
        }

        else if (NumeroDeObjetos == 40)
        {
            Imagenes40.SetActive(true);
            for (int i = 0; i < 40; i++)
            {
                if (numbersToChooseFrom.Count > 0)
                {
                    // Genera un �ndice aleatorio dentro del rango de la lista de n�meros posibles
                    int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                    // Obtiene el n�mero correspondiente al �ndice aleatorio
                    randomNumber = numbersToChooseFrom[randomIndex];

                    // Procesa el n�mero elegido (en este caso, solo lo imprime)
                    Debug.Log("N�mero elegido: " + randomNumber);

                    // Agrega el n�mero a la lista de n�meros elegidos
                    chosenNumbers.Add(randomNumber);

                    // Remueve el n�mero elegido de la lista de n�meros posibles
                    numbersToChooseFrom.RemoveAt(randomIndex);


                    Instantiate(ConjuntoObjetos[randomNumber], Objetos40[i].transform.position, Quaternion.identity);
                    Objetos40[i].SetActive(false);

                    if (randomNumber >= 0 && randomNumber <= 9)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Cocina";
                    }
                    else if (randomNumber >= 10 && randomNumber <= 19)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                    }
                    else if (randomNumber >= 20 && randomNumber <= 29)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Ba�o";
                    }
                    else if (randomNumber >= 30 && randomNumber <= 39)
                    {
                        ConjuntoObjetos[randomNumber].tag = "Juguetes";
                    }
                }
            }
        }
    }

    BotonJugar.SetActive(false);
    BotonesNumeroObjetos.SetActive(false);
}*/
/*if (NumeroDeObjetos == 12)
            {
                Imagenes12.SetActive(true);
                for (int i = 0; i < 12; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {
                        // Genera un �ndice aleatorio dentro del rango de la lista de n�meros posibles
                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        // Obtiene el n�mero correspondiente al �ndice aleatorio
                        randomNumber = numbersToChooseFrom[randomIndex];

                        // Procesa el n�mero elegido (en este caso, solo lo imprime)
                        Debug.Log("N�mero elegido: " + randomNumber);

                        // Agrega el n�mero a la lista de n�meros elegidos
                        chosenNumbers.Add(randomNumber);

                        // Remueve el n�mero elegido de la lista de n�meros posibles
                        numbersToChooseFrom.RemoveAt(randomIndex);

                        if (randomNumber >= 0 && randomNumber <= 9)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Cocina";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                            Objetos12[i].SetActive(false);
                            Cocina12++;

                            if (Cocina12 == 3)
                            {
                                numbersToChooseFrom.Remove(0);
                                numbersToChooseFrom.Remove(1);
                                numbersToChooseFrom.Remove(2);
                                numbersToChooseFrom.Remove(3);
                                numbersToChooseFrom.Remove(4);
                                numbersToChooseFrom.Remove(5);
                                numbersToChooseFrom.Remove(6);
                                numbersToChooseFrom.Remove(7);
                                numbersToChooseFrom.Remove(8);
                                numbersToChooseFrom.Remove(9);

                            }
                        }
                        else if (randomNumber >= 10 && randomNumber <= 19)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                            Objetos12[i].SetActive(false);
                            Dormitorio12++;

                            if (Dormitorio12 == 3)
                            {
                                numbersToChooseFrom.Remove(10);
                                numbersToChooseFrom.Remove(11);
                                numbersToChooseFrom.Remove(12);
                                numbersToChooseFrom.Remove(13);
                                numbersToChooseFrom.Remove(14);
                                numbersToChooseFrom.Remove(15);
                                numbersToChooseFrom.Remove(16);
                                numbersToChooseFrom.Remove(17);
                                numbersToChooseFrom.Remove(18);
                                numbersToChooseFrom.Remove(19);

                            }
                        }
                        else if (randomNumber >= 20 && randomNumber <= 29)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Ba�o";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                            Objetos12[i].SetActive(false);
                            Ba�o12++;

                            if (Ba�o12 == 3)
                            {
                                numbersToChooseFrom.Remove(20);
                                numbersToChooseFrom.Remove(21);
                                numbersToChooseFrom.Remove(22);
                                numbersToChooseFrom.Remove(23);
                                numbersToChooseFrom.Remove(24);
                                numbersToChooseFrom.Remove(25);
                                numbersToChooseFrom.Remove(26);
                                numbersToChooseFrom.Remove(27);
                                numbersToChooseFrom.Remove(28);
                                numbersToChooseFrom.Remove(29);

                            }
                        }
                        else if (randomNumber >= 30 && randomNumber <= 39)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Juguetes";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos12[i].transform.position, Quaternion.identity);
                            Objetos12[i].SetActive(false);
                            Juguetes12++;

                            if (Juguetes12 == 3)
                            {
                                numbersToChooseFrom.Remove(30);
                                numbersToChooseFrom.Remove(31);
                                numbersToChooseFrom.Remove(32);
                                numbersToChooseFrom.Remove(33);
                                numbersToChooseFrom.Remove(34);
                                numbersToChooseFrom.Remove(35);
                                numbersToChooseFrom.Remove(36);
                                numbersToChooseFrom.Remove(37);
                                numbersToChooseFrom.Remove(38);
                                numbersToChooseFrom.Remove(39);

                            }
                        }
                    }
                }
            }


            else if (NumeroDeObjetos == 20)
            {
                Imagenes20.SetActive(true);
                for (int i = 0; i < 20; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {
                        // Genera un �ndice aleatorio dentro del rango de la lista de n�meros posibles
                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        // Obtiene el n�mero correspondiente al �ndice aleatorio
                        randomNumber = numbersToChooseFrom[randomIndex];

                        // Procesa el n�mero elegido (en este caso, solo lo imprime)
                        Debug.Log("N�mero elegido: " + randomNumber);

                        // Agrega el n�mero a la lista de n�meros elegidos
                        chosenNumbers.Add(randomNumber);

                        // Remueve el n�mero elegido de la lista de n�meros posibles
                        numbersToChooseFrom.RemoveAt(randomIndex);

                        if (randomNumber >= 0 && randomNumber <= 9)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Cocina";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                            Objetos20[i].SetActive(false);
                            Cocina20++;

                            if (Cocina20 == 5)
                            {
                                numbersToChooseFrom.Remove(0);
                                numbersToChooseFrom.Remove(1);
                                numbersToChooseFrom.Remove(2);
                                numbersToChooseFrom.Remove(3);
                                numbersToChooseFrom.Remove(4);
                                numbersToChooseFrom.Remove(5);
                                numbersToChooseFrom.Remove(6);
                                numbersToChooseFrom.Remove(7);
                                numbersToChooseFrom.Remove(8);
                                numbersToChooseFrom.Remove(9);
                            }
                        }
                        else if (randomNumber >= 10 && randomNumber <= 19)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                            Objetos20[i].SetActive(false);
                            Dormitorio20++;

                            if (Dormitorio20 == 5)
                            {
                                numbersToChooseFrom.Remove(10);
                                numbersToChooseFrom.Remove(11);
                                numbersToChooseFrom.Remove(12);
                                numbersToChooseFrom.Remove(13);
                                numbersToChooseFrom.Remove(14);
                                numbersToChooseFrom.Remove(15);
                                numbersToChooseFrom.Remove(16);
                                numbersToChooseFrom.Remove(17);
                                numbersToChooseFrom.Remove(18);
                                numbersToChooseFrom.Remove(19);
                            }
                        }
                        else if (randomNumber >= 20 && randomNumber <= 29)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Ba�o";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                            Objetos20[i].SetActive(false);
                            Ba�o20++;

                            if (Ba�o20 == 5)
                            {
                                numbersToChooseFrom.Remove(20);
                                numbersToChooseFrom.Remove(21);
                                numbersToChooseFrom.Remove(22);
                                numbersToChooseFrom.Remove(23);
                                numbersToChooseFrom.Remove(24);
                                numbersToChooseFrom.Remove(25);
                                numbersToChooseFrom.Remove(26);
                                numbersToChooseFrom.Remove(27);
                                numbersToChooseFrom.Remove(28);
                                numbersToChooseFrom.Remove(29);
                            }
                        }
                        else if (randomNumber >= 30 && randomNumber <= 39)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Juguetes";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos20[i].transform.position, Quaternion.identity);
                            Objetos20[i].SetActive(false);
                            Juguetes20++;

                            if (Juguetes20 == 5)
                            {
                                numbersToChooseFrom.Remove(30);
                                numbersToChooseFrom.Remove(31);
                                numbersToChooseFrom.Remove(32);
                                numbersToChooseFrom.Remove(33);
                                numbersToChooseFrom.Remove(34);
                                numbersToChooseFrom.Remove(35);
                                numbersToChooseFrom.Remove(36);
                                numbersToChooseFrom.Remove(37);
                                numbersToChooseFrom.Remove(38);
                                numbersToChooseFrom.Remove(39);
                            }
                        }
                    }
                }
            }

            else if (NumeroDeObjetos == 28)
            {
                Imagenes28.SetActive(true);
                for (int i = 0; i < 28; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {
                        // Genera un �ndice aleatorio dentro del rango de la lista de n�meros posibles
                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        // Obtiene el n�mero correspondiente al �ndice aleatorio
                        randomNumber = numbersToChooseFrom[randomIndex];

                        // Procesa el n�mero elegido (en este caso, solo lo imprime)
                        Debug.Log("N�mero elegido: " + randomNumber);

                        // Agrega el n�mero a la lista de n�meros elegidos
                        chosenNumbers.Add(randomNumber);

                        // Remueve el n�mero elegido de la lista de n�meros posibles
                        numbersToChooseFrom.RemoveAt(randomIndex);

                        if (randomNumber >= 0 && randomNumber <= 9)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Cocina";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                            Objetos28[i].SetActive(false);
                            Cocina28++;

                            if (Cocina28 == 7)
                            {
                                numbersToChooseFrom.Remove(0);
                                numbersToChooseFrom.Remove(1);
                                numbersToChooseFrom.Remove(2);
                                numbersToChooseFrom.Remove(3);
                                numbersToChooseFrom.Remove(4);
                                numbersToChooseFrom.Remove(5);
                                numbersToChooseFrom.Remove(6);
                                numbersToChooseFrom.Remove(7);
                                numbersToChooseFrom.Remove(8);
                                numbersToChooseFrom.Remove(9);
                            }
                        }
                        else if (randomNumber >= 10 && randomNumber <= 19)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                            Objetos28[i].SetActive(false);
                            Dormitorio28++;

                            if (Dormitorio28 == 7)
                            {
                                numbersToChooseFrom.Remove(10);
                                numbersToChooseFrom.Remove(11);
                                numbersToChooseFrom.Remove(12);
                                numbersToChooseFrom.Remove(13);
                                numbersToChooseFrom.Remove(14);
                                numbersToChooseFrom.Remove(15);
                                numbersToChooseFrom.Remove(16);
                                numbersToChooseFrom.Remove(17);
                                numbersToChooseFrom.Remove(18);
                                numbersToChooseFrom.Remove(19);
                            }
                        }
                        else if (randomNumber >= 20 && randomNumber <= 29)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Ba�o";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                            Objetos28[i].SetActive(false);
                            Ba�o28++;

                            if (Ba�o28 == 7)
                            {
                                numbersToChooseFrom.Remove(20);
                                numbersToChooseFrom.Remove(21);
                                numbersToChooseFrom.Remove(22);
                                numbersToChooseFrom.Remove(23);
                                numbersToChooseFrom.Remove(24);
                                numbersToChooseFrom.Remove(25);
                                numbersToChooseFrom.Remove(26);
                                numbersToChooseFrom.Remove(27);
                                numbersToChooseFrom.Remove(28);
                                numbersToChooseFrom.Remove(29);
                            }
                        }
                        else if (randomNumber >= 30 && randomNumber <= 39)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Juguetes";
                            Instantiate(ConjuntoObjetos[randomNumber], Objetos28[i].transform.position, Quaternion.identity);
                            Objetos28[i].SetActive(false);
                            Juguetes28++;

                            if (Juguetes28 == 7)
                            {
                                numbersToChooseFrom.Remove(30);
                                numbersToChooseFrom.Remove(31);
                                numbersToChooseFrom.Remove(32);
                                numbersToChooseFrom.Remove(33);
                                numbersToChooseFrom.Remove(34);
                                numbersToChooseFrom.Remove(35);
                                numbersToChooseFrom.Remove(36);
                                numbersToChooseFrom.Remove(37);
                                numbersToChooseFrom.Remove(38);
                                numbersToChooseFrom.Remove(39);
                            }
                        }
                    }
                }
            }

            else if (NumeroDeObjetos == 40)
            {
                Imagenes40.SetActive(true);
                for (int i = 0; i < 40; i++)
                {
                    if (numbersToChooseFrom.Count > 0)
                    {
                        // Genera un �ndice aleatorio dentro del rango de la lista de n�meros posibles
                        int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

                        // Obtiene el n�mero correspondiente al �ndice aleatorio
                        randomNumber = numbersToChooseFrom[randomIndex];

                        // Procesa el n�mero elegido (en este caso, solo lo imprime)
                        Debug.Log("N�mero elegido: " + randomNumber);

                        // Agrega el n�mero a la lista de n�meros elegidos
                        chosenNumbers.Add(randomNumber);

                        // Remueve el n�mero elegido de la lista de n�meros posibles
                        numbersToChooseFrom.RemoveAt(randomIndex);


                        Instantiate(ConjuntoObjetos[randomNumber], Objetos40[i].transform.position, Quaternion.identity);
                        Objetos40[i].SetActive(false);

                        if (randomNumber >= 0 && randomNumber <= 9)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Cocina";
                        }
                        else if (randomNumber >= 10 && randomNumber <= 19)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Dormitorio";
                        }
                        else if (randomNumber >= 20 && randomNumber <= 29)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Ba�o";
                        }
                        else if (randomNumber >= 30 && randomNumber <= 39)
                        {
                            ConjuntoObjetos[randomNumber].tag = "Juguetes";
                        }
                    }
                }
            }
        }
        
        BotonJugar.SetActive(false);
        BotonesNumeroObjetos.SetActive(false);

*/
