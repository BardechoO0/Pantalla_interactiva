using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orden : MonoBehaviour
{
    [SerializeField] Juego Jg;
    void Start()
    {
        Jg = FindAnyObjectByType<Juego>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Waka");
        if (other.gameObject.tag == "Player")
        {
            Jg.Correcto();
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        
    }
}
