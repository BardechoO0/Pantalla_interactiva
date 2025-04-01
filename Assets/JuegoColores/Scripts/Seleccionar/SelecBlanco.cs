using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecBlanco : MonoBehaviour
{
    
    [SerializeField] bool SpawnChecker;
    [SerializeField] AudioSource SonidoExito;
    // Start is called before the first frame update
    void Start()
    {

        SpawnChecker = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnChecker == true)
        {
            gameManager.Instance.PedirColor();
            SpawnChecker = false;
        }
    }

    void OnMouseDown()
    {

        if (gameObject.tag == gameManager.Instance.ColorPedido)
        {
            SonidoExito.Play();
            gameManager.Instance.SumarPuntos();
            gameManager.Instance.TeleportBlanco();
            SpawnChecker = true;

        }
    }
}
