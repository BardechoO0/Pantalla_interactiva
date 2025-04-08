using System.Collections.Generic;
using UnityEngine;

public class GeneradorActividades : MonoBehaviour
{
    [SerializeField] public GameObject[] ConjuntoActividades = new GameObject[30];
    public List<int> numbersToChooseFrom = new List<int>(); // Lista de números posibles
    private List<int> chosenNumbers = new List<int>(); // Lista de números ya elegidos
    [SerializeField] public int randomNumber;
    public static GeneradorActividades Referencia;
    [SerializeField] public GameObject ActividadSolicitada;
    [SerializeField] public GameObject[] DestinosGenerados;
    [SerializeField] public GameObject[] AccionesPosibles = new GameObject[120];
    [SerializeField] public GameObject[] AccionesPosiblesTP = new GameObject[120];
    [SerializeField] public GameObject Ex51;
    [SerializeField] public GameObject Ex52;
    [SerializeField] public GameObject Ex53;
    [SerializeField] public GameObject Ex54;
    [SerializeField] public bool CheckerSpawnAcciones;
    [SerializeField] public GameObject[] AccionesGeneradas = new GameObject[8];
    [SerializeField] public GameObject[] AccionesFinales = new GameObject[8];
    [SerializeField] public Vector2[] ArrayPosSpawn = new Vector2[8];
    [SerializeField] public int ForAuxiliar;
    [SerializeField] public bool CocinaChecker;
    [SerializeField] public bool SalonChecker;
    [SerializeField] public bool BañoChecker;
    [SerializeField] public bool VestidorChecker;
    [SerializeField] public bool TallerChecker;
    [SerializeField] public string[] TagsSpawnAcciones = new string[6];

    [SerializeField] public GameObject FondoPause;
    [SerializeField] public GameObject VolverAlMenu;
    [SerializeField] public GameObject ContinuarJugando;
    [SerializeField] public GameObject Reiniciar;

    [SerializeField] public GameObject JugadorAlInicio;
    [SerializeField] public GameObject JugadorDespues;

    [SerializeField] public GameObject FondoCocina;
    [SerializeField] public GameObject FondoBaño;
    [SerializeField] public GameObject FondoVestidor;
    [SerializeField] public GameObject FondoSalon;
    [SerializeField] public GameObject FondoExcurion;
    [SerializeField] public GameObject FondoTaller;

    public void Awake()
    {
        if (Referencia == null)
        {
            Referencia = this;
        }
    }
    void Start()
    {
        Time.timeScale = 1;
        FondoPause.SetActive(false);
        VolverAlMenu.SetActive(false);
        ContinuarJugando.SetActive(false);
        Reiniciar.SetActive(false);
        TagsSpawnAcciones[0] = "Cocina";
        TagsSpawnAcciones[1] = "Salon";
        TagsSpawnAcciones[2] = "Baño";
        TagsSpawnAcciones[3] = "Vestidor";
        TagsSpawnAcciones[4] = "Taller";
        TagsSpawnAcciones[5] = "Excursion";
        CocinaChecker = false;
        SalonChecker = false;
        TallerChecker = false;
        VestidorChecker = false;
        BañoChecker = false;
        for (int i = 0; i <= 29; i++)
        {
            numbersToChooseFrom.Add(i);
        }
        SpawnActividad();
    }
 
    int support2;
    int support3;

    public void SpawnAccionesOptimizao3()
    {
        Destroy(JugadorAlInicio);
        JugadorDespues.SetActive(true);
        List<int> numbersToChooseFrom2 = new List<int>();
        List<int> chosenNumbers2 = new List<int>();
        int randomNumber2;
        List<int> numbersToChooseFrom3 = new List<int>();
        List<int> chosenNumbers3 = new List<int>();
        int randomNumber3;

        for (int i = 0; i <= 119; i++)
        {
            numbersToChooseFrom2.Add(i);
        }
        for (int i = 0; i <= 7; i++)
        {
            numbersToChooseFrom3.Add(i);
        }
        if (randomNumber == 29)
        {
            if (ConjuntoActividades[randomNumber].gameObject.name == TagsSpawnAcciones[5] + 5)
            {



                AccionesGeneradas[0] = Ex51;
                AccionesGeneradas[1] = Ex52;
                AccionesGeneradas[2] = Ex53;
                AccionesGeneradas[3] = Ex54;
                

                for (int i = 4; i <= 7; i++)
                {
                    CheckerSpawnAcciones = false;
                    while (CheckerSpawnAcciones == false)
                    {
                        if (numbersToChooseFrom2.Count > 0)
                        {

                            int randomIndex = Random.Range(0, numbersToChooseFrom2.Count);

                            randomNumber2 = numbersToChooseFrom2[randomIndex];

                            Debug.Log("Número elegido2: " + randomNumber2);

                            chosenNumbers.Add(randomNumber2);

                            numbersToChooseFrom2.RemoveAt(randomIndex);

                            AccionesGeneradas[i] = AccionesPosibles[randomNumber2];

                            if (AccionesGeneradas[i] != AccionesGeneradas[0] && AccionesGeneradas[i] != AccionesGeneradas[1] && AccionesGeneradas[i] != AccionesGeneradas[2] && AccionesGeneradas[i] != AccionesGeneradas[3])
                            {
                                CheckerSpawnAcciones = true;
                            }
                        }
                    }
                }
                for (int i = 0; i < 8; i++)
                {
                    if (numbersToChooseFrom3.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom3.Count);

                        randomNumber3 = numbersToChooseFrom3[randomIndex];

                        Debug.Log("Número elegido3: " + randomNumber3);

                        chosenNumbers.Add(randomNumber3);

                        numbersToChooseFrom3.RemoveAt(randomIndex);

                        Debug.Log(":)");
                        Debug.Log(":)");

                        float x = AccionesFinales[randomNumber3].gameObject.transform.position.x;
                        float y = AccionesFinales[randomNumber3].gameObject.transform.position.y;
                        Vector2 PosSpawn = new Vector2(x, y);
                        ArrayPosSpawn[i] = PosSpawn;
                        Instantiate(AccionesGeneradas[i], PosSpawn, Quaternion.identity);
                        AccionesFinales[randomNumber3].SetActive(false);
                    }
                }


            }
        }
        else if (randomNumber < 29)
        {
            for (int j = 0; j <= 5; j++)
            {
                for (int i = 1; i <= 5; i++)
                {


                    ForAuxiliar = 0;
                    ForAuxiliar = ForAuxiliar + 20 * j;
                    ForAuxiliar = ForAuxiliar + 4 * (i - 1);


                    string Num = i.ToString();
                    if (ConjuntoActividades[randomNumber].gameObject.name == TagsSpawnAcciones[j] + i)
                    {



                        AccionesGeneradas[0] = AccionesPosibles[0 + ForAuxiliar];
                        AccionesGeneradas[1] = AccionesPosibles[1 + ForAuxiliar];
                        AccionesGeneradas[2] = AccionesPosibles[2 + ForAuxiliar];
                        AccionesGeneradas[3] = AccionesPosibles[3 + ForAuxiliar];
                        numbersToChooseFrom2.RemoveAt(0 + ForAuxiliar);
                        numbersToChooseFrom2.RemoveAt(1 + ForAuxiliar);
                        numbersToChooseFrom2.RemoveAt(2 + ForAuxiliar);
                        numbersToChooseFrom2.RemoveAt(3 + ForAuxiliar);

                        switch (j)
                        {
                            case 0:

                                FondoCocina.SetActive(true);

                                break;

                            case 1:

                                FondoSalon.SetActive(true);

                                break;

                            case 2:

                                FondoBaño.SetActive(true);

                                break;

                            case 3:

                                FondoVestidor.SetActive(true);

                                break;

                            case 4:

                                FondoTaller.SetActive(true);

                                break;

                            case 5:

                                FondoExcurion.SetActive(true);

                                break;
                        }
                        

                        j = 6;
                        i = 6;
                    }
                }
            }
            for (int i = 4; i <= 7; i++)
            {
                CheckerSpawnAcciones = false;
                while (CheckerSpawnAcciones == false)
                {
                    if (numbersToChooseFrom2.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom2.Count);

                        randomNumber2 = numbersToChooseFrom2[randomIndex];

                        Debug.Log("Número elegido2: " + randomNumber2);

                        chosenNumbers.Add(randomNumber2);

                        numbersToChooseFrom2.RemoveAt(randomIndex);

                        AccionesGeneradas[i] = AccionesPosibles[randomNumber2];

                        if (AccionesGeneradas[i] != AccionesGeneradas[0] && AccionesGeneradas[i] != AccionesGeneradas[1] && AccionesGeneradas[i] != AccionesGeneradas[2] && AccionesGeneradas[i] != AccionesGeneradas[3])
                        {
                            CheckerSpawnAcciones = true;
                        }
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (numbersToChooseFrom3.Count > 0)
                {

                    int randomIndex = Random.Range(0, numbersToChooseFrom3.Count);

                    randomNumber3 = numbersToChooseFrom3[randomIndex];

                    Debug.Log("Número elegido3: " + randomNumber3);

                    chosenNumbers.Add(randomNumber3);

                    numbersToChooseFrom3.RemoveAt(randomIndex);

                    Debug.Log(":)");
                    Debug.Log(":)");

                    float x = AccionesFinales[randomNumber3].gameObject.transform.position.x;
                    float y = AccionesFinales[randomNumber3].gameObject.transform.position.y;
                    Vector2 PosSpawn = new Vector2(x, y);
                    ArrayPosSpawn[i] = PosSpawn;
                    Instantiate(AccionesGeneradas[i], PosSpawn, Quaternion.identity);
                    AccionesFinales[randomNumber3].SetActive(false);
                }
            }
        }
       
    }

    public void SpawnAccionesOptimizao4()
    {
        Destroy(JugadorAlInicio);
        JugadorDespues.SetActive(true);
        List<int> numbersToChooseFrom2 = new List<int>();
        List<int> chosenNumbers2 = new List<int>();
        int randomNumber2;
        List<int> numbersToChooseFrom3 = new List<int>();
        List<int> chosenNumbers3 = new List<int>();
        int randomNumber3;

        for (int i = 0; i <= 47; i++)
        {
            numbersToChooseFrom2.Add(i);
        }
        for (int i = 0; i <= 7; i++)
        {
            numbersToChooseFrom3.Add(i);
        }
        if (randomNumber == 11)
        {
            if (ConjuntoActividades[randomNumber].gameObject.name == TagsSpawnAcciones[5] + 2)
            {



                AccionesGeneradas[0] = Ex51;
                AccionesGeneradas[1] = Ex52;
                AccionesGeneradas[2] = Ex53;
                AccionesGeneradas[3] = Ex54;


                for (int i = 4; i <= 7; i++)
                {
                    CheckerSpawnAcciones = false;
                    while (CheckerSpawnAcciones == false)
                    {
                        if (numbersToChooseFrom2.Count > 0)
                        {

                            int randomIndex = Random.Range(0, numbersToChooseFrom2.Count);

                            randomNumber2 = numbersToChooseFrom2[randomIndex];

                            Debug.Log("Número elegido2: " + randomNumber2);

                            chosenNumbers.Add(randomNumber2);

                            numbersToChooseFrom2.RemoveAt(randomIndex);

                            AccionesGeneradas[i] = AccionesPosibles[randomNumber2];

                            if (AccionesGeneradas[i] != AccionesGeneradas[0] && AccionesGeneradas[i] != AccionesGeneradas[1] && AccionesGeneradas[i] != AccionesGeneradas[2] && AccionesGeneradas[i] != AccionesGeneradas[3])
                            {
                                CheckerSpawnAcciones = true;
                            }
                        }
                    }
                }
                for (int i = 0; i < 8; i++)
                {
                    if (numbersToChooseFrom3.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom3.Count);

                        randomNumber3 = numbersToChooseFrom3[randomIndex];

                        Debug.Log("Número elegido3: " + randomNumber3);

                        chosenNumbers.Add(randomNumber3);

                        numbersToChooseFrom3.RemoveAt(randomIndex);

                        Debug.Log(":)");
                        Debug.Log(":)");

                        float x = AccionesFinales[randomNumber3].gameObject.transform.position.x;
                        float y = AccionesFinales[randomNumber3].gameObject.transform.position.y;
                        Vector2 PosSpawn = new Vector2(x, y);
                        ArrayPosSpawn[i] = PosSpawn;
                        Instantiate(AccionesGeneradas[i], PosSpawn, Quaternion.identity);
                        AccionesFinales[randomNumber3].SetActive(false);
                    }
                }


            }
        }
        else if (randomNumber < 29)
        {
            for (int j = 0; j <= 5; j++)
            {
                for (int i = 1; i <= 2; i++)
                {


                    ForAuxiliar = 0;
                    ForAuxiliar = ForAuxiliar + 12 * j;
                    ForAuxiliar = ForAuxiliar + 4 * (i - 1);


                    string Num = i.ToString();
                    if (ConjuntoActividades[randomNumber].gameObject.name == TagsSpawnAcciones[j] + i)
                    {



                        AccionesGeneradas[0] = AccionesPosibles[0 + ForAuxiliar];
                        AccionesGeneradas[1] = AccionesPosibles[1 + ForAuxiliar];
                        AccionesGeneradas[2] = AccionesPosibles[2 + ForAuxiliar];
                        AccionesGeneradas[3] = AccionesPosibles[3 + ForAuxiliar];
                        numbersToChooseFrom2.RemoveAt(0 + ForAuxiliar);
                        numbersToChooseFrom2.RemoveAt(1 + ForAuxiliar);
                        numbersToChooseFrom2.RemoveAt(2 + ForAuxiliar);
                        numbersToChooseFrom2.RemoveAt(3 + ForAuxiliar);

                        switch (j)
                        {
                            case 0:

                                FondoCocina.SetActive(true);

                                break;

                            case 1:

                                FondoSalon.SetActive(true);

                                break;

                            case 2:

                                FondoBaño.SetActive(true);

                                break;

                            case 3:

                                FondoVestidor.SetActive(true);

                                break;

                            case 4:

                                FondoTaller.SetActive(true);

                                break;

                            case 5:

                                FondoExcurion.SetActive(true);

                                break;
                        }


                        j = 6;
                        i = 6;
                    }
                }
            }
            for (int i = 4; i <= 7; i++)
            {
                CheckerSpawnAcciones = false;
                while (CheckerSpawnAcciones == false)
                {
                    if (numbersToChooseFrom2.Count > 0)
                    {

                        int randomIndex = Random.Range(0, numbersToChooseFrom2.Count);

                        randomNumber2 = numbersToChooseFrom2[randomIndex];

                        Debug.Log("Número elegido2: " + randomNumber2);

                        chosenNumbers.Add(randomNumber2);

                        numbersToChooseFrom2.RemoveAt(randomIndex);

                        AccionesGeneradas[i] = AccionesPosibles[randomNumber2];

                        if (AccionesGeneradas[i] != AccionesGeneradas[0] && AccionesGeneradas[i] != AccionesGeneradas[1] && AccionesGeneradas[i] != AccionesGeneradas[2] && AccionesGeneradas[i] != AccionesGeneradas[3])
                        {
                            CheckerSpawnAcciones = true;
                        }
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (numbersToChooseFrom3.Count > 0)
                {

                    int randomIndex = Random.Range(0, numbersToChooseFrom3.Count);

                    randomNumber3 = numbersToChooseFrom3[randomIndex];

                    Debug.Log("Número elegido3: " + randomNumber3);

                    chosenNumbers.Add(randomNumber3);

                    numbersToChooseFrom3.RemoveAt(randomIndex);

                    Debug.Log(":)");
                    Debug.Log(":)");

                    float x = AccionesFinales[randomNumber3].gameObject.transform.position.x;
                    float y = AccionesFinales[randomNumber3].gameObject.transform.position.y;
                    Vector2 PosSpawn = new Vector2(x, y);
                    ArrayPosSpawn[i] = PosSpawn;
                    Instantiate(AccionesGeneradas[i], PosSpawn, Quaternion.identity);
                    AccionesFinales[randomNumber3].SetActive(false);
                }
            }
        }

    }

    public void SpawnActividad()
    {
        if (numbersToChooseFrom.Count > 0)
        {

            int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

            randomNumber = numbersToChooseFrom[randomIndex];

            Debug.Log("Número elegido: " + randomNumber);

            chosenNumbers.Add(randomNumber); 

            numbersToChooseFrom.RemoveAt(randomIndex);

           

           
            if (randomNumber >= 0 && randomNumber <= 4)
            {
                ConjuntoActividades[randomNumber].tag = "Cocina";
            }
            else if (randomNumber >= 5 && randomNumber <= 9)
            {
                ConjuntoActividades[randomNumber].tag = "Salon";
            }
            else if (randomNumber >= 10 && randomNumber <= 14)
            {
                ConjuntoActividades[randomNumber].tag = "Baño";
            }
            else if (randomNumber >= 15 && randomNumber <= 19)
            {
                ConjuntoActividades[randomNumber].tag = "Vestidor";
            }
            else if (randomNumber >= 20 && randomNumber <= 24)
            {
                ConjuntoActividades[randomNumber].tag = "Taller";
            }
            else if (randomNumber >= 25 && randomNumber <= 29)
            {
                ConjuntoActividades[randomNumber].tag = "Excursion";
            }
            Destroy(ActividadSolicitada);
            ActividadSolicitada = ConjuntoActividades[randomNumber].gameObject;
            Vector2 PosActividad = new Vector2(0f, 4f);
            Instantiate(ActividadSolicitada, PosActividad, Quaternion.identity);
        }
    }

    public void SpawnActividad2()
    {
        if (numbersToChooseFrom.Count > 0)
        {

            int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

            randomNumber = numbersToChooseFrom[randomIndex];

            Debug.Log("Número elegido: " + randomNumber);

            chosenNumbers.Add(randomNumber);

            numbersToChooseFrom.RemoveAt(randomIndex);




            if (randomNumber >= 0 && randomNumber <= 1)
            {
                ConjuntoActividades[randomNumber].tag = "Cocina";
            }
            else if (randomNumber >= 2 && randomNumber <= 3)
            {
                ConjuntoActividades[randomNumber].tag = "Salon";
            }
            else if (randomNumber >= 4 && randomNumber <= 5)
            {
                ConjuntoActividades[randomNumber].tag = "Baño";
            }
            else if (randomNumber >= 6 && randomNumber <= 7)
            {
                ConjuntoActividades[randomNumber].tag = "Vestidor";
            }
            else if (randomNumber >= 8 && randomNumber <= 9)
            {
                ConjuntoActividades[randomNumber].tag = "Taller";
            }
            else if (randomNumber >= 10 && randomNumber <= 11)
            {
                ConjuntoActividades[randomNumber].tag = "Excursion";
            }
            Destroy(ActividadSolicitada);
            ActividadSolicitada = ConjuntoActividades[randomNumber].gameObject;
            Vector2 PosActividad = new Vector2(0f, 4f);
            Instantiate(ActividadSolicitada, PosActividad, Quaternion.identity);
        }
    }
    public void Engranaje()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            VolverAlMenu.SetActive(true);
            ContinuarJugando.SetActive(true);
            Reiniciar.SetActive(true);
            FondoPause.SetActive(true);
        }else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            VolverAlMenu.SetActive(false);
            ContinuarJugando.SetActive(false);
            Reiniciar.SetActive(false);
            FondoPause.SetActive(false);
        }
    }
    public void Continuar()
    {
        Time.timeScale = 1;
        VolverAlMenu.SetActive(false);
        ContinuarJugando.SetActive(false);
        Reiniciar.SetActive(false);
        FondoPause.SetActive(false);
    }
}
