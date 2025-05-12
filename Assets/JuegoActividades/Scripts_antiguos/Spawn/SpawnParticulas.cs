using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnParticulas : MonoBehaviour
{
    public GameObject particleSystemPrefab;
    public GameObject Rojo;
    public GameObject Verde;
    public GameObject Amarillo;
    public GameObject Azul;
    public GameObject Blanco;
    public GameObject ReferenciaCocina;
    public GameObject ReferenciaBaño;
    public GameObject ReferenciaDormitorio;
    public GameObject ReferenciaJuguetes;
    public ParticleSystem ParticulasAzul;
    public ParticleSystem ParticulasAmarillo;
    public ParticleSystem ParticulasBlanco;
    public ParticleSystem ParticulasRojo;
    public ParticleSystem ParticulasVerde;
    public GameObject ParticulasAzulPadre;
    public GameObject ParticulasAmarilloPadre;
    public GameObject ParticulasBlancoPadre;
    public GameObject ParticulasRojoPadre;
    public GameObject ParticulasVerdePadre;
    // Asigna el prefab del sistema de partículas en el Inspector
    public static SpawnParticulas ReferenciaParticulas;
    public void Awake()
    {
        if (ReferenciaParticulas == null)
        {
            ReferenciaParticulas = this;
        }
    }
    public void Start()
    {
        ParticulasAzulPadre.SetActive(false);
        ParticulasAmarilloPadre.SetActive(false);
        ParticulasBlancoPadre.SetActive(false);
        ParticulasRojoPadre.SetActive(false);
        ParticulasVerdePadre.SetActive(false);
    }

    public void SpawnParticles()
    {
        
        // Instancia el sistema de partículas en la posición actual del objeto que tiene este script
        GameObject particleSystemInstance = Instantiate(particleSystemPrefab, transform.position, Quaternion.identity);

        // Destruye el sistema de partículas después de 1 segundo
        Destroy(particleSystemInstance, 2f);
    }
    public void ParticulasOrdenarCocina()
    {
        // Instancia el sistema de partículas en la posición actual del objeto que tiene este script
        GameObject particleSystemInstance = Instantiate(particleSystemPrefab, ReferenciaCocina.gameObject.transform.position, Quaternion.identity);

        // Destruye el sistema de partículas después de 1 segundo
        Destroy(particleSystemInstance, 2f);
    }
    public void ParticulasOrdenarBaño()
    {
        // Instancia el sistema de partículas en la posición actual del objeto que tiene este script
        GameObject particleSystemInstance = Instantiate(particleSystemPrefab, ReferenciaBaño.gameObject.transform.position, Quaternion.identity);

        // Destruye el sistema de partículas después de 1 segundo
        Destroy(particleSystemInstance, 2f);
    }
    public void ParticulasOrdenarDormitorio()
    {
        // Instancia el sistema de partículas en la posición actual del objeto que tiene este script
        GameObject particleSystemInstance = Instantiate(particleSystemPrefab, ReferenciaDormitorio.gameObject.transform.position, Quaternion.identity);

        // Destruye el sistema de partículas después de 1 segundo
        Destroy(particleSystemInstance, 2f);
    }
    public void ParticulasOrdenarJuguetes()
    {
        // Instancia el sistema de partículas en la posición actual del objeto que tiene este script
        GameObject particleSystemInstance = Instantiate(particleSystemPrefab, ReferenciaJuguetes.gameObject.transform.position, Quaternion.identity);

        // Destruye el sistema de partículas después de 1 segundo
        Destroy(particleSystemInstance, 2f);
    }
    /*public void ParticulasRojo()
    {
        GameObject particleSystemInstance = Instantiate(Rojo, gameManager.Instance.VectorRojo, Quaternion.identity);

        // Destruye el sistema de partículas después de 1 segundo
        Destroy(particleSystemInstance, 2f);
    }

    public void ParticulasBlanco()
    {
        GameObject particleSystemInstance = Instantiate(Blanco, gameManager.Instance.VectorBlanco, Quaternion.identity);

        // Destruye el sistema de partículas después de 1 segundo
        Destroy(particleSystemInstance, 2f);
    }
    public void ParticulasVerde()
    {
        GameObject particleSystemInstance = Instantiate(Verde, gameManager.Instance.VectorVerde, Quaternion.identity);

        // Destruye el sistema de partículas después de 1 segundo
        Destroy(particleSystemInstance, 2f);
    }
    
    public void ParticulasAmarillo()
    {
        GameObject particleSystemInstance = Instantiate(Amarillo, gameManager.Instance.VectorAmarillo, Quaternion.identity);

        // Destruye el sistema de partículas después de 1 segundo
        Destroy(particleSystemInstance, 2f);
    }*/
    public void PlayParticulasAzul()
    {
        ParticulasAzulPadre.SetActive(true);
        ParticulasAzul.Play();
    }
    public void StopParticulasAzul()
    {
        ParticulasAzul.Stop();
        ParticulasAzulPadre.SetActive(false);
    }
    public void PlayParticulasAmarillo()
    {
        ParticulasAmarilloPadre.SetActive(true);
        ParticulasAmarillo.Play();
    }
    public void StopParticulasAmarillo()
    {
        ParticulasAmarillo.Stop();
        ParticulasAmarilloPadre.SetActive(false);
    }
    public void PlayParticulasBlanco()
    {
        ParticulasBlancoPadre.SetActive(true);
        ParticulasBlanco.Play();
    }
    public void StopParticulasBlanco()
    {
        ParticulasBlanco.Stop();
        ParticulasBlancoPadre.SetActive(false);
    }
    public void PlayParticulasRojo()
    {
        ParticulasRojoPadre.SetActive(true);
        ParticulasRojo.Play();
    }
    public void StopParticulasRojo()
    {
        ParticulasRojo.Stop();
        ParticulasRojoPadre.SetActive(false);
    }
    public void PlayParticulasVerde()
    {
        ParticulasVerdePadre.SetActive(true);
        ParticulasVerde.Play();
    }
    public void StopParticulasVerde()
    {
        ParticulasVerde.Stop();
        ParticulasVerdePadre.SetActive(false);
    }
}
