using UnityEngine;

public class Acciones : MonoBehaviour
{
    [SerializeField] public int Conteo = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Conteo >= 4)
        {
            Debug.Log("Muy bien");
            Conteo = 0;
            Actividades.InstanceActividades.CheckerDestinoAcertado = false;
            JugarDeNuevo.ReferenciaJugarDeNuevo.Juego.SetActive(false);
            JugarDeNuevo.ReferenciaJugarDeNuevo.Botones.SetActive(true);
            
            



        }
    }
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Actividades.InstanceActividades.CheckerDestinoAcertado == true)
        {
            if (Conteo < 4)
            {
                if (GeneradorActividades.Referencia.ActividadSolicitada.gameObject.name == collision.gameObject.tag)
                {
                    if (collision.gameObject.name == "Primero(Clone)")
                    {
                        Conteo++;
                        collision.gameObject.SetActive(false);
                        SpawnParticulas.ReferenciaParticulas.SpawnParticles();
                    }
                    else if (collision.gameObject.name == "Segundo(Clone)" && Conteo == 1)
                    {
                        Conteo++;
                        collision.gameObject.SetActive(false);
                        SpawnParticulas.ReferenciaParticulas.SpawnParticles();
                    }
                    else if (collision.gameObject.name == "Tercero(Clone)" && Conteo == 2)
                    {
                        Conteo++;
                        collision.gameObject.SetActive(false);
                        SpawnParticulas.ReferenciaParticulas.SpawnParticles();
                    }
                    else if (collision.gameObject.name == "Cuarto(Clone)" && Conteo == 3)
                    {
                        Conteo++;
                        collision.gameObject.SetActive(false);
                        SpawnParticulas.ReferenciaParticulas.SpawnParticles();
                    }
                }
            }
        }
    }
}
