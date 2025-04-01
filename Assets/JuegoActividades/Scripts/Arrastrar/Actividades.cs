using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividades : MonoBehaviour
{
    [SerializeField] public int PuntosCocina;
    [SerializeField] public int PuntosDormitorio;
    [SerializeField] public int PuntosBaño;
    [SerializeField] public int PuntosJuguetes;
    [SerializeField] public GameObject GrupoDestinos;
    [SerializeField] public GameObject GrupoAcciones;
    [SerializeField] public bool CheckerDestinoAcertado;
    public static Actividades InstanceActividades;
    
    [SerializeField] public bool CheckerUp;

    public void Awake()
    {
        if (InstanceActividades == null)
        {
            InstanceActividades = this;
        }
    }
    private void Start()
    {
        CheckerDestinoAcertado = false;
        GrupoAcciones.SetActive(false);
       // FondoCocina.SetActive(false);
        //FondoBaño.SetActive(false);
        //FondoVestidor.SetActive(false);
        //FondoSalon.SetActive(false);
        //FondoExcurion.SetActive(false);
        //FondoTaller.SetActive(false);
    }
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (CheckerDestinoAcertado == false)
        {
            if (GeneradorActividades.Referencia.ConjuntoActividades[GeneradorActividades.Referencia.randomNumber].gameObject.tag == collision.gameObject.tag)
            {
                SpawnParticulas.ReferenciaParticulas.SpawnParticles();
                Debug.Log("Coñoooooooooooooooooooo");
                    GrupoDestinos.SetActive(false);
                    GrupoAcciones.SetActive(true);
                    GeneradorActividades.Referencia.SpawnAccionesOptimizao3();
                    CheckerDestinoAcertado = true;
                    //FondoCocina.SetActive(true);
                // GeneradorActividades.Referencia.ActualizarTags();
            }
        } 
    }
}
/*
if (collision.gameObject.tag == "Cocina1" || collision.gameObject.tag == "Cocina2" || collision.gameObject.tag == "Cocina3" || collision.gameObject.tag == "Cocina4" || collision.gameObject.tag == "Cocina5")
{
    GrupoDestinos.SetActive(false);
    //FondoCocina.SetActive(true);
}
if (collision.gameObject.tag == "Baño1" || collision.gameObject.tag == "Baño2" || collision.gameObject.tag == "Baño3" || collision.gameObject.tag == "Baño4" || collision.gameObject.tag == "Baño5")
{
    GrupoDestinos.SetActive(false);
    //FondoBaño.SetActive(true);
}
if (collision.gameObject.tag == "Vestidor1" || collision.gameObject.tag == "Vestidor2" || collision.gameObject.tag == "Vestidor3" || collision.gameObject.tag == "Vestidor4" || collision.gameObject.tag == "Vestidor5")
{
    GrupoDestinos.SetActive(false);
    //FondoVestidor.SetActive(true);
}
if (collision.gameObject.tag == "Salon1" || collision.gameObject.tag == "Salon2" || collision.gameObject.tag == "Salon3" || collision.gameObject.tag == "Salon4" || collision.gameObject.tag == "Salon5")
{
    GrupoDestinos.SetActive(false);
    //FondoSalon.SetActive(true);
}
if (collision.gameObject.tag == "Excursion1" || collision.gameObject.tag == "Excursion2" || collision.gameObject.tag == "Excursion3" || collision.gameObject.tag == "Excursion4" || collision.gameObject.tag == "Excursion5")
{
    GrupoDestinos.SetActive(false);
    //FondoExcurion.SetActive(true);
}
if (collision.gameObject.tag == "Taller1" || collision.gameObject.tag == "Taller2" || collision.gameObject.tag == "Taller3" || collision.gameObject.tag == "Taller4" || collision.gameObject.tag == "Taller5")
{
    GrupoDestinos.SetActive(false);
    // FondoTaller.SetActive(true);
}
*/