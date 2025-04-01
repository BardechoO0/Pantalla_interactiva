using UnityEngine;

public class CuentaBaño : MonoBehaviour
{
    [SerializeField] public int PuntosCocina;
    [SerializeField] public int PuntosDormitorio;
    [SerializeField] public int PuntosBaño;
    [SerializeField] public int PuntosJuguetes;
    [SerializeField] public GameObject Este;
    [SerializeField] public GameObject[] RecogidosHab1 = new GameObject[10];
    [SerializeField] public GameObject[] RecogidosHab2Pos1 = new GameObject[10];
    [SerializeField] public GameObject[] RecogidosHab2Pos2 = new GameObject[10];
    [SerializeField] public GameObject[] RecogidosHab34Pos1 = new GameObject[10];
    [SerializeField] public GameObject[] RecogidosHab34Pos2 = new GameObject[10];
    [SerializeField] public GameObject[] RecogidosHab34Pos3 = new GameObject[10];
    [SerializeField] public GameObject[] RecogidosHab34Pos4 = new GameObject[10];
    [SerializeField] public GameObject[] ObjetosRecogidos = new GameObject[40];
    [SerializeField] public bool CheckerUp;
    //public static CuentaBaño Instance;
    public static CuentaBaño ReferenciaCuentaBaño;

    

    [SerializeField] public bool CocinaHab1Pos1 = false;
    [SerializeField] public bool BañoHab1Pos1 = false;
    [SerializeField] public bool DormitorioHab1Pos1 = false;
    [SerializeField] public bool JuguetesHab1Pos1 = false;
    [SerializeField] public bool CocinaHab2Pos1 = false;
    [SerializeField] public bool CocinaHab2Pos2 = false;
    [SerializeField] public bool BañoHab2Pos1 = false;
    [SerializeField] public bool BañoHab2Pos2 = false;
    [SerializeField] public bool DormitorioHab2Pos1 = false;
    [SerializeField] public bool DormitorioHab2Pos2 = false;
    [SerializeField] public bool JuguetesHab2Pos1 = false;
    [SerializeField] public bool JuguetesHab2Pos2 = false;
    [SerializeField] public bool CocinaHab34Pos2 = false;
    [SerializeField] public bool BañoHab34Pos1 = false;
    [SerializeField] public bool DormitorioHab34Pos4 = false;
    [SerializeField] public bool JuguetesHab34Pos3 = false;


    
    public void Awake()
    {
        if (ReferenciaCuentaBaño == null)
        {
            ReferenciaCuentaBaño = this;
        }
    }
    public void Update()
    {
        
        CocinaHab1Pos1 = EleccionNumero.ReferenciaEleccionNumero.CocinaHab1Pos1Num;
        BañoHab1Pos1 = EleccionNumero.ReferenciaEleccionNumero.BañoHab1Pos1Num;
        DormitorioHab1Pos1 = EleccionNumero.ReferenciaEleccionNumero.DormitorioHab1Pos1Num;
        JuguetesHab1Pos1 = EleccionNumero.ReferenciaEleccionNumero.JuguetesHab1Pos1Num;
        CocinaHab2Pos1 = EleccionNumero.ReferenciaEleccionNumero.CocinaHab2Pos1Num;
        CocinaHab2Pos2 = EleccionNumero.ReferenciaEleccionNumero.CocinaHab2Pos2Num;
        BañoHab2Pos1 = EleccionNumero.ReferenciaEleccionNumero.BañoHab2Pos1Num;
        BañoHab2Pos2 = EleccionNumero.ReferenciaEleccionNumero.BañoHab2Pos2Num;
        DormitorioHab2Pos1 = EleccionNumero.ReferenciaEleccionNumero.DormitorioHab2Pos1Num;
        DormitorioHab2Pos2 = EleccionNumero.ReferenciaEleccionNumero.DormitorioHab2Pos2Num;
        JuguetesHab2Pos1 = EleccionNumero.ReferenciaEleccionNumero.JuguetesHab2Pos1Num;
        JuguetesHab2Pos2 = EleccionNumero.ReferenciaEleccionNumero.JuguetesHab2Pos2Num;
        CocinaHab34Pos2 = EleccionNumero.ReferenciaEleccionNumero.CocinaHab34Pos2Num;
        BañoHab34Pos1 = EleccionNumero.ReferenciaEleccionNumero.BañoHab34Pos1Num;
        DormitorioHab34Pos4 = EleccionNumero.ReferenciaEleccionNumero.DormitorioHab34Pos4Num;
        JuguetesHab34Pos3 = EleccionNumero.ReferenciaEleccionNumero.JuguetesHab34Pos3Num;
    }
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cocina" && Este.gameObject.tag == "Cocina")
        {
            
            SpawnParticulas.ReferenciaParticulas.ParticulasOrdenarCocina();

            if (CocinaHab1Pos1 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "cuchillo(Clone)":

                        ObjetosRecogidos[0].transform.position = RecogidosHab1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);
                        
                        break;

                    case "exprimidor(Clone)":

                        ObjetosRecogidos[1].transform.position = RecogidosHab1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "fregadero(Clone)":

                        ObjetosRecogidos[2].transform.position = RecogidosHab1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "horno(Clone)":

                        ObjetosRecogidos[3].transform.position = RecogidosHab1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "microondas(Clone)":

                        ObjetosRecogidos[4].transform.position = RecogidosHab1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "nevera(Clone)":

                        ObjetosRecogidos[5].transform.position = RecogidosHab1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "olla(Clone)":

                        ObjetosRecogidos[6].transform.position = RecogidosHab1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "sandwichera(Clone)":

                        ObjetosRecogidos[7].transform.position = RecogidosHab1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "sartén(Clone)":

                        ObjetosRecogidos[8].transform.position = RecogidosHab1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "tostadora(Clone)":

                        ObjetosRecogidos[9].transform.position = RecogidosHab1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                
                Debug.Log("HolaCocina1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                collision.gameObject.SetActive(false);
                //RecogidosHab1[PuntosCocina].SetActive(false);
                Debug.Log("HolaCocina4");
            }
            else if (CocinaHab2Pos1 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "cuchillo(Clone)":

                        ObjetosRecogidos[0].transform.position = RecogidosHab2Pos1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "exprimidor(Clone)":

                        ObjetosRecogidos[1].transform.position = RecogidosHab2Pos1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "fregadero(Clone)":

                        ObjetosRecogidos[2].transform.position = RecogidosHab2Pos1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "horno(Clone)":

                        ObjetosRecogidos[3].transform.position = RecogidosHab2Pos1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "microondas(Clone)":

                        ObjetosRecogidos[4].transform.position = RecogidosHab2Pos1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "nevera(Clone)":

                        ObjetosRecogidos[5].transform.position = RecogidosHab2Pos1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "olla(Clone)":

                        ObjetosRecogidos[6].transform.position = RecogidosHab2Pos1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "sandwichera(Clone)":

                        ObjetosRecogidos[7].transform.position = RecogidosHab2Pos1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "sartén(Clone)":

                        ObjetosRecogidos[8].transform.position = RecogidosHab2Pos1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "tostadora(Clone)":

                        ObjetosRecogidos[9].transform.position = RecogidosHab2Pos1[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                
                Debug.Log("HolaCocina1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaCocina2");

                Debug.Log("HolaCocina3");
                //RecogidosHab2Pos1[PuntosCocina].SetActive(false);
                collision.gameObject.SetActive(false);
                Debug.Log("HolaCocina4");
            }
            else if (CocinaHab2Pos2 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "cuchillo(Clone)":

                        ObjetosRecogidos[0].transform.position = RecogidosHab2Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "exprimidor(Clone)":

                        ObjetosRecogidos[1].transform.position = RecogidosHab2Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "fregadero(Clone)":

                        ObjetosRecogidos[2].transform.position = RecogidosHab2Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "horno(Clone)":

                        ObjetosRecogidos[3].transform.position = RecogidosHab2Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "microondas(Clone)":

                        ObjetosRecogidos[4].transform.position = RecogidosHab2Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "nevera(Clone)":

                        ObjetosRecogidos[5].transform.position = RecogidosHab2Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "olla(Clone)":

                        ObjetosRecogidos[6].transform.position = RecogidosHab2Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "sandwichera(Clone)":

                        ObjetosRecogidos[7].transform.position = RecogidosHab2Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "sartén(Clone)":

                        ObjetosRecogidos[8].transform.position = RecogidosHab2Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "tostadora(Clone)":

                        ObjetosRecogidos[9].transform.position = RecogidosHab2Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                Debug.Log("Tomate");
                
                Debug.Log("HolaCocina1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaCocina2");

                Debug.Log("HolaCocina3");
                //RecogidosHab2Pos2[PuntosCocina].SetActive(false);
                collision.gameObject.SetActive(false);
                Debug.Log("HolaCocina4");
            }
            else if (CocinaHab34Pos2 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "cuchillo(Clone)":

                        ObjetosRecogidos[0].transform.position = RecogidosHab34Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "exprimidor(Clone)":

                        ObjetosRecogidos[1].transform.position = RecogidosHab34Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "fregadero(Clone)":

                        ObjetosRecogidos[2].transform.position = RecogidosHab34Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "horno(Clone)":

                        ObjetosRecogidos[3].transform.position = RecogidosHab34Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "microondas(Clone)":

                        ObjetosRecogidos[4].transform.position = RecogidosHab34Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "nevera(Clone)":

                        ObjetosRecogidos[5].transform.position = RecogidosHab34Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "olla(Clone)":

                        ObjetosRecogidos[6].transform.position = RecogidosHab34Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "sandwichera(Clone)":

                        ObjetosRecogidos[7].transform.position = RecogidosHab34Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "sartén(Clone)":

                        ObjetosRecogidos[8].transform.position = RecogidosHab34Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "tostadora(Clone)":

                        ObjetosRecogidos[9].transform.position = RecogidosHab34Pos2[PuntosCocina].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                
                Debug.Log("HolaCocina1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaCocina2");

                Debug.Log("HolaCocina3");
                collision.gameObject.SetActive(false);
                //RecogidosHab34Pos2[PuntosCocina].SetActive(false);
                Debug.Log("HolaCocina4");
            }
            PuntosCocina++;
            EleccionNumero.ReferenciaEleccionNumero.ObjetosAcertados++;
            
            
        }
        if (collision.tag == "Baño" && Este.gameObject.tag == "Baño")
        {
            
            SpawnParticulas.ReferenciaParticulas.ParticulasOrdenarBaño();

            if (BañoHab1Pos1 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "bañera(Clone)":

                        ObjetosRecogidos[20].transform.position = RecogidosHab1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "bidé(Clone)":

                        ObjetosRecogidos[21].transform.position = RecogidosHab1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cepillo de dientes(Clone)":

                        ObjetosRecogidos[22].transform.position = RecogidosHab1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "champú(Clone)":

                        ObjetosRecogidos[23].transform.position = RecogidosHab1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "coger la toalla(Clone)":

                        ObjetosRecogidos[24].transform.position = RecogidosHab1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cuchilla de afeitar(Clone)":

                        ObjetosRecogidos[25].transform.position = RecogidosHab1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "ducha(Clone)":

                        ObjetosRecogidos[26].transform.position = RecogidosHab1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "jabón(Clone)":

                        ObjetosRecogidos[27].transform.position = RecogidosHab1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "lavabo(Clone)":

                        ObjetosRecogidos[28].transform.position = RecogidosHab1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "retrete(Clone)":

                        ObjetosRecogidos[29].transform.position = RecogidosHab1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                
                Debug.Log("HolaBaño1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaBaño2");
                collision.gameObject.SetActive(false);
                Debug.Log("HolaBaño3");
                //RecogidosHab1[PuntosBaño].SetActive(false);
                Debug.Log("HolaBaño4");
            }
            else if (BañoHab2Pos1 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "bañera(Clone)":

                        ObjetosRecogidos[20].transform.position = RecogidosHab2Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "bidé(Clone)":

                        ObjetosRecogidos[21].transform.position = RecogidosHab2Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cepillo de dientes(Clone)":

                        ObjetosRecogidos[22].transform.position = RecogidosHab2Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "champú(Clone)":

                        ObjetosRecogidos[23].transform.position = RecogidosHab2Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "coger la toalla(Clone)":

                        ObjetosRecogidos[24].transform.position = RecogidosHab2Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cuchilla de afeitar(Clone)":

                        ObjetosRecogidos[25].transform.position = RecogidosHab2Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "ducha(Clone)":

                        ObjetosRecogidos[26].transform.position = RecogidosHab2Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "jabón(Clone)":

                        ObjetosRecogidos[27].transform.position = RecogidosHab2Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "lavabo(Clone)":

                        ObjetosRecogidos[28].transform.position = RecogidosHab2Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "retrete(Clone)":

                        ObjetosRecogidos[29].transform.position = RecogidosHab2Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                
                Debug.Log("HolaBaño1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaBaño2");
                collision.gameObject.SetActive(false);
                Debug.Log("HolaBaño3");
                //RecogidosHab2Pos1[PuntosBaño].SetActive(false);
                Debug.Log("HolaBaño4");
            }
            else if (BañoHab2Pos2 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "bañera(Clone)":

                        ObjetosRecogidos[20].transform.position = RecogidosHab2Pos2[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "bidé(Clone)":

                        ObjetosRecogidos[21].transform.position = RecogidosHab2Pos2[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cepillo de dientes(Clone)":

                        ObjetosRecogidos[22].transform.position = RecogidosHab2Pos2[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "champú(Clone)":

                        ObjetosRecogidos[23].transform.position = RecogidosHab2Pos2[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "coger la toalla(Clone)":

                        ObjetosRecogidos[24].transform.position = RecogidosHab2Pos2[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cuchilla de afeitar(Clone)":

                        ObjetosRecogidos[25].transform.position = RecogidosHab2Pos2[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "ducha(Clone)":

                        ObjetosRecogidos[26].transform.position = RecogidosHab2Pos2[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "jabón(Clone)":

                        ObjetosRecogidos[27].transform.position = RecogidosHab2Pos2[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "lavabo(Clone)":

                        ObjetosRecogidos[28].transform.position = RecogidosHab2Pos2[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "retrete(Clone)":

                        ObjetosRecogidos[29].transform.position = RecogidosHab2Pos2[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                
                Debug.Log("HolaBaño1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaBaño2");
                collision.gameObject.SetActive(false);
                Debug.Log("HolaBaño3");
                //RecogidosHab2Pos2[PuntosBaño].SetActive(false);
                Debug.Log("HolaBaño4");
            }
            else if (BañoHab34Pos1 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "bañera(Clone)":

                        ObjetosRecogidos[20].transform.position = RecogidosHab34Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "bidé(Clone)":

                        ObjetosRecogidos[21].transform.position = RecogidosHab34Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cepillo de dientes(Clone)":

                        ObjetosRecogidos[22].transform.position = RecogidosHab34Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "champú(Clone)":

                        ObjetosRecogidos[23].transform.position = RecogidosHab34Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "coger la toalla(Clone)":

                        ObjetosRecogidos[24].transform.position = RecogidosHab34Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cuchilla de afeitar(Clone)":

                        ObjetosRecogidos[25].transform.position = RecogidosHab34Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "ducha(Clone)":

                        ObjetosRecogidos[26].transform.position = RecogidosHab34Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "jabón(Clone)":

                        ObjetosRecogidos[27].transform.position = RecogidosHab34Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "lavabo(Clone)":

                        ObjetosRecogidos[28].transform.position = RecogidosHab34Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "retrete(Clone)":

                        ObjetosRecogidos[29].transform.position = RecogidosHab34Pos1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
               
                Debug.Log("HolaBaño1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaBaño2");
                collision.gameObject.SetActive(false);
                Debug.Log("HolaBaño3");
                //RecogidosHab34Pos1[PuntosBaño].SetActive(false);
                Debug.Log("HolaBaño4");
            }
            PuntosBaño++;
            EleccionNumero.ReferenciaEleccionNumero.ObjetosAcertados++;

        }
        if (collision.tag == "Dormitorio" && Este.gameObject.tag == "Dormitorio")
        {
            
            SpawnParticulas.ReferenciaParticulas.ParticulasOrdenarDormitorio();

            if (DormitorioHab1Pos1 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "almohada(Clone)":

                        ObjetosRecogidos[10].transform.position = RecogidosHab1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "armario(Clone)":

                        ObjetosRecogidos[11].transform.position = RecogidosHab1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cajonera(Clone)":

                        ObjetosRecogidos[12].transform.position = RecogidosHab1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cama(Clone)":

                        ObjetosRecogidos[13].transform.position = RecogidosHab1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cojín(Clone)":

                        ObjetosRecogidos[14].transform.position = RecogidosHab1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "escritorio(Clone)":

                        ObjetosRecogidos[15].transform.position = RecogidosHab1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "lámpara(Clone)":

                        ObjetosRecogidos[16].transform.position = RecogidosHab1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "manta(Clone)":

                        ObjetosRecogidos[17].transform.position = RecogidosHab1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "mesilla(Clone)":

                        ObjetosRecogidos[18].transform.position = RecogidosHab1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "reloj despertador(Clone)":

                        ObjetosRecogidos[19].transform.position = RecogidosHab1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                Debug.Log("HolaDormitorio1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaDormitorio2");
                collision.gameObject.SetActive(false);
                Debug.Log("HolaDormitorio3");
                //RecogidosHab1[PuntosDormitorio].SetActive(false);
                Debug.Log("HolaDormitorio4");
            }
            else if (DormitorioHab2Pos1 == true)
            {

                switch (collision.gameObject.name)
                {
                    case "almohada(Clone)":

                        ObjetosRecogidos[10].transform.position = RecogidosHab2Pos1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "armario(Clone)":

                        ObjetosRecogidos[11].transform.position = RecogidosHab2Pos1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cajonera(Clone)":

                        ObjetosRecogidos[12].transform.position = RecogidosHab2Pos1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cama(Clone)":

                        ObjetosRecogidos[13].transform.position = RecogidosHab2Pos1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cojín(Clone)":

                        ObjetosRecogidos[14].transform.position = RecogidosHab2Pos1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "escritorio(Clone)":

                        ObjetosRecogidos[15].transform.position = RecogidosHab2Pos1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "lámpara(Clone)":

                        ObjetosRecogidos[16].transform.position = RecogidosHab2Pos1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "manta(Clone)":

                        ObjetosRecogidos[17].transform.position = RecogidosHab2Pos1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "mesilla(Clone)":

                        ObjetosRecogidos[18].transform.position = RecogidosHab2Pos1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "reloj despertador(Clone)":

                        ObjetosRecogidos[19].transform.position = RecogidosHab2Pos1[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }


                
                Debug.Log("HolaDormitorio1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaDormitorio2");
                
                Debug.Log("HolaDormitorio3");
                //RecogidosHab2Pos1[PuntosDormitorio].SetActive(false);
                Debug.Log("HolaDormitorio4");
            }
            else if (DormitorioHab2Pos2 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "almohada(Clone)":

                        ObjetosRecogidos[10].transform.position = RecogidosHab2Pos2[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "armario(Clone)":

                        ObjetosRecogidos[11].transform.position = RecogidosHab2Pos2[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cajonera(Clone)":

                        ObjetosRecogidos[12].transform.position = RecogidosHab2Pos2[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cama(Clone)":

                        ObjetosRecogidos[13].transform.position = RecogidosHab2Pos2[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cojín(Clone)":

                        ObjetosRecogidos[14].transform.position = RecogidosHab2Pos2[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "escritorio(Clone)":

                        ObjetosRecogidos[15].transform.position = RecogidosHab2Pos2[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "lámpara(Clone)":

                        ObjetosRecogidos[16].transform.position = RecogidosHab2Pos2[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "manta(Clone)":

                        ObjetosRecogidos[17].transform.position = RecogidosHab2Pos2[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "mesilla(Clone)":

                        ObjetosRecogidos[18].transform.position = RecogidosHab2Pos2[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "reloj despertador(Clone)":

                        ObjetosRecogidos[19].transform.position = RecogidosHab2Pos2[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
               
                Debug.Log("HolaDormitorio1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaDormitorio2");
                collision.gameObject.SetActive(false);
                Debug.Log("HolaDormitorio3");
                //RecogidosHab2Pos2[PuntosDormitorio].SetActive(false);
                Debug.Log("HolaDormitorio4");
            }
            else if (DormitorioHab34Pos4 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "almohada(Clone)":

                        ObjetosRecogidos[10].transform.position = RecogidosHab34Pos4[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "armario(Clone)":

                        ObjetosRecogidos[11].transform.position = RecogidosHab34Pos4[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cajonera(Clone)":

                        ObjetosRecogidos[12].transform.position = RecogidosHab34Pos4[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cama(Clone)":

                        ObjetosRecogidos[13].transform.position = RecogidosHab34Pos4[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cojín(Clone)":

                        ObjetosRecogidos[14].transform.position = RecogidosHab34Pos4[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "escritorio(Clone)":

                        ObjetosRecogidos[15].transform.position = RecogidosHab34Pos4[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "lámpara(Clone)":

                        ObjetosRecogidos[16].transform.position = RecogidosHab34Pos4[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "manta(Clone)":

                        ObjetosRecogidos[17].transform.position = RecogidosHab34Pos4[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "mesilla(Clone)":

                        ObjetosRecogidos[18].transform.position = RecogidosHab34Pos4[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "reloj despertador(Clone)":

                        ObjetosRecogidos[19].transform.position = RecogidosHab34Pos4[PuntosDormitorio].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                
                Debug.Log("HolaDormitorio1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaDormitorio2");
                collision.gameObject.SetActive(false);
                Debug.Log("HolaDormitorio3");
                //RecogidosHab34Pos4[PuntosDormitorio].SetActive(false);
                Debug.Log("HolaDormitorio4");
            }
            PuntosDormitorio++;
            EleccionNumero.ReferenciaEleccionNumero.ObjetosAcertados++;
        }
        if (collision.tag == "Juguetes" && Este.gameObject.tag == "Juguetes")
        {
            
            SpawnParticulas.ReferenciaParticulas.ParticulasOrdenarJuguetes();

            if (JuguetesHab1Pos1 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "canicas(Clone)":

                        ObjetosRecogidos[30].transform.position = RecogidosHab1[PuntosBaño].transform.position;
                        collision.gameObject.SetActive(false);
                        Destroy(collision.gameObject);

                        break;

                    case "cubo de rubik(Clone)":

                        ObjetosRecogidos[31].transform.position = RecogidosHab1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);
                        Destroy(collision.gameObject);

                        break;

                    case "diábolo(Clone)":

                        ObjetosRecogidos[32].transform.position = RecogidosHab1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);
                        Destroy(collision.gameObject);

                        break;

                    case "juego de enroscar(Clone)":

                        ObjetosRecogidos[33].transform.position = RecogidosHab1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);
                        Destroy(collision.gameObject);

                        break;

                    case "juego de las anillas(Clone)":

                        ObjetosRecogidos[34].transform.position = RecogidosHab1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);
                        Destroy(collision.gameObject);

                        break;

                    case "peluche de dinosaurio(Clone)":

                        ObjetosRecogidos[35].transform.position = RecogidosHab1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);
                        Destroy(collision.gameObject);

                        break;

                    case "peonza(Clone)":

                        ObjetosRecogidos[36].transform.position = RecogidosHab1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);
                        Destroy(collision.gameObject);

                        break;

                    case "scalextric(Clone)":

                        ObjetosRecogidos[37].transform.position = RecogidosHab1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);
                        Destroy(collision.gameObject);

                        break;

                    case "slinky(Clone)":

                        ObjetosRecogidos[38].transform.position = RecogidosHab1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);
                        Destroy(collision.gameObject);

                        break;

                    case "yoyó(Clone)":

                        ObjetosRecogidos[39].transform.position = RecogidosHab1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);
                        Destroy(collision.gameObject);

                        break;
                }
                
                Debug.Log("HolaJuguetes1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaJuguetes2");
                collision.gameObject.SetActive(false);
                Debug.Log("HolaJuguetes3");
                //RecogidosHab1[PuntosJuguetes].SetActive(false);
                Debug.Log("HolaJuguetes4");
            }
            else if (JuguetesHab2Pos1 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "canicas(Clone)":

                        ObjetosRecogidos[30].transform.position = RecogidosHab2Pos1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cubo de rubik(Clone)":

                        ObjetosRecogidos[31].transform.position = RecogidosHab2Pos1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "diábolo(Clone)":

                        ObjetosRecogidos[32].transform.position = RecogidosHab2Pos1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "juego de enroscar(Clone)":

                        ObjetosRecogidos[33].transform.position = RecogidosHab2Pos1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "juego de las anillas(Clone)":

                        ObjetosRecogidos[34].transform.position = RecogidosHab2Pos1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "peluche de dinosaurio(Clone)":

                        ObjetosRecogidos[35].transform.position = RecogidosHab2Pos1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "peonza(Clone)":

                        ObjetosRecogidos[36].transform.position = RecogidosHab2Pos1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "scalextric(Clone)":

                        ObjetosRecogidos[37].transform.position = RecogidosHab2Pos1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "slinky(Clone)":

                        ObjetosRecogidos[38].transform.position = RecogidosHab2Pos1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "yoyó(Clone)":

                        ObjetosRecogidos[39].transform.position = RecogidosHab2Pos1[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                
                Debug.Log("HolaJuguetes1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaJuguetes2");
                collision.gameObject.SetActive(false);
                Debug.Log("HolaJuguetes3");
                //RecogidosHab2Pos1[PuntosJuguetes].SetActive(false);
                Debug.Log("HolaJuguetes4");
            }
            else if (JuguetesHab2Pos2 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "canicas(Clone)":

                        ObjetosRecogidos[30].transform.position = RecogidosHab2Pos2[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cubo de rubik(Clone)":

                        ObjetosRecogidos[31].transform.position = RecogidosHab2Pos2[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "diábolo(Clone)":

                        ObjetosRecogidos[32].transform.position = RecogidosHab2Pos2[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "juego de enroscar(Clone)":

                        ObjetosRecogidos[33].transform.position = RecogidosHab2Pos2[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "juego de las anillas(Clone)":

                        ObjetosRecogidos[34].transform.position = RecogidosHab2Pos2[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "peluche de dinosaurio(Clone)":

                        ObjetosRecogidos[35].transform.position = RecogidosHab2Pos2[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "peonza(Clone)":

                        ObjetosRecogidos[36].transform.position = RecogidosHab2Pos2[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "scalextric(Clone)":

                        ObjetosRecogidos[37].transform.position = RecogidosHab2Pos2[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "slinky(Clone)":

                        ObjetosRecogidos[38].transform.position = RecogidosHab2Pos2[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "yoyó(Clone)":

                        ObjetosRecogidos[39].transform.position = RecogidosHab2Pos2[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                
                Debug.Log("HolaJuguetes1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaJuguetes2");
                collision.gameObject.SetActive(false);
                Debug.Log("HolaJuguetes3");
                //RecogidosHab2Pos2[PuntosJuguetes].SetActive(false);
                Debug.Log("HolaJuguetes4");
            }
            else if (JuguetesHab34Pos3 == true)
            {
                switch (collision.gameObject.name)
                {
                    case "canicas(Clone)":

                        ObjetosRecogidos[30].transform.position = RecogidosHab34Pos3[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "cubo de rubik(Clone)":

                        ObjetosRecogidos[31].transform.position = RecogidosHab34Pos3[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "diábolo(Clone)":

                        ObjetosRecogidos[32].transform.position = RecogidosHab34Pos3[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "juego de enroscar(Clone)":

                        ObjetosRecogidos[33].transform.position = RecogidosHab34Pos3[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "juego de las anillas(Clone)":

                        ObjetosRecogidos[34].transform.position = RecogidosHab34Pos3[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "peluche de dinosaurio(Clone)":

                        ObjetosRecogidos[35].transform.position = RecogidosHab34Pos3[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "peonza(Clone)":

                        ObjetosRecogidos[36].transform.position = RecogidosHab34Pos3[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "scalextric(Clone)":

                        ObjetosRecogidos[37].transform.position = RecogidosHab34Pos3[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "slinky(Clone)":

                        ObjetosRecogidos[38].transform.position = RecogidosHab34Pos3[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;

                    case "yoyó(Clone)":

                        ObjetosRecogidos[39].transform.position = RecogidosHab34Pos3[PuntosJuguetes].transform.position;
                        collision.gameObject.SetActive(false);

                        break;
                }
                
                Debug.Log("HolaJuguetes1");
                //collision.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                Debug.Log("HolaJuguetes2");
                 collision.gameObject.SetActive(false);
                Debug.Log("HolaJuguetes3");
                //RecogidosHab34Pos3[PuntosJuguetes].SetActive(false);
                Debug.Log("HolaJuguetes4");
            }
            PuntosJuguetes++;
            EleccionNumero.ReferenciaEleccionNumero.ObjetosAcertados++;

        }
        

    }
   


}
